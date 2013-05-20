// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMap.cs" company="">
//   
// </copyright>
// <summary>
//   The Map interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Interfaces
{
    using System.Collections.Generic;

    using LiquidSimulator.Blocks;

    /// <summary>
    /// The Map interface.
    /// </summary>
    public interface IMap
    {
        #region Public Properties

        /// <summary>
        /// Gets the blocks.
        /// </summary>
        List<Block> Blocks { get; }

        #endregion
    }
}