using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Strategy
{
    public class Context
    {
        IChoice choice;
        /*
         * It's our choice. We prefer to use a setter method instead of using a constructor. We can call this method whenever we want to change the "choice behaviour" on the fly.
         */
        public void SetChoice(IChoice choice)
        {
            this.choice = choice;
        }
    }
}
