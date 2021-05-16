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

namespace W1534169_2019172.view.expense
{
    public partial class AllExpensesListCtrl : UserControl
    {
        public Expense expense;

        public AllExpensesListCtrl()
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
        private void AllExpensesListCtrl_Load(object sender, EventArgs e)
        {
            lblDate.Text = Convert.ToString(Date);
            lblExpName.Text = ExpenseName;
            lblExpAmount.Text = Convert.ToString(Amount);
        }
    }
}
