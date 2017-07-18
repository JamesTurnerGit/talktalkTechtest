namespace VendingApp
{
    public class Item
    {
        public int Cost { get; private set; }
        public string Name { get; private set; }

        public Item(int cost, string name)
        {
            Cost = cost;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} ({Cost}p)";
        }
    }
}
