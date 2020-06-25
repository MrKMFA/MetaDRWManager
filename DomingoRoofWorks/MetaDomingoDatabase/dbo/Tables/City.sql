CREATE TABLE [dbo].[City]
(
	[CityId]          NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[CityCode]        NVARCHAR(10)		NOT NULL    ,
	[CityName]        NVARCHAR(50)		NOT NULL    ,
	[CreatedAt]       DATETIME2(7)		NOT NULL	,
    [ModifiedDate]    DATETIME2(7)		NOT NULL
)
