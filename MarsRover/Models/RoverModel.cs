using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Enums;

namespace MarsRover.Models
{
    public class RoverModel
    {
        private PositionModel position;

        public RoverModel(PositionModel positionModel)
        {
            this.Position = positionModel;
        }
        public PositionModel Position 
        {
            get { return position; } 
            set { position = value; } 
        }

        public string GetCurrentPosition()
        {
            return Position.X + " " + Position.Y + " " + Position.Direction;
        }
    }
}
