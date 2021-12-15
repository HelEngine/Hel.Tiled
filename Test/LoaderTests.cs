using System.IO;
using FluentAssertions;
using Hel.Tiled;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class LoaderTests
    {
        
        [Test]
        [TestCase("./MapFiles/beach_tileset.json")]
        public void Should_LoadTileset_When_ValidPathProvided(string path) {
            var tileset = Loader.LoadTileset(path);

            tileset.Columns.Should().Be(36);
            tileset.Image.Should().Be("beach_tileset.png");
            tileset.Name.Should().Be("beach_tileset");
        }

        [Test]
        [TestCase("invalid_path.json")]
        public void Should_ThrowException_On_LoadTileset_When_InvalidPathProvided(string path) =>
            Assert.Throws<FileNotFoundException>(() => {
                Loader.LoadTileset(path);
            });
    }
}