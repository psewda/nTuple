using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public abstract class AssertException : Exception
    {
        /// <summary>
        /// Initializes the class with the specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AssertException(string message) : base(message)
        {

        }

        /// <summary>
        /// Initializes the class with the specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public AssertException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
