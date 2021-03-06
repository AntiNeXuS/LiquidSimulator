﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapTests.cs" company="">
//   
// </copyright>
// <summary>
//   The map tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Windows.Media.Media3D;

using FluentAssertions;
using NUnit.Framework;

using LiquidSimulator.Base;
using LiquidSimulator.Blocks;
using LiquidSimulator.Blocks.Liquids;

namespace LiquidSimulatorTests.Base
{
    /// <summary>
    /// The map tests.
    /// </summary>
    [TestFixture]
    public class MapTests
    {
        #region Public Methods and Operators

        /// <summary>
        /// The create map test.
        /// </summary>
        [Test]
        public void CreateMapTest()
        {
            var map = new Map();

            map.Should().NotBeNull();
            map.Blocks.Should().NotBeNull();
            map.Blocks.Should().NotBeNull();
            (map.Blocks[new Point3D(0, 0, 0)] is Solid).Should().BeTrue();
            (map.Blocks[new Point3D(0, 0, 1)] is Air).Should().BeTrue();
        }

        /// <summary>
        /// The create water source test.
        /// </summary>
        [Test]
        public void CreateWaterSourceTest()
        {
            var map = new Map();
            var liquidPoint = new Point3D(5, 5, 1);
            map.Replace(liquidPoint, new Liquid(map, liquidPoint, LiquidTypes.Water,  true));

            var liquidTile = map.Blocks[liquidPoint];
            (liquidTile is Liquid).Should().BeTrue();
            var liquid = liquidTile as Liquid;
            liquid.IsSource.Should().BeTrue();
            liquid.Level.Should().Be(15);
        }

        /// <summary>
        /// The update water source test.
        /// </summary>
        [Test]
        public void UpdateWaterSourceTest()
        {
            var map = new Map();
            var liquidPoint = new Point3D(5, 5, 1);
            map.Replace(liquidPoint, new Liquid(map, liquidPoint, LiquidTypes.Water,  true));

            var liquid = map.Blocks[liquidPoint] as Liquid;
            liquid.Should().NotBeNull();
            liquid.Level.Should().Be(15);

            map.Update();

            liquid.Level.Should().Be(15);

            (liquid.Top() is Air).Should().BeTrue();
            (liquid.Bottom() is Solid).Should().BeTrue();
            var front = liquid.Front();
            (front is Liquid).Should().BeTrue();
            (front as Liquid).Level.Should().Be(1);
            var behind = liquid.Behind();
            var left = liquid.Left();
            var right = liquid.Right();

            /*var topN = map.Blocks.First(x => x.Position == new Point3D(6, 5, 1));
            var bottomN = map.Blocks.First(x => x.Position == new Point3D(4, 5, 1));
            var leftN = map.Blocks.First(x => x.Position == new Point3D(5, 4, 1));
            var rightN = map.Blocks.First(x => x.Position == new Point3D(5, 6, 1));*/

            /*topN.Should().NotBeNull();
            bottomN.Should().NotBeNull();
            leftN.Should().NotBeNull();
            rightN.Should().NotBeNull();*/

            /*(topN is WaterTile).Should().BeTrue();
            (bottomN is WaterTile).Should().BeTrue();
            (leftN is WaterTile).Should().BeTrue();
            (rightN is WaterTile).Should().BeTrue();*/
        }

        #endregion
    }
}