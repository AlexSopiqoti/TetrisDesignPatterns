using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisDesignPatterns.State
{
    public class GameReset : IGameState
    {
        public void doAction(Context context, Timer timer, Label label)
        {
            context.setState(this);
            label.Text = "Game Status: \n Game Resseted. \n Please press Start or Reset again!";
        }
    }
}
