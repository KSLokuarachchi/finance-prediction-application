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
using W1534169_2019172.view.common;

namespace W1534169_2019172.view.expense
{
    public partial class AllExpensesView : Form
    {
        ExpenseDetailsController expenseDetailsController = new ExpenseDetailsController();
        AllExpensesCtrl expenseCtrl;
        const int SPACE = 20;

        public AllExpensesView()
        {
            InitializeComponent();
        }

        private void AllExpensesView_Load(object sender, EventArgs e)
        {
            List<Expense> expensesList = expenseDetailsController.getAllExpenses();

            int i = 0;
            /*Rendering forms according to the amount*/
            foreach (var expense in expensesList)
            {
                expenseCtrl = new AllExpensesCtrl();
                expenseCtrl.expense = expense;

                expenseCtrl.Date = expense.Date;
                expenseCtrl.ExpenseName = expense.Name;
                expenseCtrl.Amount = expense.Amount;
                expenseCtrl.Payee = expense.Payee;

                expenseCtrl.Location = new Point(40, (SPACE * 10) + ((expenseCtrl.Height + SPACE) * i));
                allExpensesPanel.Controls.Add(expenseCtrl);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeView().Show();
        }
    }
}
