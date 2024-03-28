using Dice_Game;

namespace Dice_Game__topic_5._5_assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bankAccount, playerBet;
            int diceTotal;
            string playerName, betOption;
            Die die1 = new Die();
            Die die2 = new Die();

            bankAccount = 100.00;

            Console.WriteLine("Welcome to DICERNG.");
            Thread.Sleep(1000);
            Console.WriteLine($"You currently have {bankAccount.ToString("C")} dollars.");
            Thread.Sleep(500);

            Console.WriteLine("What outcome do you want to bet on?");
            Console.WriteLine("Doubles?");
            Thread.Sleep(500);
            Console.WriteLine("Not double?");
            Thread.Sleep(500);
            Console.WriteLine("Even sum?");
            Thread.Sleep(500);
            Console.WriteLine("Or odd sum?");
            Console.WriteLine("Input either Double, NotDouble, Even or Odd.");
            betOption = Console.ReadLine();
            betOption = betOption.ToLower();
            Console.WriteLine("How much do you want to bet?");
            playerBet = Convert.ToDouble(Console.ReadLine());
            if (playerBet <= 0)
            {
                playerBet = 0;
            }
            else if (playerBet >= bankAccount)
            {
                playerBet = bankAccount;
            }
            if (betOption == "double")
            {
                Console.WriteLine("We'll roll two dice, and see if both of the numbers are the same.");
                Thread.Sleep(500);
                Console.WriteLine("If you win, you'll earn double the amount of what you bet. If you lose...well.");
                Thread.Sleep(500);
                Console.WriteLine("Now rolling...");
                Thread.Sleep(300);
                die1.RollDie();
                die2.RollDie();
                die1.DrawRoll();
                die2.DrawRoll();
                if (die1 == die2)
                {
                    bankAccount = bankAccount + (playerBet * 2);
                    Console.WriteLine("You win!");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Play again soon!");
                }
                else
                {
                    bankAccount = bankAccount - (playerBet * 2);
                    Console.WriteLine("You lost...");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Maybe next time.");
                }
            }
            else if (betOption == "notdouble")
            {
                Console.WriteLine("We'll roll two dice, and see if both of the numbers are different.");
                Thread.Sleep(500);
                Console.WriteLine("If you win, you'll earn half the amount of what you bet. If you lose...well.");
                Thread.Sleep(500);
                Console.WriteLine("Now rolling...");
                Thread.Sleep(300);
                die1.RollDie();
                die2.RollDie();
                die1.DrawRoll();
                die2.DrawRoll();
                if (die1 != die2)
                {
                    bankAccount = bankAccount + (playerBet / 2);
                    Console.WriteLine("You win!");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Play again soon!");
                }
                else
                {
                    bankAccount = bankAccount - (playerBet / 2);
                    Console.WriteLine("You lost...");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Maybe next time.");
                }
            }
            else if (betOption == "even")
            {
                Console.WriteLine("We'll roll two dice, and add the numbers together.");
                Console.WriteLine("If the sum is even, you'll win the amount you bet.");
                Thread.Sleep(500);
                Console.WriteLine("If the sum isn't, well...");
                Thread.Sleep(500);
                Console.WriteLine("Now Rolling...");
                Thread.Sleep(300);
                die1.RollDie();
                die2.RollDie();
                die1.DrawRoll();
                die2.DrawRoll();
                diceTotal = die1.roll + die2.roll;
                diceTotal = diceTotal % 2;
                if (diceTotal == 0)
                {
                    bankAccount = bankAccount + playerBet;
                    Console.WriteLine("The numbers add up to an even number. You win!");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Play again soon!");
                }
                else
                {
                    bankAccount = bankAccount - playerBet;
                    Console.WriteLine("The numbers add up to an odd number. You lost...");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Maybe next time.");
                }

            }
            else if (betOption == "odd")
            {
                Console.WriteLine("We'll roll two dice, and add the numbers together.");
                Console.WriteLine("If the sum is odd, you'll win the amount you bet.");
                Thread.Sleep(500);
                Console.WriteLine("If the sum isn't, well...");
                Thread.Sleep(500);
                Console.WriteLine("Now Rolling...");
                Thread.Sleep(300);
                die1.RollDie();
                die2.RollDie();
                die1.DrawRoll();
                die2.DrawRoll();
                diceTotal = die1.roll + die2.roll;
                diceTotal = diceTotal % 2;
                if (diceTotal == 1)
                {
                    bankAccount = bankAccount + playerBet;
                    Console.WriteLine("The numbers add up to an odd number. You win!");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Play again soon!");
                }
                else
                {
                    bankAccount = bankAccount - playerBet;
                    Console.WriteLine("The numbers add up to an even number. You lost...");
                    Console.WriteLine($"You now have {bankAccount.ToString("C")} dollars.");
                    Thread.Sleep(500);
                    Console.WriteLine("Maybe next time.");
                }
            }
            else
            {
                Console.WriteLine("ERROR: Invalid input.");
                Console.WriteLine("Please input either Double, NotDouble, Even or Odd.");
                Console.WriteLine("Reboot and try again.");
            }
        }
    }
}