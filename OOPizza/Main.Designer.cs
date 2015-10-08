namespace OOPizza
{
    partial class frmPizzaPartyPlanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.numSlices = new System.Windows.Forms.NumericUpDown();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.ckbKandM = new System.Windows.Forms.CheckBox();
            this.ckbTzat = new System.Windows.Forms.CheckBox();
            this.ckbBBQ = new System.Windows.Forms.CheckBox();
            this.ckbCOlives = new System.Windows.Forms.CheckBox();
            this.ckbBOlives = new System.Windows.Forms.CheckBox();
            this.ckbGOlives = new System.Windows.Forms.CheckBox();
            this.ckbPineapple = new System.Windows.Forms.CheckBox();
            this.ckbChicken = new System.Windows.Forms.CheckBox();
            this.ckbBeef = new System.Windows.Forms.CheckBox();
            this.ckbHam = new System.Windows.Forms.CheckBox();
            this.cbkBacon = new System.Windows.Forms.CheckBox();
            this.ckbMush = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGPep = new System.Windows.Forms.CheckBox();
            this.ckbPep = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCurrentTops = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCurrentPizzas = new System.Windows.Forms.ListBox();
            this.lblCurrentPizzas = new System.Windows.Forms.Label();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.SubT = new System.Windows.Forms.Label();
            this.btnRemoveTopping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSlices)).BeginInit();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(70, 15);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 0;
            this.cboType.Tag = "pizza type";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cboSize.Location = new System.Drawing.Point(69, 45);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 2;
            this.cboSize.Tag = "pizza size";
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged_1);
            // 
            // numSlices
            // 
            this.numSlices.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSlices.Location = new System.Drawing.Point(70, 75);
            this.numSlices.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSlices.Name = "numSlices";
            this.numSlices.Size = new System.Drawing.Size(120, 20);
            this.numSlices.TabIndex = 3;
            this.numSlices.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.ckbKandM);
            this.grpToppings.Controls.Add(this.ckbTzat);
            this.grpToppings.Controls.Add(this.ckbBBQ);
            this.grpToppings.Controls.Add(this.ckbCOlives);
            this.grpToppings.Controls.Add(this.ckbBOlives);
            this.grpToppings.Controls.Add(this.ckbGOlives);
            this.grpToppings.Controls.Add(this.ckbPineapple);
            this.grpToppings.Controls.Add(this.ckbChicken);
            this.grpToppings.Controls.Add(this.ckbBeef);
            this.grpToppings.Controls.Add(this.ckbHam);
            this.grpToppings.Controls.Add(this.cbkBacon);
            this.grpToppings.Controls.Add(this.ckbMush);
            this.grpToppings.Controls.Add(this.ckbOnion);
            this.grpToppings.Controls.Add(this.ckbGPep);
            this.grpToppings.Controls.Add(this.ckbPep);
            this.grpToppings.Controls.Add(this.ckbSausage);
            this.grpToppings.Location = new System.Drawing.Point(196, 12);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(330, 167);
            this.grpToppings.TabIndex = 4;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // ckbKandM
            // 
            this.ckbKandM.AutoSize = true;
            this.ckbKandM.Location = new System.Drawing.Point(199, 55);
            this.ckbKandM.Name = "ckbKandM";
            this.ckbKandM.Size = new System.Drawing.Size(128, 17);
            this.ckbKandM.TabIndex = 15;
            this.ckbKandM.Text = "Ketchup and Mustard";
            this.ckbKandM.UseVisualStyleBackColor = true;
            this.ckbKandM.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbTzat
            // 
            this.ckbTzat.AutoSize = true;
            this.ckbTzat.Location = new System.Drawing.Point(199, 35);
            this.ckbTzat.Name = "ckbTzat";
            this.ckbTzat.Size = new System.Drawing.Size(96, 17);
            this.ckbTzat.TabIndex = 14;
            this.ckbTzat.Text = "Tzatziki Sauce";
            this.ckbTzat.UseVisualStyleBackColor = true;
            this.ckbTzat.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbBBQ
            // 
            this.ckbBBQ.AutoSize = true;
            this.ckbBBQ.Location = new System.Drawing.Point(199, 15);
            this.ckbBBQ.Name = "ckbBBQ";
            this.ckbBBQ.Size = new System.Drawing.Size(82, 17);
            this.ckbBBQ.TabIndex = 13;
            this.ckbBBQ.Text = "BBQ Sauce";
            this.ckbBBQ.UseVisualStyleBackColor = true;
            this.ckbBBQ.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbCOlives
            // 
            this.ckbCOlives.AutoSize = true;
            this.ckbCOlives.Location = new System.Drawing.Point(95, 135);
            this.ckbCOlives.Name = "ckbCOlives";
            this.ckbCOlives.Size = new System.Drawing.Size(102, 17);
            this.ckbCOlives.TabIndex = 12;
            this.ckbCOlives.Text = "Calamata Olives";
            this.ckbCOlives.UseVisualStyleBackColor = true;
            this.ckbCOlives.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbBOlives
            // 
            this.ckbBOlives.AutoSize = true;
            this.ckbBOlives.Location = new System.Drawing.Point(95, 115);
            this.ckbBOlives.Name = "ckbBOlives";
            this.ckbBOlives.Size = new System.Drawing.Size(85, 17);
            this.ckbBOlives.TabIndex = 11;
            this.ckbBOlives.Text = "Black Olives";
            this.ckbBOlives.UseVisualStyleBackColor = true;
            this.ckbBOlives.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbGOlives
            // 
            this.ckbGOlives.AutoSize = true;
            this.ckbGOlives.Location = new System.Drawing.Point(95, 95);
            this.ckbGOlives.Name = "ckbGOlives";
            this.ckbGOlives.Size = new System.Drawing.Size(87, 17);
            this.ckbGOlives.TabIndex = 10;
            this.ckbGOlives.Text = "Green Olives";
            this.ckbGOlives.UseVisualStyleBackColor = true;
            this.ckbGOlives.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbPineapple
            // 
            this.ckbPineapple.AutoSize = true;
            this.ckbPineapple.Location = new System.Drawing.Point(95, 75);
            this.ckbPineapple.Name = "ckbPineapple";
            this.ckbPineapple.Size = new System.Drawing.Size(73, 17);
            this.ckbPineapple.TabIndex = 9;
            this.ckbPineapple.Text = "Pineapple";
            this.ckbPineapple.UseVisualStyleBackColor = true;
            this.ckbPineapple.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbChicken
            // 
            this.ckbChicken.AutoSize = true;
            this.ckbChicken.Location = new System.Drawing.Point(8, 115);
            this.ckbChicken.Name = "ckbChicken";
            this.ckbChicken.Size = new System.Drawing.Size(65, 17);
            this.ckbChicken.TabIndex = 8;
            this.ckbChicken.Text = "Chicken";
            this.ckbChicken.UseVisualStyleBackColor = true;
            this.ckbChicken.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbBeef
            // 
            this.ckbBeef.AutoSize = true;
            this.ckbBeef.Location = new System.Drawing.Point(8, 95);
            this.ckbBeef.Name = "ckbBeef";
            this.ckbBeef.Size = new System.Drawing.Size(48, 17);
            this.ckbBeef.TabIndex = 7;
            this.ckbBeef.Text = "Beef";
            this.ckbBeef.UseVisualStyleBackColor = true;
            this.ckbBeef.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbHam
            // 
            this.ckbHam.AutoSize = true;
            this.ckbHam.Location = new System.Drawing.Point(8, 75);
            this.ckbHam.Name = "ckbHam";
            this.ckbHam.Size = new System.Drawing.Size(48, 17);
            this.ckbHam.TabIndex = 6;
            this.ckbHam.Text = "Ham";
            this.ckbHam.UseVisualStyleBackColor = true;
            this.ckbHam.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // cbkBacon
            // 
            this.cbkBacon.AutoSize = true;
            this.cbkBacon.Location = new System.Drawing.Point(8, 55);
            this.cbkBacon.Name = "cbkBacon";
            this.cbkBacon.Size = new System.Drawing.Size(57, 17);
            this.cbkBacon.TabIndex = 5;
            this.cbkBacon.Text = "Bacon";
            this.cbkBacon.UseVisualStyleBackColor = true;
            this.cbkBacon.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbMush
            // 
            this.ckbMush.AutoSize = true;
            this.ckbMush.Location = new System.Drawing.Point(95, 55);
            this.ckbMush.Name = "ckbMush";
            this.ckbMush.Size = new System.Drawing.Size(75, 17);
            this.ckbMush.TabIndex = 4;
            this.ckbMush.Text = "Mushroom";
            this.ckbMush.UseVisualStyleBackColor = true;
            this.ckbMush.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Location = new System.Drawing.Point(95, 15);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(54, 17);
            this.ckbOnion.TabIndex = 3;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            this.ckbOnion.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbGPep
            // 
            this.ckbGPep.AutoSize = true;
            this.ckbGPep.Location = new System.Drawing.Point(95, 35);
            this.ckbGPep.Name = "ckbGPep";
            this.ckbGPep.Size = new System.Drawing.Size(92, 17);
            this.ckbGPep.TabIndex = 2;
            this.ckbGPep.Text = "Green Pepper";
            this.ckbGPep.UseVisualStyleBackColor = true;
            this.ckbGPep.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbPep
            // 
            this.ckbPep.AutoSize = true;
            this.ckbPep.Location = new System.Drawing.Point(8, 35);
            this.ckbPep.Name = "ckbPep";
            this.ckbPep.Size = new System.Drawing.Size(74, 17);
            this.ckbPep.TabIndex = 1;
            this.ckbPep.Text = "Pepperoni";
            this.ckbPep.UseVisualStyleBackColor = true;
            this.ckbPep.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(8, 15);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(68, 17);
            this.ckbSausage.TabIndex = 0;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            this.ckbSausage.CheckedChanged += new System.EventHandler(this.addTopping);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "# of Slices";
            // 
            // lstCurrentTops
            // 
            this.lstCurrentTops.FormattingEnabled = true;
            this.lstCurrentTops.Location = new System.Drawing.Point(538, 28);
            this.lstCurrentTops.Name = "lstCurrentTops";
            this.lstCurrentTops.Size = new System.Drawing.Size(120, 147);
            this.lstCurrentTops.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(69, 107);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(121, 68);
            this.txtNotes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current Toppings";
            // 
            // lstCurrentPizzas
            // 
            this.lstCurrentPizzas.FormattingEnabled = true;
            this.lstCurrentPizzas.Location = new System.Drawing.Point(12, 258);
            this.lstCurrentPizzas.Name = "lstCurrentPizzas";
            this.lstCurrentPizzas.Size = new System.Drawing.Size(120, 160);
            this.lstCurrentPizzas.TabIndex = 12;
            this.lstCurrentPizzas.SelectedIndexChanged += new System.EventHandler(this.lstCurrentPizzas_SelectedIndexChanged);
            // 
            // lblCurrentPizzas
            // 
            this.lblCurrentPizzas.AutoSize = true;
            this.lblCurrentPizzas.Location = new System.Drawing.Point(14, 239);
            this.lblCurrentPizzas.Name = "lblCurrentPizzas";
            this.lblCurrentPizzas.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentPizzas.TabIndex = 13;
            this.lblCurrentPizzas.Text = "Current Pizzas";
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Location = new System.Drawing.Point(12, 181);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(517, 41);
            this.btnAddPizza.TabIndex = 14;
            this.btnAddPizza.Text = "Add Pizza";
            this.btnAddPizza.UseVisualStyleBackColor = true;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(152, 271);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(296, 147);
            this.txtDetails.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pizza Details";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(454, 271);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(75, 35);
            this.btnRemoveSelected.TabIndex = 17;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(454, 312);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 35);
            this.btnRemoveAll.TabIndex = 18;
            this.btnRemoveAll.Text = "Remove All Pizzas";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(454, 374);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(75, 44);
            this.btnCreateReport.TabIndex = 19;
            this.btnCreateReport.Text = "Create Report";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(620, 405);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(34, 13);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "$0.00";
            // 
            // SubT
            // 
            this.SubT.AutoSize = true;
            this.SubT.Location = new System.Drawing.Point(542, 405);
            this.SubT.Name = "SubT";
            this.SubT.Size = new System.Drawing.Size(53, 13);
            this.SubT.TabIndex = 22;
            this.SubT.Text = "Sub Total";
            // 
            // btnRemoveTopping
            // 
            this.btnRemoveTopping.Location = new System.Drawing.Point(538, 181);
            this.btnRemoveTopping.Name = "btnRemoveTopping";
            this.btnRemoveTopping.Size = new System.Drawing.Size(120, 41);
            this.btnRemoveTopping.TabIndex = 24;
            this.btnRemoveTopping.Text = "Remove Topping";
            this.btnRemoveTopping.UseVisualStyleBackColor = true;
            this.btnRemoveTopping.Click += new System.EventHandler(this.btnRemoveTopping_Click);
            // 
            // frmPizzaPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 438);
            this.Controls.Add(this.btnRemoveTopping);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.SubT);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.lblCurrentPizzas);
            this.Controls.Add(this.lstCurrentPizzas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCurrentTops);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.numSlices);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.cboType);
            this.Name = "frmPizzaPartyPlanner";
            this.Text = "Pizza Party Planner";
            this.Load += new System.EventHandler(this.frmPizzaPartyPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSlices)).EndInit();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.NumericUpDown numSlices;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.CheckBox ckbMush;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbGPep;
        private System.Windows.Forms.CheckBox ckbPep;
        private System.Windows.Forms.CheckBox ckbBeef;
        private System.Windows.Forms.CheckBox ckbHam;
        private System.Windows.Forms.CheckBox cbkBacon;
        private System.Windows.Forms.CheckBox ckbTzat;
        private System.Windows.Forms.CheckBox ckbBBQ;
        private System.Windows.Forms.CheckBox ckbCOlives;
        private System.Windows.Forms.CheckBox ckbBOlives;
        private System.Windows.Forms.CheckBox ckbGOlives;
        private System.Windows.Forms.CheckBox ckbPineapple;
        private System.Windows.Forms.CheckBox ckbChicken;
        private System.Windows.Forms.CheckBox ckbKandM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCurrentTops;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstCurrentPizzas;
        private System.Windows.Forms.Label lblCurrentPizzas;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label SubT;
        private System.Windows.Forms.Button btnRemoveTopping;
    }
}

