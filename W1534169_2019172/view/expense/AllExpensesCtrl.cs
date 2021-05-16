using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.model.payee;
using W1534169_2019172.model.expense;
using W1534169_2019172.view.payee;
using W1534169_2019172.controller.expense;

namespace W1534169_2019172.view.expense
{
    public partial class AllExpensesCtrl : UserControl
    {
        ExpensesEditView editExpView;
        PayeeUpdateView editPayee;
        public Expense expense;
        ExpenseDetailsController expenseController;

        public AllExpensesCtrl()
        {
            InitializeComponent();
        }

        DateTime date;
        string expenseName;
        Double amount;

        Payee payee = new Payee();

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string ExpenseName
        {
            get { return expenseName; }
            set { expenseName = value; }
        }

        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Payee Payee
        {
            get { return payee; }
            set { payee = value; }
        }

        private void AllExpensesCtrl_Load(object sender, EventArgs e)
        {
            lblDate.Text = Convert.ToString(Date);
            lblExpName.Text = ExpenseName;
            lblExpAmount.Text = Convert.ToString(Amount);
        }

        private void btnUpdateExp_Click(object sender, EventArgs e)
        {
            editExpView = new ExpensesEditView();
            editExpView.expense = this.expense;
            editExpView.Activate();
            editExpView.ShowDialog();
        }

        private void btnEditPayee_Click(object sender, EventArgs e)
        {
            editPayee = new PayeeUpdateView();
            editPayee.payee = this.payee;
            editPayee.Activate();
            editPayee.ShowDialog();
        }

        private void btnDeleteExp_Click(object sender, EventArgs e)
        {
            expenseController = new ExpenseDetailsController();
            expenseController.deleteExpense(this.expense.Id);
            foreach (Form aForm in Application.OpenForms)
            {
                if (aForm.Name.Equals("AllExpensesView"))
                {
                    aForm.Close();
                    new AllExpensesView().Show();
                    break;
                }
            }
        }
    }
}
