using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework
{
    public enum AssertType
    {
        /// <summary>
        /// The 'String' assert is used to compare string values.
        /// </summary>
        String,

        /// <summary>
        /// The 'Number' assert is used to compare numeric values.
        /// </summary>
        Number,

        /// <summary>
        /// The 'Boolean' assert is used to compare boolean values.
        /// </summary>
        Boolean,

        /// <summary>
        /// The 'Object' assert is used to compare object values.
        /// </summary>
        Object
    }
}
