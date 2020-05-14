using System;

namespace CommanderAndConqure
{
    public class Power
    {
        enum state
        {
            off,
            on
        };

        private state powerState;
        public void on()
        {
            if (powerState != state.on)
            {
                Console.WriteLine("Power is on");
                powerState = state.on;

            }
            else
            {
                Console.WriteLine("Power is already on");
            }

        }

        public void off()
        {
            if (powerState != state.off)
            {
                Console.WriteLine("power is off");
                powerState = state.off;
            }
            else
            {
                Console.WriteLine("Power is already off");
            }
        }
    }
}