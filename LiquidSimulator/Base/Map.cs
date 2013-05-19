using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Media3D;
using LiquidSimulator.Interfaces;

namespace LiquidSimulator.Base
{
    public class Map : IMap
    {
        public List<Tile> Blocks { get; private set; }

        public Map(int sizeX = 10, int sizeY = 10, int sizeZ = 10)
        {
            Blocks = new List<Tile>();

            for (var x = 0; x < sizeX; x++)
                for (var y = 0; y < sizeY; y++)
                    for (var z = 0; z < sizeZ; z++)
                    {
                        var type = z == 0 ? TileTypes.Solid : TileTypes.Air;
                        Blocks.Add(new Tile(type, new Point3D(x, y, z)));
                    }

        }

        public void Update()
        {
            foreach (var tile in Blocks.Where(x => x.Type != TileTypes.Air))
            {
                tile.Update(this);
            }
        }
    }
}