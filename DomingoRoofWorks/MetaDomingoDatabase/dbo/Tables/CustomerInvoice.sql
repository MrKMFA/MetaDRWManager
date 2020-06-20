CREATE TABLE [dbo].[CustomerInvoice]
(
	[CustomerInvoiceId]		NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[CustomerId]			NVARCHAR(14)	NOT NULL,
	[InvoiceId]				NVARCHAR(14)	NOT NULL,
	[CreatedAt]             DATETIME2(7)    NOT NULL,
    [ModifiedDate]          DATETIME2(7)    NOT NULL
)
