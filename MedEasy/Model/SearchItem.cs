using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Model
{
    public class SearchItem
    {
        [System.ComponentModel.DisplayName("ID")]
        public int ItemUid { get; set; }

        [System.ComponentModel.DisplayName("Item Name")]
        public string ItemBrandName { get; set; }
    }
}
