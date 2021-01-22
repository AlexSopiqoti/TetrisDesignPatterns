using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisDesignPatterns.State
{
    public class GameStopped : IGameState
    {
        public void doAction(Context context, Timer timer, Label label)
        {            
            context.setState(this);
            timer.Enabled = false;
            label.Text = "Game Status: \n Game Stopped. \n Please press Start or Reset!";
        }
    }
}
