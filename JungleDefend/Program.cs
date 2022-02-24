using System;
using System.Threading;
namespace JungleDefend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Start()
            {
                Thread.Sleep(3000);
                Console.WriteLine("Here in each kilometer you will face a preditor, either tiger or bear or lion or snake or bat or hound");

                Thread.Sleep(1000);
                Console.WriteLine("And in each KM, you will be provided one to defend yourself, by gun or bow or sword");

                Thread.Sleep(3000);
                Console.WriteLine("But, you dont know who you will face in the next KM, you just have to predict and choose an armour");

                Thread.Sleep(2000);
                Console.WriteLine("You have to have GUN to defend HOUND/LION/TIGER, BOW for BAT/BEAR and SWORD FOR SNAKE");

                Console.Beep();
            }
            string name = "Jungle Defend";
            string version = "1.0.0";
            string author = "Al Yeasin";

           Console.ForegroundColor = ConsoleColor.Blue;
    
           Console.WriteLine("{0}: Version {1} by {2}", name,version,author);
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Console.WriteLine("..");
            Console.Beep();
            Console.WriteLine(" .");
            Console.WriteLine(". ..");
            Console.WriteLine(".  .");
            Thread.Sleep(1000);
            Console.Beep();
            Console.WriteLine(" .. .");
            Thread.Sleep(1000);
            Console.Beep();
            Console.WriteLine();
            Console.WriteLine("Please type your name");
            string username = Console.ReadLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Hello {0} to the Jungle, Can you defend?", username);
            Console.WriteLine("Type [Y or N]");
            int count = 0;
            int wasted = 0;
            int gain = 0;
            string entery = Console.ReadLine();
            if(entery.ToUpper() != "Y") { Console.WriteLine("Thank you, Have a nice day"); }
            else
            {
                while (true)
                {
                    string[] preds = { "TIGER", "BEAR", "LION", "SNAKE", "BAT", "HOUND" };
                    string[] defends = { "GUN", "BOW", "SWORD" };

                   if(count == 0)

                    {
                        Start();
                    }
                    count++;
                   
                    void Play()
                    {
                        count++;
                        Console.WriteLine("Pick Arms");
                        Random random = new Random();
                        int pred = random.Next(0, preds.Length);

                       
                        string defend = Console.ReadLine();

                        if (defend.ToUpper() == "GUN")
                        {
                            if (preds[pred].ToUpper() == "TIGER" || preds[pred].ToUpper() == "LION" || preds[pred].ToUpper() == "HOUND")
                            {
                                gain++;
                                Console.WriteLine("You killed the {0} with {1} : GAIN ++ {2}", preds[pred].ToUpper(), defend.ToUpper(), gain);
                                
                                Play();                            }
                            else wasted = 1;
                        }
                        else if (defend.ToUpper() == "BOW")
                        {
                            if (preds[pred].ToUpper() == "BAT" || preds[pred].ToUpper() == "BEAR" || preds[pred].ToUpper() != "TIGER" || preds[pred].ToUpper() != "LION" || preds[pred].ToUpper() != "HOUND" || preds[pred].ToUpper() != "SNAKE")
                            {
                                gain++;
                                Console.WriteLine("You killed the {0} with {1} : GAIN ++ {2}", preds[pred].ToUpper(), defend.ToUpper(), gain);
                                
                                Play();
                            }
                            else wasted = 1;

                        }
                        else if (defend.ToUpper() == "SWORD")
                        {
                            if (preds[pred].ToUpper() != "BAT" || preds[pred].ToUpper() != "BEAR" || preds[pred].ToUpper() != "TIGER" || preds[pred].ToUpper() != "LION" || preds[pred].ToUpper() != "HOUND" || preds[pred].ToUpper() == "SNAKE")
                            {
                                gain++;
                                Console.WriteLine("You killed the {0} with {1} - GAIN ++ {2}", preds[pred].ToUpper(), defend.ToUpper(), gain);
                                
                                Play();
                            }
                            else wasted = 1;

                        }
                        else if (wasted == 1)
                        {
                            {
                                gain = 0;
                                count = 1;
                                Console.WriteLine("!!! THERE WAS {0}, You failed to survive", preds[pred].ToUpper());
                                Thread.Sleep(1000);
                                Console.WriteLine("Wanna Play again? Type [Y or N]");
                                string again = Console.ReadLine();
                                if (again.ToUpper() == "N")
                                {
                                    return;
                                }
                                else if (again.ToUpper() == "Y")
                                {
                                    count = 1;

                                }
                            }
                        }
                    }
                    if (gain == 0)
                    {
                        Play();
                    }

                }
            };

            
        }
    }
}
