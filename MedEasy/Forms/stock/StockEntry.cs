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
            if (string.IsNullOrEmpty(txt_search_Item.Text) || txt_search_Item.Text.Length < 3)
            {
                combo_searchResult.DroppedDown = false;
                combo_searchResult.DataSource = null;
                combo_searchResult.Visible = false;
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
            int selectedKey = ((System.Collections.Generic.KeyValuePair<int, string>)
                              (((System.Windows.Forms.ListControl)(cmb)).SelectedValue)).Key;
            string selectedValue = ((System.Collections.Generic.KeyValuePair<int, string>)
                              (((System.Windows.Forms.ListControl)(cmb)).SelectedValue)).Value;
            txt_search_Item.Text = selectedValue;

            // filter the item that was selected
            var item = _items.Where(it => it.ItemUid == selectedKey).First();
            if (null != item)
            {
                // Fill the item text box with the value collected
                txt_ItemId_StockEntry.Text = item.ItemUid.ToString();
                txt_Name_StockEntry.Text = item.ItemBrandName;
                txt_MRP_StockEntry.Text = item.Mrp.ToString();
                txt_Tax_StockEntry.Text = item.Tax.ToString();
                txt_Rate_StockEntry.Text = item.PerUnitRate.ToString();
                txt_IGST.Text = item.Igst.ToString();
                txt_CSGT.Text = item.Cgst.ToString();
                txt_Tax_StockEntry.Text = (item.Igst + item.Cgst).ToString();
            }
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

            txt_Amount_StockEntry.Text = (unit * mrp).ToString();
        }

        private void btn_Save_StockEntry_Click(object sender, EventArgs e)
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(txt_ItemId_StockEntry.Text))
                error += "Choose Item (Medicine) to add in Stock\n";
            if (string.IsNullOrEmpty(txt_Batch_StockEntry.Text))
                error += "Enter Batch\n";
            if (string.IsNullOrEmpty(txt_Unit_StockEntry.Text))
                error += "Enter Unit bought \n";
            if (string.IsNullOrEmpty(txt_PurchaseVoucherNo.Text))
                error += "Enter Purchase Voucher No \n";
            if (string.IsNullOrEmpty(txt_VendorName.Text))
                error += "Enter Vendor Name \n";
            
            if(!string.IsNullOrEmpty(error))
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
