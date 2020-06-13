CREATE TABLE [dbo].[EmployeeJobcard]
(
	[EmployeeJobcardId]     NVARCHAR(450) NOT NULL,
    [JobcardId]             NVARCHAR(450) NOT NULL,
    [EmployeeId]            NVARCHAR(450) NOT NULL,
    [CreatedBy]             NVARCHAR(450) NOT NULL,
    [CreatedAt]             DATETIME2 NOT NULL, 
    [AssignedStartDate]     DATETIME2 NOT NULL, 
    [AssignedEndDate]       DATETIME2 NULL DEFAULT NULL, 
    CONSTRAINT [PK_EmployeeJobcard] PRIMARY KEY CLUSTERED ([EmployeeJobcardId] ASC),
    CONSTRAINT [FK_EmployeeJobcard_Employee_EmployeeId] FOREIGN KEY (EmployeeId) REFERENCES Employee(EmployeeId),
    CONSTRAINT [FK_EmployeeJobcard_Jobcard_JobcardId] FOREIGN KEY (JobcardId) REFERENCES Jobcard(JobcardId)
)
