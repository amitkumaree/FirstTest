using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Model
{
    internal sealed class SaveStock
    {
        public Stock StockHeader { get; set; }
        public StockDtl StockDtl { get; set; }
    }
}
