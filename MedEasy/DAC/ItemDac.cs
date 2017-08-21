using MedEasy.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.DAC
{
    public sealed class ItemDac
    {
        public List<Item> GetItems()
        {
            var Items = new List<Item>();

            using (var connetion = MedEasyConnection.NewConnection)
            {
                using (var command = MedEasyConnection.Command(connetion, MedEasySQLCommands.GetItem))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            { 
                                var item = new Item ();
                                
                                
                                    item.ItemUid = CheckNull<int>(reader[itemConst.ItemUid]);
                                    item.ItemId = CheckNull<string>(reader[itemConst.ItemId]);
                                    item.ItemBrandName = CheckNull<string>(reader[itemConst.ItemBrandName]);
                                    item.ItemPower = CheckNull<string>(reader[itemConst.ItemPower]);
                                    item.FormTypUid = CheckNull<int?>(reader[itemConst.FormTypUid]);
                                    item.ManufacturersUid = CheckNull<int?>(reader[itemConst.ManufacturersUid]);
                                    item.PackSize = CheckNull<string>(reader[itemConst.PackSize]);
                                    item.PurchaseUnit = CheckNull<string>(reader[itemConst.PurchaseUnit]);
                                    item.SaleUnit = CheckNull<string>(reader[itemConst.SaleUnit]);
                                    item.NoOfUnit = CheckNull<int?>(reader[itemConst.NoOfUnit]);
                                    item.PerUnitRate = CheckNull<decimal?>(reader[itemConst.PerUnitRate]);
                                    item.Mrp = CheckNull<decimal?>(reader[itemConst.Mrp]);
                                    item.MedType = CheckNull<string>(reader[itemConst.MedType]);
                                    item.Schedule = CheckNull<string>(reader[itemConst.Schedule]);
                                    item.RecordedQty = CheckNull<int?>(reader[itemConst.RecordedQty]);
                                    item.ProfitMergine = CheckNull<decimal?>(reader[itemConst.ProfitMergine]);
                                    item.Cgst = CheckNull<decimal?>(reader[itemConst.Cgst]);
                                    item.Igst = CheckNull<decimal?>(reader[itemConst.Igst]);
                                    item.Tax = CheckNull<decimal?>(reader[itemConst.Tax]);
                                    item.Discount1 = CheckNull<decimal?>(reader[itemConst.Discount1]);
                                    item.Discount2 = CheckNull<decimal?>(reader[itemConst.Discount2]);
                                    item.Discount3 = CheckNull<decimal?>(reader[itemConst.Discount3]);
                                    item.StoreRackNo = CheckNull<string>(reader[itemConst.StoreRackNo]);
                                    item.StoreBoxNo = CheckNull<string>(reader[itemConst.StoreBoxNo]);
                                    item.DemandGenLimit = CheckNull<int?>(reader[itemConst.DemandGenLimit]);
                                    //OrglUser = CheckNull<string>(reader[itemConst.OrglUser]);
                                    //OrglStamp = CheckNull<DateTime?>(reader[itemConst.OrglStamp]);
                                    //UpdtUser = CheckNull<string>(reader[itemConst.UpdtUser]);
                                    //UpdtStamp = CheckNull<DateTime?>(reader[itemConst.UpdtStamp]);
                                    Items.Add(item);

                               
                            }
                        }
                        //foreach (var item in reader.Read(ItemReader)) { Items.Add(item); }
                    }
                }
            }

            return Items;
        }

        public T CheckNull<T>(object obj)
        {
            return (obj == DBNull.Value ? default(T) : (T)obj);
        }
    }
    public sealed class itemConst
    {
        internal const string ItemUid = "ITEM_UID";
        internal const string ItemId = "ITEM_ID";
        internal const string ItemBrandName = "ITEM_BRAND_NAME";
        internal const string ItemPower = "ITEM_POWER";
        internal const string FormTypUid = "FORM_TYP_UID";
        internal const string ManufacturersUid = "MANUFACTURERS_UID";
        internal const string PackSize = "PACK_SIZE";
        internal const string PurchaseUnit = "PURCHASE_UNIT";
        internal const string SaleUnit = "SALE_UNIT";
        internal const string NoOfUnit = "NO_OF_UNIT";
        internal const string PerUnitRate = "PER_UNIT_RATE";
        internal const string Mrp = "MRP";
        internal const string MedType = "MED_TYPE";
        internal const string Schedule = "SCHEDULE";
        internal const string RecordedQty = "RECORDED_QTY";
        internal const string ProfitMergine = "PROFIT_MERGINE";
        internal const string Cgst = "CGST";
        internal const string Igst = "IGST";
        internal const string Tax = "TAX";
        internal const string Discount1 = "DISCOUNT1";
        internal const string Discount2 = "DISCOUNT2";
        internal const string Discount3 = "DISCOUNT3";
        internal const string StoreRackNo = "STORE_RACK_NO";
        internal const string StoreBoxNo = "STORE_BOX_NO";
        internal const string DemandGenLimit = "DEMAND_GEN_LIMIT";
        internal const string OrglUser = "ORGL_USER";
        internal const string OrglStamp = "ORGL_STAMP";
        internal const string UpdtUser = "UPDT_USER";
        internal const string UpdtStamp = "UPDT_STAMP";

    }
}
