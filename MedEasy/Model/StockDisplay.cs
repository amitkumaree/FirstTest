﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.Model
{
    public sealed class StockDisplay
    {
        [System.ComponentModel.DisplayName("ID")]
        [System.ComponentModel.Browsable(false)]
        public int ItemUid { get; set; }

        [System.ComponentModel.DisplayName("ITEM NAME")]
        public string ItemBrandName { get; set; }

        [System.ComponentModel.DisplayName("BATCH")]
        public string Batch { get; set; }

        [System.ComponentModel.DisplayName("EXPIRY DATE")]
        public DateTime ExpiryDt { get; set; }

        [System.ComponentModel.DisplayName("QUANTITY")]
        public int Quantity { get; set; }

        //[System.ComponentModel.DisplayName("Unit")]
        //public string Unit { get; set; }

        //[System.ComponentModel.DisplayName("Rate")]
        //public string Rate { get; set; }

        //[System.ComponentModel.DisplayName("Amount")]
        //public decimal Amount { get; set; }

        [System.ComponentModel.DisplayName("MRP")]
        public decimal MRP { get; set; }

        //[System.ComponentModel.DisplayName("TAX%")]
        //public decimal Tax { get; set; }

        //[System.ComponentModel.DisplayName("S.Rate")]
        //public decimal SRate { get; set; }


    }
}
