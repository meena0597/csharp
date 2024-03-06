using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        public void foo()
        {
            IList<Item> Items = new List<Item> { ItemFactory.CreateItem("Aged Brie", 10, 10) };
            GildedRose app = new GildedRose(Items);
            app.UpdateProperties();
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(11, Items[0].Quality);
        }
    }
}
