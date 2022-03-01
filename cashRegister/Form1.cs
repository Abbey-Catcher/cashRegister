using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        double redShoes = 0;
        double blueShoes = 0;
        double greyShoes = 0;

        double redShoesCost = 20;
        double blueShoesCost = 25;
        double greyShoesCost = 15;

        double subTotal = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            try { 
                redShoes = Convert.ToDouble(redShoesInput.Text);
                blueShoes = Convert.ToDouble(blueShoesInput.Text);
                greyShoes = Convert.ToDouble(greyShoesInput.Text);

                subTotal = (redShoes * redShoesCost) + (blueShoes * blueShoesCost) + (greyShoes * greyShoesCost);

                taxAmount = subTotal * taxRate;

                subTotalOutput.Text = $"{subTotal.ToString("C")}";
            }
            catch {
                subTotalOutput.Text = "Error";
            }
        }
    }
}
