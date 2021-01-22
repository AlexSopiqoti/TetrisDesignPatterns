using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisDesignPatterns.State
{
    public class Context
    {
        private IGameState state;

        public Context()
        {
            state = null;
        }

        public void setState(IGameState state)
        {
            this.state = state;
        }

        public IGameState getState()
        {
            return state;
        }
    }
}
