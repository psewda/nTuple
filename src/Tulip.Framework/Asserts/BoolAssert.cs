using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Common;

namespace Tulip.Framework.Asserts
{
    public class BoolAssert : BaseAssert, IBoolAssert
    {
        #region Ctors

        /// <summary>
        /// Initializes the class with the specified source value and operator type.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="operator">The operator type.</param>
        public BoolAssert(object source, OperatorType @operator) : base(source, @operator, AssertType.Boolean)
        {

        }

        #endregion
        
        #region True

        /// <summary>
        /// Asserts that the source value is true.
        /// </summary>
        public void True()
        {
            this.True(null);
        }

        /// <summary>
        /// Asserts that the source value is true.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        public void True(string message)
        {
            const string assertName = nameof(this.True);
            var source = (bool)this.Source;
            var status = source == true;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <true> ";
                isMessage += $"but actually found <{source.ToLower()}>.";

                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value other than true> ";
                isNotMessage += $"but actually found <{source.ToLower()}>.";
                
                this.HandleFail(assertName, this.Source, true, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region False

        /// <summary>
        /// Asserts that the source value is false.
        /// </summary>
        public void False()
        {
            this.False(null);
        }

        /// <summary>
        /// Asserts that the source value is false.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        public void False(string message)
        {
            const string assertName = nameof(this.False);
            var source = (bool)this.Source;
            var status = source == false;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <false> ";
                isMessage += $"but actually found <{source.ToLower()}>.";
                
                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value other than false> ";
                isNotMessage += $"but actually found <{source.ToLower()}>.";
                
                this.HandleFail(assertName, this.Source, false, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region EqualTo

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void EqualTo(bool value)
        {
            this.EqualTo(value, null);
        }

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void EqualTo(bool value, string message)
        {
            const string assertName = nameof(this.EqualTo);
            var source = (bool)this.Source;
            var status = source == value;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <{value.ToLower()}> ";
                isMessage += $"but actually found <{source.ToLower()}>.";

                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value other than {value.ToLower()}> ";
                isNotMessage += $"but actually found <{source.ToLower()}>.";
                
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region Valid

        /// <summary>
        /// Asserts that the source value is valid.
        /// </summary>
        /// <param name="validator">The delegate to validate the source value.</param>
        public void Valid(Action<Expression<bool>> validator)
        {
            this.InvokeValidator(validator, nameof(this.Valid));
        }

        #endregion
    }
}
