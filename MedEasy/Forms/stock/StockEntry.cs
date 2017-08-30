using MedEasy.Bussiness;
using MedEasy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedEasy.Forms.stock
{
    public partial class StockEntry : Form
    {
        List<Item> _items = new List<Item>();
        Item _currentChoosenITem = new Item();

        public StockEntry()
        {
            InitializeComponent();

            //pnl_stockOpeningStock.Location = new Point(50, this.ClientSize.Height / 2 - 
            //pnl_stockOpeningStock.Size.Height / 2);
            //pnl_stockOpeningStock.Anchor = AnchorStyles.Left;
            //pnl_stockOpeningStock.Visible = true;

            //pnl_viewItemGrid.Location = new Point(this.ClientSize.Width - pnl_viewItemGrid.Size.Width - 5, 25);
            //pnl_viewItemGrid.Size = new Size(pnl_viewItemGrid.Size.Width, this.ClientSize.Height);
            //pnl_viewItemGrid.Anchor = AnchorStyles.Right;
            //pnl_viewItemGrid.Visible = true;

            //var itemSearcLst = new ItemBuss().GetSearchItem();
            //dataGrid_Item.DataSource = itemSearcLst;
            _items = new ItemBuss().Items;
            dataGridView_ShowStock.DataSource = new ItemBuss().GetStocks();
            dataGridView_ShowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            //AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //foreach (var item in _items)
            //    //MyCollection.Add(item.ItemBrandName);
            //    MyCollection.Add(item.ItemUid.ToString() + " " + item.ItemBrandName + " " + item.MedType);

            //txt_Name_StockEntry.AutoCompleteCustomSource = MyCollection;


            txt_search_Item.Text = "Search Medicine....";

            txt_search_Item.GotFocus += RemoveText;
            txt_search_Item.LostFocus += AddText;
        }

        //private void dataGrid_Item_SelectionChanged(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow row in dataGrid_Item.SelectedRows)
        //    {
        //        txt_ItemId_StockEntry.Text = row.Cells[0].Value.ToString();
        //        txt_Name_StockEntry.Text = row.Cells[1].Value.ToString();                
        //        //...
        //    }
        //}



        //private void RefreshGrid()
        //{
        //    txt_Name_StockEntry.Text = txtVieItemSearch.Text = txt_Name_StockEntry.Text = txt_ItemId_StockEntry.Text = string.Empty;

        //    foreach (DataGridViewRow row in dataGrid_Item.Rows)
        //    {
        //        row.DefaultCellStyle.BackColor = Color.White;
        //    }
        //}

        //private void txtVieItemSearch_TextChanged(object sender, EventArgs e)
        //{
        //    var filteredSearchLst = new List<SearchItem>();
        //    var itemSearcLst = new ItemBuss().GetSearchItem();

        //    if (string.IsNullOrEmpty(txtVieItemSearch.Text))
        //    {
        //        dataGrid_Item.DataSource = itemSearcLst;
        //        RefreshGrid();
        //        return;
        //    }

        //    // copy the item search text to stock entry search text
        //    txt_Name_StockEntry.Text = txtVieItemSearch.Text;

        //    //// Code to search the  alphanumneric Part Number (in Column1 header called "PART NUMBER") and highlihgt the row
        //    //foreach (DataGridViewRow row in dataGrid_Item.Rows)
        //    //{
        //    //    //var cellValue = row.Cells["ItemBrandName"].Value;
        //    //    if (txtVieItemSearch.Text.Length < 3 && row.Cells["ItemBrandName"].Value.ToString().
        //ToLower().Contains(txtVieItemSearch.Text.ToLower()))
        //    //    {
        //    //        row.DefaultCellStyle.BackColor = Color.Yellow;
        //    //    }
        //    //    else if (row.Cells["ItemBrandName"].Value.ToString().ToLower().Equals(txtVieItemSearch.Text.ToLower()))
        //    //        row.DefaultCellStyle.BackColor = Color.Yellow;

        //    //}

        //    if (txtVieItemSearch.Text.Length < 3)
        //        filteredSearchLst = itemSearcLst.Where(item => item.ItemBrandName.ToLower().
        //Contains(txtVieItemSearch.Text.ToLower())).ToList();
        //    else
        //        filteredSearchLst = itemSearcLst.Where(item => item.ItemBrandName.ToLower().
        //Equals(txtVieItemSearch.Text.ToLower())).ToList();
        //}

        //private void txt_Name_StockEntry_TextChanged(object sender, EventArgs e)
        //{


        //    // if the text box has no text then refresh the grid
        //    if (string.IsNullOrEmpty(txt_Name_StockEntry.Text) || txt_Name_StockEntry.Text.Length < 2)
        //    {
        //        //dataGrid_Item.DataSource = itemSearcLst;
        //        //RefreshGrid();
        //        return;
        //    }
        //    try
        //    {
        //        var filteredItems = _items.Where(item => item.ItemBrandName.ToLower().
        //Contains(txt_Name_StockEntry.Text.ToLower())).ToList();
        //        //var itemSearcLst = new ItemBuss().GetSearchItem();
        //        // copy the item search text to stock entry search text
        //        //txtVieItemSearch.Text = txt_Name_StockEntry.Text;

        //        //if (txt_Name_StockEntry.Text.Length < 3)            
        //        //    filteredSearchLst = itemSearcLst.Where(item => item.ItemBrandName.ToLower().
        //Contains(txt_Name_StockEntry.Text.ToLower())).ToList();            
        //        //else
        //        //    filteredSearchLst = itemSearcLst.Where(item => item.ItemBrandName.ToLower().
        //Equals(txt_Name_StockEntry.Text.ToLower())).ToList();

        //        var MyCollection = new AutoCompleteStringCollection();

        //        foreach (var item in filteredItems)
        //            MyCollection.Add(item.ItemBrandName);
        //        //MyCollection.Add(item.ItemUid.ToString() + " " + item.ItemBrandName + " " + item.MedType);
        //        //MyCollection.Add(item.ItemBrandName);

        //        txt_Name_StockEntry.AutoCompleteCustomSource = MyCollection;

        //        // If filtered search result is 1 then copy the content to stock form
        //        if (filteredItems.Count == 1)
        //        {
        //            //txt_Name_StockEntry.Text = filteredSearchLst[0].ItemBrandName;
        //            txt_ItemId_StockEntry.Text = filteredItems[0].ItemUid.ToString();
        //        }

        //        //dataGrid_Item.DataSource = filteredSearchLst;
        //    }
        //    catch (Exception ex)
        //    { }

        //}

        #region Events for place holder in the search box
        public void RemoveText(object sender, EventArgs e)
        {
            if (txt_search_Item.Text.Equals("Search Medicine...."))
                txt_search_Item.Text = "";
        }
        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_search_Item.Text))
                txt_search_Item.Text = "Search Medicine....";
        }
        #endregion

        private void txt_search_Item_TextChanged(object sender, EventArgs e)
        {

            // if the text box has no text then refresh the grid
            if (string.IsNullOrEmpty(txt_search_Item.Text) 
                || txt_search_Item.Text.Length < 3
                || txt_search_Item.Text.Equals("Search Medicine...."))
            {
                if (combo_searchResult.Visible)
                {
                    combo_searchResult.DroppedDown = false;
                    combo_searchResult.DataSource = null;
                    combo_searchResult.Visible = false;
                }
                else
                    txt_search_Item.Focus();
                return;
            }

            try
            {
                // filter the list of item with the text.
                var filteredItems = _items.Where(item => item.ItemBrandName.ToLower().Contains
                                    (txt_search_Item.Text.ToLower())).ToList();

                //var MyCollection = new AutoCompleteStringCollection();

                //foreach (var item in filteredItems)
                //    MyCollection.Add(item.ItemBrandName);
                //MyCollection.Add(item.ItemUid.ToString() + " " + item.ItemBrandName + " " + item.MedType);

                if (filteredItems.Count > 0)
                {
                    combo_searchResult.Visible = true;
                    combo_searchResult.DataSource = filteredItems.Select(item => new KeyValuePair<int, string>
                                                    (item.ItemUid, item.ItemBrandName)).ToList();
                    combo_searchResult.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                    combo_searchResult.DisplayMember = "Value";

                }
                else
                {
                    MessageBox.Show("Medecine doesnt Exist!! Add in item and then enter Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // If filtered search result is 1 then copy the content to stock form
                //if (filteredItems.Count == 1)
                //{
                //    //txt_Name_StockEntry.Text = filteredSearchLst[0].ItemBrandName;
                //    txt_ItemId_StockEntry.Text = filteredItems[0].ItemUid.ToString();
                //}

                //dataGrid_Item.DataSource = filteredSearchLst;
            }
            catch (Exception ex)
            { }
        }

        private void combo_searchResult_DropDownClosed(object sender, EventArgs e)
        {
            // Close search Drop Down list
            combo_searchResult.DroppedDown = false;

            ComboBox cmb = (ComboBox)sender;
            if (null == cmb.SelectedValue)
                return;
            int selectedKey = ((System.Collections.Generic.KeyValuePair<int, string>)
                              (((System.Windows.Forms.ListControl)(cmb)).SelectedValue)).Key;
            string selectedValue = ((System.Collections.Generic.KeyValuePair<int, string>)
                              (((System.Windows.Forms.ListControl)(cmb)).SelectedValue)).Value;
            txt_search_Item.Text = selectedValue;

            // filter the item that was selected
            var item = _items.Where(it => it.ItemUid == selectedKey).First();
            if (null != item)
            {
                // Set the current choosen item as this item
                _currentChoosenITem = item;
                // Fill the item text box with the value collected
                //txt_ItemId_StockEntry.Text = item.ItemUid.ToString();
                txt_Name_StockEntry.Text = item.ItemBrandName;
                txt_Price_bf_tax.Text = item.Mrp.ToString();
               
                txt_Tax_StockEntry.Text = item.Tax.ToString();
                txt_Rate_StockEntry.Text = item.PerUnitRate.ToString();
                txt_IGST.Text = item.Igst.ToString();
                txt_CSGT.Text = item.Cgst.ToString();
                txt_Unit_StockEntry.Text = "1";
                txt_No_of_Unit_in_Item.Text = item.NoOfUnit.Value.ToString();
                txt_Tax_StockEntry.Text = (item.Igst + item.Cgst).ToString();
                txt_MRP_StockEntry.Text = GetMRP(item);

                txt_Remarks_StockEntry.Focus();
            }
        }

        private string GetMRP(Item item)
        {
            var MRP = item.Mrp + (item.Mrp * item.Igst / 100) + (item.Mrp * item.Igst / 100);
            return MRP.Value.ToString("#.00");
        }

        private void txt_Unit_StockEntry_LostFocus(object sender, EventArgs e)
        {
            GetAmount();
        }

        private void GetAmount()
        {
            if (string.IsNullOrEmpty(txt_Unit_StockEntry.Text) ||
                string.IsNullOrEmpty(txt_MRP_StockEntry.Text))
                return;

            int unit = Convert.ToInt32(txt_Unit_StockEntry.Text);
            decimal mrp = Convert.ToDecimal(txt_MRP_StockEntry.Text);

            txt_Price_bf_tax.Text = (unit * mrp).ToString();
        }

        private void btn_Save_StockEntry_Click(object sender, EventArgs e)
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(txt_Name_StockEntry.Text))
                error += "Choose Item (Medicine) to add in Stock\n";
            if (string.IsNullOrEmpty(txt_Batch_StockEntry.Text))
                error += "Enter Batch\n";
            if (string.IsNullOrEmpty(txt_Unit_StockEntry.Text))
                error += "Enter Unit bought \n";
            if (string.IsNullOrEmpty(txt_PurchaseVoucherNo.Text))
                error += "Enter Purchase Voucher No \n";
            if (string.IsNullOrEmpty(txt_VendorName.Text))
                error += "Enter Vendor Name \n";

            if (!string.IsNullOrEmpty(error))
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //var gross = string.IsNullOrEmpty(txt_Price_bf_tax.Text) ? 0 : Convert.ToDecimal(txt_Price_bf_tax.Text);
                //var perUnitPrice = string.IsNullOrEmpty(txt_Rate_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_Rate_StockEntry.Text);
                //var UnitsInItem = gross/perUnitPrice;
                // collect data and save in stock hdr and stock dtl
                var saveStock = new SaveStock();
                saveStock.StockHeader = 
                    new Stock 
                    {
                        PurchaseDate = Convert.ToDateTime(dateTimePicker_Purchase_Dt.Value.ToShortDateString()),
                        PurchaseVoucherNo = txt_PurchaseVoucherNo.Text,
                        VendorName = txt_VendorName.Text,
                        GrossPrice = string.IsNullOrEmpty(txt_Price_bf_tax.Text) ? 0 : Convert.ToDecimal(txt_Price_bf_tax.Text),
                        DiscountPer = string.IsNullOrEmpty(txt_Discount_Percent.Text) ? 0 : Convert.ToDecimal(txt_Discount_Percent.Text),
                        DiscountPrice = string.IsNullOrEmpty(txt_discount_Amt.Text) ? 0 : Convert.ToDecimal(txt_discount_Amt.Text),
                        TaxPer = string.IsNullOrEmpty(txt_Tax_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_Tax_StockEntry.Text),
                        ItemCount = 1,
                        PayType = combo_payMode.SelectedText,
                        NetPrice = string.IsNullOrEmpty(txt_NetTotal_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_NetTotal_StockEntry.Text),
                        Rmks = txt_Remarks_StockEntry.Text,
                    };
                saveStock.StockDtl = 
                    new StockDtl 
                    {
                        ItemUid = _currentChoosenITem.ItemUid,
                        BatchNo = txt_Batch_StockEntry.Text,
                        ManufacturerDt = dateTimePicker_Manufacture.Value,
                        ExpDt = dateTimePicker_Expiry.Value,
                        PerUnitRate = string.IsNullOrEmpty(txt_Rate_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_Rate_StockEntry.Text),
                        Mrp = string.IsNullOrEmpty(txt_MRP_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_MRP_StockEntry.Text),
                        GrossPrice = string.IsNullOrEmpty(txt_Price_bf_tax.Text) ? 0 : Convert.ToDecimal(txt_Price_bf_tax.Text),
                        TaxPer = string.IsNullOrEmpty(txt_Tax_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_Tax_StockEntry.Text),
                        DiscountAmt = string.IsNullOrEmpty(txt_discount_Amt.Text) ? 0 : Convert.ToDecimal(txt_discount_Amt.Text),
                        NetPrice = string.IsNullOrEmpty(txt_NetTotal_StockEntry.Text) ? 0 : Convert.ToDecimal(txt_NetTotal_StockEntry.Text),
                        PurchaseQty = string.IsNullOrEmpty(txt_Quantity_StockEntry.Text) ? 0 : Convert.ToInt32(txt_Quantity_StockEntry.Text),
                        PurchaseUnit = _currentChoosenITem.NoOfUnit.Value.ToString() //! known issue
                    };

                new ItemBuss().SaveStock(saveStock);
                dataGridView_ShowStock.DataSource = new ItemBuss().GetStocks();
            }
        }

        private void txt_PurchaseVoucherNo_LostFocus(object sender, EventArgs e)
        {
            CheckMastDtlEntered();
        }
        private void txt_VendorName_LostFocus(object sender, EventArgs e)
        {
            CheckMastDtlEntered();
        }
        private void combo_payMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMastDtlEntered();
        }

        private void CheckMastDtlEntered()
        {
            if (!string.IsNullOrEmpty(txt_PurchaseVoucherNo.Text) && !string.IsNullOrEmpty(txt_VendorName.Text)
                && combo_payMode.SelectedItem != null)
            {
                pnlMain.Enabled = true;
                txt_search_Item.Focus();
                EnableDisableMaster(false);
            }
            else
                pnlMain.Enabled = false;

        }

        private void EnableDisableMaster(bool enable)
        {
            dateTimePicker_Purchase_Dt.Enabled = enable;
            txt_PurchaseVoucherNo.Enabled = enable;
            txt_VendorName.Enabled = enable;
            combo_payMode.Enabled = enable;
            if (enable)
            {
                txt_PurchaseVoucherNo.Clear();
                txt_VendorName.Clear();
                dateTimePicker_Purchase_Dt.Focus();
            }
        }

        private void txt_Discount_Percent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Discount_Percent.Text))
            {
                txt_discount_Amt.Clear();
                return;
            }

            var gross = Convert.ToDecimal(txt_Price_bf_tax.Text);
            var discountPercent = Convert.ToDecimal(txt_Discount_Percent.Text);

            txt_discount_Amt.Text = (gross * discountPercent / 100).ToString("0.##");
        }

        private void txt_Quantity_StockEntry_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Quantity_StockEntry.Text))
                return;

            var MRP = Convert.ToDecimal(txt_MRP_StockEntry.Text);
            var discountAmt = string.IsNullOrEmpty(txt_discount_Amt.Text) ? 0 : Convert.ToDecimal(txt_discount_Amt.Text);
            var quantity = Convert.ToInt32(txt_Quantity_StockEntry.Text);

            txt_NetTotal_StockEntry.Text = (quantity * (MRP - discountAmt)).ToString("0.##");            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            EnableDisableMaster(true);
            pnlMain.Enabled = false;
        }

       
        
        /*
        /////////////////////////////////////////////////////
        private bool _canUpdate = true; 

        private bool _needUpdate = false;
        Timer timer1 = new Timer();

        //If text has been changed then start timer
        //If the user doesn't change text while the timer runs then start search
        private void combobox1_TextChanged(object sender, EventArgs e)
        {
            if (_needUpdate)
            {
                if (_canUpdate)
                {
                    _canUpdate = false;
                    UpdateData();                   
                }
                else
                {
                    RestartTimer();
                }
            }
        }

        private void UpdateData()
        {
            if (combobox1.Text.Length > 1)
            {
                //List<string> searchData = Search.GetData(combobox1.Text);
                HandleTextChanged();
            }
        }       

        //If an item was selected don't start new search
        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _needUpdate = false;
        }

        //Update data only when the user (not program) change something
        private void combobox1_TextUpdate(object sender, EventArgs e)
        {
            _needUpdate = true;
        }

        //While timer is running don't start search
        //timer1.Interval = 1500;
        private void RestartTimer()
        {
            timer1.Stop();
            _canUpdate = false;
            timer1.Start();
        }

        //Update data when timer stops
        private void timer1_Tick(object sender, EventArgs e)
        {
            _canUpdate = true;
            timer1.Stop();
            UpdateData();
        }

        //Update combobox with new data
        private void HandleTextChanged()
        {
            var text = combobox1.Text;
            List<string> dataSource = _items.Where(item => item.ItemBrandName.ToLower().StartsWith(text.ToLower()))
                                            .Select(item => item.ItemBrandName + item.MedType).ToList();
            if (dataSource.Count() > 0)
            {
                combobox1.DataSource = dataSource;  

                var sText = combobox1.Items[0].ToString();
                combobox1.SelectionStart = text.Length;
                combobox1.SelectionLength = sText.Length - text.Length;
                combobox1.DroppedDown = true;


                return;
            }
            else
            {
                combobox1.DroppedDown = false;
                combobox1.SelectionStart = text.Length;
            }
        }
        */
    }
}
