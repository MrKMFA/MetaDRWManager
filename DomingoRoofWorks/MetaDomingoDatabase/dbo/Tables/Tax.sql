CREATE TABLE [dbo].[Tax]
(
	[TaxId]           NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[TaxLabel]        NVARCHAR(14)    ,
	[TaxPerc]		  DECIMAL(3,2)	  ,
	[CreatedAt]       DATETIME2(7)    NOT NULL,
    [ModifiedDate]    DATETIME2(7)    NOT NULL
)
