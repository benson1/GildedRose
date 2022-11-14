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

            IList<Item> items = new List<Item>{ 
                new Item{Name = "+5 Dexterity Vest",SellIn = 10,Quality = 20}
            };
            Program app = new Program() { Items = items};
            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, 9);
            Assert.AreEqual(app.Items[0].Quality,19);
            //test.Should().Be("");
        }
        [Test]
        public void WhenRegularItemUpdate_ExpiredSellinQualityDecreasesTwiceAsFast()
        {

            IList<Item> items = new List<Item>{
                new Item{Name = "+5 Dexterity Vest",SellIn = 0, Quality = 20}
            };
            Program app = new Program() { Items = items };
            app.UpdateQuality();

            Assert.AreEqual(app.Items[0].SellIn, -1);
            Assert.AreEqual(app.Items[0].Quality, 18);
            //test.Should().Be("");
        }

    }
}