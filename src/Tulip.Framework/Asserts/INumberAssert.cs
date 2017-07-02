using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Asserts
{
    public interface INumberAssert<T> : IAssert<T> where T : struct, IComparable<T>
    {
        #region EqualTo

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void EqualTo(T value);

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void EqualTo(T value, string message);

        #endregion

        #region GreaterThan

        /// <summary>
        /// Asserts that the source value is greater than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void GreaterThan(T value);

        /// <summary>
        /// Asserts that the source value is greater than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void GreaterThan(T value, string message);

        #endregion

        #region LessThan

        /// <summary>
        /// Asserts that the source value is less than the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void LessThan(T value);

        /// <summary>
        /// Asserts that the source value is less than the target value.
        /// </summary>
        /// <param name="value">The number to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void LessThan(T value, string message);

        #endregion
    }
}
