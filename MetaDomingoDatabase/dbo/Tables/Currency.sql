CREATE TABLE [dbo].[Currency]
(
	[CurrencyId]    NVARCHAR(450) NOT NULL, 
    [CreatedAt]     DATETIME2     NOT NULL DEFAULT GetDate(), 
    [CurrencyCode]  NVARCHAR(MAX) NOT NULL, 
    [CurrencyName]  NVARCHAR(MAX) NOT NULL,
    CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED ([CurrencyId] ASC)
);
