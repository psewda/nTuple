using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Asserts
{
    public interface IStringAssert : IAssert<string>
    {
        #region Null

        /// <summary>
        /// Asserts that the source value is null.
        /// </summary>
        void Null();

        /// <summary>
        /// Asserts that the source value is null.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        void Null(string message);

        #endregion

        #region Empty

        /// <summary>
        /// Asserts that the source value is empty.
        /// </summary>
        void Empty();

        /// <summary>
        /// Asserts that the source value is empty.
        /// </summary>
        /// <param name="message">The message to display when any failure.</param>
        void Empty(string message);

        #endregion

        #region EqualTo

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void EqualTo(string value);

        /// <summary>
        /// Asserts that the source value is equal to the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void EqualTo(string value, string message);

        /// <summary>
        /// Asserts that the source value is equal to the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        void EqualTo(string value, bool ignoreCase);

        /// <summary>
        /// Asserts that the source value is equal to the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        void EqualTo(string value, bool ignoreCase, string message);

        #endregion

        #region Containing

        /// <summary>
        /// Asserts that the source value is containing the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void Containing(string value);

        /// <summary>
        /// Asserts that the source value is containing the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void Containing(string value, string message);

        /// <summary>
        /// Asserts that the source value is containing the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        void Containing(string value, bool ignoreCase);

        /// <summary>
        /// Asserts that the source value is containing the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        void Containing(string value, bool ignoreCase, string message);

        #endregion

        #region StartingWith

        /// <summary>
        /// Asserts that the source value is starting with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void StartingWith(string value);

        /// <summary>
        /// Asserts that the source value is starting with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void StartingWith(string value, string message);

        /// <summary>
        /// Asserts that the source value is starting with the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        void StartingWith(string value, bool ignoreCase);

        /// <summary>
        /// Asserts that the source value is starting with the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        void StartingWith(string value, bool ignoreCase, string message);

        #endregion

        #region EndingWith

        /// <summary>
        /// Asserts that the source value is ending with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        void EndingWith(string value);

        /// <summary>
        /// Asserts that the source value is ending with the target value.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="message">The message to display when any failure.</param>
        void EndingWith(string value, string message);

        /// <summary>
        /// Asserts that the source value is ending with the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        void EndingWith(string value, bool ignoreCase);

        /// <summary>
        /// Asserts that the source value is ending with the target value. A boolean parameter
        /// specifies whether the operation is case-sensitive.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="ignoreCase">A boolean true to ignore case; false to consider case.</param>
        /// <param name="message">The message to display when any failure.</param>
        void EndingWith(string value, bool ignoreCase, string message);

        #endregion
    }
}
