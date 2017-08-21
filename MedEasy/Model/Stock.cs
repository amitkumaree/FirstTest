using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Model
{
    class Stock
    {
        public int StockUid { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public string PurchaseVoucherNo { get; set; }

        public string VendorName { get; set; }

        public decimal? GrossPrice { get; set; }

        public decimal? DiscountPer { get; set; }

        public decimal? DiscountPrice { get; set; }

        public decimal? TaxPer { get; set; }

        public int? ItemCount { get; set; }

        public string PayType { get; set; }

        public decimal? NetPrice { get; set; }

        public string Rmks { get; set; }

        public string OrglUser { get; set; }

        public DateTime? OrglStamp { get; set; }

        public string UpdtUser { get; set; }

        public DateTime? UpdtStamp { get; set; }
    }
}
