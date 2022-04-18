using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models
{
    public class PlateauModel
    {
        /// <summary>
        /// Width of Plateau
        /// </summary>
        private int width;

        /// <summary>
        /// Height of Plateau
        /// </summary>
        private int height;

        public PlateauModel(int w, int h)
        {
            width = w;
            height = h;
        }

        public int Width
        {
            get { return width; }
            set { width = value > 0 ? value : 0; } //The minimum value can be zero.
        }

        public int Height
        {
            get { return height; }
            set { height = value > 0 ? value : 0; } //The minimum value can be zero.
        }


    }
}
