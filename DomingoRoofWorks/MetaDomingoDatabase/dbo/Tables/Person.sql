CREATE TABLE [dbo].[Person]
(
	[PersonId]                  NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[EntityId]                  NVARCHAR(14)	NOT NULL,
	[FirstName]                 NVARCHAR(50)    ,
	[LastName]                  NVARCHAR(50)    ,
)
