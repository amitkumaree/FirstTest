DROP TABLE ME_OWN.MST_STORE;
CREATE TABLE ME_OWN.MST_STORE(STORE_UID 		      INT IDENTITY(1,1),
                              STORE_ID                VARCHAR(100) NOT NULL, 
                              STORE_NAME 	          VARCHAR(300) NOT NULL,
                              PRODUCT_NAME            VARCHAR(100) NOT NULL,
                              STORE_OWNER_NAME        VARCHAR(300) NULL,
                              STORE_ADDR1             VARCHAR(150) NULL,
                              STORE_ADDR2             VARCHAR(150) NULL,
                              STORE_ADDR3             VARCHAR(150) NULL,
                              STORE_CITY              VARCHAR(50)  NULL,
                              STORE_PIN               INT NULL,
                              STORE_STATE             VARCHAR(50) NULL,
                              STORE_CNTRY             VARCHAR(50) NULL,
                              STORE_PH_NO1            VARCHAR(20) NULL,
                              STORE_PH_NO2            VARCHAR(20) NULL,
                              STORE_PH_NO3            VARCHAR(20) NULL,
                              STORE_EMAIL             VARCHAR(50) NULL,
                              STORE_DRUG_LICENCE_NO   VARCHAR(100) NULL,
                              STORE_REGIN_NO          VARCHAR(200) NULL,
                              STORE_REGIN_DT          DATE NULL,
                              STORE_REGIN_EXP_DT      DATE NULL,
                              STORE_GST_NO            VARCHAR(100) NULL,
                              STORE_CIN_NO            VARCHAR(100) NULL,
                              STRORE_TIN_NO           VARCHAR(100) NULL
                              ) ;
DROP TABLE ME_OWN.MST_CUST;
CREATE TABLE ME_OWN.MST_CUST (CUST_UID   INT          IDENTITY(1,1)  ,
							  CUST_NAME  VARCHAR(200) NULL ,
							  DOB        DATETIME     NULL,
							  GENDER     VARCHAR(1)   NULL,
							  ADDR_DTL   VARCHAR(300) NULL,
							  PH_NO1     VARCHAR(15)  NULL,
                              PH_NO2     VARCHAR(15)  NULL,
                              EMAIL      VARCHAR(125) NULL,
							  CUST_GST_NO VARCHAR(100) NULL,
                              CUST_TYP   VARCHAR(1)   NULL) --R-REGULAR,O-OCCASIONAL
DROP TABLE ME_OWN.MST_DOCTOR;
CREATE TABLE ME_OWN.MST_DOCTOR (DOCTOR_UID   INT          IDENTITY(1,1)  ,
							  DOCTOR_NAME  VARCHAR(200) NULL ,
							  DEGREE       VARCHAR(200) NULL ,
							  SPECIALITY   VARCHAR(200) NULL ,
							  REG_NO       VARCHAR(200) NULL ,
							  GENDER     VARCHAR(1)   NULL,
							  ADDR_DTL   VARCHAR(300) NULL,
							  PH_NO1     VARCHAR(15)  NULL,
                              PH_NO2     VARCHAR(15)  NULL,
                              EMAIL      VARCHAR(125) NULL
							  )                               
DROP TABLE ME_OWN.MST_MANUFACTURERS ;                              
CREATE TABLE ME_OWN.MST_MANUFACTURERS (MANUFACTURERS_UID INT IDENTITY(1,1)  ,
							  SRLNO VARCHAR(30) NULL,																
       						  MANUFACTURER_NAME VARCHAR(500) NULL,
                              ADDR VARCHAR(900) NULL,
                              PHONENO VARCHAR(500) NULL,
                              FAX VARCHAR(500) NULL,
                              EMAIL VARCHAR(500) NULL,
                              URL VARCHAR(500) NULL,
                              SUBDIVISION VARCHAR(6000) NULL
                              );
DROP TABLE ME_OWN.MST_FORM_TYP;                               
CREATE TABLE ME_OWN.MST_FORM_TYP (FORM_TYP_UID INT IDENTITY(1,1)  ,
							      [FORM_NAME] [VARCHAR](75) NOT NULL,
							      [FORM_PIC_FILE_NAME] [VARCHAR](75) NULL) ; 

