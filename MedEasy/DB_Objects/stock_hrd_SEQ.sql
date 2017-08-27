-----------------------------------------------------------------------------------
--|Sequence Name  : STOCK_HDR_SEQ					                           	|--
--|Description : This sequence is used by stock headertable    					|--
--|MAXVALUE: 2147483647															|--
------------------------------------------------------------------------------------
IF (EXISTS ( SELECT * FROM SYS.SEQUENCES
WHERE UPPER(NAME)='STOCK_HDR_SEQ'))
    BEGIN
         DROP SEQUENCE [ME_OWN].[STOCK_HDR_SEQ];
    END
    
    GO
CREATE SEQUENCE [ME_OWN].[STOCK_HDR_SEQ]
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 2147483647
 CACHE ;