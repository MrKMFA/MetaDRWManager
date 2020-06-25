CREATE TABLE [dbo].[JobcardEmployee]
(
	[JobcardEmployeeId]		NVARCHAR(14)	PRIMARY KEY NOT NULL,
	[JobcardId]				NVARCHAR(14)	NOT NULL,
	[EmployeeId]			NVARCHAR(14)	NOT NULL,
	[AssignedStartDate]		DATETIME2(2)	NOT NULL,
	[AssignedEndDate]		DATETIME2(2)	NOT NULL,
	[CreatedAt]				DATETIME2(2)	NOT NULL,
	[ModifiedDate]			DATETIME2(2)	NOT NULL,
	CONSTRAINT [FK_JobcardEmployee_ToJobcard] FOREIGN KEY (JobcardId) REFERENCES Jobcard(JobcardId),
	CONSTRAINT [FK_JobcardEmployee_ToEmployee] FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId)
)
