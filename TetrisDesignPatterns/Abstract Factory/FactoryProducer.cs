using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public class FactoryProducer
    {
        public static IAbstractFactory getFactory()
        {
            return new ShapeFactory();
        }
    }
}
