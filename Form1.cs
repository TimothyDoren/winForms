using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms
{
    public partial class Form1 : Form
    {
        double Length;
        double Width;
        double CostPerSquareFoot;
        double costPerHour = 35.75;
        double numOfFeetInstalledPerHour = 40;
        bool IsLengthAndWidthInputted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblLength_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CostPerSquareFoot = Convert.ToDouble(tbxCostPerSquareFoot.Text);
            CostPerSquareFoot = Length * Width * CostPerSquareFoot;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Width = Convert.ToDouble(tbxWidth.Text);
            if(Width > 0)
            {
                IsLengthAndWidthInputted = true;
            }
            else
            {
                IsLengthAndWidthInputted= false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Length = (Convert.ToDouble(tbxLength.Text));
                if (Length > 0)
                {
                    IsLengthAndWidthInputted = true;
                }
                else
                {
                    IsLengthAndWidthInputted = false;
                }
            }
            catch(Exception ex)
            {
               if(tbxLength.GetType() != typeof(string))
                {
                    MessageBox.Show(ex + "Invalid Input");
                }
            }
           
        }

        private void lblCostPerSquareFoot_Click(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

       

        private void lblCostOfHours_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }
    }
}
