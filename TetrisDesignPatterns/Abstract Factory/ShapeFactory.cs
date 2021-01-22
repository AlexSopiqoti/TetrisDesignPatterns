using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public class ShapeFactory : IAbstractFactory
    {
        public IShape getShape(int shapeType)
        {
            if (shapeType.Equals(1))
            {
                return new ShapeL();
            }
            else if (shapeType.Equals(2))
            {
                return new ShapeT();
            }
            else if (shapeType.Equals(3))
            {
                return new ShapeO();
            }
            else if (shapeType.Equals(4))
            {
                return new ShapeI();
            }
            else if (shapeType.Equals(5))
            {
                return new ShapeZ();
            }

            return null; 
        }
    }
}

