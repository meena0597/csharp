using csharp.Models;

namespace csharp
{
    public class ItemFactory
    {
        public static Item CreateItem(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Aged Brie":
                    return new AgedBrie(name, sellIn, quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePasses(name, sellIn, quality);
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(name, sellIn, quality);
                case "Conjured Mana Cake":
                    return new Conjured(name, sellIn, quality);
                default:
                    return new StandardItem(name, sellIn, quality);
            }
        }
    }
}
