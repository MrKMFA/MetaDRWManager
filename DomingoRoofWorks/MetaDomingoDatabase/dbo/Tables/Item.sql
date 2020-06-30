CREATE TABLE [dbo].[Item]
(
	[ItemId]			NVARCHAR(14)	PRIMARY KEY NOT NULL,
	[ItemName]			NVARCHAR(50)	NOT NULL,
	[ItemDescription]	NVARCHAR(MAX)	NOT NULL,
	[VendorId]			NVARCHAR(14)	NOT NULL,
	[PreferredVendor]	BIT				NOT NULL DEFAULT 0,
	[CostPrice]			MONEY			NOT NULL,
	[MarkupPerc]		DECIMAL(3,2)	NOT NULL,
	[UnitPrice] AS CostPrice * MarkupPerc PERSISTED,
	[CreatedAt]			DATETIME2(7)	NOT NULL,
	[ModifiedDate]		DATETIME2(7)	NOT NULL,
	CONSTRAINT [FK_Item_ToVendor] FOREIGN KEY (VendorId) REFERENCES Vendor(VendorId)
)
