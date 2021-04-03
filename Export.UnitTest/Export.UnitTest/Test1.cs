using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class Test1
    {
        [TestCase]
        public void TestLogin()
        {
            Assert.AreEqual(1, 1);
        }
        [TestCase]
        public void getuserdetails()
        {
            Assert.Pass();
        }
    }
}
