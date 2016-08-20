using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTest.Test
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void TestAddition()
        {
            int result = Addition.Add(1,2);
            Assert.AreEqual(result, 3);            
        }

    }
}
