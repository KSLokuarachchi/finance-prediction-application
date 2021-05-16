using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.payee;
using W1534169_2019172.model.payee;
using W1534169_2019172.view.expense;

namespace W1534169_2019172.view.payee
{
    public partial class PayeeUpdateView : Form
    {
        public Payee payee;
        PayeeDetailsController payeeController;
        public PayeeUpdateView()
        {
            InitializeComponent();
        }

        private void PayeeUpdateView_Load(object sender, EventArgs e)
        {
            txtPayeeNameUpdated.Text = payee.Name;
            txtPayeeNoteUpdated.Text = payee.Note;
        }

        private void btnUpdatePayee_Click(object sender, EventArgs e)
        {
            Payee payeeUpdated = payee;
            payeeUpdated.Name = txtPayeeNameUpdated.Text;
            payeeUpdated.Note = txtPayeeNoteUpdated.Text;

            payeeController = new PayeeDetailsController();
            payeeController.updatePayee(payeeUpdated);

            this.Close();

            foreach (Form aForm in Application.OpenForms)
            {
                if (aForm.Name.Equals("AllExpensesView"))
                {
                    aForm.Close();
                    new AllExpensesView().Show();
                    break;
                }
            }
        }
    }
}
