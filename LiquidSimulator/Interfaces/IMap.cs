// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMap.cs" company="">
//   
// </copyright>
// <summary>
//   The Map interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Windows.Media.Media3D;

using LiquidSimulator.Blocks;

namespace LiquidSimulator.Interfaces
{
    /// <summary>
    /// The Map interface.
    /// </summary>
    public interface IMap
    {
        #region Public Properties

        /// <summary>
        /// Gets the blocks.
        /// </summary>
        IDictionary<Point3D, Block> Blocks { get; }

        IDictionary<Point3D, Block> UpdatingBlocks { get; }

        void Replace(Point3D position, Block newBlock);

        #endregion
    }
}