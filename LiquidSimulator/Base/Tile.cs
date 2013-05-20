// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tile.cs" company="">
//   
// </copyright>
// <summary>
//   The tile.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Base
{
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Interfaces;

    /// <summary>
    /// The tile.
    /// </summary>
    public class Tile : IUpdatable
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        public Tile(TileTypes type, Point3D position)
        {
            Type = type;
            Position = position;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the position.
        /// </summary>
        public Point3D Position { get; private set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public TileTypes Type { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update.
        /// </summary>
        public virtual void Update()
        {
        }

        #endregion
    }
}