DROP TABLE  ME_OWN.MST_ITEM;
CREATE TABLE ME_OWN.MST_ITEM (ITEM_UID INT IDENTITY(1,1)  ,
                       [ITEM_ID]                VARCHAR(20)      NULL,
                       [ITEM_BRAND_NAME]        [VARCHAR](200) NULL ,
                       [ITEM_POWER]             [VARCHAR](50) NULL,
                       [DEL_FLG]                VARCHAR(1) NULL,
                       [FORM_TYP_UID]           [INT] NULL,
                       [MANUFACTURERS_UID]      [INT] NULL,
					   [CATEGORY_UID]           [INT] NULL,
                       [UNIT_MESURE]            VARCHAR(50) NULL,--15 (Units)
                       [UNIT]                   INT         NULL, -- 15
                       [NO_OF_UNIT]             INT         NULL,  -- 15 in a strip
                       [PER_UNIT_RATE]          DECIMAL(9,2) NULL, --NOT REQUIRED EVERY TIME
                       [MRP]                    DECIMAL(9,2) NULL, --MRP for whole UNIT
                       [MED_TYPE]               [VARCHAR](35) NULL,--HOMIO/ALAPATHY
                       [SCHEDULE]               [VARCHAR](10) NULL, --SCHEDULE
                       [HSN_NO]                 [VARCHAR](20) NULL, --Harmozed Number of medecine
                       [RECORDED_QTY]           INT NULL,
                       [BOOKED_QTY]             INT NULL,
                       [PROFIT_MARGIN]          DECIMAL(9,2) NULL,
                       [CGST]                   DECIMAL(9,2) NULL,
                       [IGST]                   DECIMAL(9,2) NULL,
                       [TAX]                    DECIMAL(9,2) NULL,
                       [DISCOUNT1]              DECIMAL(9,2) NULL,
                       [DISCOUNT2]              DECIMAL(9,2) NULL,
                       [DISCOUNT3]              DECIMAL(9,2) NULL,
                       [STORE_RACK_NO]          [VARCHAR](4) NULL,
                       [STORE_BOX_NO]           [VARCHAR](4) NULL,
                       [DEMAND_GEN_LIMIT]       INT NULL,
                       [ORGL_USER]              [VARCHAR](20) NULL,
                       [ORGL_STAMP]              DATETIME NULL,
                       [UPDT_USER]              [VARCHAR](20) NULL,
                       [UPDT_STAMP]              DATETIME NULL) ; 		
                       
DROP TABLE ME_OWN.MST_COMPOSITION;
CREATE TABLE ME_OWN.MST_COMPOSITION (COMPOSITION_UID   INT IDENTITY(1,1)  ,
                       [ITEM_UID]                      INT NOT NULL,
                       [COMPOSITION_NAME]              [VARCHAR](500) NULL,
                       [PER_UNIT]                      [VARCHAR](100) NULL
                       )                         
DROP TABLE  ME_OWN.TRN_STOCK;
CREATE TABLE ME_OWN.TRN_STOCK (STOCK_UID INT IDENTITY(1,1)  ,
                               [PURCHASE_DATE]       DATETIME,
                               [PURCHASE_VOUCHER_NO] VARCHAR(100) NULL,
                               [VENDOR_NAME]         VARCHAR(200) NULL,
                               [GROSS_PRICE]         DECIMAL(9,2) NULL,
                               [DISCOUNT_PER]        DECIMAL(9,2) NULL,
                               [DISCOUNT_PRICE]      DECIMAL(9,2) NULL,
							   [TAX_PER]             DECIMAL(9,2) NULL,
							   [ITEM_COUNT]          INT NULL,
							   [PAY_TYPE]            VARCHAR(30) NULL,--BY CASH/CHEQUE/CREDIT NOTE/CARD							     
                               [NET_PRICE]           DECIMAL(9,2) NULL,
                               [RMKS]                VARCHAR(100),
                               [ORGL_USER]           [VARCHAR](20) NULL,
                       		   [ORGL_STAMP]          DATETIME NULL,
                               [UPDT_USER]           [VARCHAR](20) NULL,
                               [UPDT_STAMP]          DATETIME NULL);
DROP TABLE ME_OWN.TRN_STOCK_DTL;                                                                             
CREATE TABLE ME_OWN.TRN_STOCK_DTL (STOCK_DTL_UID INT IDENTITY(1,1)  ,
                               [STOCK_UID]              INT NULL,
                               [ITEM_UID]               INT NULL ,
							   [BATCH_NO]               [VARCHAR](50) NULL,
                               [MANUFACTURER_DT]        DATETIME NULL,
                               [EXP_DT]                 DATETIME NULL,
                               [PER_UNIT_RATE]          DECIMAL(9,2) NULL,
                               [PURCHASE_UNIT]          [VARCHAR](15) NULL, 
                               [PURCHASE_QTY]           INT NULL, 
                               [BOOKED_QTY]             INT NULL, 
                               [MRP]                    DECIMAL(9,2) NULL,
                               [GROSS_PRICE]            DECIMAL(9,2) NULL,
                               [TAX_PER]                DECIMAL(9,2) NULL,
                               [DISCOUNT_AMT]           DECIMAL(9,2) NULL,    
                               [NET_PRICE]              DECIMAL(9,2) NULL,
                               [ORGL_USER]              [VARCHAR](20) NULL,
                       		   [ORGL_STAMP]             DATETIME NULL,
                               [UPDT_USER]              [VARCHAR](20) NULL,
                               [UPDT_STAMP]             DATETIME NULL);     
