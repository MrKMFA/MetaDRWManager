CREATE TABLE [dbo].[Item]
(
	[ItemId]			NVARCHAR(14)	PRIMARY KEY NOT NULL,
	[ItemName]			NVARCHAR(14)	NOT NULL,
	[ItemDescription]	NVARCHAR(14)	NOT NULL,
	[VendorId]			NVARCHAR(14)	NOT NULL,
	[PreferredVendor]	BIT				NOT NULL,
	[CostPrice]			MONEY			NOT NULL,
	[MarkupPerc]		DECIMAL(3,2)	NOT NULL,
	[UnitPrice] AS CostPrice * MarkupPerc PERSISTED,
	[CreatedAt]			DATETIME2(2)	NOT NULL,
	[ModifiedDate]		DATETIME2(2)	NOT NULL,
	CONSTRAINT [FK_Item_ToVendor] FOREIGN KEY (VendorId) REFERENCES Vendor(VendorId)
)
