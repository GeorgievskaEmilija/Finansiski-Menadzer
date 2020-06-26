using System;
using System.Runtime.Serialization;

namespace Finansiski_Mendzer
{
    [Serializable]
    internal class BadTransactionException : Exception
    {
        public BadTransactionException()
        {
        }

        public BadTransactionException(string message) : base(message)
        {
        }

        public BadTransactionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BadTransactionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}