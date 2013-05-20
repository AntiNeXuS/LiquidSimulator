// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Neightbours.cs" company="">
//   
// </copyright>
// <summary>
//   The neightbours.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Base
{
    using System.Linq;
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Blocks;

    /// <summary>
    /// The neightbours.
    /// </summary>
    public static class Neightbours
    {
        #region Public Methods and Operators

        /// <summary>
        /// The behind.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="Block"/>.
        /// </returns>
        public static Block Behind(this Block source)
        {
            return
                source.owner.Blocks.FirstOrDefault(
                    x => x.Position == new Point3D(source.Position.X, source.Position.Y - 1, source.Position.Z));
        }

        /// <summary>
        /// The bottom.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="Block"/>.
        /// </returns>
        public static Block Bottom(this Block source)
        {
            return
                source.owner.Blocks.FirstOrDefault(
                    x => x.Position == new Point3D(source.Position.X, source.Position.Y, source.Position.Z - 1));
        }

        /// <summary>
        /// The front.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="Block"/>.
        /// </returns>
        public static Block Front(this Block source)
        {
            return
                source.owner.Blocks.FirstOrDefault(
                    x => x.Position == new Point3D(source.Position.X, source.Position.Y + 1, source.Position.Z));
        }

        /// <summary>
        /// The left.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="Block"/>.
        /// </returns>
        public static Block Left(this Block source)
        {
            return
                source.owner.Blocks.FirstOrDefault(
                    x => x.Position == new Point3D(source.Position.X + 1, source.Position.Y, source.Position.Z));
        }

        /// <summary>
        /// The right.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="Block"/>.
        /// </returns>
        public static Block Right(this Block source)
        {
            return
                source.owner.Blocks.FirstOrDefault(
                    x => x.Position == new Point3D(source.Position.X - 1, source.Position.Y, source.Position.Z));
        }

        /// <summary>
        /// The top.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <returns>
        /// The <see cref="Block"/>.
        /// </returns>
        public static Block Top(this Block source)
        {
            return
                source.owner.Blocks.FirstOrDefault(
                    x => x.Position == new Point3D(source.Position.X, source.Position.Y, source.Position.Z + 1));
        }

        #endregion
    }
}