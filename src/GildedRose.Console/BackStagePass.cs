using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class BackStagePass : BaseItem
    {
        public BackStagePass()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert";
            Sellin = 10;
            Quality = 15;
            }


        public override void UpdateItem()
        {
            Sellin -=1 ;
            Quality = Sellin > 0 ? QualityCalculate(Quality, Sellin) : 0;
        }

        private int QualityCalculate(int quality,int sellin)
        {
            if (sellin >10) { return quality += 1; };
            if (sellin > 5) { return quality += 2; };
            if (sellin > 0) { return quality += 3; };

            return quality;
        }
    }
    }

