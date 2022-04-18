using System;
using MarsRover.Models;
using MarsRover.Enums;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            PositionModel positionModel = new PositionModel(1, 2, Direction.N);
            PlateauModel plateauModel = new PlateauModel(5, 5);
            RoverModel roverModel = new RoverModel(positionModel);

            Engine engine = new Engine(roverModel, plateauModel);

            engine.Execute("LMLMLMLMM");

            Console.WriteLine(roverModel.GetCurrentPosition());                     
        }
    }
}
