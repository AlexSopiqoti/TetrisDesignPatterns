using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisDesignPatterns.State
{
    public interface IGameState
    {
         void doAction(Context context, Timer timer, Label label);
    }
}
