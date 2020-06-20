CREATE TABLE [dbo].[BusinessEntity]
(
	[EntityId]                  NVARCHAR(14)    PRIMARY KEY NOT NULL,
    [ContactName]               NVARCHAR(14)    ,
    [Email]                     NVARCHAR(14)    ,
    [Phone]                     NVARCHAR(14)    ,
    [TaxRegistrationNumber]     NVARCHAR(14)    ,
    [WebsiteUrl]                NVARCHAR(14)    ,
    [AddressLine1]              NVARCHAR(14)    ,
    [AddressLine2]              NVARCHAR(14)    ,
    [CityId]                    NVARCHAR(14)    NOT NULL,
    [PostCode]                  NVARCHAR(14)    ,
    [AdditionalInfo]            NVARCHAR(14)    ,
    [CreatedAt]                 DATETIME2(7)    NOT NULL,
    [ModifiedDate]              DATETIME2(7)    NOT NULL
)
