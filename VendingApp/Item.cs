namespace VendingApp
{
    public interface IItem
    {
    }

    public class Item : IItem
    {
        public int Cost { get; private set; }
        public string Name { get; private set; }

        public Item(int cost, string name)
        {
            Cost = cost;
            Name = name;
        }
    }
}
