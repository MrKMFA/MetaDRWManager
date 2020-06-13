CREATE TABLE [dbo].[JobcardMaterial]
(
	[JobcardMaterialId]   NVARCHAR (450)  NOT NULL,
    [JobcardId]           NVARCHAR (450)  NOT NULL,
    [CreatedAt]           DATETIME2 (7)   NOT NULL,
    [ItemId]              NVARCHAR (450)  NOT NULL,
    [Quantity]            INT            NOT NULL,
    [TaxId]               NVARCHAR (450)  NOT NULL,
    CONSTRAINT [PK_JobcardMaterialId] PRIMARY KEY CLUSTERED ([JobcardMaterialId] ASC),
    CONSTRAINT [FK_JobcardMaterial_Item_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Item] ([ItemId]),
    CONSTRAINT [FK_JobcardMaterial_Jobcard_JobcardId] FOREIGN KEY ([JobcardId]) REFERENCES [dbo].[Jobcard] ([JobcardId]),
    CONSTRAINT [FK_JobcardMaterial_Tax_TaxId] FOREIGN KEY ([TaxId]) REFERENCES [dbo].[Tax] ([TaxId])
)
