using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1534169_2019172.view.expense
{
    public partial class AddExpenseOptionsCtrl : UserControl
    {
        public AddExpenseOptionsCtrl()
        {
            InitializeComponent();
        }

        public Int32 ExpensesAmount { get
            {
                return Convert.ToInt32(this.txtExpensesAmount.Text);
            } 
        }

        public DateTime SelectedDate
        {
            get
            {
                return Convert.ToDateTime(this.txtDate.Value);
            }
        }

        private void txtExpensesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void btnAddExpense_Click(object sender, EventArgs e)
        {

        }
    }
}
