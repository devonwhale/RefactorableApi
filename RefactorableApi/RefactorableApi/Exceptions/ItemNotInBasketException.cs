using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RefactorableApi.Exceptions
{
    public class ItemNotInBasketException : Exception
    {
        public ItemNotInBasketException()
        {
        }

        public ItemNotInBasketException(string message) : base(message)
        {
        }

        public ItemNotInBasketException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemNotInBasketException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
