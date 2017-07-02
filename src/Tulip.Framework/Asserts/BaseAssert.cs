using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Common;

namespace Tulip.Framework.Asserts
{
    public abstract class BaseAssert : IFailure
    {
        /// <summary>
        /// Initializes the class with the specified source value, operator and assert type.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="operator">The operator type.</param>
        /// <param name="type">The assert type.</param>
        public BaseAssert(object source, OperatorType @operator, AssertType type)
        {
            this.Source = source;
            this.Operator = @operator;
            this.Type = type;
        }

        /// <summary>
        /// Gets the source value.
        /// </summary>
        public object Source { get; private set; }

        /// <summary>
        /// Gets the operator type.
        /// </summary>
        public OperatorType Operator { get; private set; }

        /// <summary>
        /// Gets the assert type.
        /// </summary>
        public AssertType Type { get; private set; }

        /// <summary>
        /// Checks whether the assertion is failed. If the specified status is NOT matching 
        /// with the selected operator, then the assertion is considered as failed.
        /// </summary>
        /// <param name="status">The result of assertion.</param>
        /// <returns>A boolean true if the assertion is failed.</returns>
        protected bool IsFailed(bool status)
        {
            if ((status == true && this.Operator == OperatorType.IsNot) || (status == false && this.Operator == OperatorType.Is))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Throws the assert exception when the specified assert condition fails. The exception 
        /// has all required failure information.
        /// </summary>
        /// <param name="assertName">The assert name.</param>
        /// <param name="source">The source value for the assert.</param>
        /// <param name="target">The target value for the assert.</param>
        /// <param name="isMessage">The message to use while having 'Is' operator.</param>
        /// <param name="isNotMessage">The message to use while having 'IsNot' operator.</param>
        /// <param name="userMessage">The user specified message.</param>
        protected void HandleFail(string assertName, object source, object target, string isMessage, string isNotMessage, string userMessage)
        {
            var assert = new AssertInfo(this.Type, assertName);
            var message = this.getMessage(assert, isMessage, isNotMessage, userMessage);
            this.HandleFail(assert, source, target, message);
        }

        /// <summary>
        /// Throws the assert exception when the specified assert condition fails. The exception 
        /// has all required failure information.
        /// </summary>
        /// <param name="assert">The instance of 'AssertInfo' object.</param>
        /// <param name="source">The source value for the assert.</param>
        /// <param name="target">The target value for the assert.</param>
        /// <param name="message">The instance of 'Message' object.</param>
        protected void HandleFail(AssertInfo assert, object source, object target, Message message)
        {
            var failure = new FailureInfo(assert, this.Operator, source, target, message);
            throw new AssertFailedException(failure.Message.ToString(), failure);
        }

        /// <summary>
        /// Throws the assert exception when the specified assert condition fails. The exception 
        /// has all required failure information.
        /// </summary>
        /// <param name="assert">The instance of 'AssertInfo' object.</param>
        /// <param name="source">The source value for the assert.</param>
        /// <param name="target">The target value for the assert.</param>
        /// <param name="message">The instance of 'Message' object.</param>
        void IFailure.HandleFail(AssertInfo assert, object source, object target, Message message)
        {
            this.HandleFail(assert, source, target, message);
        }

        /// <summary>
        /// Invokes the specified validator. The validator is a delegate which 
        /// is responsible to validate the source value.
        /// </summary>
        /// <param name="validator">The delegate to validate the source value.</param>
        protected void InvokeValidator<T>(Action<Expression<T>> validator, string assertName)
        {
            if (validator != null)
            {
                try
                {
                    validator.Invoke(new Expression<T>(this, assertName));
                }
                catch (AssertFailedException)
                {
                    throw;
                }
                catch (Exception exp)
                {
                    var message = "The validator has thrown an unhandled exception.";
                    this.HandleFail(assertName, this.Source, null, message, message, exp.Message);
                }
            }
        }
        
        private Message getMessage(AssertInfo assert, string isMessage, string isNotMessage, string userMessage)
        {
            var failureMessage = assert.GetFailureMessage(this.Operator);
            var selectedMessage = this.Operator == OperatorType.Is ? isMessage : isNotMessage;
            var systemMessage = $"{failureMessage} {selectedMessage}";
            
            return new Message(systemMessage, userMessage);
        }
    }
}
