CREATE TABLE [dbo].[Jobtype]
(
	[JobtypeId]				NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[JobtypeName]			NVARCHAR(50)	NOT NULL    ,
	[JobtypeDescription]    NVARCHAR(MAX)	NOT NULL    ,
	[Rate]					MONEY			NOT NULL	,
	[CreatedAt]				DATETIME2(7)    NOT NULL	,
    [ModifiedDate]			DATETIME2(7)    NOT NULL
)
