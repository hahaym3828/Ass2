using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author : Ming YIng.
 * Date:    2017-2-11
 * Description : Its the assignment2 for Visual Studio
 * The function is calculating the items that customers bought.    
 *
 *   
     */
namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void StereoSystem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //calculate the price in the 2 group boxes
        private double CalculateAllPrice()
        {
            double AP = 0;
            if (StereoSystem.Checked)
            {
                AP = AP + 425.76;
            }

            if (LeatherInterior.Checked)
            {
                AP = AP + 987.41;
            }

            if (ComputerNavigation.Checked)
            {
                AP = AP + 1741.23;
            }
            if (Pearlized.Checked)
            {
                AP = AP + 345.72;
            }
            if (CustomizedDetailing.Checked)
            {
                AP = AP + 599.99;
            }
            return AP;
        }
        
        private void SharpAutoForm_Load(object sender, EventArgs e)
        {

        }

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //exit
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //clear all the boxes 
        private void ClearButton_Click(object sender, EventArgs e)
        {
            BasePrice.Text = "0";
            AdditionalOption.Text = "";
            Subtotal.Text = "";
            SalesTax.Text = "";
            Total.Text = "";
            TradeInAllowance.Text = "0";
            AmountDue.Text = "";
            Standard.Checked = true;
            StereoSystem.Checked = false;
            LeatherInterior.Checked = false;
            ComputerNavigation.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //the function of calculate button
        //include all the readonly box displaying fuction and calculateting function
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double subtotal = double.Parse(BasePrice.Text) + CalculateAllPrice();
            Subtotal.Text = subtotal.ToString("c3");
            double saleTax = subtotal * 0.13;
            SalesTax.Text = saleTax.ToString("c3");

            double total = subtotal * 1.13;
            Total.Text = total.ToString("c3");
            double amountDue = total - double.Parse(TradeInAllowance.Text);
            AmountDue.Text = amountDue.ToString("c3");
        }

        private void fontFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculate the price the customer buy for their staff!");
        }
    }
}
