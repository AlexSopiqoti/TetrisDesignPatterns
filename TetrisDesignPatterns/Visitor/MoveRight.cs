using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Abstract_Factory;

namespace TetrisDesignPatterns.Visitor
{
    public class MoveRight : IMovement
    {
        public void visit(ShapeL lShape)
        {
            moveRight(lShape);
        }

        public void visit(ShapeT tShape)
        {
            moveRight(tShape);
        }

        public void visit(ShapeO sShape)
        {
            moveRight(sShape);
        }

        public void visit(ShapeZ zShape)
        {
            moveRight(zShape);
        }

        public void visit(ShapeI iShape)
        {
            moveRight(iShape);
        }

        public void moveRight(IShape shape)
        {
            foreach(Cell cell in shape.draw())
            {
                cell.X++;
            }
        }
    }
}
