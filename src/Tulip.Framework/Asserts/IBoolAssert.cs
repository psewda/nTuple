using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Asserts
{
    public interface IBoolAssert : IAssert<bool>
    {
        #region True

        /// <summary>
        /// Asserts that the source value is true.
        /// </summary>
        void True();

        /// <summary>
        /// Asserts that the source value is true.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        void True(string message);

        #endregion

        #region False

        /// <summary>
        /// Asserts that the source value is false.
        /// </summary>
        void False();

        /// <summary>
        /// Asserts that the source value is false.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        void False(string message);

        #endregion

        #region EqualTo

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void EqualTo(bool value);

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void EqualTo(bool value, string message);

        #endregion
    }
}
