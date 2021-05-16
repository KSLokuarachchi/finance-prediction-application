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
    public partial class AllExpensesXMLView : Form
    {
        ExpenseDetailsController expenseDetailsController = new ExpenseDetailsController();
        AllExpensesListCtrl expenseCtrl;
        const int SPACE = 20;

        public AllExpensesXMLView()
        {
            InitializeComponent();
        }

        private void AllExpensesXMLView_Load(object sender, EventArgs e)
        {
            List<Expense> expensesList = expenseDetailsController.getAllExpensesXML();

            int i = 0;
            /*Rendering forms according to the amount*/
            foreach (var expense in expensesList)
            {
                expenseCtrl = new AllExpensesListCtrl();
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
