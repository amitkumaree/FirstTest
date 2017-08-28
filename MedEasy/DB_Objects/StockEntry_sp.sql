IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ME_OWN.Stock_Entry') AND type in (N'P', N'PC'))
	BEGIN
		DROP PROCEDURE ME_OWN.Stock_Entry
	END
	GO
CREATE PROCEDURE ME_OWN.Stock_Entry
 @purchaseDt		DATETIME,
 @voucherNo			VARCHAR(100),
 @vendorName		VARCHAR(200),
 @grossPrice		decimal(9,2),
 @disCountPer		decimal(9,2),
 @disCountPrice		decimal(9,2),
 @taxPer			decimal(9,2),
 @itemCount			int,
 @payType			varchar(30),
 @netPrice			decimal(9,2),
 @rmrks				VARCHAR(100),
 @itemUid			INT,
 @batchNo			VARCHAR(50),
 @manuFactureDt		DATETIME,
 @expiryDt			DATETIME,
 @itemPerUnitRt		decimal(9,2),
 @itemMrp			decimal(9,2),
 @ItemgrossPrice	decimal(9,2),
 @itemTaxPer		decimal(9,2),
 @itemDiscountAmt	decimal(9,2),
 @itemNetPrice		decimal(9,2),
 @itemPurchaseUnit	VARCHAR(15),
 @itemPurchaseQnt	INT

AS
BEGIN
	DECLARE @isInsert BIT = 0,
			@stockId  INT = NULL;

	--
	-- check if the stock header already exists
	SELECT @stockId = STOCK_UID
	FROM ME_OWN.TRN_STOCK
	where --PURCHASE_DATE = @purchaseDt and 
			PURCHASE_VOUCHER_NO = @voucherNo AND
			VENDOR_NAME = @vendorName 
	--
		
	if(@stockId IS NULL)
	BEGIN
		--
		INSERT INTO [ME_OWN].[TRN_STOCK]
           ([PURCHASE_DATE]  ,[PURCHASE_VOUCHER_NO] ,[VENDOR_NAME] ,[GROSS_PRICE] ,[DISCOUNT_PER]
           ,[DISCOUNT_PRICE] ,[TAX_PER] ,[ITEM_COUNT] ,[PAY_TYPE] ,[NET_PRICE] ,[RMKS]
           ,[ORGL_USER] ,[ORGL_STAMP] ,[UPDT_USER] ,[UPDT_STAMP])
		VALUES
           (@purchaseDt ,@voucherNo ,@vendorName ,@grossPrice ,@disCountPer
           ,@disCountPrice ,@taxPer ,@itemCount ,@payType ,@netPrice ,@rmrks
           ,CURRENT_USER ,GETDATE() ,CURRENT_USER ,GETDATE())
		--
		-- 
		-- Grab the generated stock uid
		SELECT @stockId = STOCK_UID
		FROM ME_OWN.TRN_STOCK
		where --PURCHASE_DATE = @purchaseDt and 
				PURCHASE_VOUCHER_NO = @voucherNo AND
				VENDOR_NAME = @vendorName 
		--
		--
		INSERT INTO [ME_OWN].[TRN_STOCK_DTL]
           ([STOCK_UID] ,[ITEM_UID] ,[BATCH_NO] ,[MANUFACTURER_DT] ,[EXP_DT] ,[PER_UNIT_RATE]
           ,[PURCHASE_UNIT] ,[PURCHASE_QTY] ,[MRP] ,[GROSS_PRICE] ,[TAX_PER] ,[DISCOUNT_AMT] ,[NET_PRICE]
           ,[ORGL_USER] ,[ORGL_STAMP] ,[UPDT_USER] ,[UPDT_STAMP])
		VALUES
           (@stockId ,@itemUid ,@batchNo ,@manuFactureDt ,@expiryDt ,@itemPerUnitRt
           ,@itemPurchaseUnit ,@itemPurchaseQnt ,@itemMrp ,@ItemgrossPrice ,@itemTaxPer ,@itemDiscountAmt ,@itemNetPrice
           ,CURRENT_USER ,GETDATE() ,CURRENT_USER ,GETDATE())
		--
	END
	ELSE --		
	BEGIN
		--
		UPDATE [ME_OWN].[TRN_STOCK]
		SET GROSS_PRICE = GROSS_PRICE + @grossPrice,
			DISCOUNT_PER = (DISCOUNT_PER +  @disCountPer)/(ITEM_COUNT + @itemCount),
			DISCOUNT_PRICE = DISCOUNT_PRICE + @disCountPrice,
			TAX_PER = (TAX_PER +  @taxPer)/(ITEM_COUNT + @taxPer),
			ITEM_COUNT = ITEM_COUNT + @itemCount,
			NET_PRICE = NET_PRICE + @netPrice
		where STOCK_UID = @stockId
		--
		--
		INSERT INTO [ME_OWN].[TRN_STOCK_DTL]
           ([STOCK_UID] ,[ITEM_UID] ,[BATCH_NO] ,[MANUFACTURER_DT] ,[EXP_DT] ,[PER_UNIT_RATE]
           ,[PURCHASE_UNIT] ,[PURCHASE_QTY] ,[MRP] ,[GROSS_PRICE] ,[TAX_PER] ,[DISCOUNT_AMT] ,[NET_PRICE]
           ,[ORGL_USER] ,[ORGL_STAMP] ,[UPDT_USER] ,[UPDT_STAMP])
		VALUES
           (@stockId ,@itemUid ,@batchNo ,@manuFactureDt ,@expiryDt ,@itemPerUnitRt
           ,@itemPurchaseUnit ,@itemPurchaseQnt ,@itemMrp ,@ItemgrossPrice ,@itemTaxPer ,@itemDiscountAmt ,@itemNetPrice
           ,CURRENT_USER ,GETDATE() ,CURRENT_USER ,GETDATE())
		--
	END
END