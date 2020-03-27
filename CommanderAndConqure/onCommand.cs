using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderAndConqure
{
    class onCommand : ICommand
    {
        private Power _power;
        public onCommand(Power pow)
        {
            _power = pow;
        }

        public void execute()
        {
            _power.on();
        }
    }
}
