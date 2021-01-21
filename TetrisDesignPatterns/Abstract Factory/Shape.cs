using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public interface Shape
    {
        List<Cell> draw();
        void update();
        void FillShape();
        Brush getColor();
        Cell getLowestCell();
        Cell getHighestCell();
    }
}
