namespace csharp.Samples
{
    public class Sulfuras : IItem
    {
        public Item item { get; set; }
        public Sulfuras(Item _item)
        {
            item = _item;
        }
        public Item UpdateSellIn()
        {
            // The SellIn property of Sulfuras will never change.
            return item;
        }
        public Item UpdateQuality()
        {
            // The Quality property of Sulfuras will never change.
            return item;
        }

    }
}
