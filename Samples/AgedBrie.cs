namespace csharp.Samples
{
    public class AgedBrie : IItem
    {
        public Item item { get; set; }
        public AgedBrie(Item _item)
        {
            item = _item;
        }

        public Item UpdateQuality()
        {
            item.Quality = item.Quality + 1;
            item = Helper.ValidateQuality(item);
            item = Helper.ValidateSellIn(item);
            return item;
        }
    }
}
