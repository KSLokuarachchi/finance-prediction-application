using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.expense;
using W1534169_2019172.model.expense;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.view.expense
{
    public partial class ExpensesEditView : Form
    {
        public Expense expense;
        ExpenseDetailsController expController;
        
        public ExpensesEditView()
        {
            InitializeComponent();
        }

        private void EditExpensesView_Load(object sender, EventArgs e)
        {
            txtDateUpdated.Value = expense.Date;
            txtNameUpdated.Text = expense.Name;
            txtAmountUpdated.Text = Convert.ToString(expense.Amount);

        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            Expense expenseUpdated = expense;
            expenseUpdated.Name = txtNameUpdated.Text;
            expenseUpdated.Amount = Convert.ToDouble(txtAmountUpdated.Text);
            expenseUpdated.Date = txtDateUpdated.Value;

            expController = new ExpenseDetailsController();
            expController.updateExpense(expenseUpdated);

            this.Close();

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
