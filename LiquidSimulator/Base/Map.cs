// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Map.cs" company="">
//   
// </copyright>
// <summary>
//   The map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Base
{
    using System.Collections.Generic;
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Blocks;
    using LiquidSimulator.Interfaces;

    /// <summary>
    /// The map.
    /// </summary>
    public class Map : IMap
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
            Blocks = new List<Block>();

            for (var x = 0; x < sizeX; x++)
            {
                for (var y = 0; y < sizeY; y++)
                {
                    for (var z = 0; z < sizeZ; z++)
                    {
                        if (z == 0)
                        {
                            Blocks.Add(new Solid(this, new Point3D(x, y, z)));
                        }
                        else
                        {
                            Blocks.Add(new Air(this, new Point3D(x, y, z)));
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
        public List<Block> Blocks { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update.
        /// </summary>
        public void Update()
        {
            foreach (var block in Blocks)
            {
                block.Update();
            }
        }

        #endregion
    }
}