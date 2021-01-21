using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public abstract class AbstractFactory
    {
        public abstract Shape getShape(int shapeType);
    }
}
