using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        int totalTransactions = 0;
        decimal totalAmount = 0;

        public Form1() => InitializeComponent();

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) && txtPrice.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Please enter only numeric characters.");
                // Clear the textbox or take other action as needed
                txtPrice.Text = string.Empty;
                txtPrice.Focus();
            }
        }

        private void txtTrade_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTrade.Text) && txtTrade.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Please enter only numeric characters.");
                // Clear the textbox or take other action as needed
                txtTrade.Text = string.Empty;
                txtTrade.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string formattedDate = DateTime.Now.ToString("dddd, MMMM dd");
            lblTodaysDate.Text = formattedDate;
            reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Transactions = { totalTransactions }\n Total Sales Amount = {totalAmount}");
            Close();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal salesPrice;
            if (!decimal.TryParse(txtPrice.Text, out salesPrice) || salesPrice < 500 || salesPrice > 30000)
            {
                MessageBox.Show("Sale Price must be between $500 and $30,000");
                txtPrice.Focus();
                txtPrice.SelectAll();
                return;
            }
            decimal tradePrice;
            if (!decimal.TryParse(txtTrade.Text, out tradePrice) ||  tradePrice > salesPrice)
            {
                MessageBox.Show("Trade-In Allowance must be less than the Sale Price");
                txtTrade.Focus();
                txtTrade.SelectAll();
                return;
            }
            var accessoriesPrice = getAccessoriesAmount();
            var finishPrice = getFinishAmount();

            var finish = accessoriesPrice + finishPrice;
            var subtotal = finish + salesPrice;
            var salestax = subtotal * .08m;
            var total = subtotal + salestax;
            var amountDue = total - tradePrice;

            txtFinish.Text = (finish).ToString("C");
            txtSubtotal.Text = (subtotal).ToString("C");
            txtTax.Text = (salestax).ToString("C");
            txtTotal.Text = (total).ToString("C");
            txtAmount.Text = (amountDue).ToString("C");

            totalTransactions++;
            totalAmount += amountDue;
        }
        private decimal getAccessoriesAmount()
        {
            decimal total = 0;
            foreach (Control control in grpAccessories.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    total += decimal.Parse(checkBox.Tag.ToString());
                }
            }
            return total;
        }
        private decimal getFinishAmount()
        {
            decimal total = 0;
            foreach (Control control in grpExterior.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    total += decimal.Parse(radioButton.Tag.ToString());
                }
            }
            return total;
        }
        private void reset()
        {
            foreach (Control control in grpAccessories.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }

            rbStandard.Checked = true;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
        