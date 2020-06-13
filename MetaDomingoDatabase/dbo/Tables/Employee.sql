CREATE TABLE [dbo].[Employee]
(
	[EmployeeId]            NVARCHAR (450) NOT NULL,
    [AdditionalInformation] NVARCHAR (MAX) NULL DEFAULT NULL,
    [AddressLine1]          NVARCHAR(MAX) NOT NULL, 
    [AddressLine2]          NVARCHAR(MAX) NULL DEFAULT NULL, 
    [CityId]                NVARCHAR(450) NOT NULL, 
    [PostCode]              NVARCHAR(5) NOT NULL,
    [ContactName]           NVARCHAR (MAX) NOT NULL,
    [CreatedAt]             DATETIME2 (7)  NOT NULL DEFAULT GetDate(),
    [EmployeeFName]         NVARCHAR (MAX) NOT NULL,
    [EmployeeSName]         NVARCHAR (MAX) NOT NULL,
    [Email]                 NVARCHAR (MAX) NOT NULL,
    [Fax]                   NVARCHAR (MAX) NULL DEFAULT NULL,
    [Phone]                 NVARCHAR (MAX) NOT NULL,
    [TaxRegisteredNumber]   NVARCHAR (MAX) NULL DEFAULT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [FK_Employee_City_CityId] FOREIGN KEY ([CityId]) REFERENCES City([CityId])
);
