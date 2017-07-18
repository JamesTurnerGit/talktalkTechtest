using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    /// <summary>
    /// Very rough and ready way to interact with the model for testing and demonstration.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            Item crisps = new Item(40, "Packet of Crisps");
            Item water = new Item(60, "Bottled Water");
            Coin fiftyPence = new Coin(50);
            string userInput;

            vendingMachine.AddStock(crisps);
            vendingMachine.AddStock(water);

            DisplayMenu(vendingMachine);

            while (true)
            {
                Console.WriteLine ("the display shows " + vendingMachine.ActiveMoney + " pence");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Program.TryToBuy(vendingMachine, crisps);
                        break;
                    case "2":
                        Program.TryToBuy(vendingMachine, water);
                        break;
                    case "3":
                        vendingMachine.InsertCoin(fiftyPence);
                        Console.WriteLine("you put in 50p");
                        break;
                    case "4":
                        ToStringCoins(vendingMachine.CoinReturn());
                        break;
                    case "q":
                        Console.WriteLine("goodBye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid option.");
                        DisplayMenu(vendingMachine);
                        break;
                }

            }
        }

        public static void ToStringCoins(List<Coin> coins)
        {
            if(coins.Count == 0)
            {
                Console.WriteLine("no coins were returned");
                return;
            }
            Console.WriteLine("the machine spits out the following:");
            foreach(Coin coin in coins)
            {
                Console.WriteLine(coin.ToString());
            }
            Console.WriteLine("that's it!");
        }

        public static void DisplayMenu(VendingMachine vendingMachine)
        {

            Console.WriteLine("you see a vending machine, it has 4 points of interaction");

            var crisps = vendingMachine.Stock.First(i => i.Name.Contains("Crisps"));
            var water = vendingMachine.Stock.First(i => i.Name.Contains("Water"));

            Console.WriteLine("1. Buy {0}", crisps);
            Console.WriteLine("2. Buy {0}", water);


            Console.WriteLine("3. Insert a 50p Coin");
            Console.WriteLine("4. Press Coin Return");
            Console.WriteLine("to use it type 1-4 on your keyboard and press return or press Q to quit");
        }

        public static void TryToBuy(VendingMachine vm, Item item)
        {
            if (vm.TryPurchase(item))
            {
                Console.WriteLine("you successfully buy the" + item.Name);
            }
            else
            {
                Console.WriteLine("the" + item.Name + "didn't come out, did you put in enough money?");
            }
        }
    }
}
