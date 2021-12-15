using FluentAssertions;
using Hel.Tiled;
using NUnit.Framework;

namespace Test {

    [TestFixture]
    public class TilemapManagerTests {

        private TilemapManager _tilemapManager;
        
        [SetUp]
        public void Setup() {
            _tilemapManager = new TilemapManager(Loader.LoadTilemap("./MapFiles/TilemapManagerTests.json"));
        }

        [Test]
        [TestCase("ObjectA", 1)]
        // TODO: Test fails, fix bug. 
        [TestCase("ObjectB", 0)]
        public void Should_GetObjects_WhenValidDataProvided(string objectGroupName, int countOfObjects) {
            var objs = _tilemapManager.GetObjects(objectGroupName);
            objs.Item1.Should().Be(1);
            objs.Item2.Should().HaveCount(countOfObjects);
        }
    }
}
