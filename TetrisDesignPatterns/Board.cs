using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns
{
    class Board
    {
        public Cell[,] board { get; }
        public int width { get; }
        public int height { get; }

        public Board()
        {
            width = 10;
            height = 20;

            this.board = new Cell[10, 20];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    board[i, j] = new Cell(i, j, Cell.CellType.Free);
                }
            }
        }
    }
}
