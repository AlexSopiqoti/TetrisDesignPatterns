using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Abstract_Factory;

namespace TetrisDesignPatterns.Visitor
{
    public class RotateAt3 : IMovement
    {
        public void visit(ShapeL lShape)
        {
            lShape.draw()[0].Y += 2;
            lShape.draw()[2].X--;
            lShape.draw()[2].Y++;
            lShape.draw()[3].X--;
            lShape.draw()[3].Y++;
            lShape.setPos(3);
        }

        public void visit(ShapeT tShape)
        {
            tShape.draw()[0].Y++;
            tShape.draw()[2].X--;
            tShape.draw()[2].Y++;
            tShape.draw()[3].Y++;
        }

        public void visit(ShapeO sShape)
        {
            //not needed
        }

        public void visit(ShapeZ zShape)
        {
            
        }

        public void visit(ShapeI iShape)
        {
            
        }
    }
}
