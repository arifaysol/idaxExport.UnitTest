using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public abstract class TestGeneric<DBO,IDAX>
        where DBO:class
        where IDAX: class
    {

        [SetUp]
        public void SetUp()
        {
            // Call DI at here
        }
        [TestCase]
        public virtual void CompareCountOfRows(IEnumerable<DBO> dbos, IEnumerable<IDAX> idxs)
        {
            Assert.AreEqual(dbos.Count(), idxs.Count());
        }
        [TestCase]
        public abstract void CompareLineBaseLineLatestRows();
    }
}
