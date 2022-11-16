using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {

        static void Main(string[] args)
        {
                             var Items = new List<BaseItem>
                                          {
                                              new DexterityVest {Name = "+5 Dexterity Vest", Sellin = 10, Quality = 20},
                                              new AgedBrie {Name = "Aged Brie", Sellin = 2, Quality = 0},
                                              new ElixerOfTheMongoose {Name = "Elixir of the Mongoose", Sellin = 5, Quality = 7},
                                              new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", Sellin = 0, Quality = 80},
                                              new BackStagePass
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      Sellin = 15,
                                                      Quality = 20
                                                  },
                                              //new BaseItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          

                          };

            foreach (BaseItem item in Items)
            {
                System.Console.WriteLine(
                    item.Name
                    + " / quality: "
                    + item.Quality
                     + " / sell in: "
                     + item.Sellin);
                item.UpdateItem();
            }

            foreach (BaseItem item in Items)
            {
                System.Console.WriteLine(
                    item.Name
                    + " / quality: "
                    + item.Quality
                     + " / sell in: "
                     + item.Sellin);
                item.UpdateItem();
            }
            System.Console.ReadKey();

        }

        

    }


}
