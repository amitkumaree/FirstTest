using MedEasy.DAC;
using MedEasy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Bussiness
{
    internal sealed class ItemBuss
    {
        ItemDac _itemDac = new ItemDac();
        List<Item> _items = null;

        public List<Item> Items
        {
            get{
                if (null == _items)
                    _items = _itemDac.GetItems();
                return _items;
            }            
        }

        public List<SearchItem> GetSearchItem()
        {
            return Items.Select(itm => new SearchItem { ItemUid = itm.ItemUid, ItemBrandName = itm.ItemBrandName }).ToList();
        }

        public void SaveStock(SaveStock saveStock)
        {
            new StockDac().SaveStock(saveStock);
        }

        public List<StockDisplay> GetStocks()
        {
            return new StockDac().GetStockDtl();
        }
    }
}
 