using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.view.payer;
using W1534169_2019172.model.income;
using W1534169_2019172.model.payer;

namespace W1534169_2019172.view.income
{
    public partial class AddIncomeCtrl : UserControl
    {

        PayerCreateView payer;
        Income inc = new Income();
        Payer payerModel = new Payer();

        public AddIncomeCtrl()
        {
            InitializeComponent();
        }

        public string IncomeName
        {
            get
            {
                return this.txtIncName.Text;
            }
        }

        public Int32 IncomeAmount
        {
            get
            {
                return Convert.ToInt32(this.txtIncAmount.Text);
            }
        }

        public Int32 PayerID
        {
            get
            {
                return Convert.ToInt32(this.inc.Payer.Id);
            }
        }

        private void btnAddPayer_Click(object sender, EventArgs e)
        {
            payer = new PayerCreateView();
            payer.inc = this.inc;
            payer.inc.Payer = this.payerModel;
            payer.Activate();
            payer.ShowDialog();

            this.btnAddPayer.Text = "Payer Added";
            this.btnAddPayer.ForeColor = Color.Green;

            Console.WriteLine(this.inc.Payer.Id);
        }

        private void IncomeCtrl_Load(object sender, EventArgs e)
        {
            this.btnAddPayer.Enabled = false;
        }

        private void txtIncName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.btnAddPayer.Enabled = true;
        }

        private void txtIncAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.btnAddPayer.Enabled = true;
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
    }
}
