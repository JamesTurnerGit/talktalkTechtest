namespace VendingApp
{
    public interface ICoin
    {
    }

    public class Coin: ICoin
    {
        public int Value { get; private set; }

        public Coin(int value)
        {
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
