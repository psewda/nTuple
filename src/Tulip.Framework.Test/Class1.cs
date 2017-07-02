using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulip.Framework.Asserts;

namespace Tulip.Framework.Test
{
    public class Emp
    {
        public int EmpId { get; set; }
    }

    public static class Wow
    {
        public static void ContainingSpace(this IStringAssert assert)
        {
            var exp = Runtime.GetExpression(assert, nameof(Wow.ContainingSpace));
            
            if(!exp.Source.Contains("WW"))
            {
                exp.Halt("the string has space");

                Verify.That(232).Is.EqualTo(353);
            }
        }

        public static void WOwNum<T>(this INumberAssert<T> assert) where T : struct, IComparable<T>
        {
            var exp = Runtime.GetExpression(assert, nameof(Wow.WOwNum));
            
            exp.Halt("invalid employee #");

            exp.Halt("Invalid emp number. Employee number is always numeric");
            
        }
    }
    

    public class Class1
    {
        //[NUnit.Framework.Test]
        public void Test()
        {
            //Assert.That("wow").Is.StartingWith("w1");

            Assert.That("").Is.ContainingSpace();
            
            Assert.That(45).Is.EqualTo(40);

            Assert.That("prakash").Is.EndingWith("kash");

            //Assert.That(12).Is.Valid(i => i.Fail("invalid value passed"));


            //Assert.That(new Emp()).Is.Valid;
        }
    }
}
