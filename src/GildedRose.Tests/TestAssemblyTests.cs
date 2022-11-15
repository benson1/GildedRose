using FluentAssertions;
using GildedRose.Console;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace GildedRose.Tests
{
    [TestFixture]
    public class TestAssemblyTests
    {
        private Item CreateItemAndUpdate(string Name, int SellIn,int Quality)
        {
            IList<Item> items = new List<Item>{
                new Item{Name = Name,SellIn =SellIn,Quality = Quality}
            };
            GildedRoseLogic app = new GildedRoseLogic() { Items = items };
            app.UpdateQuality();
            return items[0];

        }

        [Test]
        public void WhenRegularItemUpdate_LowerSellinAndQuality()
        {
            Item item = CreateItemAndUpdate("item",10,19 );
            Assert.AreEqual(9, item.SellIn);
            Assert.AreEqual(18, item.Quality);
        }
        [Test]
        public void WhenRegularItemUpdate_ExpiredSellinQualityDecreasesTwiceAsFast()
        {
            Item item = CreateItemAndUpdate("item", 0, 19);
            Assert.AreEqual(-1, item.SellIn);
            Assert.AreEqual(17, item.Quality);
        }
        [Test]
        public void WhenRegularItemUpdate_QualityNeverNegative()
        {
            Item item = CreateItemAndUpdate("item", 15, 0);
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void WhenAgedBreeQualityIncreases()
        {
            Item item = CreateItemAndUpdate(GildedRoseLogic.AGED_BRIE, 15, 0);
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void WhenAgedBreeQualityNeverExceeds50()
        {
            Item item = CreateItemAndUpdate(GildedRoseLogic.AGED_BRIE, 15, 50);
            Assert.AreEqual(50, item.Quality);
        }
        [Test]
        public void WhenSulfurasQualityNeverDecreases()
        {
            Item item = CreateItemAndUpdate("Sulfuras, Hand of Ragnaros", 15, 80);
            Assert.AreEqual(80, item.Quality);
        }
        [Test]
        public void WhenSulfurasSellinNeverDecreases()
        {
            Item item = CreateItemAndUpdate("Sulfuras, Hand of Ragnaros", 15, 80);
            Assert.AreEqual(15, item.SellIn);
        }
        [Test]
        public void WhenBackstagePassQualityIncreases()
        {
            Item item = CreateItemAndUpdate("Backstage passes to a TAFKAL80ETC concert", 15, 30);
            Assert.AreEqual(31, item.Quality);
        }
        [Test]
        public void WhenBackstagePass10DaysRemainQualityIncreasesby2()
        {
            Item item = CreateItemAndUpdate("Backstage passes to a TAFKAL80ETC concert", 10, 30);
            Assert.AreEqual(32, item.Quality);
        }
        [Test]
        public void WhenBackstagePass10DaysRemainQualityIncreasesby3()
        {
            Item item = CreateItemAndUpdate("Backstage passes to a TAFKAL80ETC concert", 5, 30);
            Assert.AreEqual(33, item.Quality);
        }
        [Test]
        public void WhenBackstageExpiredDaysQualityDropsTo0()
        {
            Item item = CreateItemAndUpdate("Backstage passes to a TAFKAL80ETC concert", 0, 30);
            Assert.AreEqual(0, item.Quality);
        }
    }
}