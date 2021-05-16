using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1534169_2019172.model.payer
{
    public class Payer
    {
        private int id;
        private string name;
        private string note;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Note { get => note; set => note = value; }

        public void createPayer(Payer payer)
        {
            PayerEntity entity = new PayerEntity();
            entity.createPayer(payer);
        }

        public Payer getPayer(Payer payer)
        {
            PayerEntity entity = new PayerEntity();
            Payer retrievedPayer = entity.getPayer(payer);
            return retrievedPayer;
        }

        public Payer getPayerById(int payerId)
        {
            PayerEntity entity = new PayerEntity();
            Payer retrievedPayer = entity.getPayerById(payerId);
            return retrievedPayer;
        }

        public void updatePayer(Payer payer)
        {
            PayerEntity entity = new PayerEntity();
            entity.updatePayer(payer);
        }
    }
}
