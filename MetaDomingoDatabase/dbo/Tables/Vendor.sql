CREATE TABLE [dbo].[Vendor]
(
	[VendorId]              NVARCHAR (450) NOT NULL,
    [AdditionalInformation] NVARCHAR (MAX) NULL DEFAULT NULL,
    [AddressLine1]          NVARCHAR(MAX) NOT NULL, 
    [AddressLine2]          NVARCHAR(MAX) NULL DEFAULT NULL, 
    [CityId]                NVARCHAR(450) NOT NULL, 
    [PostCode]              NVARCHAR(5) NOT NULL,
    [ContactName]           NVARCHAR (MAX) NOT NULL,
    [CreatedAt]             DATETIME2 (7)  NOT NULL DEFAULT GetDate(),
    [Email]                 NVARCHAR (MAX) NOT NULL,
    [Fax]                   NVARCHAR (MAX) NULL DEFAULT NULL,
    [Phone]                 NVARCHAR (MAX) NOT NULL,
    [TaxRegisteredNumber]   NVARCHAR (MAX) NULL DEFAULT NULL,
    [VendorName]            NVARCHAR (MAX) NOT NULL,
    [Website]               NVARCHAR (MAX) NULL DEFAULT NULL,
    CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED ([VendorId] ASC),
    CONSTRAINT [FK_Vendor_City_CityId] FOREIGN KEY ([CityId]) REFERENCES City([CityId])
);
