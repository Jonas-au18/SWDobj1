using System;
using System.Security.Cryptography.X509Certificates;

namespace CommanderAndConqure
{
    public class CommandDemo
    {
        public void demo()
        {
            Switch mySwitch = new Switch();
            Power pow = new Power();

            bool done = false;
            do
            {
                Console.WriteLine(
                    "Select option:\n 1 for On \n 2 for off \n Q for terminate program\n");
                string function = Console.ReadLine();
                if (string.IsNullOrEmpty(function)) continue;

                switch (function[0])
                {
                    case '1':
                    {
                        mySwitch.setCommand(new onCommand(pow));
                        break;
                    }
                    case '2':
                    {
                        mySwitch.setCommand(new offCommand(pow));
                        break;
                    }
                    case 'Q':
                    case 'q':
                    {
                        done = true;
                        break;
                    }
                    default:
                        break;
                }
                mySwitch.switchFlipped();
            } while (!done);
        }
    }
}