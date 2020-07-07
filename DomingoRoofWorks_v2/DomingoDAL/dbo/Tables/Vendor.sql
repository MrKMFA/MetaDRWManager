CREATE TABLE [dbo].[Vendor]
(
	[VendorId]		NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[EntityId]		NVARCHAR(14)    NOT NULL,
	[VendorName]	NVARCHAR(50)    NOT NULL,
	CONSTRAINT [FK_Vendor_ToBusinessEntity] FOREIGN KEY (EntityId) REFERENCES BusinessEntity(EntityId)
)
