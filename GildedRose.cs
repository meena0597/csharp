﻿using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateProperties()
        {
            foreach (var item in Items)
            {
                item.UpdateSellIn();
                item.UpdateQuality();
            }
        }
    }
    
}
