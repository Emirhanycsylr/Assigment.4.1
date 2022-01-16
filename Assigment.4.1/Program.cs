using System;

namespace Assigment._4._1
{
    class Program
    {
        static char[] part = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int PrefersOnMenu;
        static int flag = 0;
        static int prefer;
        static void Main(string[] args)
        {
            while (true)
            {
                SecondPart.Gamemenu();

                PrefersOnMenu = Convert.ToChar(Console.ReadLine());
                switch (PrefersOnMenu)
                {
                    case '1':
                        Console.WriteLine("GAME BOARD");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to tic-tac-toe awesome gameeeee!");
                            Console.WriteLine("PLAYER 1 is X and PLAYER 2 is O \n");


                            if (player % 2 == 0)
                            {
                                Console.WriteLine("PLAYER 2's TURN");

                            }
                            else
                            {
                                Console.WriteLine("PLAYER 1's TURN");
                            }
                            Console.Write("\n");

                            SecondPart.gameBoard(part);

                            prefer = int.Parse(Console.ReadLine());


                            if (part[prefer] != 'X' && part[prefer] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    part[prefer] = 'O';

                                    player++;
                                }
                                else
                                {
                                    part[prefer] = 'X';
                                    player++;
                                }
                            }

                            else
                            {
                                Console.WriteLine("{0}.ROW already FILLED with {1} \n", prefer, part[prefer]);

                                Console.WriteLine("PLEASE WAIT ");


                            }
                            flag = SecondPart.whoWon(part);

                            Console.Clear();
                            SecondPart.gameBoard(part);

                            if (flag == 1)
                            {
                                Console.WriteLine("PLAYER {0} WON CONGRATS!! AWESOMEEEEE", (player % 2) + 1);
                            }
                            else
                            {
                                Console.WriteLine("DRAWWWW !");
                            }


                        } while (flag != 1 && flag != -1);
                        Console.WriteLine("press the key to get any menu!");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case '2':
                        Console.WriteLine("AUTHOR NAME İS EMİRHAN YÜCESOYLAR...");
                        Console.WriteLine("Press any key!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("do you want to quit are u sure ? (y/n)");
                        prefer = Convert.ToChar(Console.ReadLine());
                        switch (prefer)
                        {
                            case 'y':
                                Console.WriteLine("It was really good game Thank u ! ");
                                System.Environment.Exit(-1);
                                break;

                            case 'n':
                                Console.Clear();
                                break;

                        }
                        break;
                }
                Console.ReadLine();
            }
        }


      
    }
}

