CREATE TABLE [dbo].[BusinessEntity]
(
	[EntityId]                  NVARCHAR(14)    PRIMARY KEY NOT NULL,
    [ContactName]               NVARCHAR(50)    ,
    [Email]                     NVARCHAR(256)   UNIQUE,
    [Phone]                     NVARCHAR(13)    ,
    [TaxRegistrationNumber]     NVARCHAR(14)    ,
    [WebsiteUrl]                NVARCHAR(256)   ,
    [AddressLine1]              NVARCHAR(MAX)   ,
    [AddressLine2]              NVARCHAR(MAX)   ,
    [CityId]                    NVARCHAR(14)    NULL,
    [PostCode]                  NVARCHAR(4)     ,
    [AdditionalInfo]            NVARCHAR(MAX)   ,
    [CreatedAt]                 DATETIME2(7)    NOT NULL,
    [ModifiedDate]              DATETIME2(7)    NOT NULL
)
