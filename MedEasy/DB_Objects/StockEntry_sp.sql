CREATE PROCEDURE ME_OWN.Stock_Entry
 @purchaseDt     DATETIME,
 @voucherNo		VARCHAR(100),
 @vendorName	VARCHAR(200)
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
	END
	ELSE --
	BEGIN
	END
END