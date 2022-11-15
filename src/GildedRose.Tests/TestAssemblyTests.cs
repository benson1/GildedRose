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

        [Test]
        public void WhenRegularItemUpdate_LowerSellinAndQuality()
        {
            BaseItem item = new DexterityVest() { Sellin = 10,Quality = 20 };
            item.UpdateItem();
            Assert.AreEqual(9, item.Sellin);
            Assert.AreEqual(19, item.Quality);
        }
        [Test]
        public void WhenRegularItemUpdate_ExpiredSellinQualityDecreasesTwiceAsFast()
        {
            BaseItem item = new DexterityVest() { Sellin = 0, Quality = 19 };
            item.UpdateItem();
            Assert.AreEqual(17, item.Quality);
        }
        [Test]
        public void WhenRegularItemUpdate_QualityNeverNegative()
        {
            BaseItem item = new DexterityVest() { Sellin = 10, Quality = 0 };
            item.UpdateItem();
            Assert.AreEqual(0, item.Quality);
        }

        [Test]
        public void WhenAgedBreeQualityIncreases()
        {
            BaseItem item = new AgedBrie() { Sellin = 15, Quality = 0 };
            item.UpdateItem();
            Assert.AreEqual(14, item.Sellin);
            Assert.AreEqual(1, item.Quality);
        }

        [Test]
        public void WhenAgedBreeQualityNeverExceeds50()
        {
            BaseItem item = new AgedBrie() { Sellin = 15, Quality = 50 };
            item.UpdateItem();
            Assert.AreEqual(50, item.Quality);
        }
        [Test]
        public void WhenSulfurasQualityNeverDecreases()
        {
            BaseItem item = new Sulfuras() { Sellin = 15, Quality = 80 };
            item.UpdateItem();
            Assert.AreEqual(80, item.Quality);
        }
        [Test]
        public void WhenSulfurasSellinNeverDecreases()
        {
            BaseItem item = new Sulfuras() { Sellin = 15, Quality = 80 };
            item.UpdateItem();
            Assert.AreEqual(15, item.Sellin);
        }
        [Test]
        public void WhenBackstagePassQualityIncreases()
        {
            BaseItem item = new BackStagePass() { Sellin = 15, Quality = 30 };
            item.UpdateItem();
            Assert.AreEqual(31, item.Quality);
        }
        [Test]
        public void WhenBackstagePass10DaysRemainQualityIncreasesby2()
        {
            BaseItem item = new BackStagePass() { Sellin = 10, Quality = 30 };
            item.UpdateItem();
            Assert.AreEqual(32, item.Quality);
        }
        [Test]
        public void WhenBackstagePass5DaysRemainQualityIncreasesby3()
        {
            BaseItem item = new BackStagePass() { Sellin = 5, Quality = 30 };
            item.UpdateItem();
            Assert.AreEqual(33, item.Quality);
        }
        [Test]
        public void WhenBackstageExpiredDaysQualityDropsTo0()
        {
            BaseItem item = new BackStagePass() { Sellin = 0, Quality = 30 };
            item.UpdateItem();
            Assert.AreEqual(0, item.Quality);
        }
    }
}