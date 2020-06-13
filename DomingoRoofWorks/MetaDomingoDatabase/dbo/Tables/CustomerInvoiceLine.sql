CREATE TABLE [dbo].[CustomerInvoiceLine] (
    [CustomerInvoiceLineId] NVARCHAR (450)  NOT NULL,
    [Amount]                DECIMAL (18, 2) NOT NULL,
    [CreatedAt]             DATETIME2 (7)   NOT NULL,
    [CustomerInvoiceId]     NVARCHAR (450)  NOT NULL,
    [Description]           NVARCHAR (MAX)  NULL DEFAULT NULL,
    [ItemId]                NVARCHAR (450)  NOT NULL,
    [Price]                 DECIMAL (18, 2) NOT NULL,
    [Quantity]              INT            NOT NULL,
    [TaxAmount]             DECIMAL (18, 2) NOT NULL,
    [TaxId]                 NVARCHAR (MAX)  NOT NULL,
    [TotalAmount]           DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_CustomerInvoiceLine] PRIMARY KEY CLUSTERED ([CustomerInvoiceLineId] ASC),
    CONSTRAINT [FK_CustomerInvoiceLine_CustomerInvoice_CustomerInvoiceId] FOREIGN KEY ([CustomerInvoiceId]) REFERENCES [dbo].[CustomerInvoice] ([CustomerInvoiceId]),
    CONSTRAINT [FK_CustomerInvoiceLine_Item_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId])
);
