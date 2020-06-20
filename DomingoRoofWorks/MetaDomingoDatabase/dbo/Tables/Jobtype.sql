CREATE TABLE [dbo].[Jobtype]
(
	[JobtypeId]				NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[JobtypeName]			NVARCHAR(14)    ,
	[JobtypeDescription]    NVARCHAR(14)    ,
	[Rate]					MONEY			,
	[CreatedAt]				DATETIME2(7)    NOT NULL,
    [ModifiedDate]			DATETIME2(7)    NOT NULL
)
