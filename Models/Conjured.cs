namespace csharp.Models
{
    public class Conjured : Item
    {
        public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality = Quality - 2;
            }
            else
            {
                Quality = Quality - 1;
            }
            base.UpdateQuality();
        }
    }
}
