using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class Sulfuras : BaseItem
    {
        public Sulfuras()
            {
                Name = "Sulfuras, Hand of Ragnaros";
            }


        public override void UpdateItem()
        {
            Sellin =Sellin ;
            Quality = Quality;
        }
    }
    }

