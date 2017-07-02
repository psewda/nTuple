using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public class AssertTypeNotFoundException : AssertException
    {
        /// <summary>
        /// Initializes the class with the specified message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AssertTypeNotFoundException(string message) : base(message)
        {

        }
    }
}
