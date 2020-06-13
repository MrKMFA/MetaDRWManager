CREATE TABLE [dbo].[Item]
(
	[ItemId]          NVARCHAR (450)  NOT NULL,
    [CreatedAt]       DATETIME2 (7)   NOT NULL DEFAULT GetDate(),
    [CurrencyId]      NVARCHAR (450)  NOT NULL,
    [ItemDescription] NVARCHAR (MAX)  NOT NULL,
    [ItemName]        NVARCHAR (MAX)  NOT NULL,
    [CostPrice]       DECIMAL (18, 2) NOT NULL,
    [TaxId]           NVARCHAR (450)  NOT NULL,
    [SalePrice]       DECIMAL (18, 2) NOT NULL,
    [MarkupPerc]      DECIMAL (3, 2)  NOT NULL DEFAULT 1.00,
    [LastUpdated] DATETIME2 NOT NULL, 
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([ItemId] ASC),
    CONSTRAINT [FK_Item_Currency_CurrencyId] FOREIGN KEY ([CurrencyId]) REFERENCES [dbo].[Currency] ([CurrencyId]),
    CONSTRAINT [FK_Item_Tax_TaxId] FOREIGN KEY ([TaxId]) REFERENCES [dbo].[Tax] ([TaxId])
);