using csharp.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        public class ItemTestCase
        {
            public string Name { get; set; }
            public int SellIn { get; set; }
            public int Quality { get; set; }
            public int ExpectedSellIn { get; set; }
            public int ExpectedQuality { get; set; }
        }

        [Test]
        [TestCaseSource(nameof(GetTestData))]
        public void GildedRoseFactoryTest(ItemTestCase testCase)
        {
            Item item = new Item { Name = testCase.Name, SellIn = testCase.SellIn, Quality = testCase.Quality };
            IList<IItem> items = new List<IItem> { ItemFactory.CreateItem(item) };
            GildedRose app = new GildedRose(items);
            var result = app.UpdateProperties();
            Assert.AreEqual(testCase.ExpectedSellIn, result[0].SellIn);
            Assert.AreEqual(testCase.ExpectedQuality, result[0].Quality);
        }

        private static IEnumerable<ItemTestCase> GetTestData()
        {
            return new List<ItemTestCase>
            {
            new ItemTestCase { Name = "Dexterity Vest", SellIn = 10, Quality = 20, ExpectedSellIn = 9, ExpectedQuality = 19 },
            new ItemTestCase { Name = "Aged Brie", SellIn = 2, Quality = 0, ExpectedSellIn = 1, ExpectedQuality = 1 },
            new ItemTestCase { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7, ExpectedSellIn = 4, ExpectedQuality = 6 },
            new ItemTestCase { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, ExpectedSellIn = 0, ExpectedQuality = 80 },
            new ItemTestCase { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20, ExpectedSellIn = 14, ExpectedQuality = 21 },
            new ItemTestCase { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, ExpectedSellIn = 2, ExpectedQuality = 4 }
            };
        }
    }
}
