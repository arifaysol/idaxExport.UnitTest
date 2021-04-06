using Database.Repositories;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    public abstract class TestGeneric
    {
        public abstract long CountOfDbo { get; set; }
        public abstract long CountOfIdx { get; set; }

        [SetUp]
        public void SetUp()
        {
            if (!RegisterService.WasInjected)
            {
                RegisterService.Register();
            }
        }
        [TestCase]
        public virtual async Task CompareCountOfRows()
        {
            await Task.Run(() =>
            {
                Assert.AreEqual(CountOfDbo, CountOfIdx);
            });
        }

        public abstract Task CompareLineBaseLineLatestRows();

    }
}
