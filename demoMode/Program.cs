using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommanderAndConqure;
using MementoMori;
using UnitedWeStand;

namespace demoMode
{
    class Program
    {
        static void Main(string[] args)
        {
            CombinedDemo combined = new CombinedDemo();
            MementoDemo memento = new MementoDemo();
            CommandDemo command = new CommandDemo();
            
            bool done = false;
            do
            {
                Console.WriteLine(
                    "Select option:\n 1 for Memento demo \n 2 for Command demo \n 3 for Combined demo \n Q for terminate program\n");
                string function = Console.ReadLine();
                if (string.IsNullOrEmpty(function)) continue;

                switch (function[0])
                {
                    case '1':
                    {
                        memento.demo();
                        break;
                    }
                    case '2':
                    {
                        command.demo();
                        break;
                    }
                    case '3':
                    {
                        combined.demo();
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

            } while (!done);
        }
    }
}
