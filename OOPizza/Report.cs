using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPizza
{
    public partial class Report : Form
    {
        private Form mainForm;
        List<Pizza> pizzas;

        public Report(List<Pizza> zas, Form main )
        {
            this.pizzas = zas;
            this.mainForm = main;


            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            string location;

            saveFile.Filter = "Text File | *.txt";
            saveFile.DefaultExt = "txt";
            saveFile.ShowDialog();
            location = saveFile.FileName;
            try
            {


                File.WriteAllText(location, txtReport.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            setText();
        }

        private void setText()
        {
            string nl = Environment.NewLine;
            txtReport.Text = "Pizza Party Plan " + DateTime.Today;
            txtReport.Text += nl;
            txtReport.Text += "----------";

            if (pizzas != null)
            {
                foreach (Pizza za in pizzas)
                {
                    txtReport.Text += nl;
                    txtReport.Text += za.printLayout();
                }
            }
            else
            {
                txtReport.Text += "No pizzas in this plan";
            }

            decimal subTotal = calculateTotal();

            txtReport.Text += string.Format("{0:C}", subTotal);
            txtReport.Text += nl;
            txtReport.Text += string.Format("Tax: {0:C}", (subTotal*0.075m));
            txtReport.Text += nl;
            txtReport.Text += nl;
            txtReport.Text += "Total:";
            txtReport.Text += nl;
            txtReport.Text += string.Format("{0:C}", (subTotal*1.075m));
        }

        private decimal calculateTotal()
        {
            decimal total = 0m;
            if (pizzas != null)
            {
                foreach (Pizza za in pizzas)
                {
                    total += za.price;
                }
                
            }
            return total;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
