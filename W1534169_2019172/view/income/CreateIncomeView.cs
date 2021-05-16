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
using W1534169_2019172.model.payer;
using W1534169_2019172.view.common;

namespace W1534169_2019172.view.income
{
    public partial class CreateIncomeView : Form
    {
        AddIncomeOptionsCtrl incomesCtrl = null;
        List<Income> incomes = new List<Income>();
        AddIncomeCtrl[] incomesList;
        const int SPACE = 20;
        IncomeDetailsController incomeController;

        public CreateIncomeView()
        {
            InitializeComponent();
        }

        private void CreateIncomeView_Load(object sender, EventArgs e)
        {
            incomesCtrl = new AddIncomeOptionsCtrl();
            incomesCtrl.Location = new Point(38, 77);

            this.Controls.Add(incomesCtrl);
            incomesCtrl.btnAddIncome.Click += BtnAddIncome_Click; 
        }

        private void BtnAddIncome_Click(object sender, EventArgs e)
        {
            Int32 incomesAmount = incomesCtrl.IncomesAmount;

            int count = 0;
             while (true)
             {
                 if(this.Controls[String.Format("incomeCtrl{0}",count)] != null)
                 {
                     this.Controls.Remove(this.Controls[String.Format("incomeCtrl{0}", count)]);
                     count++;
                 }
                 else
                 {
                     break;
                 }
             } 

           /* foreach (var item in this.Controls)
            {
                IncomeCtrl x = item as IncomeCtrl;
                if (x != null)
                {
                    if (x.Name.Equals(String.Format("incomeCtrl{0}", count)))
                    {
                        this.Controls.Remove(x);
                        count++;
                    }
                }
            } */

            incomesList = new AddIncomeCtrl[incomesAmount];

            /*Rendering forms according to the amount*/
            for (int i = 0; i < incomesAmount; i++)
            {
                incomesList[i] = new AddIncomeCtrl();
                incomesList[i].Location = new Point(40, (SPACE * 10) + ((incomesList[i].Height + SPACE) * i));
                incomesList[i].Name = String.Format("incomeCtrl{0}",i);
                this.Controls.Add(incomesList[i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            incomesCtrl = new AddIncomeOptionsCtrl();

            foreach (AddIncomeCtrl incomeCtrl in incomesList)
            {
                Income exp = new Income();
                Payer payer = new Payer();
                exp.Name = incomeCtrl.IncomeName;
                exp.Amount = incomeCtrl.IncomeAmount;
                exp.Payer = payer;
                exp.Payer.Id = incomeCtrl.PayerID;
                exp.Date = incomesCtrl.SelectedDate;
                incomes.Add(exp);
                incomeCtrl.Enabled = false;
            }

            incomeController = new IncomeDetailsController();
            incomeController.createIncome(incomes);

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
