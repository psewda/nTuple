using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public class AssertInfo
    {
        /// <summary>
        /// Initializes the class with the specified assert type and name.
        /// </summary>
        /// <param name="type">A value from the assert type enum.</param>
        /// <param name="name">The name of assert operation.</param>
        public AssertInfo(AssertType type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Gets the assert type.
        /// </summary>
        public AssertType Type { get; private set; }

        /// <summary>
        /// Gets the assert name.
        /// </summary>
        public string Name { get; private set; }
    }
}
