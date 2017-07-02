using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Asserts
{
    public class NumberAssert<T> : BaseAssert, INumberAssert<T> where T : struct, IComparable<T>
    {
        #region Ctors

        /// <summary>
        /// Initializes the class with the specified source value and operator type.
        /// </summary>
        /// <param name="source">The source value.</param>
        /// <param name="operator">The operator type.</param>
        public NumberAssert(object source, OperatorType @operator) : base(source, @operator, AssertType.Number)
        {

        }

        #endregion

        #region EqualTo

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void EqualTo(T value)
        {
            this.EqualTo(value, null);
        }

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void EqualTo(T value, string message)
        {
            const string assertName = nameof(this.EqualTo);
            var source = (T)this.Source;
            var status = source.CompareTo(value) == 0;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <{value}> ";
                isMessage += $"but actually found <{source}>.";
                
                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value other than {value}> ";
                isNotMessage += $"but actually found <{source}>.";
                
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region GreaterThan

        /// <summary>
        /// Asserts that the source value is greater than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void GreaterThan(T value)
        {
            this.GreaterThan(value, null);
        }

        /// <summary>
        /// Asserts that the source value is greater than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void GreaterThan(T value, string message)
        {
            const string assertName = nameof(this.GreaterThan);
            var source = (T)this.Source;
            var status = source.CompareTo(value) > 0;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <any value greater than {value}> ";
                isMessage += $"but actually found <{source}>.";

                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value not greater than {value}> ";
                isNotMessage += $"but actually found <{source}>.";
                
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region LessThan

        /// <summary>
        /// Asserts that the source value is less than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        public void LessThan(T value)
        {
            this.LessThan(value, null);
        }

        /// <summary>
        /// Asserts that the source value is less than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        public void LessThan(T value, string message)
        {
            const string assertName = nameof(this.LessThan);
            var source = (T)this.Source;
            var status = source.CompareTo(value) < 0;

            if (this.IsFailed(status))
            {
                var isMessage = string.Empty;
                isMessage += $"The assert was expecting <any value less than {value}> ";
                isMessage += $"but actually found <{source}>.";
                
                var isNotMessage = string.Empty;
                isNotMessage += $"The assert was expecting <any value not less than {value}> ";
                isNotMessage += $"but actually found <{source}>.";
                
                this.HandleFail(assertName, this.Source, value, isMessage, isNotMessage, message);
            }
        }

        #endregion

        #region Valid

        /// <summary>
        /// Asserts that the source value is valid.
        /// </summary>
        /// <param name="validator">The delegate to validate the source value.</param>
        public void Valid(Action<Expression<T>> validator)
        {
            this.InvokeValidator(validator, nameof(this.Valid));
        }

        #endregion
    }
}
