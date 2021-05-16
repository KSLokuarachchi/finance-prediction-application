using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.controller.payee
{
    class PayeeDetailsController
    {
        public Payee createPayee(Payee payee)
        {
            /* Saving results in the database */
            payee.createPayee(payee);
            payee = payee.getPayee(payee);
            this.writePayeeToFile("payeeDetails.xml",payee);
            return payee;
        }

        public Payee getPayeeById(int payeeId)
        {
            Payee payee = new Payee();
            /* Getting results from the database */
            payee = payee.getPayeeById(payeeId);
            return payee;

        }
        public void updatePayee(Payee payee)
        {
            /* Saving results in the database */
            payee.updatePayee(payee);
        }

        public void writePayeeToFile(string fileName, Payee payee)
        {
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter(string.Format("{0}\\{1}", workingDir, fileName), Encoding.UTF32);
            textWriter.WriteStartDocument();

            textWriter.WriteComment("This file contains the Payee details of Expenses");

            textWriter.WriteStartElement("Payee", "");

            textWriter.WriteStartElement("ID", "");
            textWriter.WriteValue(payee.Id);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Name", "");
            textWriter.WriteValue(payee.Name);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Note", "");
            textWriter.WriteValue(payee.Note);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();

            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();
        }
    }
}
