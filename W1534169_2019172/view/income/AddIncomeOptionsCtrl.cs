using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1534169_2019172.view.income
{
    public partial class AddIncomeOptionsCtrl : UserControl
    {
        public AddIncomeOptionsCtrl()
        {
            InitializeComponent();
        }

        public Int32 IncomesAmount
        {
            get
            {
                return Convert.ToInt32(this.txtIncomesAmount.Text);
            }
        }

        public DateTime SelectedDate
        {
            get
            {
                return Convert.ToDateTime(this.txtDate.Value);
            }
        }

        private void txtIncomesAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
