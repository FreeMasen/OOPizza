using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPizza
{
    public partial class frmPizzaPartyPlanner : Form
    {
        public frmPizzaPartyPlanner()
        {
            InitializeComponent();
        }

        private List<Pizza> options = new List<Pizza>();
        private List<Pizza> pizzas = new List<Pizza>();
        private Pizza toBeAdded;

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if (txtNotes.Text.Length > 0)
            {
                toBeAdded.notes = txtNotes.Text;
            }
            pizzas.Add(toBeAdded);
            resetSelections();
            updateZas();
            updateSub();
            
        }

        private void resetSelections()
        {
            btnAddPizza.Text = "Add Pizza";
            cboType.SelectedIndex = -1;
            cboSize.SelectedIndex = -1;
            numSlices.Value = 8;

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex > -1)
            {
                toBeAdded = options[cboType.SelectedIndex];
            }
            else
            {
                toBeAdded = new Pizza();
            }
            updateTops();
        }

        private void frmPizzaPartyPlanner_Load(object sender, EventArgs e)
        {
            options.Add(new Pizza());
            options.Add(new Surpreme());
            options.Add(new BBQChicken());
            options.Add(new Hawaiian());
            options.Add(new MeatLovers());
            options.Add(new Veggy());
            options.Add(new Greek());
            options.Add(new Cheeseburger());

            //add the options to the type dropdown
            foreach (Pizza pizza in options)
            {
                cboType.Items.Add(pizza.name);
            }
        }

        private void addTopping(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox) sender;

            //this is required becuase a check or uncheck trigger the same event
            if (box.Checked)
            {
                toBeAdded.toppings.Add(box.Text);
                switch (toBeAdded.size)
                {
                    case size.Small:
                        toBeAdded.price += 0.25m;
                        break;
                    case size.Medium:
                        toBeAdded.price += 0.50m;
                        break;
                    case size.Large:
                        toBeAdded.price += 0.75m;
                        break;
                }
                box.Checked = false;
            }
            updateTops();
            updateCurrentCost();

        }

        private void btnRemoveTopping_Click(object sender, EventArgs e)
        {
            if (lstCurrentTops.SelectedIndex > -1)
            {
                toBeAdded.toppings.RemoveAt(lstCurrentTops.SelectedIndex);
                switch (toBeAdded.size)
                {
                    case size.Small:
                        toBeAdded.price -= 0.25m;
                        break;
                    case size.Medium:
                        toBeAdded.price -= 0.50m;
                        break;
                    case size.Large:
                        toBeAdded.price -= 0.75m;
                        break;
                }
            }

            updateTops();
            updateCurrentCost();
        }

        private void updateTops()
        {
            lstCurrentTops.Items.Clear();
            if (toBeAdded.toppings != null)
            {
                foreach (string top in toBeAdded.toppings)
                {
                    lstCurrentTops.Items.Add(top);
                }
            }
        }

        private void updateZas()
        {
            lstCurrentPizzas.Items.Clear();
            foreach (Pizza za in pizzas)
            {
                lstCurrentPizzas.Items.Add(za.ToString());
            }
        }

        private void updateCurrentCost()
        {
            btnAddPizza.Text = String.Format("Add Pizza {0:C}", toBeAdded.price.ToString());
        }

        private void updateSub()
        {
            decimal subTotal = 0;
            foreach (Pizza za in pizzas)
            {
                subTotal += za.price;
            }
            lblSubTotal.Text = string.Format("{0:C}", subTotal);
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //a user cannot enter a pizza size w/o entering a pizza type.
            if (cboType.SelectedIndex > -1)
            {
                toBeAdded.size = (size) cboSize.SelectedIndex;
                toBeAdded.basePrice();
                updateCurrentCost();
            }
            else if (cboSize.SelectedIndex == -1)
            {
                
            }else
            {
                MessageBox.Show("Please enter a pizza type first.", this.Text);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (lstCurrentPizzas.SelectedIndex > -1)
            {
                pizzas.RemoveAt(lstCurrentPizzas.SelectedIndex);
                updateZas();
                txtDetails.Clear();
            }
            else
            {
                MessageBox.Show("Please select a pizza to remove", this.Text);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            DialogResult yesNo = MessageBox.Show("Are you sure you want to remove all pizzas?", this.Name,
                MessageBoxButtons.YesNo);
            if (yesNo == DialogResult.Yes)
            {
                pizzas.Clear();
                txtDetails.Clear();
                updateZas();
            }
        }

        private void lstCurrentPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurrentPizzas.SelectedIndex > -1)
            {
                txtDetails.Text = pizzas[lstCurrentPizzas.SelectedIndex].printLayout();
            }
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report rp = new Report(pizzas, this); 
            rp.Show();
        }


    }
}
