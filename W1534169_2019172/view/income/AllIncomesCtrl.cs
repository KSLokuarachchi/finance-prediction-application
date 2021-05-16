using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.model.payer;
using W1534169_2019172.controller.income;
using W1534169_2019172.model.income;
using W1534169_2019172.view.payer;

namespace W1534169_2019172.view.income
{
    public partial class AllIncomesCtrl : UserControl
    {
        public AllIncomesCtrl()
        {
            InitializeComponent();
        }

        EditIncomesView editIncView;
        PayerUpdateView editPayer;
        public Income income;
        IncomeDetailsController incomeController;

        DateTime date;
        string incomeName;
        Double amount;

        Payer payer = new Payer();

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string IncomeName
        {
            get { return incomeName; }
            set { incomeName = value; }
        }

        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Payer Payer
        {
            get { return payer; }
            set { payer = value; }
        }

        private void AllIncomesCtrl_Load(object sender, EventArgs e)
        {
            lblDate.Text = Convert.ToString(Date);
            lblIncName.Text = IncomeName;
            lblIncAmount.Text = Convert.ToString(Amount);
        }

        private void btnUpdateInc_Click(object sender, EventArgs e)
        {
            editIncView = new EditIncomesView();
            editIncView.income = this.income;
            editIncView.Activate();
            editIncView.ShowDialog();
        }

        private void btnDeleteInc_Click(object sender, EventArgs e)
        {
            incomeController = new IncomeDetailsController();
            incomeController.deleteIncome(this.income.Id);
            foreach (Form aForm in Application.OpenForms)
            {
                if (aForm.Name.Equals("AllIncomesView"))
                {
                    aForm.Close();
                    new AllIncomesView().Show();
                    break;
                }
            }
        }

        private void btnEditPayer_Click(object sender, EventArgs e)
        {
            editPayer = new PayerUpdateView();
            editPayer.payer = this.payer;
            editPayer.Activate();
            editPayer.ShowDialog();
        }
    }
}
