IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ME_OWN.Stock_Entry') AND type in (N'P', N'PC'))
	BEGIN
		DROP PROCEDURE ME_OWN.Stock_Entry
	END
	GO
CREATE PROCEDURE ME_OWN.Stock_Entry
 @purchaseDt     DATETIME,
 @voucherNo		VARCHAR(100),
 @vendorName	VARCHAR(200),
 @grossPrice	decimal(9,2),
 @disCountPer	decimal(9,2),
 @disCountPrice	decimal(9,2),
 @taxPer		decimal(9,2),
 @itemCount		int,
 @payType		varchar(30),
 @netPrice		decimal(9,2),
 @rmrks			VARCHAR(100)
AS
BEGIN
	DECLARE @isInsert BIT = 0;
	IF EXISTS(SELECT COUNT(1) 
			  from ME_OWN.TRN_STOCK 
			  where PURCHASE_DATE = @purchaseDt and 
			  PURCHASE_VOUCHER_NO = @voucherNo AND
			  VENDOR_NAME = @vendorName)
		SET @isInsert = 1;
	if(@isInsert = 1)
	BEGIN
		INSERT INTO [ME_OWN].[TRN_STOCK]
           ([PURCHASE_DATE]  ,[PURCHASE_VOUCHER_NO] ,[VENDOR_NAME] ,[GROSS_PRICE] ,[DISCOUNT_PER]
           ,[DISCOUNT_PRICE] ,[TAX_PER] ,[ITEM_COUNT] ,[PAY_TYPE] ,[NET_PRICE] ,[RMKS]
           ,[ORGL_USER] ,[ORGL_STAMP] ,[UPDT_USER] ,[UPDT_STAMP])
     VALUES
           (@purchaseDt ,@voucherNo ,@vendorName ,@grossPrice ,@disCountPer
           ,@disCountPrice ,@taxPer ,@itemCount ,@payType ,@netPrice ,@rmrks
           ,CURRENT_USER ,GETDATE() ,CURRENT_USER ,GETDATE())
	END
	ELSE --		
	BEGIN
		UPDATE [ME_OWN].[TRN_STOCK]
		SET GROSS_PRICE = GROSS_PRICE + @grossPrice,
			DISCOUNT_PER = (DISCOUNT_PER +  @disCountPer)/(ITEM_COUNT + @itemCount),
			DISCOUNT_PRICE = DISCOUNT_PRICE + @disCountPrice,
			TAX_PER = (TAX_PER +  @taxPer)/(ITEM_COUNT + @taxPer),
			ITEM_COUNT = ITEM_COUNT + @itemCount,
			NET_PRICE = NET_PRICE + @netPrice
		where PURCHASE_DATE = @purchaseDt and 
			  PURCHASE_VOUCHER_NO = @voucherNo AND
			  VENDOR_NAME = @vendorName 
	END
END