CREATE TABLE [dbo].[Customer]
(
	[CustomerId]	NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[PersonId]		NVARCHAR(14)    NOT NULL,
	CONSTRAINT [FK_Customer_ToPerson] FOREIGN KEY (PersonId) REFERENCES Person(PersonId)
)
