using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.model.payer;

namespace W1534169_2019172.controller.payer
{
    class PayerDetailsController
    {
        public Payer createPayer(Payer payer)
        {
            /* Saving results in the database */
            payer.createPayer(payer);
            payer = payer.getPayer(payer);
            return payer;

        }
        public Payer getPayerById(int payerId)
        {
            Payer payer = new Payer();
            /* Getting results from the database */
            payer = payer.getPayerById(payerId);
            return payer;

        }
        public void updatePayer(Payer payer)
        {
            /* Saving results in the database */
            payer.updatePayer(payer);
        }
    }
}
