using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Enums;

namespace MarsRover.Models
{
    public class PositionModel
    {
        /// <summary>
        /// Position of the rover on the plane on the x-axis.
        /// </summary>
        private int x;

        /// <summary>
        /// Position of the rover on the plane on the y-axis.
        /// </summary>
        private int y;

        /// <summary>
        /// Direction of the rover on the plane.
        /// </summary>
        private Direction direction;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Direction Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        /// <summary>
        /// Position cannot be created without giving the coordinate information.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public PositionModel(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }
    }
}
