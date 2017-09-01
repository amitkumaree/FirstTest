using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Model
{
    public sealed class Item
    {        
        [System.ComponentModel.DisplayName("ID")]
        public int ItemUid { get; set; }

        [System.ComponentModel.DisplayName("Item Name")]
        public string ItemBrandName { get; set; }

        public string ItemId { get; set; }


        public string ItemPower { get; set; }

        public string DelFlg { get; set; }

        public int? FormTypUid { get; set; }

        public int? ManufacturersUid { get; set; }

        public int? CategoryUid { get; set; }

        public string UnitMesure { get; set; }

        public int? Unit { get; set; }

        public int? NoOfUnit { get; set; }

        public decimal? PerUnitRate { get; set; }

        public decimal? Mrp { get; set; }

        public string MedType { get; set; }

        public string Schedule { get; set; }

        public string HsnNo { get; set; }

        public int? RecordedQty { get; set; }

        public int? BookedQty { get; set; }

        public decimal? ProfitMargin { get; set; }

        public decimal? Cgst { get; set; }

        public decimal? Igst { get; set; }

        public decimal? Tax { get; set; }

        public decimal? Discount1 { get; set; }

        public decimal? Discount2 { get; set; }

        public decimal? Discount3 { get; set; }

        public string StoreRackNo { get; set; }

        public string StoreBoxNo { get; set; }

        public int? DemandGenLimit { get; set; }

        public string OrglUser { get; set; }

        public DateTime? OrglStamp { get; set; }

        public string UpdtUser { get; set; }

        public DateTime? UpdtStamp { get; set; }

    }
    

}
