using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingApp
{
    internal class ConsoleView
    {
        private readonly IConsoleWrapper _consoleWrapper;
        

        public ConsoleView(IConsoleWrapper consoleWrapper)
        {
            _consoleWrapper = consoleWrapper;
        }

        public void StartConsoleView()
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
                _consoleWrapper.WriteLine("the display shows " + vendingMachine.ActiveMoney + " pence");
                userInput = _consoleWrapper.ReadLine();
                switch (userInput)
                {
                    case "1":
                        TryToBuy(vendingMachine, crisps);
                        break;
                    case "2":
                        TryToBuy(vendingMachine, water);
                        break;
                    case "3":
                        vendingMachine.InsertCoin(fiftyPence);
                        _consoleWrapper.WriteLine("you put in 50p");
                        break;
                    case "4":
                        ToStringCoins(vendingMachine.CoinReturn());
                        break;
                    case "q":
                        _consoleWrapper.WriteLine("goodBye");
                        Environment.Exit(0);
                        break;
                    default:
                        _consoleWrapper.WriteLine("invalid option.");
                        DisplayMenu(vendingMachine);
                        break;
                }
            }
        }

        public void ToStringCoins(List<Coin> coins)
        {
            if (coins.Count == 0)
            {
                _consoleWrapper.WriteLine("no coins were returned");
                return;
            }
            _consoleWrapper.WriteLine("the machine spits out the following:");
            foreach (Coin coin in coins)
            {
                _consoleWrapper.WriteLine(coin.ToString());
            }
            _consoleWrapper.WriteLine("that's it!");
        }

        public void DisplayMenu(VendingMachine vendingMachine)
        {

            _consoleWrapper.WriteLine("you see a vending machine, it has 4 points of interaction");

            var crisps = vendingMachine.Stock.First(i => i.Name.Contains("Crisps"));
            var water = vendingMachine.Stock.First(i => i.Name.Contains("Water"));

            _consoleWrapper.WriteLine("1. Buy " + crisps);
            _consoleWrapper.WriteLine("2. Buy " + water);


            _consoleWrapper.WriteLine("3. Insert a 50p Coin");
            _consoleWrapper.WriteLine("4. Press Coin Return");
            _consoleWrapper.WriteLine("to use it type 1-4 on your keyboard and press return or press Q to quit");
        }

        public void TryToBuy(VendingMachine vm, Item item)
        {
            if (vm.TryPurchase(item))
            {
                _consoleWrapper.WriteLine("you successfully buy the" + item.Name);
            }
            else
            {
                _consoleWrapper.WriteLine("the" + item.Name + "didn't come out, did you put in enough money?");
            }
        }
    }
}