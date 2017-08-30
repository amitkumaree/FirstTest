namespace MedEasy.Forms.stock
{
    partial class StockEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockEntry));
            this.combo_payMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_VendorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PurchaseVoucherNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Purchase_Dt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_hr_belowHdr = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txt_search_Item = new System.Windows.Forms.TextBox();
            this.combo_searchResult = new System.Windows.Forms.ComboBox();
            this.pnl_stockOpeningStock = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_discount_Amt = new System.Windows.Forms.TextBox();
            this.txt_Discount_Percent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_No_of_Unit_in_Item = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Manufacture = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CSGT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IGST = new System.Windows.Forms.TextBox();
            this.btn_Del_StockEntry = new System.Windows.Forms.Button();
            this.btn_Save_StockEntry = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_Remarks_StockEntry = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_NetTotal_StockEntry = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_MRP_StockEntry = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_Tax_StockEntry = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_Price_bf_tax = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_Rate_StockEntry = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_Unit_StockEntry = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_Quantity_StockEntry = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Expiry = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_Batch_StockEntry = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_Name_StockEntry = new System.Windows.Forms.TextBox();
            this.dataGridView_ShowStock = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnl_stockOpeningStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowStock)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_payMode
            // 
            this.combo_payMode.FormattingEnabled = true;
            this.combo_payMode.Items.AddRange(new object[] {
            "Cash",
            "Cheque"});
            this.combo_payMode.Location = new System.Drawing.Point(757, 34);
            this.combo_payMode.Name = "combo_payMode";
            this.combo_payMode.Size = new System.Drawing.Size(122, 21);
            this.combo_payMode.TabIndex = 4;
            this.combo_payMode.SelectedIndexChanged += new System.EventHandler(this.combo_payMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(753, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 82;
            this.label6.Text = "Pay Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(619, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 80;
            this.label5.Text = "Vendor Name";
            // 
            // txt_VendorName
            // 
            this.txt_VendorName.Location = new System.Drawing.Point(623, 34);
            this.txt_VendorName.Name = "txt_VendorName";
            this.txt_VendorName.Size = new System.Drawing.Size(128, 21);
            this.txt_VendorName.TabIndex = 3;
            this.txt_VendorName.LostFocus += new System.EventHandler(this.txt_VendorName_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(369, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "Purchase Voucher No";
            // 
            // txt_PurchaseVoucherNo
            // 
            this.txt_PurchaseVoucherNo.Location = new System.Drawing.Point(373, 34);
            this.txt_PurchaseVoucherNo.Name = "txt_PurchaseVoucherNo";
            this.txt_PurchaseVoucherNo.Size = new System.Drawing.Size(244, 21);
            this.txt_PurchaseVoucherNo.TabIndex = 2;
            this.txt_PurchaseVoucherNo.LostFocus += new System.EventHandler(this.txt_PurchaseVoucherNo_LostFocus);
            // 
            // dateTimePicker_Purchase_Dt
            // 
            this.dateTimePicker_Purchase_Dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Purchase_Dt.Location = new System.Drawing.Point(282, 34);
            this.dateTimePicker_Purchase_Dt.Name = "dateTimePicker_Purchase_Dt";
            this.dateTimePicker_Purchase_Dt.Size = new System.Drawing.Size(85, 21);
            this.dateTimePicker_Purchase_Dt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(278, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Purchase Dt";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_header.Location = new System.Drawing.Point(72, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(210, 49);
            this.lbl_header.TabIndex = 47;
            this.lbl_header.Text = "Stock Entry";
            // 
            // lbl_hr_belowHdr
            // 
            this.lbl_hr_belowHdr.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_hr_belowHdr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hr_belowHdr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_hr_belowHdr.Location = new System.Drawing.Point(81, 55);
            this.lbl_hr_belowHdr.Name = "lbl_hr_belowHdr";
            this.lbl_hr_belowHdr.Size = new System.Drawing.Size(840, 3);
            this.lbl_hr_belowHdr.TabIndex = 48;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.txt_search_Item);
            this.pnlMain.Controls.Add(this.combo_searchResult);
            this.pnlMain.Controls.Add(this.pnl_stockOpeningStock);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(81, 61);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(839, 237);
            this.pnlMain.TabIndex = 84;
            // 
            // txt_search_Item
            // 
            this.txt_search_Item.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_Item.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_search_Item.Location = new System.Drawing.Point(21, 8);
            this.txt_search_Item.Name = "txt_search_Item";
            this.txt_search_Item.Size = new System.Drawing.Size(800, 40);
            this.txt_search_Item.TabIndex = 52;
            this.txt_search_Item.TextChanged += new System.EventHandler(this.txt_search_Item_TextChanged);
            // 
            // combo_searchResult
            // 
            this.combo_searchResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.combo_searchResult.FormattingEnabled = true;
            this.combo_searchResult.Location = new System.Drawing.Point(21, 47);
            this.combo_searchResult.Name = "combo_searchResult";
            this.combo_searchResult.Size = new System.Drawing.Size(800, 21);
            this.combo_searchResult.TabIndex = 51;
            this.combo_searchResult.Visible = false;
            this.combo_searchResult.DropDownClosed += new System.EventHandler(this.combo_searchResult_DropDownClosed);
            // 
            // pnl_stockOpeningStock
            // 
            this.pnl_stockOpeningStock.Controls.Add(this.label10);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_discount_Amt);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Discount_Percent);
            this.pnl_stockOpeningStock.Controls.Add(this.label8);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_No_of_Unit_in_Item);
            this.pnl_stockOpeningStock.Controls.Add(this.dateTimePicker_Manufacture);
            this.pnl_stockOpeningStock.Controls.Add(this.label7);
            this.pnl_stockOpeningStock.Controls.Add(this.label2);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_CSGT);
            this.pnl_stockOpeningStock.Controls.Add(this.label1);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_IGST);
            this.pnl_stockOpeningStock.Controls.Add(this.btn_Del_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.btn_Save_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label31);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Remarks_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label30);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_NetTotal_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label29);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_MRP_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label28);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Tax_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label27);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Price_bf_tax);
            this.pnl_stockOpeningStock.Controls.Add(this.label26);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Rate_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label25);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Unit_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label24);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Quantity_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.dateTimePicker_Expiry);
            this.pnl_stockOpeningStock.Controls.Add(this.label23);
            this.pnl_stockOpeningStock.Controls.Add(this.label22);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Batch_StockEntry);
            this.pnl_stockOpeningStock.Controls.Add(this.label20);
            this.pnl_stockOpeningStock.Controls.Add(this.txt_Name_StockEntry);
            this.pnl_stockOpeningStock.Location = new System.Drawing.Point(21, 60);
            this.pnl_stockOpeningStock.Name = "pnl_stockOpeningStock";
            this.pnl_stockOpeningStock.Size = new System.Drawing.Size(800, 170);
            this.pnl_stockOpeningStock.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(248, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 34);
            this.label10.TabIndex = 91;
            this.label10.Text = "       Discount\r\n        % / Amt     ";
            // 
            // txt_discount_Amt
            // 
            this.txt_discount_Amt.Location = new System.Drawing.Point(290, 144);
            this.txt_discount_Amt.Name = "txt_discount_Amt";
            this.txt_discount_Amt.Size = new System.Drawing.Size(54, 21);
            this.txt_discount_Amt.TabIndex = 3;
            // 
            // txt_Discount_Percent
            // 
            this.txt_Discount_Percent.Location = new System.Drawing.Point(245, 144);
            this.txt_Discount_Percent.Name = "txt_Discount_Percent";
            this.txt_Discount_Percent.Size = new System.Drawing.Size(44, 21);
            this.txt_Discount_Percent.TabIndex = 3;
            this.txt_Discount_Percent.TextChanged += new System.EventHandler(this.txt_Discount_Percent_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(566, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 87;
            this.label8.Text = "Units in Item";
            // 
            // txt_No_of_Unit_in_Item
            // 
            this.txt_No_of_Unit_in_Item.Enabled = false;
            this.txt_No_of_Unit_in_Item.Location = new System.Drawing.Point(570, 28);
            this.txt_No_of_Unit_in_Item.Name = "txt_No_of_Unit_in_Item";
            this.txt_No_of_Unit_in_Item.Size = new System.Drawing.Size(96, 21);
            this.txt_No_of_Unit_in_Item.TabIndex = 86;
            // 
            // dateTimePicker_Manufacture
            // 
            this.dateTimePicker_Manufacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Manufacture.Location = new System.Drawing.Point(14, 144);
            this.dateTimePicker_Manufacture.Name = "dateTimePicker_Manufacture";
            this.dateTimePicker_Manufacture.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker_Manufacture.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(10, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 84;
            this.label7.Text = "Made Of Dt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(434, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "CGST";
            // 
            // txt_CSGT
            // 
            this.txt_CSGT.Enabled = false;
            this.txt_CSGT.Location = new System.Drawing.Point(438, 71);
            this.txt_CSGT.Name = "txt_CSGT";
            this.txt_CSGT.Size = new System.Drawing.Size(44, 21);
            this.txt_CSGT.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(368, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "IGST";
            // 
            // txt_IGST
            // 
            this.txt_IGST.Enabled = false;
            this.txt_IGST.Location = new System.Drawing.Point(372, 71);
            this.txt_IGST.Name = "txt_IGST";
            this.txt_IGST.Size = new System.Drawing.Size(56, 21);
            this.txt_IGST.TabIndex = 71;
            // 
            // btn_Del_StockEntry
            // 
            this.btn_Del_StockEntry.Location = new System.Drawing.Point(692, 142);
            this.btn_Del_StockEntry.Name = "btn_Del_StockEntry";
            this.btn_Del_StockEntry.Size = new System.Drawing.Size(85, 25);
            this.btn_Del_StockEntry.TabIndex = 5;
            this.btn_Del_StockEntry.Text = "Delete";
            this.btn_Del_StockEntry.UseVisualStyleBackColor = true;
            // 
            // btn_Save_StockEntry
            // 
            this.btn_Save_StockEntry.Location = new System.Drawing.Point(585, 142);
            this.btn_Save_StockEntry.Name = "btn_Save_StockEntry";
            this.btn_Save_StockEntry.Size = new System.Drawing.Size(99, 25);
            this.btn_Save_StockEntry.TabIndex = 4;
            this.btn_Save_StockEntry.Text = "Save";
            this.btn_Save_StockEntry.UseVisualStyleBackColor = true;
            this.btn_Save_StockEntry.Click += new System.EventHandler(this.btn_Save_StockEntry_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label31.Location = new System.Drawing.Point(10, 71);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 19);
            this.label31.TabIndex = 68;
            this.label31.Text = "Remarks";
            // 
            // txt_Remarks_StockEntry
            // 
            this.txt_Remarks_StockEntry.Location = new System.Drawing.Point(75, 59);
            this.txt_Remarks_StockEntry.Multiline = true;
            this.txt_Remarks_StockEntry.Name = "txt_Remarks_StockEntry";
            this.txt_Remarks_StockEntry.Size = new System.Drawing.Size(279, 41);
            this.txt_Remarks_StockEntry.TabIndex = 67;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label30.Location = new System.Drawing.Point(679, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 19);
            this.label30.TabIndex = 66;
            this.label30.Text = "Net Total";
            // 
            // txt_NetTotal_StockEntry
            // 
            this.txt_NetTotal_StockEntry.Enabled = false;
            this.txt_NetTotal_StockEntry.Location = new System.Drawing.Point(683, 71);
            this.txt_NetTotal_StockEntry.Name = "txt_NetTotal_StockEntry";
            this.txt_NetTotal_StockEntry.Size = new System.Drawing.Size(110, 21);
            this.txt_NetTotal_StockEntry.TabIndex = 65;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(566, 52);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(39, 19);
            this.label29.TabIndex = 64;
            this.label29.Text = "MRP";
            // 
            // txt_MRP_StockEntry
            // 
            this.txt_MRP_StockEntry.Location = new System.Drawing.Point(571, 71);
            this.txt_MRP_StockEntry.Name = "txt_MRP_StockEntry";
            this.txt_MRP_StockEntry.Size = new System.Drawing.Size(97, 21);
            this.txt_MRP_StockEntry.TabIndex = 63;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label28.Location = new System.Drawing.Point(499, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 19);
            this.label28.TabIndex = 62;
            this.label28.Text = "Tax";
            // 
            // txt_Tax_StockEntry
            // 
            this.txt_Tax_StockEntry.Enabled = false;
            this.txt_Tax_StockEntry.Location = new System.Drawing.Point(503, 71);
            this.txt_Tax_StockEntry.Name = "txt_Tax_StockEntry";
            this.txt_Tax_StockEntry.Size = new System.Drawing.Size(47, 21);
            this.txt_Tax_StockEntry.TabIndex = 61;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label27.Location = new System.Drawing.Point(679, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 19);
            this.label27.TabIndex = 60;
            this.label27.Text = "Gross Price";
            // 
            // txt_Price_bf_tax
            // 
            this.txt_Price_bf_tax.Enabled = false;
            this.txt_Price_bf_tax.Location = new System.Drawing.Point(683, 29);
            this.txt_Price_bf_tax.Name = "txt_Price_bf_tax";
            this.txt_Price_bf_tax.Size = new System.Drawing.Size(110, 21);
            this.txt_Price_bf_tax.TabIndex = 59;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label26.Location = new System.Drawing.Point(441, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 19);
            this.label26.TabIndex = 58;
            this.label26.Text = "Price of Unit";
            // 
            // txt_Rate_StockEntry
            // 
            this.txt_Rate_StockEntry.Enabled = false;
            this.txt_Rate_StockEntry.Location = new System.Drawing.Point(445, 28);
            this.txt_Rate_StockEntry.Name = "txt_Rate_StockEntry";
            this.txt_Rate_StockEntry.Size = new System.Drawing.Size(105, 21);
            this.txt_Rate_StockEntry.TabIndex = 57;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label25.Location = new System.Drawing.Point(368, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 19);
            this.label25.TabIndex = 56;
            this.label25.Text = "Unit";
            // 
            // txt_Unit_StockEntry
            // 
            this.txt_Unit_StockEntry.Enabled = false;
            this.txt_Unit_StockEntry.Location = new System.Drawing.Point(372, 28);
            this.txt_Unit_StockEntry.Name = "txt_Unit_StockEntry";
            this.txt_Unit_StockEntry.Size = new System.Drawing.Size(56, 21);
            this.txt_Unit_StockEntry.TabIndex = 55;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 10F);
            this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label24.Location = new System.Drawing.Point(351, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 34);
            this.label24.TabIndex = 54;
            this.label24.Text = "Quantity Of\r\nItem Required";
            // 
            // txt_Quantity_StockEntry
            // 
            this.txt_Quantity_StockEntry.Location = new System.Drawing.Point(354, 144);
            this.txt_Quantity_StockEntry.Name = "txt_Quantity_StockEntry";
            this.txt_Quantity_StockEntry.Size = new System.Drawing.Size(119, 21);
            this.txt_Quantity_StockEntry.TabIndex = 1;
            this.txt_Quantity_StockEntry.TextChanged += new System.EventHandler(this.txt_Quantity_StockEntry_TextChanged);
            // 
            // dateTimePicker_Expiry
            // 
            this.dateTimePicker_Expiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Expiry.Location = new System.Drawing.Point(134, 144);
            this.dateTimePicker_Expiry.Name = "dateTimePicker_Expiry";
            this.dateTimePicker_Expiry.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_Expiry.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(130, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 19);
            this.label23.TabIndex = 49;
            this.label23.Text = "Expiry Dt";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(479, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 19);
            this.label22.TabIndex = 47;
            this.label22.Text = "Batch";
            // 
            // txt_Batch_StockEntry
            // 
            this.txt_Batch_StockEntry.Location = new System.Drawing.Point(483, 144);
            this.txt_Batch_StockEntry.Name = "txt_Batch_StockEntry";
            this.txt_Batch_StockEntry.Size = new System.Drawing.Size(83, 21);
            this.txt_Batch_StockEntry.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(10, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 19);
            this.label20.TabIndex = 5;
            this.label20.Text = "Name";
            // 
            // txt_Name_StockEntry
            // 
            this.txt_Name_StockEntry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Name_StockEntry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Name_StockEntry.Enabled = false;
            this.txt_Name_StockEntry.Location = new System.Drawing.Point(14, 28);
            this.txt_Name_StockEntry.Name = "txt_Name_StockEntry";
            this.txt_Name_StockEntry.Size = new System.Drawing.Size(341, 21);
            this.txt_Name_StockEntry.TabIndex = 4;
            // 
            // dataGridView_ShowStock
            // 
            this.dataGridView_ShowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowStock.Location = new System.Drawing.Point(81, 302);
            this.dataGridView_ShowStock.Name = "dataGridView_ShowStock";
            this.dataGridView_ShowStock.Size = new System.Drawing.Size(840, 317);
            this.dataGridView_ShowStock.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.Location = new System.Drawing.Point(897, 34);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(22, 20);
            this.btn_clear.TabIndex = 85;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1039, 717);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lbl_hr_belowHdr);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.combo_payMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_Purchase_Dt);
            this.Controls.Add(this.txt_VendorName);
            this.Controls.Add(this.txt_PurchaseVoucherNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_ShowStock);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StockEntry";
            this.Text = "StockEntry";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnl_stockOpeningStock.ResumeLayout(false);
            this.pnl_stockOpeningStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_hr_belowHdr;
        private System.Windows.Forms.ComboBox combo_payMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_VendorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PurchaseVoucherNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Purchase_Dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txt_search_Item;
        private System.Windows.Forms.ComboBox combo_searchResult;
        private System.Windows.Forms.DataGridView dataGridView_ShowStock;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel pnl_stockOpeningStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_discount_Amt;
        private System.Windows.Forms.TextBox txt_Discount_Percent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_No_of_Unit_in_Item;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Manufacture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CSGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IGST;
        private System.Windows.Forms.Button btn_Del_StockEntry;
        private System.Windows.Forms.Button btn_Save_StockEntry;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_Remarks_StockEntry;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txt_NetTotal_StockEntry;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_MRP_StockEntry;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_Tax_StockEntry;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txt_Price_bf_tax;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txt_Rate_StockEntry;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_Unit_StockEntry;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_Quantity_StockEntry;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Expiry;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_Batch_StockEntry;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_Name_StockEntry;

    }
}