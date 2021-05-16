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

namespace W1534169_2019172.view.income
{
    public partial class EditIncomesView : Form
    {
        public Income income;
        IncomeDetailsController incController;

        public EditIncomesView()
        {
            InitializeComponent();
        }

        private void EditIncomesView_Load(object sender, EventArgs e)
        {
            txtDateUpdated.Value = income.Date;
            txtNameUpdated.Text = income.Name;
            txtAmountUpdated.Text = Convert.ToString(income.Amount);
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            Income incomeUpdated = income;
            incomeUpdated.Name = txtNameUpdated.Text;
            incomeUpdated.Amount = Convert.ToDouble(txtAmountUpdated.Text);
            incomeUpdated.Date = txtDateUpdated.Value;

            incController = new IncomeDetailsController();
            incController.updateIncome(incomeUpdated);

            this.Close();

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
    }
}
