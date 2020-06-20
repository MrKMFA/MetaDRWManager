CREATE TABLE [dbo].[InvoiceItem]
(
	[InvoiceItemId]			NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[InvoiceId]				NVARCHAR(14)	NOT NULL,
	[ItemId]				NVARCHAR(14)	NOT NULL,
	[Quantity]				INT				NOT NULL,
	[CreatedAt]             DATETIME2(7)    NOT NULL,
    [ModifiedDate]          DATETIME2(7)    NOT NULL
)
