using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Asserts;
using Tulip.Framework.Common;

namespace Tulip.Framework
{
    public class Expression<T>
    {
        private IFailure failure;

        private AssertInfo assert;

        /// <summary>
        /// Initializes the class with the specified assert object and assert name.
        /// </summary>
        /// <param name="assert">The instance of assert object.</param>
        /// <param name="assertName">The assert name.</param>
        public Expression(BaseAssert assert, string assertName)
        {
            this.failure = assert;
            this.assert = new AssertInfo(assert.Type, assertName);
            this.Source = (T)assert.Source;
            this.Operator = assert.Operator;
        }

        /// <summary>
        /// Gets the source value.
        /// </summary>
        public T Source { get; private set; }

        /// <summary>
        /// Gets the operator type.
        /// </summary>
        public OperatorType Operator { get; private set; }

        /// <summary>
        /// Halts the assert operation by throwing exception.
        /// </summary>
        /// <param name="message">The message to display on failure.</param>
        public void Halt(string message)
        {
            var msg = new Message(this.assert.GetFailureMessage(this.Operator), message);
            failure.HandleFail(this.assert, this.Source, null, msg);
        }

        /// <summary>
        /// Halts the assert operation by throwing exception.
        /// </summary>
        /// <param name="target">The target value.</param>
        /// <param name="message">The message to display on failure.</param>
        public void Halt(T target, string message)
        {
            var msg = new Message(this.assert.GetFailureMessage(this.Operator), message);
            failure.HandleFail(this.assert, this.Source, target, msg);
        }
    }
}
