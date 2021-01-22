using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.Abstract_Factory
{
    public interface IAbstractFactory
    {
        IShape getShape(int shapeType);
    }
}
