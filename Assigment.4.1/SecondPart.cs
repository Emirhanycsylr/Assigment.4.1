using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment._4._1
{
    class SecondPart
    {
        static public void Gamemenu()
        {
            Console.WriteLine("WELCOME TO TIC TAC TOE GAMEEE!!! ");
            Console.WriteLine("PRESS ANY KEY TO ACCESS MENU");
            Console.WriteLine("1. Start a new game ");
            Console.WriteLine("2. Author ");
            Console.WriteLine("3. Exit ");
        }

        static public int whoWon(char[] part)
        {
            if (part[1] == part[2] && part[2] == part[3])
            {
                return 1;
            }

            else if (part[4] == part[5] && part[5] == part[6])
            {
                return 1;
            }
            else if (part[6] == part[7] && part[7] == part[8])
            {
                return 1;
            }


            else if (part[1] == part[4] && part[4] == part[7])
            {
                return 1;
            }


            else if (part[2] == part[5] && part[5] == part[8])
            {
                return 1;
            }


            else if (part[3] == part[6] && part[6] == part[9])
            {
                return 1;
            }


            else if (part[1] == part[5] && part[5] == part[9])
            {
                return 1;
            }


            else if (part[3] == part[5] && part[5] == part[7])
            {
                return 1;
            }

            else if (part[1] != '1' && part[2] != '2' && part[3] != '3' && part[4] != '4' && part[5] != '5' && part[6] != '6' && part[7] != '7' && part[8] != '8' && part[9] != '9')
            {
                return -1;

            }
            else
            {
                return 0;
            }
        }
        static public void gameBoard(char[] part)
        {


            Console.WriteLine(" {0} | {1} | {2} ", part[1], part[2], part[3]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", part[4], part[5], part[6]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", part[7], part[8], part[9]);
        }
    }
}
