using System;
using System.Collections.Generic;


namespace VendingApp
{
    public interface ICoin
    {
    }

    public class Coin: ICoin
    {
        public int Value { get; private set; }
        public static List<int> validCoinValues = new List<int> { 200, 100, 50, 20, 5, 2, 1 };

        public Coin(int value)
        {
            if (!validCoinValues.Contains(value)) {
                throw new ArgumentException("invalid coin denomination: " + value + " cannot be created");
            }
            Value = value;
        }

        public override string ToString()
        {
            string name;
            var worth = Value;

            if(worth >= 100)
            {
                worth = worth / 100;
                name = "pound";
            }
            else
            {
                name = "pence";
            }

            return worth + " " + name + " coin";
        }
    }
}
