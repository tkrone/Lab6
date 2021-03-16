using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComputeTipButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool valid = Double.TryParse(TotalBillTextBox.Text, out double totalBillDouble);

            bool valid2 = Double.TryParse(TipPercentBox.Text, out double totalTipDouble);

            ComputeTipButton.Enabled = valid && valid2;
        }

        private void ComputeTipButton_Click(object sender, EventArgs e)
        {
            string totalBill = TotalBillTextBox.Text;

            Double.TryParse(totalBill, out double totalBillDouble);

            string tipPercentage = TipPercentBox.Text;

            Double.TryParse(tipPercentage, out double tipPercentDouble);
      
            double tip = totalBillDouble * (tipPercentDouble/100);

            TipAmountTextBox.Text = tip.ToString();

            double totalAmount = (totalBillDouble + tip);
            TotalTextBox.Text = totalAmount.ToString();


        }

        private void TipPercentBox_TextChanged(object sender, EventArgs e)
        {
            bool valid = Double.TryParse(TotalBillTextBox.Text, out double totalBillDouble);

            bool valid2 = Double.TryParse(TipPercentBox.Text, out double totalTipDouble);

            ComputeTipButton.Enabled = valid && valid2;
        }
    }
}
