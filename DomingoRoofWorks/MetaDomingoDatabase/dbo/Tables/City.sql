CREATE TABLE [dbo].[City]
(
	[CityId]          NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[CityCode]        NVARCHAR(14)    ,
	[CityName]        NVARCHAR(14)    ,
	[CreatedAt]       DATETIME2(7)    NOT NULL,
    [ModifiedDate]    DATETIME2(7)    NOT NULL
)
