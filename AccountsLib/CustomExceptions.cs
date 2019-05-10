using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{

        [Serializable]
        public class InvalidOperation : Exception
        {
            public InvalidOperation() { }
            public InvalidOperation(string message) : base(message) { }
            public InvalidOperation(string message, Exception inner) : base(message, inner) { }
            protected InvalidOperation(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }
        }

        [Serializable]
        public class AccountNotActiveException : Exception
        {
            public AccountNotActiveException() { }
            public AccountNotActiveException(string message) : base(message) { }
            public AccountNotActiveException(string message, Exception inner) : base(message, inner) { }
            protected AccountNotActiveException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }
        }
    }

