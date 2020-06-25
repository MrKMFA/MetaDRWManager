CREATE TABLE [dbo].[Jobcard]
(
	[JobcardId]		NVARCHAR(14)	PRIMARY KEY NOT NULL,
	[CreatedBy]		NVARCHAR(14)	NOT NULL,
	[CustomerId]	NVARCHAR(14)	NOT NULL,
	[JobtypeId]		NVARCHAR(14)	NOT NULL,
	[JobStartDate]	DATETIME2(7)	NOT NULL,
	[JobEndDate]	DATETIME2(7)	NOT NULL,
	[CreatedAt]		DATETIME2(7)	NOT NULL,
	[ModifiedDate]	DATETIME2(7)	NOT NULL,
	CONSTRAINT [FK_Jobcard_ToEmployee] FOREIGN KEY (CreatedBy) REFERENCES Employee(EmployeeId),
	CONSTRAINT [FK_Jobcard_ToCustomer] FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
	CONSTRAINT [FK_Jobcard_ToJobtype] FOREIGN KEY (JobtypeId) REFERENCES Jobtype(JobtypeId)
)
