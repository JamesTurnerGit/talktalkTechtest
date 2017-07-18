using System;
using System.Collections.Generic;

namespace VendingApp
{
    public interface ICoin
    {
        int Value { get; }
        string ToString();
    }

    /// <summary>
    /// coin implemntation designed to be configurable
    /// </summary>
    public class Coin: ICoin
    {
        public int Value { get; private set; }
        public static List<int> ValidCoinValues = new List<int> { 200, 100, 50, 20, 10, 5, 2, 1 };
        public const string bigUnit = "pound";
        public const string smallUnit = "pence";
 
        public Coin(int value)
        {
            if (!ValidCoinValues.Contains(value)) {
                throw new ArgumentException("invalid coin denomination: " + value + " cannot be created");
            }
            Value = value;
        }

        public override string ToString()
        {
            string name;
            int worth = Value;

            if(worth >= 100)
            {
                worth = worth / 100;
                name = bigUnit;
            }
            else
            {
                name = smallUnit;
            }

            return worth + " " + name + " coin";
        }
    }
}
