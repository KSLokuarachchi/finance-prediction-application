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
using W1534169_2019172.model.expense;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.view.payee
{
    public partial class PayeeCreateView : Form
    {
        public Expense exp;
        PayeeDetailsController payeeController;
        Payee payee;

        public PayeeCreateView()
        {
            InitializeComponent();
        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            payeeController = new PayeeDetailsController();
            payee = new Payee();

            payee.Name = this.txtPayeeName.Text;
            payee.Note = this.txtPayeeNote.Text;

            payee = payeeController.createPayee(payee);
            exp.Payee.Id = payee.Id;
            this.Close();
        }
    }
}
