// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Liquid.cs" company="">
//   
// </copyright>
// <summary>
//   The liquid.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Windows.Media.Media3D;
using LiquidSimulator.Base;
using LiquidSimulator.Interfaces;

namespace LiquidSimulator.Blocks.Liquids
{
    /// <summary>
    /// Блок жидкости
    /// </summary>
    public class Liquid : Block
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Liquid" /> class.
        /// </summary>
        /// <param name="owner">
        ///     The owner.
        /// </param>
        /// <param name="position">
        ///     The position.
        /// </param>
        /// <param name="isSource">
        ///     The is source.
        /// </param>
        public Liquid(IMap owner, Point3D position, LiquidTypes type, bool isSource)
            : base(owner, 2, position)
        {
            IsSource = isSource;
            Level = 15;
            Pressure = 1;
            Type = type;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The update.
        /// </summary>
        public override void Update()
        {
            if (Level < 2)
            {
                return;
            }

            var top = this.Top() as Liquid;
            if (top != null)
            {
                Pressure += top.Pressure;
            }

            var bottom = this.Bottom() as Liquid;
            if (bottom != null)
            {
                if (bottom.Level < Level)
                {
                    bottom.Level += 1;
                    Level -= 1;
                }
            }

            var front = this.Front();
            if (front != null)
            {
                if (front is Air)
                {
                    Owner.Blocks.Remove(front.Position);
                    Owner.Blocks.Add(front.Position, new Liquid(Owner, front.Position, Type, false) {Level = 1});
                }
                else if (front is Liquid && (front as Liquid).Level < Level)
                {
                    (front as Liquid).Level += 1;
                    Level -= 1;
                }
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
        public ushort Level { get; set; }

        /// <summary>
        ///     Gets or sets the pressure.
        /// </summary>
        public ushort Pressure { get; set; }

        public LiquidTypes Type { get; private set; }

        #endregion
    }
}