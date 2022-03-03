using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        double redShoes;
        double blueShoes;
        double greyShoes;

        //cost of different types
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

                //calculate subtotal, tax amount, and total
                subTotal = (redShoes * redShoesCost) + (blueShoes * blueShoesCost) + (greyShoes * greyShoesCost);

                taxAmount = subTotal * taxRate;
                total = subTotal + taxAmount;

                //outputing the totals and tax amount
                subTotalOutput.Text = $"{subTotal.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch {
                //Prints "ERROR" if letter (not a number) is the input
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

                //calculate change
                change = amountTendered - total;
                changeOutput.Text = change.ToString("C");

                //can't press print receipt button until accepted amount is in
                if (change >= 0)
                {
                    printReceiptButton.Enabled = true;
                }
                else
                {
                    changeOutput.Text = "Not Enough Money";
                }
            }
            catch {
                //if something other than a number is the input, prints "ERROR"
                changeOutput.Text = "ERROR";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            //printing sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptPrintSound);

            player.Play();

            //thread.sleep and refresh() wait half a second before printing next line
            receiptLabel.Text = "\n            SHOES SHOES SHOES!!!";
            Thread.Sleep(200);
            Refresh();

            receiptLabel.Text += "\n\nOrder Number 4023";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += "\nMarch 1, 2022";
            Thread.Sleep(200);
            Refresh();

            //prints number of shoes bought and price for 1
            receiptLabel.Text += $"\n\nRed Shoes  x{redShoes} @   {redShoesCost.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nBlue Shoes  x{blueShoes} @  {blueShoesCost.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nGrey Shoes  x{greyShoes} @ {greyShoesCost.ToString("C")}";
            Thread.Sleep(200);
            Refresh();

            //prints subtotal, tax amount, and total
            receiptLabel.Text += $"\n\nSubtotal                 {subTotal.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nTax                            {taxAmount.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nTotal                       {total.ToString("C")}";
            Thread.Sleep(200);
            Refresh();

            //prints tendered and change amount
            receiptLabel.Text += $"\n\nTendered              {amountTendered.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nChange                    {change.ToString("C")}";
            Thread.Sleep(200);
            Refresh();

            receiptLabel.Text += "\n\nHave a nice day!";
            Thread.Sleep(200);
            Refresh();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //resets button so cannot print another reciept unless inputs are put in again
            printReceiptButton.Enabled = false;

            redShoesInput.Text = String.Empty;
            blueShoesInput.Text = String.Empty;
            greyShoesInput.Text = String.Empty;

            subTotalOutput.Text = String.Empty;
            taxOutput.Text = String.Empty;
            totalOutput.Text = String.Empty;

            tenderedInput.Text = String.Empty;

            changeOutput.Text = String.Empty;

            receiptLabel.Text = String.Empty;

            //resets the variables
            redShoes = 0;
            blueShoes = 0;
            greyShoes = 0;

            subTotal = 0;
            taxAmount = 0;
            total = 0;

            amountTendered = 0;
            change = 0;
        }
    }
}
