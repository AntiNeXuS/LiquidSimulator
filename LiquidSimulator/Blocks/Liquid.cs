// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Liquid.cs" company="">
//   
// </copyright>
// <summary>
//   The liquid.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace LiquidSimulator.Blocks
{
    using System.Windows.Media.Media3D;

    using LiquidSimulator.Base;
    using LiquidSimulator.Interfaces;

    /// <summary>
    /// The liquid.
    /// </summary>
    public class Liquid : Block
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Liquid"/> class.
        /// </summary>
        /// <param name="owner">
        /// The owner.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        /// <param name="isSource">
        /// The is source.
        /// </param>
        public Liquid(IMap owner, Point3D position, bool isSource)
            : base(owner, 2, position)
        {
            this.IsSource = isSource;
            this.Level = 15;
            this.Pressure = 1;
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
        public ushort Level { get; set; }

        /// <summary>
        /// Gets or sets the pressure.
        /// </summary>
        public ushort Pressure { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The update.
        /// </summary>
        public override void Update()
        {
            if (this.Level < 2)
            {
                return;
            }

            var top = this.Top() as Liquid;
            if (top != null)
            {
                this.Pressure += top.Pressure;
            }

            var bottom = this.Bottom() as Liquid;
            if (bottom != null)
            {
                if (bottom.Level < this.Level)
                {
                    bottom.Level += 1;
                    this.Level -= 1;
                }
            }

            var front = this.Front();
            if (front != null)
            {
                if (front is Air)
                {
                    owner.Blocks.Remove(front);
                    owner.Blocks.Add(new Liquid(owner, front.Position, false) { Level = 1 });
                }
                else if (front is Liquid && (front as Liquid).Level < Level)
                {
                    (front as Liquid).Level += 1;
                    Level -= 1;
                }
            }
        }

        #endregion
    }
}