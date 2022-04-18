using System;
using Xunit;
using MarsRover.Models;

namespace MarsRover.Test
{
    public class EngineTest
    {
        [Fact]
        public void ExecuteTest()
        {
            #region Arrange
            PositionModel position = new PositionModel(1, 2, Enums.Direction.N);
            PlateauModel plateau = new PlateauModel(5, 5);
            RoverModel rover = new RoverModel(position);
            Engine _engine = new Engine(rover, plateau);
            #endregion

            #region Act
            _engine.Execute("LMLMLMLMM");
            #endregion

            #region Assert
            Assert.Equal("3 2 N", rover.GetCurrentPosition());
            #endregion
        }
    }
}
