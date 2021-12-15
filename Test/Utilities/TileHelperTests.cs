using FluentAssertions;
using Hel.Tiled.Utilities;
using NUnit.Framework;

namespace Test.Utilities {
    
    [TestFixture]
    public class TileHelperTests {

        [Test]
        [TestCase(458, TileHelper.FlippedHorizontallyFlag, true)]
        [TestCase(232, TileHelper.FlippedVerticallyFlag, false)]
        [TestCase(676, (uint) 0x00000000, false)]
        public void Should_DetectFlippedHorizontally_Flag(int gid, uint flag, bool isFlipped) =>
            TileHelper.IsFlippedHorizontally(SetFlipFlag(gid, flag)).Should().Be(isFlipped);

        private static int SetFlipFlag(int gid, uint flag) => gid | (int)flag;
    }
}
