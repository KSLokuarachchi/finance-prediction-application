using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using W1534169_2019172.controller.payee;
using W1534169_2019172.controller.user;
using W1534169_2019172.model.expense;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.controller.expense
{
    class ExpenseDetailsController
    {
        Expense expense;
        UserDetailsController userController;

        public object _locker = 0;

        public void createExpense(List<Expense> expensesList)
        {
            expense = new Expense();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");


            /* Saving results in the database */
            foreach (Expense expense in expensesList)
            {
                /*use of threads to file write and database saving */
                Thread db = new Thread(() =>
                {
                    lock (_locker)
                    {
                        int id = expense.createExpense(expense, userId);
                        expense.Id = id;
                    }

                });
                Thread fileIO = new Thread(() =>
                {
                    lock (_locker)
                    {
                        this.writeExpenseToFile("userExpenseDetails.xml", userId, expense);
                    }

                });
                db.Start();
                fileIO.Start();

            }
        }

        public List<Expense> getAllExpenses()
        {
            expense = new Expense();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");

            /* Getting results in the database */
             return expense.getAllExpenses(userId);

        }

        public List<Expense> getAllExpensesXML()
        {
            expense = new Expense();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");

            /* Getting results from the XML file */
             List<Expense> expenses = readExpenseFromFile("userExpenseDetails.xml", userId);
             return expenses;

        }

        public void updateExpense(Expense expense)
        {
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");


            /* Updating results in the database */
            expense.updateExpense(expense, userId);
        }

        public void deleteExpense(int expenseId)
        {
            expense = new Expense();
            /* Deleting  results in the database */
            expense.deleteExpense(expenseId);
        }

        public void writeExpenseToFile(string fileName, int userId, Expense expense)
        {
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter(string.Format("{0}\\{1}", workingDir, fileName), Encoding.UTF32);
            textWriter.WriteStartDocument();

            textWriter.WriteComment("This file contains the expenses of Users");

            textWriter.WriteStartElement("UserID", "");
            textWriter.WriteValue(userId);

            textWriter.WriteStartElement("Expense", "");

            textWriter.WriteStartElement("ID", "");
            textWriter.WriteValue(expense.Id);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Date", "");
            textWriter.WriteValue(expense.Date);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Name", "");
            textWriter.WriteValue(expense.Name);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Amount", "");
            textWriter.WriteValue(expense.Amount);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("IsDeleted", "");
            textWriter.WriteValue(expense.IsDeleted);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Payee", "");

            textWriter.WriteStartElement("ID", "");
            textWriter.WriteValue(expense.Payee.Id);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();

            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();
        }


        public List<Expense> readExpenseFromFile(string fileName, int userId)
        {
            List<Expense> expensesList = new List<Expense>();
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextReader textReader = new XmlTextReader(string.Format("{0}\\{1}", workingDir, fileName));
            Console.WriteLine("Base URI:" + textReader.BaseURI);
            textReader.Read();
            while (textReader.Read())
            {
                textReader.MoveToElement();
                textReader.Read();
                if (textReader.Name == "UserID")
                {
                    textReader.Read();
                    XmlNodeType nType = textReader.NodeType;
                    if (nType == XmlNodeType.Text)
                    {
                        if (textReader.Value.ToString() == userId.ToString())
                        {
                            Expense expense = new Expense();
                            Payee payee = new Payee();
                            userId = Convert.ToInt32(textReader.Value.ToString());
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            expense.Id = Convert.ToInt32(textReader.Value.ToString());
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            expense.Date = Convert.ToDateTime(textReader.Value.ToString());
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            expense.Name = textReader.Value.ToString();
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            expense.Amount = Convert.ToInt32(textReader.Value.ToString());
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            expense.IsDeleted = Convert.ToBoolean(textReader.Value);
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            textReader.Read();
                            expense.Payee = payee;
                            expense.Payee.Id = Convert.ToInt32(textReader.Value.ToString());

                            if (!expense.IsDeleted)
                            {
                                expensesList.Add(expense);
                            }
                            Console.WriteLine("expense:" + expense);
                        }
                       
                    }
                }
            }
            Console.ReadLine();
            textReader.Close();
            return expensesList;
        }
    }
}
