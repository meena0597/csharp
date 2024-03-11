namespace csharp.Models
{
    public class Conjured : IItem
    {
        public Item item { get; set; }
        public Conjured(Item _item)
        {
            item = _item;
        }
        public Item UpdateQuality()
        {
            item = Helper.ValidateSellIn(item);
            item.Quality -= 2;
            if (item.SellIn < 0)
            {
                item.Quality -= 2;
            }
            item = Helper.ValidateQuality(item);
            
            return item;
        }
    }
}
