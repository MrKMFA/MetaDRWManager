CREATE TABLE [dbo].[InternalCompany]
(
	[InternalCompanyId]		NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[EntityId]				NVARCHAR(14)    NOT NULL,
	[InternalCompanyName]	NVARCHAR(50)    NOT NULL,
	CONSTRAINT [FK_InternalCompany_ToBusinessEntity] FOREIGN KEY (EntityId) REFERENCES BusinessEntity(EntityId)
)
