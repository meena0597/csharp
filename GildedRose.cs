using csharp.Samples;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<IItem> Items;
        public GildedRose(IList<IItem> Items)
        {
            this.Items = Items;
        }

        public IList<Item> UpdateProperties()
        {
            IList<Item> datas=new List<Item>();
            foreach (var item in Items)
            {
                var data=item.UpdateQuality();
                datas.Add(data);
            }
            return datas;
        }
    }
    
}
