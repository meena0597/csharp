namespace csharp.Models
{
    public static class Helper
    {
        public static Item ValidateQuality(Item item)
        {
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            else if (item.Quality > 50)
            {
                item.Quality = 50;
            }
            return item;
        }
        public static Item ValidateSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
            return item;
        }
    }
}
