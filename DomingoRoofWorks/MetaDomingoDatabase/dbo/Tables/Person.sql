CREATE TABLE [dbo].[Person]
(
	[PersonId]                  NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[EntityId]                  NVARCHAR(14)	NOT NULL,
	[FirstName]                 NVARCHAR(14)    ,
	[LastName]                  NVARCHAR(14)    ,
	[CreatedAt]                 DATETIME2(7)    NOT NULL,
	[ModifiedDate]              DATETIME2(7)    NOT NULL,
)
