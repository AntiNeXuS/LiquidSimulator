// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Block.cs" company="">
//   
// </copyright>
// <summary>
//   The block.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Blocks
{
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Interfaces;

    /// <summary>
    /// The block.
    /// </summary>
    public abstract class Block : IUpdatable
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Block"/> class.
        /// </summary>
        /// <param name="owner">
        /// The owner.
        /// </param>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        protected Block(IMap owner, int id, Point3D position)
        {
            this.owner = owner;
            this.Id = id;
            this.Position = position;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the id.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether is visible.
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Gets the position.
        /// </summary>
        public Point3D Position { get; private set; }

        /// <summary>
        /// Gets the owner.
        /// </summary>
        public IMap owner { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update.
        /// </summary>
        public abstract void Update();

        #endregion
    }
}