using MedEasy.DAC;
using MedEasy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Bussiness
{
    public sealed class ItemBuss
    {
        ItemDac _dac = new ItemDac();
        List<Item> _items = null;

        public List<Item> Items
        {
            get{
                if (null == _items)
                    _items = _dac.GetItems();
                return _items;
            }            
        }

        public List<SearchItem> GetSearchItem()
        {
            return Items.Select(itm => new SearchItem { ItemUid = itm.ItemUid, ItemBrandName = itm.ItemBrandName }).ToList();
        }
    }
}
 