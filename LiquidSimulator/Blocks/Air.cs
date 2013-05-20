// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Air.cs" company="">
//   
// </copyright>
// <summary>
//   The air.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Blocks
{
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Interfaces;

    /// <summary>
    /// The air.
    /// </summary>
    public class Air : Block
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Air"/> class.
        /// </summary>
        /// <param name="owner">
        /// The owner.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        public Air(IMap owner, Point3D position)
            : base(owner, 0, position)
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