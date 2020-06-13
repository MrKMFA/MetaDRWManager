CREATE FUNCTION [dbo].[udfGetJobcardEmployees]
(
	@JobcardId nvarchar(450)
)
RETURNS @retEmployeesAssigned TABLE
(
	EmployeeId nvarchar(450),
	CreatedBy nvarchar(450),
	CreatedAt datetime2(7),
	AssignedStartDate datetime2(7),
	AssignedEndDate datetime2(7),
	EmployeeFName nvarchar(max),
	EmployeeSName nvarchar(max),
	Phone nvarchar(max)
)
AS
BEGIN
	IF @JobcardId IS NOT NULL
		BEGIN
		IF EXISTS(SELECT * FROM [EmployeeJobcard] x
					WHERE x.JobcardId = @JobcardId)
			INSERT INTO  @retEmployeesAssigned
				SELECT
					x.EmployeeId,
					x.CreatedBy,
					x.CreatedAt,
					x.AssignedStartDate,
					x.AssignedEndDate,
					e.EmployeeFName,
					e.EmployeeSName,
					e.Phone
				FROM [Employee] AS e
					INNER JOIN [EmployeeJobcard] x
					ON e.EmployeeId = x.EmployeeId
				WHERE x.JobcardId = @JobcardId
		END
	RETURN;
END;
