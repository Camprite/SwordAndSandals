using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndSandalsLogic.Exceptions
{
    internal class WarriorBuilderException : Exception
    {
        public WarriorBuilderException()
        {
        }

        public WarriorBuilderException(string? message) : base(message)
        {
        }

        public WarriorBuilderException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WarriorBuilderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
