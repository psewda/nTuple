using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Asserts;
using Tulip.Framework.Common;

namespace Tulip.Framework
{
    public class Selector<T> where T : IAssert
    {
        private object source;

        /// <summary>
        /// Initializes the class with the specified source value.
        /// </summary>
        /// <param name="source">The source value.</param>
        public Selector(object source)
        {
            this.source = source;
        }

        /// <summary>
        /// Gets the assert type instance with applied 'Is' operator.
        /// </summary>
        public T Is
        {
            get
            {
                return ObjectFactory.Get<T>(this.source, OperatorType.Is);
            }
        }

        /// <summary>
        /// Gets the assert type instance with applied 'IsNot' operator.
        /// </summary>
        public T IsNot
        {
            get
            {
                return ObjectFactory.Get<T>(this.source, OperatorType.IsNot);
            }
        }
    }
}
