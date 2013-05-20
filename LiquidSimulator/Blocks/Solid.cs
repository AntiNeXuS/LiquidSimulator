// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Solid.cs" company="">
//   
// </copyright>
// <summary>
//   The solid.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Blocks
{
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Interfaces;

    /// <summary>
    /// The solid.
    /// </summary>
    public class Solid : Block
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Solid"/> class.
        /// </summary>
        /// <param name="owner">
        /// The owner.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        public Solid(IMap owner, Point3D position)
            : base(owner, 1, position)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update.
        /// </summary>
        public override void Update()
        {
        }

        #endregion
    }
}