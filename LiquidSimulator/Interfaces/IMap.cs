using System.Collections.Generic;
using LiquidSimulator.Base;

namespace LiquidSimulator.Interfaces
{
    public interface IMap
    {
        List<Tile> Blocks { get; }
    }
}