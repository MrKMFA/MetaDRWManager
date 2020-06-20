CREATE TABLE [dbo].[Jobtype]
(
	[JobtypeId]          NVARCHAR (450)  NOT NULL,
    [CreatedAt]          DATETIME2 (7)   NOT NULL,
    [CurrencyId]         NVARCHAR (450)  NOT NULL,
    [JobtypeDescription] NVARCHAR (MAX)  NOT NULL,
    [JobtypeName]        NVARCHAR (MAX)  NOT NULL,
    [Rate]               MONEY NOT NULL,
    [TaxId]              NVARCHAR (450)  NOT NULL,
    [LastUpdated]        DATETIME2 (7)   NOT NULL,
    CONSTRAINT [PK_Jobtype] PRIMARY KEY CLUSTERED ([JobtypeId] ASC),
    CONSTRAINT [FK_Jobtype_Currency_CurrencyId] FOREIGN KEY ([CurrencyId]) REFERENCES [dbo].[Currency] ([CurrencyId]),
    CONSTRAINT [FK_Jobtype_Tax_TaxId] FOREIGN KEY ([TaxId]) REFERENCES [dbo].[Tax] ([TaxId])
);