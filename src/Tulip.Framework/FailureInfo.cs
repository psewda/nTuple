using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public class FailureInfo
    {
        /// <summary>
        /// Initializes the class with the specified assert, operator, source, target and message.
        /// </summary>
        /// <param name="assert">The assert info instance.</param>
        /// <param name="operator">The operator type.</param>
        /// <param name="source">The source value.</param>
        /// <param name="target">The target value.</param>
        /// <param name="message">The message instance having system and user message.</param>
        public FailureInfo(AssertInfo assert, OperatorType @operator, object source, object target, Message message)
        {
            this.Assert = assert;
            this.Operator = @operator;
            this.Source = source;
            this.Target = target;
            this.Message = message;
        }

        /// <summary>
        /// Gets the assert info.
        /// </summary>
        public AssertInfo Assert { get; private set; }

        /// <summary>
        /// Gets the operator type.
        /// </summary>
        public OperatorType Operator { get; private set; }

        /// <summary>
        /// Gets the source value.
        /// </summary>
        public object Source { get; private set; }
        
        /// <summary>
        /// Gets the target value.
        /// </summary>
        public object Target { get; private set; }

        /// <summary>
        /// Gets the message instance having system and user message.
        /// </summary>
        public Message Message { get; private set; }
    }
}
