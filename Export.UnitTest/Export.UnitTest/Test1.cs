﻿using Database.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Export.UnitTest
{
    [TestFixture]
    public class Test1: TestGeneric<idaxScenarios,IDAX_SCENARIOS>
    {
        public override void CompareLineBaseLineLatestRows()
        {
            throw new NotImplementedException();
        }

        [TestCase]
        public void TestLogin2()
        {
            Assert.AreEqual(1, 1);
        }
        
    }
}
