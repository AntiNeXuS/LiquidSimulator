using System.Windows.Media.Media3D;
using LiquidSimulator.Interfaces;

namespace LiquidSimulator.Base
{
    using System;

    public class Block : IUpdatable
    {
        public Point3D Position { get; private set; }

        public Guid Id { get; private set; }

        public Block(Guid id, Point3D position)
        {
            Id = id;
            Position = position;
        }

        public virtual void Update(IMap map)
        {
        }
    }
}