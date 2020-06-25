CREATE TABLE [dbo].[JobcardItem]
(
	[JobcardItemId]		NVARCHAR(14)	PRIMARY KEY NOT NULL,
	[JobcardId]			NVARCHAR(14)	NOT NULL,
	[ItemId]			NVARCHAR(14)	NOT NULL,
	[Quantity]			INT				NOT NULL,
	[CreatedAt]			DATETIME2(2)	NOT NULL,
	[ModifiedDate]		DATETIME2(2)	NOT NULL,
	CONSTRAINT [FK_JobcardItem_ToJobcard] FOREIGN KEY (JobcardId) REFERENCES Jobcard(JobcardId),
	CONSTRAINT [FK_JobcardItem_ToItem] FOREIGN KEY (ItemId) REFERENCES Item(ItemId)
)
