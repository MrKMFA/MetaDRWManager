CREATE TABLE [dbo].[Currency]
(
	[CurrencyId]      NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[CurrencySymbol]  NVARCHAR(14)    ,
	[CurrencyCode]    NVARCHAR(14)    ,
	[CurrencyName]    NVARCHAR(14)    ,
	[CreatedAt]       DATETIME2(7)    NOT NULL,
    [ModifiedDate]    DATETIME2(7)    NOT NULL
)
