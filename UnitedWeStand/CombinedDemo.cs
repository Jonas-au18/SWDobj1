using System;
using System.Linq.Expressions;

namespace UnitedWeStand
{
    public class CombinedDemo
    {
        public void demo()
        {
            Calculator myCalc = new Calculator();
            Value myVal = new Value();

            string function = "";

            Console.WriteLine("Fancy calculator");
            Console.WriteLine("Input first value");
            try
            {
                myVal.value_ = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                goto Quit;
            }


            bool finish = false;
            do
            {
                Console.WriteLine("Select option:\n + for add \n - for subtract \n * for multipy \n / for divide \n ^ for pow \n R for rollback \n C for clear \n Q for exit");
                function = "";
                function = Console.ReadLine();
                if (string.IsNullOrEmpty(function)) continue;

                switch (function[0])
                {
                    case 'Q':
                    case 'q':
                        myCalc.setCommand(new quit());
                        finish = true;
                        break;

                    case '+':
                        {
                            myCalc.setCommand(new Adding(myVal));
                            break;
                        }


                    case '-':
                        {
                            myCalc.setCommand(new Subtract(myVal));
                            break;
                        }

                    case '*':
                        {
                            myCalc.setCommand(new multipy(myVal));
                            break;
                        }

                    case '/':
                        {
                            myCalc.setCommand(new divide(myVal));
                            break;
                        }

                    case '^':
                        {
                            myCalc.setCommand(new Power(myVal));
                            break;
                        }

                    case 'C':
                    case 'c':
                        {
                            myCalc.setCommand(new Clear(myVal));
                            break;
                        }
                    case 'R':
                    case 'r':
                        {
                            myCalc.setCommand(new rollBack(myVal));
                            break;
                        }

                    default:
                        break;
                }
                myCalc.onCall();
                Console.WriteLine("\n" + myVal.value_ + "\n");
            } while (!finish);
            Quit: finish = true;
        }
        
    }
}