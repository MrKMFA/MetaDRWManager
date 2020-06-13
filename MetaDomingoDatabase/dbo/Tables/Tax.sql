﻿CREATE TABLE [dbo].[Tax]
(
	[TaxId]     NVARCHAR (450) NOT NULL,
    [CreatedAt] DATETIME2 (7)  NOT NULL DEFAULT GetDate(),
    [TaxLabel]  NVARCHAR (MAX) NOT NULL,
    [TaxRate]   DECIMAL (3,2)  NOT NULL DEFAULT 1.15,
    CONSTRAINT [PK_Tax] PRIMARY KEY CLUSTERED ([TaxId] ASC)
)
