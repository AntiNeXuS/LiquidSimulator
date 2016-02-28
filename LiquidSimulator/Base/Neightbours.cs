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
            var behindPoint = new Point3D(source.Position.X, source.Position.Y - 1, source.Position.Z);

            return GetValue(source, behindPoint);
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
            var bottomPoint = new Point3D(source.Position.X, source.Position.Y, source.Position.Z - 1);

            return GetValue(source, bottomPoint);
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
            var topPoint = new Point3D(source.Position.X, source.Position.Y, source.Position.Z + 1);

            return GetValue(source, topPoint);
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
            var frontPoint = new Point3D(source.Position.X, source.Position.Y + 1, source.Position.Z);
            
            return GetValue(source, frontPoint);
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
            var leftPoint = new Point3D(source.Position.X + 1, source.Position.Y, source.Position.Z);
            
            return GetValue(source, leftPoint);
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
            var rightPoint = new Point3D(source.Position.X - 1, source.Position.Y, source.Position.Z);
            
            return GetValue(source, rightPoint);
        }

        private static Block GetValue(Block source, Point3D rightPoint)
        {
            Block result;
            if (source.Owner.Blocks.TryGetValue(rightPoint, out result))
            {
                return result;
            }

            return null;
        }

        #endregion
    }
}