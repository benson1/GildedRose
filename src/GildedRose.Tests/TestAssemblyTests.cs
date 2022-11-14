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
            //test.Should().Be("");
        }
    }
}