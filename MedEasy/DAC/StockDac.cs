using MedEasy.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.DAC
{
    internal sealed class StockDac
    {
        public void SaveStock(SaveStock saveStock)
        {
            using (var connetion = MedEasyConnection.NewConnection)
            {
                using (var command = (SqlCommand)MedEasyConnection.Command(connetion,"ME_OWN.Stock_Entry"))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@purchaseDt", saveStock.StockHeader.PurchaseDate));
                    command.Parameters.Add(new SqlParameter("@voucherNo", saveStock.StockHeader.PurchaseVoucherNo));
                    command.Parameters.Add(new SqlParameter("@vendorName", saveStock.StockHeader.VendorName));
                    command.Parameters.Add(new SqlParameter("@grossPrice", saveStock.StockHeader.GrossPrice));
                    command.Parameters.Add(new SqlParameter("@disCountPer", saveStock.StockHeader.DiscountPer));
                    command.Parameters.Add(new SqlParameter("@disCountPrice", saveStock.StockHeader.DiscountPrice));
                    command.Parameters.Add(new SqlParameter("@taxPer", saveStock.StockHeader.TaxPer));
                    command.Parameters.Add(new SqlParameter("@itemCount", saveStock.StockHeader.ItemCount));
                    command.Parameters.Add(new SqlParameter("@payType", saveStock.StockHeader.PayType));
                    command.Parameters.Add(new SqlParameter("@netPrice", saveStock.StockHeader.NetPrice));
                    command.Parameters.Add(new SqlParameter("@rmrks", saveStock.StockHeader.Rmks));
                    command.Parameters.Add(new SqlParameter("@itemUid", saveStock.StockDtl.ItemUid));
                    command.Parameters.Add(new SqlParameter("@batchNo", saveStock.StockDtl.BatchNo));
                    command.Parameters.Add(new SqlParameter("@manuFactureDt", saveStock.StockDtl.ManufacturerDt));
                    command.Parameters.Add(new SqlParameter("@expiryDt", saveStock.StockDtl.ExpDt));
                    command.Parameters.Add(new SqlParameter("@itemPerUnitRt", saveStock.StockDtl.PerUnitRate));
                    command.Parameters.Add(new SqlParameter("@itemMrp", saveStock.StockDtl.Mrp));
                    command.Parameters.Add(new SqlParameter("@ItemgrossPrice", saveStock.StockDtl.GrossPrice));
                    command.Parameters.Add(new SqlParameter("@itemTaxPer", saveStock.StockDtl.TaxPer));
                    command.Parameters.Add(new SqlParameter("@itemDiscountAmt", saveStock.StockDtl.DiscountAmt));
                    command.Parameters.Add(new SqlParameter("@itemNetPrice", saveStock.StockDtl.NetPrice));
                    command.Parameters.Add(new SqlParameter("@itemPurchaseUnit", saveStock.StockDtl.PurchaseUnit));
                    command.Parameters.Add(new SqlParameter("@itemPurchaseQnt", saveStock.StockDtl.PurchaseQty));
                   

                    command.ExecuteNonQuery();                    
                }
            }
        }

        public List<StockDisplay> GetStockDtl()
        {
            var stockDtls = new List<StockDisplay>();
            using (var connetion = MedEasyConnection.NewConnection)
            {
                using (var command = MedEasyConnection.Command(connetion, MedEasySQLCommands.GetStockDtl))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var stockDtl = new StockDisplay();


                                stockDtl.ItemUid = CheckNull<int>(reader[itemConst.ItemUid]);
                                stockDtl.ItemBrandName = CheckNull<string>(reader[itemConst.ItemBrandName]);
                                stockDtl.Batch = CheckNull<string>(reader["BATCH_NO"]);
                                stockDtl.ExpiryDt = CheckNull<DateTime>(reader["EXP_DT"]);
                                stockDtl.Quantity = CheckNull<int>(reader["PURCHASE_QTY"]);
                                stockDtl.MRP = CheckNull<decimal>(reader["MRP"]);

                                //OrglUser = CheckNull<string>(reader[itemConst.OrglUser]);
                                //OrglStamp = CheckNull<DateTime?>(reader[itemConst.OrglStamp]);
                                //UpdtUser = CheckNull<string>(reader[itemConst.UpdtUser]);
                                //UpdtStamp = CheckNull<DateTime?>(reader[itemConst.UpdtStamp]);
                                stockDtls.Add(stockDtl);


                            }
                        }
                        //foreach (var item in reader.Read(ItemReader)) { Items.Add(item); }
                    }
                }
            }
            return stockDtls;
        }

        public T CheckNull<T>(object obj)
        {
            return (obj == DBNull.Value ? default(T) : (T)obj);
        }
    }
}
