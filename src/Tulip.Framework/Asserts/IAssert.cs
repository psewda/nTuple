using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Common;

namespace Tulip.Framework.Asserts
{
    public interface IAssert
    {

    }

    public interface IAssert<T> : IAssert
    {
        /// <summary>
        /// Asserts that the source value is valid.
        /// </summary>
        /// <param name="validator">The delegate to validate the source value.</param>
        void Valid(Action<Expression<T>> validator);
    }    
}
