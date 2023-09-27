namespace winForms
{
    partial class Form1
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblCostPerSquareFoot = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.tbxCostPerSquareFoot = new System.Windows.Forms.TextBox();
            this.lblCostOfTotalFloor = new System.Windows.Forms.Label();
            this.lblNumOfHoursToInstall = new System.Windows.Forms.Label();
            this.lblFinCost = new System.Windows.Forms.Label();
            this.lblCostOfHours = new System.Windows.Forms.Label();
            this.lblCalcTotalFloor = new System.Windows.Forms.Label();
            this.lblCalcNumOfHours = new System.Windows.Forms.Label();
            this.lblTotalFinCost = new System.Windows.Forms.Label();
            this.lblCalcCostOfHours = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(35, 47);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(78, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length of floor:";
            this.lblLength.Click += new System.EventHandler(this.lblLength_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(35, 92);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width of floor:";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // lblCostPerSquareFoot
            // 
            this.lblCostPerSquareFoot.AutoSize = true;
            this.lblCostPerSquareFoot.Location = new System.Drawing.Point(35, 146);
            this.lblCostPerSquareFoot.Name = "lblCostPerSquareFoot";
            this.lblCostPerSquareFoot.Size = new System.Drawing.Size(105, 13);
            this.lblCostPerSquareFoot.TabIndex = 2;
            this.lblCostPerSquareFoot.Text = "Cost per square foot:";
            this.lblCostPerSquareFoot.Click += new System.EventHandler(this.lblCostPerSquareFoot_Click);
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(119, 44);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(180, 20);
            this.tbxLength.TabIndex = 3;
            this.tbxLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(119, 92);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(180, 20);
            this.tbxWidth.TabIndex = 4;
            this.tbxWidth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxCostPerSquareFoot
            // 
            this.tbxCostPerSquareFoot.Location = new System.Drawing.Point(146, 146);
            this.tbxCostPerSquareFoot.Name = "tbxCostPerSquareFoot";
            this.tbxCostPerSquareFoot.Size = new System.Drawing.Size(180, 20);
            this.tbxCostPerSquareFoot.TabIndex = 5;
            this.tbxCostPerSquareFoot.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblCostOfTotalFloor
            // 
            this.lblCostOfTotalFloor.AutoSize = true;
            this.lblCostOfTotalFloor.Location = new System.Drawing.Point(35, 214);
            this.lblCostOfTotalFloor.Name = "lblCostOfTotalFloor";
            this.lblCostOfTotalFloor.Size = new System.Drawing.Size(122, 13);
            this.lblCostOfTotalFloor.TabIndex = 6;
            this.lblCostOfTotalFloor.Text = "Cost of total floor size of ";
            // 
            // lblNumOfHoursToInstall
            // 
            this.lblNumOfHoursToInstall.AutoSize = true;
            this.lblNumOfHoursToInstall.Location = new System.Drawing.Point(35, 267);
            this.lblNumOfHoursToInstall.Name = "lblNumOfHoursToInstall";
            this.lblNumOfHoursToInstall.Size = new System.Drawing.Size(170, 13);
            this.lblNumOfHoursToInstall.TabIndex = 7;
            this.lblNumOfHoursToInstall.Text = "Number of hours to install the floor:";
            // 
            // lblFinCost
            // 
            this.lblFinCost.AutoSize = true;
            this.lblFinCost.Location = new System.Drawing.Point(35, 337);
            this.lblFinCost.Name = "lblFinCost";
            this.lblFinCost.Size = new System.Drawing.Size(96, 13);
            this.lblFinCost.TabIndex = 8;
            this.lblFinCost.Text = "Total finished cost:";
            // 
            // lblCostOfHours
            // 
            this.lblCostOfHours.AutoSize = true;
            this.lblCostOfHours.Location = new System.Drawing.Point(328, 267);
            this.lblCostOfHours.Name = "lblCostOfHours";
            this.lblCostOfHours.Size = new System.Drawing.Size(64, 13);
            this.lblCostOfHours.TabIndex = 9;
            this.lblCostOfHours.Text = "At a cost of:";
            this.lblCostOfHours.Click += new System.EventHandler(this.lblCostOfHours_Click);
            // 
            // lblCalcTotalFloor
            // 
            this.lblCalcTotalFloor.AutoSize = true;
            this.lblCalcTotalFloor.Location = new System.Drawing.Point(216, 214);
            this.lblCalcTotalFloor.Name = "lblCalcTotalFloor";
            this.lblCalcTotalFloor.Size = new System.Drawing.Size(0, 13);
            this.lblCalcTotalFloor.TabIndex = 10;
            // 
            // lblCalcNumOfHours
            // 
            this.lblCalcNumOfHours.AutoSize = true;
            this.lblCalcNumOfHours.Location = new System.Drawing.Point(232, 267);
            this.lblCalcNumOfHours.Name = "lblCalcNumOfHours";
            this.lblCalcNumOfHours.Size = new System.Drawing.Size(0, 13);
            this.lblCalcNumOfHours.TabIndex = 11;
            // 
            // lblTotalFinCost
            // 
            this.lblTotalFinCost.AutoSize = true;
            this.lblTotalFinCost.Location = new System.Drawing.Point(170, 337);
            this.lblTotalFinCost.Name = "lblTotalFinCost";
            this.lblTotalFinCost.Size = new System.Drawing.Size(0, 13);
            this.lblTotalFinCost.TabIndex = 12;
            // 
            // lblCalcCostOfHours
            // 
            this.lblCalcCostOfHours.AutoSize = true;
            this.lblCalcCostOfHours.Location = new System.Drawing.Point(430, 267);
            this.lblCalcCostOfHours.Name = "lblCalcCostOfHours";
            this.lblCalcCostOfHours.Size = new System.Drawing.Size(0, 13);
            this.lblCalcCostOfHours.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(572, 364);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 46);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(312, 364);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(193, 46);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Calculate Cost";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCalcCostOfHours);
            this.Controls.Add(this.lblTotalFinCost);
            this.Controls.Add(this.lblCalcNumOfHours);
            this.Controls.Add(this.lblCalcTotalFloor);
            this.Controls.Add(this.lblCostOfHours);
            this.Controls.Add(this.lblFinCost);
            this.Controls.Add(this.lblNumOfHoursToInstall);
            this.Controls.Add(this.lblCostOfTotalFloor);
            this.Controls.Add(this.tbxCostPerSquareFoot);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.lblCostPerSquareFoot);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblCostPerSquareFoot;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.TextBox tbxCostPerSquareFoot;
        private System.Windows.Forms.Label lblCostOfTotalFloor;
        private System.Windows.Forms.Label lblNumOfHoursToInstall;
        private System.Windows.Forms.Label lblFinCost;
        private System.Windows.Forms.Label lblCostOfHours;
        private System.Windows.Forms.Label lblCalcTotalFloor;
        private System.Windows.Forms.Label lblCalcNumOfHours;
        private System.Windows.Forms.Label lblTotalFinCost;
        private System.Windows.Forms.Label lblCalcCostOfHours;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
    }
}

