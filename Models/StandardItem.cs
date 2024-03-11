namespace csharp.Models
{
    public class StandardItem : IItem
    {
        public Item item { get; set; }
        public StandardItem(Item _item)
        {
            item = _item;
        }
        public Item UpdateQuality()
        {
            item = Helper.ValidateSellIn(item);
            if (item.SellIn >= 0)
            {
                item.Quality = item.Quality - 1;
            }
            else
            {
                item.Quality = item.Quality - 2;
            }
            item = Helper.ValidateQuality(item);
            return item;
        }
    }
}
