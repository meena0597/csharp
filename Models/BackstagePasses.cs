namespace csharp.Models
{
    public class BackstagePasses : IItem
    {
        public Item item { get; set; }
        public BackstagePasses(Item _item)
        {
            item = _item;
        }
        public Item UpdateQuality()
        {
            item = Helper.ValidateSellIn(item);
            if (item.SellIn==10)
            {
                item.SellIn = 10;
            }
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality = item.Quality + 2;
            }
            else
            {
                item.Quality = item.Quality + 1;
            }
            item = Helper.ValidateQuality(item);
            return item;
        }
    }
}
