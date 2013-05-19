using System.Windows.Media.Media3D;
using LiquidSimulator.Interfaces;

namespace LiquidSimulator.Base
{
    public class Tile : IUpdatable
    {
        public Point3D Position { get; private set; }

        public TileTypes Type { get; private set; }

        public Tile(TileTypes type, Point3D position)
        {
            Type = type;
            Position = position;
        }

        public virtual void Update(IMap map)
        {
        }
    }
}