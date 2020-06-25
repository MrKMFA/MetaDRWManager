CREATE TABLE [dbo].[Tax]
(
	[TaxId]           NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[TaxLabel]        NVARCHAR(10)		NOT NULL	,
	[TaxPerc]		  DECIMAL(3,2)		NOT NULL	,
	[CreatedAt]       DATETIME2(7)		NOT NULL	,
    [ModifiedDate]    DATETIME2(7)		NOT NULL
)