DROP TABLE ME_OWN.TRN_SALE;
CREATE TABLE ME_OWN.TRN_SALE (SALE_UID INT IDENTITY(1,1),
                              [SALE_DATE]             DATETIME NULL,
                              [SALE_INV_NO]           VARCHAR(50) NULL,
                              [SALE_INV_DT]           DATETIME NULL,
                              [CUST_UID]              INT NULL,
                              [DOCTOR_UID]            INT NULL,
                              [SALE_STATUS]           VARCHAR(1) NOT NULL, --O-NEW ORDER/P-PENDING/I-INVOICE GENERATED/B-BILL GENERATED
                              [TOTAL_MRP]           DECIMAL(9,2) NULL,
                              [TOTAL_DISCOUNT]        DECIMAL(9,2) NULL,
							  [TOTAL_TAX]             DECIMAL(9,2) NULL,
							  [TOTAL_AMT]             DECIMAL(9,2) NULL,
							  [ITEM_COUNT]            INT NULL,
							  [PAY_MODE]              VARCHAR(30) NULL,--BY CASH/CHEQUE/CREDIT NOTE/CARD							     
                              [ORGL_USER]             [VARCHAR](20) NULL,
                       		  [ORGL_STAMP]            DATETIME NULL,
                       		  [UPDT_USER]             [VARCHAR](20) NULL,
                       		  [UPDT_STAMP]            DATETIME NULL
                              );
DROP TABLE ME_OWN.TRN_SALE_DTL;
CREATE TABLE ME_OWN.TRN_SALE_DTL (SALE_DTL_UID INT IDENTITY(1,1),
                              [SALE_UID] 			 INT NULL,
                              [ITEM_UID]             INT NULL,
                              [STOCK_DTL_UID]        INT NULL,
                              [RATE]                 DECIMAL(9,2) NULL,
                              [SALE_UNIT]            [VARCHAR](15) NULL,
                              [SALE_QTY]             INT NULL, 
                              [MRP]                  DECIMAL(9,2) NULL, 
                              [TAX_PER]              DECIMAL(9,2) NULL,
                              [TAX_AMT]              DECIMAL(9,2) NULL,
                              [DISCOUNT_PER]         DECIMAL(9,2) NULL,
                              [DISCOUNT_AMT]         DECIMAL(9,2) NULL,
                              [NET_AMT]              DECIMAL(9,2) NULL,
                              [ORGL_USER]            [VARCHAR](20) NULL,
                       		  [ORGL_STAMP]           DATETIME NULL,
                       		  [UPDT_USER]            [VARCHAR](20) NULL,
                       		  [UPDT_STAMP]           DATETIME NULL);                                                            
DROP TABLE ME_OWN.PRNT_SALE;                              
CREATE TABLE ME_OWN.PRNT_SALE (SALE_PRINT_UID INT IDENTITY(1,1),
                              [SRL_NO]                   INT NULL,
                              [SALE_DTL_UID]             INT NULL,
                              [BRAND_DSCR]               [VARCHAR](200) NULL,
                              [MANUFACTURERS_NAME]       [VARCHAR](200) NOT NULL,
                              [SCHEDULE]                 VARCHAR(10) NOT NULL,
                              [BATCH_NO]                 [VARCHAR](50) NULL,
                              [EXP_DT]                   DATETIME NULL,
                              [MRP_RATE_PER_UNIT]        DECIMAL(9,2) NULL,
                              [DISCOUNTED_RATE_PER_UNIT] DECIMAL(9,2) NULL,
                              [SALE_QTY]                 INT NULL,
                              [GROSS_PRICE]              DECIMAL(9,2) NULL,
                              [NET_PRICE]                DECIMAL(9,2) NULL,
                              [DISCOUNT_PRICE]           DECIMAL(9,2) NULL,
                              [TAXABLE_PRICE]            DECIMAL(9,2) NULL,
                              [CGST_RATE]                DECIMAL(9,2) NULL,
                              [CGST_PRICE]               DECIMAL(9,2) NULL,
                              [IGST_RATE]                DECIMAL(9,2) NULL,
                              [IGST_PRICE]               DECIMAL(9,2) NULL,
                              [ORGL_USER]                [VARCHAR](20) NULL,
                       		  [ORGL_STAMP]               DATETIME NULL,
                       		  [UPDT_USER]                [VARCHAR](20) NULL,
                       		  [UPDT_STAMP]               DATETIME NULL
                              );  