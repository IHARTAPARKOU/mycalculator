using MyCalculator.Core;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Add()
        {
            ICore core = new Core();

            Assert.IsTrue(core.Add(1, 1) == 2);
            Assert.IsTrue(core.Add(1, 2) != 2);
        }

        [Test]
        public void Sub()
        {
            ICore core = new Core();

            Assert.IsTrue(core.Sub(1, 1) == 0);
            Assert.IsTrue(core.Sub(1, 2) == -1);
        }
    }
}
