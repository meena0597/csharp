using csharp.Models;

namespace csharp
{
    public class ItemFactory
    {
        public static IItem CreateItem(Item item)
        {
            //Item item=new Item { Name=name,SellIn=sellIn,Quality=Quality};
            switch (item.Name)
            {
                case "Aged Brie":
                    return new AgedBrie(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePasses(item);
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(item);
                case "Conjured Mana Cake":
                    return new Conjured(item);
                default:
                    return new StandardItem(item);
            }
        }
    }
}
