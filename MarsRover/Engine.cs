using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.Models;
using MarsRover.Enums;

namespace MarsRover
{
    public class Engine
    {
        private RoverModel roverModel;
        private PlateauModel plateauModel;

        public Engine(RoverModel roverModel, PlateauModel plateauModel)
        {
            this.roverModel = roverModel;
            this.plateauModel = plateauModel;
        }

        public void Execute(string steps)
        {            
            for(int i = 0; i < steps.Length; i++)                            
                Action(Convert.ToChar(steps[i]));            
        }

        private void Action(char step)
        {
            switch (step)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
                default:
                    Console.WriteLine("Undefined command '" + step + "'");
                    break;
            }
        }

        private void TurnLeft()
        {
            roverModel.Position.Direction = roverModel.Position.Direction == Direction.N ? Direction.W : (Direction)((int)roverModel.Position.Direction - 1);
        }

        private void TurnRight()
        {
            roverModel.Position.Direction = roverModel.Position.Direction == Direction.W ? Direction.N : (Direction)((int)roverModel.Position.Direction + 1);
        }
        private void Move()
        {
            if (!BorderControl()) return;
            switch (roverModel.Position.Direction)
            {
                case Direction.N:
                    roverModel.Position.X += 1;
                    break;
                case Direction.E:
                    roverModel.Position.Y += 1;
                    break;
                case Direction.S:
                    roverModel.Position.X -= 1;
                    break;
                case Direction.W:
                    roverModel.Position.Y -= 1;
                    break;
                default:
                    break;
            }
        }

        private bool BorderControl()
        {
            if (roverModel.Position.Direction == Direction.N && roverModel.Position.X + 1 <= plateauModel.Height)
                return true;
            else if (roverModel.Position.Direction == Direction.E && roverModel.Position.Y + 1 <= plateauModel.Width)
                return true;
            else if (roverModel.Position.Direction == Direction.S && roverModel.Position.X - 1 > 0)
                return true;
            else if (roverModel.Position.Direction == Direction.W && roverModel.Position.Y - 1 > 0)
                return true;
            else
                return false;
        }
    }
}
