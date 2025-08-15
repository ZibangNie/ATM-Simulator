using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class WithdrawMoneyForm : Form
    {
        private AtmMachine atmMachine;
        private OptionForm optionForm;
        
        public int[] WithdrawalInfo(int beforeWithdraw,int afterWithdral)
        {
            int[] a = { beforeWithdraw, afterWithdral };
            return a;
        }

        public WithdrawMoneyForm(AtmMachine atmMachine)
        {
            this.atmMachine = atmMachine;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            new OptionForm(atmMachine).Show(); //reopen previous form
        }

        private void InsufficientFunds()
        {
            MessageBox.Show("Insufficient funds in your account balance", "Inssuficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Hide();
            new OptionForm(atmMachine).Show(); //reopen previous form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 10)
            {
                InsufficientFunds();
            }
            else
            {
                int beforeBalance = atmMachine.localBalance;
                atmMachine.localBalance -= 10;
                atmMachine.amountToWithdraw += 10;
                int currentBalance= atmMachine.localBalance;
                string aMessage = beforeBalance.ToString() + "--->" + currentBalance.ToString();
                /*OptionForm optionForm = new OptionForm(atmMachine);
                optionForm.SetTextBoxValue(aMessage);
                optionForm.Show();*/
                var instance = ClassInFile2.SharedInstance;
                instance.a = instance.a+" "+aMessage ;

                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 20)
            {
                InsufficientFunds();
            }
            else
            {
                int beforeBalance = atmMachine.localBalance;
                atmMachine.localBalance -= 20;
                atmMachine.amountToWithdraw += 20;
                int currentBalance = atmMachine.localBalance;
                string aMessage = beforeBalance.ToString() + "--->" + currentBalance.ToString();
                /*OptionForm optionForm = new OptionForm(atmMachine);
                optionForm.SetTextBoxValue(aMessage);
                optionForm.Show();*/
                var instance = ClassInFile2.SharedInstance;
                instance.a = instance.a+" "+aMessage;
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 40)
            {
                InsufficientFunds();
            }
            else
            {
                int beforeBalance = atmMachine.localBalance;
                atmMachine.localBalance -= 40;
                atmMachine.amountToWithdraw += 40;
                int currentBalance = atmMachine.localBalance;
                string aMessage = beforeBalance.ToString() + "--->" + currentBalance.ToString();
                /*OptionForm optionForm = new OptionForm(atmMachine);
                optionForm.SetTextBoxValue(aMessage);
                optionForm.Show();*/
                var instance = ClassInFile2.SharedInstance;
                instance.a =  instance.a+" "+aMessage;
                Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 100)
            {
                InsufficientFunds();
            }
            else
            {
                int beforeBalance = atmMachine.localBalance;
                atmMachine.localBalance -= 100;
                atmMachine.amountToWithdraw += 100;
                int currentBalance = atmMachine.localBalance;
                string aMessage = beforeBalance.ToString() + "--->" + currentBalance.ToString();
                /*OptionForm optionForm = new OptionForm(atmMachine);
                optionForm.SetTextBoxValue(aMessage);
                optionForm.Show();*/
                var instance = ClassInFile2.SharedInstance;
                instance.a = instance.a+" "+aMessage ;
                Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (atmMachine.activeAccount.getBalance() < 500)
            {
                InsufficientFunds();
            }
            else
            {
                int beforeBalance = atmMachine.localBalance;
                atmMachine.localBalance -= 500;
                atmMachine.amountToWithdraw += 500;
                int currentBalance = atmMachine.localBalance;
                string aMessage = beforeBalance.ToString() + "--->" + currentBalance.ToString();
                /*OptionForm optionForm = new OptionForm(atmMachine);
                optionForm.SetTextBoxValue(aMessage);
                optionForm.Show();*/
                var instance = ClassInFile2.SharedInstance;
                instance.a =instance.a+ " "+aMessage ;
                Hide();
            }
        }

        private void labelAmountOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
