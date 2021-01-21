using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.State
{
    public class Context
    {
        private GameState state;

        public Context()
        {
            state = null;
        }

        public void setState(GameState state)
        {
            this.state = state;
        }

        public GameState getState()
        {
            return state;
        }
    }
}
