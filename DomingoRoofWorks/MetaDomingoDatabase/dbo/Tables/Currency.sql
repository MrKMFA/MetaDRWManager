CREATE TABLE [dbo].[Currency]
(
	[CurrencyId]      NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[CurrencySymbol]  NVARCHAR(5)					,
	[CurrencyCode]    NVARCHAR(5)		NOT NULL    ,
	[CurrencyName]    NVARCHAR(50)		NOT NULL    ,
	[CreatedAt]       DATETIME2(7)		NOT NULL	,
    [ModifiedDate]    DATETIME2(7)		NOT NULL
)
