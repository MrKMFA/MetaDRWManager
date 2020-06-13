CREATE TABLE [dbo].[VendorInvoiceLine] (
    [VendorInvoiceLineId] NVARCHAR (450)  NOT NULL,
    [VendorInvoiceId]     NVARCHAR (450)  NOT NULL,
    [Amount]              MONEY NOT NULL,
    [CreatedAt]           DATETIME2 (7)   NOT NULL,
    [Description]         NVARCHAR (MAX)  NULL DEFAULT NULL,
    [ItemId]              NVARCHAR (450)  NOT NULL,
    [Price]               MONEY NOT NULL,
    [Quantity]            INT            NOT NULL,
    [TaxAmount]           MONEY NOT NULL,
    [TaxId]               NVARCHAR (MAX)  NOT NULL,
    [TotalAmount]         MONEY NOT NULL,
    CONSTRAINT [PK_VendorInvoiceLine] PRIMARY KEY CLUSTERED ([VendorInvoiceLineId] ASC),
    CONSTRAINT [FK_VendorInvoiceLine_Item_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_VendorInvoiceLine_VendorInvoice_VendorInvoiceId] FOREIGN KEY ([VendorInvoiceId]) REFERENCES [dbo].[VendorInvoice] ([VendorInvoiceId])
);