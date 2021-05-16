using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.payer;
using W1534169_2019172.model.payer;
using W1534169_2019172.view.income;

namespace W1534169_2019172.view.payer
{
    public partial class PayerUpdateView : Form
    {
        public Payer payer;
        PayerDetailsController payerController;
        public PayerUpdateView()
        {
            InitializeComponent();
        }

        private void btnUpdatePayer_Click(object sender, EventArgs e)
        {
            Payer payerUpdated = payer;
            payerUpdated.Name = txtPayerNameUpdated.Text;
            payerUpdated.Note = txtPayerNoteUpdated.Text;

            payerController = new PayerDetailsController();
            payerController.updatePayer(payerUpdated);

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

        private void PayerUpdateView_Load(object sender, EventArgs e)
        {
            txtPayerNameUpdated.Text = payer.Name;
            txtPayerNoteUpdated.Text = payer.Note;
        }
    }
}
