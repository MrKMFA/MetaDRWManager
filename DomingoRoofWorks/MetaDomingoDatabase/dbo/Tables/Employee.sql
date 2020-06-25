CREATE TABLE [dbo].[Employee]
(
	[EmployeeId]	NVARCHAR(14)    PRIMARY KEY NOT NULL,
	[PersonId]		NVARCHAR(14)    NOT NULL,
	CONSTRAINT [FK_Employee_ToPerson] FOREIGN KEY (PersonId) REFERENCES Person(PersonId)
)
