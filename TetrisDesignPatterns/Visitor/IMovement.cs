using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisDesignPatterns.Abstract_Factory;

namespace TetrisDesignPatterns.Visitor
{
    public interface IMovement
    {
        void visit(ShapeL lShape);
        void visit(ShapeT tShape);
        void visit(ShapeO sShape);
        void visit(ShapeZ zShape);
        void visit(ShapeI iShape);
    }
}
