CREATE PROCEDURE [dbo].[spJobcard_GetById]
	@JobcardId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		JobcardId,
		CreatedBy,
		CustomerId,
		JobtypeId,
		JobStartDate,
		JobEndDate,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[Jobcard]
	WHERE
		JobcardId = @JobcardId;
END;
