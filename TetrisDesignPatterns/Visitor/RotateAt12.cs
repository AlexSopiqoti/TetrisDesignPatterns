using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Abstract_Factory;

namespace TetrisDesignPatterns.Visitor
{
    public class RotateAt12 : IMovement
    {
        public void visit(ShapeL lShape)
        {            
            lShape.draw()[1].X++;
            lShape.draw()[1].Y--;
            lShape.draw()[2].X += 2;
            lShape.draw()[2].Y -= 2;
            lShape.draw()[3].X++;
            lShape.draw()[3].Y++;
            lShape.setPos(12);
        }

        public void visit(ShapeT tShape)
        {
            tShape.draw()[1].X++;
            tShape.draw()[1].Y--;
            tShape.draw()[2].X++;
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
