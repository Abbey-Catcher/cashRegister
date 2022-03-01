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
        double redShoes;
        double blueShoes;
        double greyShoes;

        double redShoesCost = 20;
        double blueShoesCost = 25;
        double greyShoesCost = 15;

        double subTotal;
        double taxRate = 0.13;
        double taxAmount;
        double total;

        double amountTendered;
        double change;

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
                total = subTotal + taxAmount;

                subTotalOutput.Text = $"{subTotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch {
                subTotalOutput.Text = "ERROR";
                taxOutput.Text = "ERROR";
                totalOutput.Text = "ERROR";
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                amountTendered = Convert.ToInt16(tenderedInput.Text);

                change = amountTendered - total;
                changeOutput.Text = change.ToString("C");
                if (change >= 0)
                {
                    printReceiptButton.Enabled = true;
                }
                else
                {
                    changeOutput.Text = "Not Enough Money";
                }
            }
            catch
            {
                changeOutput.Text = "ERROR";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "\n            SHOES SHOES SHOES!!!";

            receiptLabel.Text += "\n\nOrder Number 4023";
            receiptLabel.Text += "\nMarch 1, 2022";

            receiptLabel.Text += $"\n\nRed Shoes  x{redShoes} @   {redShoesCost.ToString("C")}";
            receiptLabel.Text += $"\nBlue Shoes  x{blueShoes} @  {blueShoesCost.ToString("C")}";
            receiptLabel.Text += $"\nGrey Shoes  x{greyShoes} @ {greyShoesCost.ToString("C")}";

            receiptLabel.Text += $"\n\nSubtotal                 {subTotal.ToString("C")}";
            receiptLabel.Text += $"\nTax                            {taxAmount.ToString("C")}";
            receiptLabel.Text += $"\nTotal                       {total.ToString("C")}";

            receiptLabel.Text += $"\n\nTendered              {amountTendered.ToString("C")}";
            receiptLabel.Text += $"\nChange                    {change.ToString("C")}";

            receiptLabel.Text += "\n\nHave a nice day!";
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            redShoesInput.Text = String.Empty;
            blueShoesInput.Text = String.Empty;
            greyShoesInput.Text = String.Empty;

            subTotalOutput.Text = String.Empty;
            taxOutput.Text = String.Empty;
            totalOutput.Text = String.Empty;

            tenderedInput.Text = String.Empty;

            changeOutput.Text = String.Empty;

            receiptLabel.Text = String.Empty;
        }
    }
}
