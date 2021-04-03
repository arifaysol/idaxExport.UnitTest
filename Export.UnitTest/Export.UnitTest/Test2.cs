using Database.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Export.UnitTest
{
    [TestFixture]
    public class Test2 : TestGeneric<idaxEntitlements, IDAX_ENTITLEMENTS>
    {
        public override void CompareLineBaseLineLatestRows()
        {
            throw new NotImplementedException();
        }
    }
}
