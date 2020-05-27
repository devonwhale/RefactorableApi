﻿using System;
using System.Runtime.Serialization;

namespace RefactorableApi.Exceptions
{
    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException()
        {
        }

        public DatabaseConnectionException(string message) : base(message)
        {
        }

        public DatabaseConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DatabaseConnectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
