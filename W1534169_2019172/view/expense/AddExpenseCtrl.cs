using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.model.expense;
using W1534169_2019172.view.payee;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.view.expense
{
    public partial class AddExpenseCtrl : UserControl
    {
        PayeeCreateView payee;
        Expense exp = new Expense();
        Payee payeeModel = new Payee();

        public AddExpenseCtrl()
        {
            InitializeComponent();
        }

        public string ExpenseName
        {
            get
            {
                return this.txtExpName.Text;
            }
        }

        public Int32 ExpenseAmount
        {
            get
            {
                return Convert.ToInt32(this.txtExpAmount.Text);
            }
        }

        public Int32 PayeeID
        {
            get
            {
                return Convert.ToInt32(this.exp.Payee.Id);
            }
        }



        private void txtExpAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.btnAddPayee.Enabled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            payee = new PayeeCreateView();
            payee.exp = this.exp;
            payee.exp.Payee = this.payeeModel;
            payee.Activate();
            payee.ShowDialog();

            this.btnAddPayee.Text = "Payee Added";
            this.btnAddPayee.ForeColor = Color.Green;

            Console.WriteLine(this.exp.Payee.Id);
        }

        private void ExpenseCtrl_Load(object sender, EventArgs e)
        {
            this.btnAddPayee.Enabled = false;
        }

        private void txtExpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.btnAddPayee.Enabled = true;
        }
    }
}
