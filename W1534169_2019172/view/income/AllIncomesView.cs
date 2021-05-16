using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.income;
using W1534169_2019172.model.income;
using W1534169_2019172.view.common;

namespace W1534169_2019172.view.income
{
    public partial class AllIncomesView : Form
    {
        IncomeDetailsController incomeDetailsController = new IncomeDetailsController();
        AllIncomesCtrl incomeCtrl;
        const int SPACE = 20;

        public AllIncomesView()
        {
            InitializeComponent();
        }

        private void AllIncomesView_Load(object sender, EventArgs e)
        {
            List<Income> incomesList = incomeDetailsController.getAllIncomes();

            int i = 0;
            /*Rendering forms according to the amount*/
            foreach (var income in incomesList)
            {
                incomeCtrl = new AllIncomesCtrl();
                incomeCtrl.income = income;

                incomeCtrl.Date = income.Date;
                incomeCtrl.IncomeName = income.Name;
                incomeCtrl.Amount = income.Amount;
                incomeCtrl.Payer = income.Payer;

                incomeCtrl.Location = new Point(40, (SPACE * 10) + ((incomeCtrl.Height + SPACE) * i));
                allIncomesPanel.Controls.Add(incomeCtrl);
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
