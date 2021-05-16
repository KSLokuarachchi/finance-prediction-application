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
using W1534169_2019172.model.income;
using W1534169_2019172.model.payer;

namespace W1534169_2019172.view.payer
{
    public partial class PayerCreateView : Form
    {
        public Income inc;
        PayerDetailsController payerController;
        Payer payer;

        public PayerCreateView()
        {
            InitializeComponent();
        }

        private void btnAddPayer_Click(object sender, EventArgs e)
        {
            payerController = new PayerDetailsController();
            payer = new Payer();

            payer.Name = this.txtPayerName.Text;
            payer.Note = this.txtPayerNote.Text;

            payer = payerController.createPayer(payer);
            inc.Payer.Id = payer.Id;
            this.Close();
        }
    }
}
