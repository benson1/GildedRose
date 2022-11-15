﻿using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new GildedRoseLogic()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };

            for (int i = 0; i < app.Items.Count; i++)
            {
                System.Console.WriteLine(
                    app.Items[i].Name
                    + " / quality: "
                    + app.Items[i].Quality
                     + " / sell in: "
                     + app.Items[i].SellIn);
            }
            app.Items = app.UpdateQuality();

            for (int i = 0; i < app.Items.Count; i++)
            {
                System.Console.WriteLine(
                    app.Items[i].Name
                    + " / quality: "
                    + app.Items[i].Quality
                     + " / sell in: "
                     + app.Items[i].SellIn);
            }
            //System.Console.WriteLine(app.items);
            System.Console.ReadKey();

        }

        

    }


}
