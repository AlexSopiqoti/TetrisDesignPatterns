using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Visitor;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public interface IShape
    {
        List<Cell> draw();
        void update();
        void FillShape();
        Brush getColor();
        Cell getLowestCell();
        Cell getHighestCell();
        void findLowestCell();
        void findHighestCell();
        void setPos(int pos);
        int getPos();
        void accept(MoveLeft MoveLeft);
        void accept(MoveRight MoveRight);
        void accept(RotateAt3 RotateAt3);
        void accept(RotateAt6 RotateAt6);
        void accept(RotateAt9 RotateAt9);
        void accept(RotateAt12 RotateAt12);
    }
}
