using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Abstract_Factory;

namespace TetrisDesignPatterns.Visitor
{
    public class MoveLeft : IMovement
    {
        public void visit(ShapeL lShape)
        {
            moveLeft(lShape);
        }

        public void visit(ShapeT tShape)
        {
            moveLeft(tShape);
        }

        public void visit(ShapeO sShape)
        {
            moveLeft(sShape);
        }

        public void visit(ShapeZ zShape)
        {
            moveLeft(zShape);
        }

        public void visit(ShapeI iShape)
        {
            moveLeft(iShape);
        }

        public void moveLeft(IShape shape)
        {
            foreach (Cell cell in shape.draw())
            {
                cell.X--;
            }
        }
    }
}
