namespace csharp.Models
{
    public class Sulfuras : Item
    {
        public Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateSellIn()
        {
            // The SellIn property of Sulfuras will never change.
        }
        public override void UpdateQuality()
        {
            // The Quality property of Sulfuras will never change.
        }

    }
}
