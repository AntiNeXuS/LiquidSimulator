using System.Linq;
using System.Windows.Media.Media3D;
using LiquidSimulator.Interfaces;

namespace LiquidSimulator.Base
{
    public class WaterBlock : Block
    {
        private byte _level;
        public byte Level
        {
            get
            {
                return _level;
            }

            set
            {
                if (!IsSource)
                {
                    _level = value;
                }
            }
        }

        public bool IsSource { get; private set; }

        public WaterBlock(bool isSource, Point3D position) : base(TileTypes.Liquid, position)
        {
            IsSource = isSource;
            if (isSource)
            {
                _level = 15;
            }
        }

        public override void Update(IMap map)
        {
            if (Level > 2)
            {
                var top = new Point3D(Position.X + 1, Position.Y, Position.Z);
                var bottom = new Point3D(Position.X - 1, Position.Y, Position.Z);
                var left = new Point3D(Position.X, Position.Y + 1, Position.Z);
                var right = new Point3D(Position.X, Position.Y - 1, Position.Z);
                var down = new Point3D(Position.X, Position.Y, Position.Z - 1);

                var neightbours = map.Blocks.Where(x => x.Type != TileTypes.Solid
                                                        &&
                                                        (x.Position == top || x.Position == bottom || x.Position == left ||
                                                         x.Position == right || x.Position == down));
                foreach (var tile in neightbours)
                {
                    if (tile.Type == TileTypes.Air)
                    {
                        map.Blocks.Remove(tile);
                        map.Blocks.Add(new WaterBlock(false, tile.Position));
                    }

                    if (tile is WaterBlock)
                    {
                        var other = tile as WaterBlock;
                        if (Level > 2)
                        {
                            if (other.Level < Level)
                            {
                                other.Level += 1;
                                Level -= 1;
                            }
                            else if (other.Level > Level)
                            {
                                other.Level -= 1;
                                Level += 1;
                            }
                        }
                    }
                }
            }

            base.Update(map);
        }
    }
}