using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1534169_2019172.model.payee
{
    public class Payee
    {
        private int id;
        private string name;
        private string note;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Note { get => note; set => note = value; }

        public void createPayee(Payee payee)
        {
            PayeeEntity entity = new PayeeEntity();
            entity.createPayee(payee);
        }

        public Payee getPayee(Payee payee)
        {
            PayeeEntity entity = new PayeeEntity();
            Payee retrievedPayee = entity.getPayee(payee);
            return retrievedPayee;
        }
        public Payee getPayeeById(int payeeId)
        {
            PayeeEntity entity = new PayeeEntity();
            Payee retrievedPayee = entity.getPayeeById(payeeId);
            return retrievedPayee;
        }

        public void updatePayee(Payee payee)
        {
            PayeeEntity entity = new PayeeEntity();
            entity.updatePayee(payee);
        }
    }
}
