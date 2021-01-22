using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisDesignPatterns.State
{
    public class GameStarted : IGameState
    {
        public void doAction(Context context, Timer timer, Label label)
        {            
            context.setState(this);
            timer.Enabled = true;
            label.Text = "Game Status: \n Game Started. \n You can Pause now or reset!";
        }
    }
}
