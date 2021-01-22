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
            lShape.findHighestCell();
            lShape.findLowestCell();
        }

        public void visit(ShapeT tShape)
        {
            tShape.draw()[0].Y -= 2;
            tShape.draw()[1].X++;
            tShape.draw()[1].Y--;
            tShape.draw()[3].X+=2;
            tShape.setPos(12);
            tShape.findLowestCell();
            tShape.findHighestCell();
        }

        public void visit(ShapeO sShape)
        {
            //not needed
        }

        public void visit(ShapeZ zShape)
        {
            zShape.draw()[0].X -= 2;
            zShape.draw()[1].X--;
            zShape.draw()[1].Y++;
            zShape.draw()[3].X++;
            zShape.draw()[3].Y++;
            zShape.setPos(12);
            zShape.findLowestCell();
            zShape.findHighestCell();
        }

        public void visit(ShapeI iShape)
        {
            iShape.draw()[1].X++;
            iShape.draw()[1].Y--;
            iShape.draw()[2].X += 2;
            iShape.draw()[2].Y -= 2;
            iShape.draw()[3].X += 3;
            iShape.draw()[3].Y -= 3;
            iShape.setPos(12);
            iShape.findHighestCell();
            iShape.findLowestCell();
        }
    }
}
