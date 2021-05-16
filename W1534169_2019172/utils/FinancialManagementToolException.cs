using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace W1534169_2019172.controller
{
    class FinancialManagementToolException : Exception
    {
        public FinancialManagementToolException()
        {
        }

        public FinancialManagementToolException(string message) : base(message)
        {
        }

        public FinancialManagementToolException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FinancialManagementToolException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
