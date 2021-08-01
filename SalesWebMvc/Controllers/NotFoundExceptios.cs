using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class NotFoundExceptios : Exception
    {
        public NotFoundExceptios()
        {
        }

        public NotFoundExceptios(string message) : base(message)
        {
        }

        public NotFoundExceptios(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundExceptios(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}