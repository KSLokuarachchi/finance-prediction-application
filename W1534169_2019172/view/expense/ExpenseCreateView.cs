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
using W1534169_2019172.view.common;

namespace W1534169_2019172.view.expense
{
    public partial class ExpenseCreateView : Form
    {
        AddExpenseOptionsCtrl expensesCtrl = null;
        List<Expense> expenses = new List<Expense>();
        AddExpenseCtrl[] expensesList;
        const int SPACE = 20;
        ExpenseDetailsController expenseController;

        public ExpenseCreateView()
        {
            InitializeComponent();
        }

        private void CreateExpenseView_Load(object sender, EventArgs e)
        {
            expensesCtrl = new AddExpenseOptionsCtrl();
            expensesCtrl.Location = new Point(38, 77);

            this.Controls.Add(expensesCtrl);
            expensesCtrl.btnAddExpense.Click += CtrlAddExpense_Click;
        }

        private void CtrlAddExpense_Click(object sender, EventArgs e)
        {
            Int32 expensesAmount = expensesCtrl.ExpensesAmount;

            int count = 0;
            while (true)
            {
                if (this.Controls[String.Format("expenseCtrl{0}", count)] != null)
                {
                    this.Controls.Remove(this.Controls[String.Format("expenseCtrl{0}", count)]);
                    count++;
                }
                else
                {
                    break;
                }
            }

            expensesList = new AddExpenseCtrl[expensesAmount];

            /*Rendering forms according to the amount*/
            for (int i=0; i < expensesAmount; i++)
            {
                expensesList[i] = new AddExpenseCtrl();
                expensesList[i].Location = new Point(40, (SPACE * 10) + ((expensesList[i].Height + SPACE) * i));
                expensesList[i].Name = String.Format("expenseCtrl{0}", i);
                this.Controls.Add(expensesList[i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            expensesCtrl = new AddExpenseOptionsCtrl();

            foreach (AddExpenseCtrl expenseCtrl in expensesList)
            {
                Expense exp = new Expense();
                Payee payee = new Payee();
                exp.Name = expenseCtrl.ExpenseName;
                exp.Amount = expenseCtrl.ExpenseAmount;
                exp.Payee = payee;
                exp.Payee.Id = expenseCtrl.PayeeID;
                exp.Date = expensesCtrl.SelectedDate;
                expenses.Add(exp);
                expenseCtrl.Enabled = false;
            }

            expenseController = new ExpenseDetailsController();
            expenseController.createExpense(expenses);

            this.btnSave.Text = "Saved!";
            this.btnSave.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeView().Show();
        }
    }
}
