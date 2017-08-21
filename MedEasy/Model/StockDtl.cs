using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Model
{
    class StockDtl
    {
        public int StockDtlUid { get; set; }

        public int? StockUid { get; set; }

        public int? ItemUid { get; set; }

        public string BatchNo { get; set; }

        public DateTime? ManufacturerDt { get; set; }

        public DateTime? ExpDt { get; set; }

        public decimal? PerUnitRate { get; set; }

        public string PurchaseUnit { get; set; }

        public int? PurchaseQty { get; set; }

        public decimal? Mrp { get; set; }

        public decimal? GrossPrice { get; set; }

        public decimal? TaxPer { get; set; }

        public decimal? DiscountAmt { get; set; }

        public decimal? NetPrice { get; set; }

        public string OrglUser { get; set; }

        public DateTime? OrglStamp { get; set; }

        public string UpdtUser { get; set; }

        public DateTime? UpdtStamp { get; set; }
    }
}
