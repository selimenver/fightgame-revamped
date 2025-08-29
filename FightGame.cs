using System;
using System.ComponentModel.Design;


namespace Program
{
    class FightGame
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int bothp = 100;
            int playerhp = 100;

            while (true)
            {
                Console.WriteLine($"Bot hp: {bothp}");
                Console.WriteLine($"Your hp: {playerhp}");
                Console.WriteLine("Type 1 to attack");
                Console.WriteLine("Type 2 to defend");
                Console.WriteLine("type 3 to flee");

                string answer = Console.ReadLine();

                if (answer == "1")
                {

                    Console.Clear();
                    int playerdmg = 0;
                    playerdmg = rng.Next(1, 21);
                    bothp -= playerdmg;
                    Console.WriteLine($"You dealt {playerdmg} dmg.");

                    int botdmg = 0;
                    botdmg = rng.Next(1, 21);
                    playerhp -= botdmg;
                    Console.WriteLine($"Bot dealt {botdmg} dmg.");

                    if (bothp <= 0)
                    {
                        Console.WriteLine("Congrats, you won!");
                        break;
                    }
                    else if (playerhp <= 0)
                    {
                        Console.WriteLine("You lost. Better luck next time.");
                        break;
                    }
                }
                else if (answer == "3")
                {
                    Console.Clear();
                    Console.WriteLine("You fleed like a coward.");
                    break;
                }
                else if (answer == "2")
                {
                    Console.Clear();
                    int urdefense;
                    urdefense = rng.Next(1, 101);

                    if (urdefense < 70)
                    {
                        Console.WriteLine("You defended.");
                    }
                    else if (urdefense == 70)
                    {
                        Console.WriteLine("Wow, you got the rare easter egg that has 1 percent chance of showing up. You dodged everything!");
                    }
                    else
                    {
                        int botdmg = 0;
                        botdmg = rng.Next(1, 21);
                        playerhp -= botdmg;
                        Console.WriteLine($"Bot still hit you, you took {botdmg} dmg.");

                    }
                    if (bothp <= 0)
                    {
                        Console.WriteLine("Congrats, you won!");
                        break;
                    }
                    else if (playerhp <= 0)
                    {
                        Console.WriteLine("You lost. Better luck next time.");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("enter a valid choice.");
                }
                
            }
        }
    }
}