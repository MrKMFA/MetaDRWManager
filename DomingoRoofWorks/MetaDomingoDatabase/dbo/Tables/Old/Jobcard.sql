CREATE TABLE [dbo].[Jobcard]
(
	[JobcardId]     NVARCHAR(450) NOT NULL, 
    [CreatedBy]     NVARCHAR(450) NOT NULL,
    [CreatedAt]     DATETIME2 NOT NULL,
    [CustomerId]    NVARCHAR(450) NOT NULL, 
    [JobtypeId]     NVARCHAR(450) NOT NULL, 
    [StartDate]     DATETIME2 NOT NULL, 
    [EndDate]       DATETIME2 NOT NULL, 
    CONSTRAINT [PK_Jobcard] PRIMARY KEY CLUSTERED ([JobcardId] ASC),
    CONSTRAINT [FK_Jobcard_Customer_CustomerId] FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId), 
    CONSTRAINT [FK_Jobcard_Employee_CreatedBy] FOREIGN KEY (CreatedBy) REFERENCES Employee(EmployeeId), 
    CONSTRAINT [FK_Jobcard_Jobtype_JobtypeId] FOREIGN KEY (JobtypeId) REFERENCES Jobtype(JobtypeId)
);
