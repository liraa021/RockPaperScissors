using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperRockScissors
{
    class Program
    {
        public class UIManager
        {
            public void uimanager(string message)
            {
                Console.Write(message);
            }
        }


        public class Randomico
        {
            private Random randomic;

            public Randomico()
            {
                randomic = new Random();
            }

            public int GeraRandomic(int minValue, int maxValue)
            {
                return randomic.Next(minValue, maxValue);
            }
        }

        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;
            UIManager uimanager = new UIManager();
            Randomico randomic = new Randomico();
           

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    uimanager.uimanager("Choose between Rock, PAPER and SCISSORS:             ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    randomInt = randomic.GeraRandomic(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }

                Console.WriteLine("Do you want to play again ?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }

    }
}