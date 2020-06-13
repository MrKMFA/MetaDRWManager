CREATE TABLE [dbo].[Customer]
(
	[CustomerId]            NVARCHAR (450) NOT NULL,
    [AdditionalInformation] NVARCHAR (MAX) NULL DEFAULT NULL,
    [AddressLine1]          NVARCHAR(MAX) NOT NULL, 
    [AddressLine2]          NVARCHAR(MAX) NULL DEFAULT NULL, 
    [CityId]                NVARCHAR(450) NOT NULL, 
    [PostCode]              NVARCHAR(5) NOT NULL,
    [ContactName]           NVARCHAR (MAX) NOT NULL,
    [CreatedAt]             DATETIME2 (7)  NOT NULL DEFAULT GetDate(),
    [CustomerFName]         NVARCHAR (MAX) NOT NULL,
    [CustomerSName]         NVARCHAR (MAX) NOT NULL,
    [Email]                 NVARCHAR (MAX) NOT NULL,
    [Fax]                   NVARCHAR (MAX) NULL DEFAULT NULL,
    [Phone]                 NVARCHAR (MAX) NOT NULL,
    [TaxRegisteredNumber]   NVARCHAR (MAX) NULL DEFAULT NULL,
    [Website]               NVARCHAR (MAX) NULL DEFAULT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customer_City_CityId] FOREIGN KEY ([CityId]) REFERENCES City([CityId])
)
