using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Asserts
{
    public interface IFailure
    {
        /// <summary>
        /// Throws the assert exception when the specified assert condition fails. The exception 
        /// has all required failure information.
        /// </summary>
        /// <param name="assert">The instance of 'AssertInfo' object.</param>
        /// <param name="source">The source value for the assert.</param>
        /// <param name="target">The target value for the assert.</param>
        /// <param name="message">The instance of 'Message' object.</param>
        void HandleFail(AssertInfo assert, object source, object target, Message message);
    }
}
