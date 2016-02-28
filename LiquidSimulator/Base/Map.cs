// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Map.cs" company="">
//   
// </copyright>
// <summary>
//   The map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Windows.Media.Media3D;

using LiquidSimulator.Blocks;
using LiquidSimulator.Interfaces;

namespace LiquidSimulator.Base
{
    /// <summary>
    /// The map.
    /// </summary>
    public class Map : IMap, IUpdatable
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class.
        /// </summary>
        /// <param name="sizeX">
        /// The size x.
        /// </param>
        /// <param name="sizeY">
        /// The size y.
        /// </param>
        /// <param name="sizeZ">
        /// The size z.
        /// </param>
        public Map(int sizeX = 10, int sizeY = 10, int sizeZ = 10)
        {
            Blocks = new Dictionary<Point3D, Block>();

            for (var x = 0; x < sizeX; x++)
            {
                for (var y = 0; y < sizeY; y++)
                {
                    for (var z = 0; z < sizeZ; z++)
                    {
                        var position = new Point3D(x, y, z);
                        if (z == 0)
                        {
                            Blocks.Add(position, new Solid(this, position));
                        }
                        else
                        {
                            Blocks.Add(position, new Air(this, position));
                        }
                    }
                }
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the blocks.
        /// </summary>
        public IDictionary<Point3D, Block> Blocks { get; private set; }

        public IDictionary<Point3D, Block> UpdatingBlocks { get; private set; }

        #endregion

        #region Public Methods and Operators

        public void Replace(Point3D position, Block newBlock)
        {
            Blocks.Remove(position);
            Blocks.Add(position, newBlock);
        }

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            foreach (var block in Blocks)
            {
                block.Value.Update();
            }
        }

        #endregion
    }
}