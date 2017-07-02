using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public class AssertFailedException : AssertException
    {
        /// <summary>
        /// Initializes the class with the specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AssertFailedException(string message) : base(message)
        {

        }

        /// <summary>
        /// Initializes the class with the specified message and inner exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public AssertFailedException(string message, Exception innerException) : base(message, innerException)
        {

        }

        /// <summary>
        /// Initializes the class with the specified message and failure info.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="failure">The failure info instance.</param>
        public AssertFailedException(string message, FailureInfo failure) : base(message)
        {
            this.Failure = failure;
        }

        /// <summary>
        /// Gets the failure info instance.
        /// </summary>
        public FailureInfo Failure { get; private set; }
    }
}
