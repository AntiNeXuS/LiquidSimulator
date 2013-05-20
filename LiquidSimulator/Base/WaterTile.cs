// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WaterTile.cs" company="">
//   
// </copyright>
// <summary>
//   WaterTile.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Base
{
    /*using System.Windows.Media.Media3D;

    /// <summary>
    /// The water tile.
    /// </summary>
    public class WaterTile : Tile
    {
        #region Fields

        /// <summary>
        /// The _level.
        /// </summary>
        private byte _level;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WaterTile"/> class.
        /// </summary>
        /// <param name="isSource">
        /// The is source.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        public WaterTile(bool isSource, Point3D position)
            : base(TileTypes.Liquid, position)
        {
            IsSource = isSource;
            if (isSource)
            {
                _level = 15;
            }
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether is source.
        /// </summary>
        public bool IsSource { get; private set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
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

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update.
        /// </summary>
        public override void Update()
        {
            if (Level > 2)
            {
                var neightbours = new[]
                                      {
                                          new Point3D(Position.X + 1, Position.Y, Position.Z), 
                                          new Point3D(Position.X - 1, Position.Y, Position.Z), 
                                          new Point3D(Position.X, Position.Y + 1, Position.Z), 
                                          new Point3D(Position.X, Position.Y - 1, Position.Z), 
                                          new Point3D(Position.X, Position.Y, Position.Z - 1), 
                                      };

                for (int i = 0; i < 5; i++)
                {
                    var neightbour =
                        map.Blocks.FirstOrDefault(x => x.Type != TileTypes.Solid && x.Position == neightbours[i]);

                    if (neightbour == null)
                    {
                        continue;
                    }

                    if (neightbour.Type == TileTypes.Air)
                    {
                        map.Blocks.Remove(neightbour);
                        map.Blocks.Add(new WaterTile(false, neightbour.Position));
                    }
                }

                /*if (tile is WaterTile)
                {
                    var other = tile as WaterTile;
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
                }//
            }

            base.Update(map);
        }

        #endregion
    }*/
}