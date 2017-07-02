using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Common
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Gets the failure message created with assert object and operator type.
        /// </summary>
        /// <param name="assert">The instance of assert object.</param>
        /// <param name="operator">The operator type.</param>
        /// <returns>The failure message created with assert object and operator type.</returns>
        public static string GetFailureMessage(this AssertInfo assert, OperatorType @operator)
        {
            return $"The {assert.Type.ToString().ToLower()} assert '{@operator}.{assert.Name}()' failed.";
        }
    }
}
