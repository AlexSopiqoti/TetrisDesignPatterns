using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CellType type { get; set; }
        public Cell(int x, int y, CellType type)
        {
            this.X = x;
            this.Y = y;
            this.type = type;

        }
        public enum CellType
        {
            Free,
            L,
            O,
            T,
            I,
            Z,
            Busy
        }
    }
}
