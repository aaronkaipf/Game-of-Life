using System;
using System.Threading;

namespace GameOfLife
{
    public class Game
    {
        private readonly Grid _grid;

        public Game(int numberOfRows, int numberOfColumns)
        {
            _grid = new Grid(numberOfRows, numberOfColumns);
        }

        public void Run(int numberOfIterations)
        {

        }
    }
}
