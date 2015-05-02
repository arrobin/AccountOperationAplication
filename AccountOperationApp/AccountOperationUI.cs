using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperationUI : Form
    {
        Account anAccount = new Account();
        public AccountOperationUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.AccountNumber = accountNumberTextBox.Text;
            anAccount.AccountName = customerNameTextBox.Text;
            MessageBox.Show("Account Created");
            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            string message = anAccount.Deposit(amount);
            MessageBox.Show(message);
            amountTextBox.Clear();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            string message = anAccount.Withdraw(amount);
            MessageBox.Show(message);
            amountTextBox.Clear();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.AccountName + ", Your Account Number is: " + anAccount.AccountNumber +
                            " and it's Balance: " + anAccount.AccountBalance+" Taka");
        }
    }
}
