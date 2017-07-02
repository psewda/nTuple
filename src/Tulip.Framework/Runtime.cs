using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Asserts;

namespace Tulip.Framework
{
    public class Runtime
    {
        /// <summary>
        /// Gets the instance of assert expression.
        /// </summary>
        /// <param name="assert">The instance of assert object.</param>
        /// <param name="assertName">The assert name.</param>
        /// <returns>The instance of assert expression.</returns>
        public static Expression<T> GetExpression<T>(IAssert<T> assert, string assertName)
        {
            if (assert != null)
            {
                var baseAssert = assert as BaseAssert;
                return baseAssert != null ? new Expression<T>(baseAssert, assertName) : null;
            }
            else
            {
                return null;
            }
        }
    }
}
