CREATE TABLE [dbo].[BaseCompany]
(
	[BaseCompanyId]           NVARCHAR (450) NOT NULL,
    [AdditionalInformation] NVARCHAR (MAX) NULL DEFAULT NULL,
    [CompanyName]           NVARCHAR (MAX) NOT NULL,
    [ContactName]           NVARCHAR (MAX) NOT NULL,
    [AddressLine1]          NVARCHAR(MAX) NOT NULL, 
    [AddressLine2]          NVARCHAR(MAX) NULL DEFAULT NULL, 
    [CityId]                NVARCHAR(450) NOT NULL, 
    [PostCode]              NVARCHAR(5) NOT NULL,
    [CreatedAt]             DATETIME2 (7)  NOT NULL DEFAULT GetDate(),
    [Email]                 NVARCHAR (MAX) NOT NULL,
    [Fax]                   NVARCHAR (MAX) NULL DEFAULT NULL,
    [Phone]                 NVARCHAR (MAX) NOT NULL,
    [TaxRegisteredNumber]   NVARCHAR (MAX) NULL DEFAULT NULL,
    [Website]               NVARCHAR (MAX) NULL DEFAULT NULL,
    [LastUpdated] DATETIME2 NOT NULL, 
    CONSTRAINT [PK_BaseCompany] PRIMARY KEY CLUSTERED ([BaseCompanyId] ASC),
    CONSTRAINT [FK_BaseCompany_City_CityId] FOREIGN KEY ([CityId]) REFERENCES City([CityId])
)
