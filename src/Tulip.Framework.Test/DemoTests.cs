using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulip.Framework.Test
{
    [NUnit.Framework.TestFixture]
    public class DemoTests
    {
        [NUnit.Framework.Test]
        public void Test1()
        {
            var name = "Prakash";
            var str = $"my name is {name}";
        }

        [NUnit.Framework.Test]
        public void Test2()
        {
            TestUtility.Display();
        }
    }
}
