using System.Linq;
using System.Windows.Media.Media3D;
using FluentAssertions;
using LiquidSimulator.Base;
using NUnit.Framework;

namespace LiquidSimulatorTests.Base
{
    [TestFixture]
    public class MapTests
    {
        [Test]
        public void CreateMapTest()
        {
            var map = new Map();

            map.Should().NotBeNull();
            map.Blocks.Should().NotBeNull();
            map.Blocks.Should().NotBeNull();
            map.Blocks.First(x => x.Position == new Point3D(0, 0, 0)).Type.Should().Be(TileTypes.Solid);
            map.Blocks.First(x => x.Position == new Point3D(0, 0, 1)).Type.Should().Be(TileTypes.Air);
        }

        [Test]
        public void CreateWaterSourceTest()
        {
            var map = new Map();
            map.Blocks.Remove(map.Blocks.First(x => x.Position == new Point3D(5, 5, 1)));
            map.Blocks.Add(new WaterTile(true, new Point3D(5, 5, 1)));

            var liquidTile = map.Blocks.First(x => x.Position == new Point3D(5, 5, 1));
            liquidTile.Type.Should().Be(TileTypes.Liquid);
            (liquidTile is WaterTile).Should().BeTrue();
            (liquidTile as WaterTile).IsSource.Should().BeTrue();
            (liquidTile as WaterTile).Level.Should().Be(15);
        }

        [Test]
        public void UpdateWaterSourceTest()
        {
            var map = new Map();
            map.Blocks.Remove(map.Blocks.First(x => x.Position == new Point3D(5, 5, 1)));
            map.Blocks.Add(new WaterTile(true, new Point3D(5, 5, 1)));

            var liquidTile = map.Blocks.First(x => x.Position == new Point3D(5, 5, 1)) as WaterTile;
            liquidTile.Level.Should().Be(15);
            
            map.Update();

            liquidTile.Level.Should().Be(15);

            var topN = map.Blocks.First(x => x.Position == new Point3D(6, 5, 1));
            var bottomN = map.Blocks.First(x => x.Position == new Point3D(4, 5, 1));
            var leftN = map.Blocks.First(x => x.Position == new Point3D(5, 4, 1));
            var rightN = map.Blocks.First(x => x.Position == new Point3D(5, 6, 1));

            topN.Should().NotBeNull();
            bottomN.Should().NotBeNull();
            leftN.Should().NotBeNull();
            rightN.Should().NotBeNull();

            /*(topN is WaterTile).Should().BeTrue();
            (bottomN is WaterTile).Should().BeTrue();
            (leftN is WaterTile).Should().BeTrue();
            (rightN is WaterTile).Should().BeTrue();*/
        }
    }
}