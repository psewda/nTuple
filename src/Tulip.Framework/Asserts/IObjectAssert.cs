using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Asserts
{
    public interface IObjectAssert<T> : IAssert<T>
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
    }
}
