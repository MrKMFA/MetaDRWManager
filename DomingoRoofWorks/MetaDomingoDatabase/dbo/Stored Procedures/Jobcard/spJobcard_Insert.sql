CREATE PROCEDURE [dbo].[spJobcard_Insert]
	@JobcardId nvarchar(14),
	@CreatedBy nvarchar(14),
	@CustomerId nvarchar(14),
	@JobtypeId nvarchar(14),
	@JobStartDate datetime2(7),
	@JobEndDate datetime2(7),
	@CreatedAt datetime2(7),
	@ModifiedDate datetime2(7)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION

		--Insert into table
		INSERT INTO [dbo].[Jobcard]
			(JobcardId, CreatedBy, CustomerId, JobtypeId, JobStartDate,
				JobEndDate, CreatedAt, ModifiedDate)
		VALUES
			(@JobcardId, @CreatedBy, @CustomerId, @JobtypeId, @JobStartDate,
				@JobEndDate, @CreatedAt, @ModifiedDate)
			SET @Rowcount = @@ROWCOUNT

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
	--Err..something went wrong
	--Rollback any active or uncommited transactions
		IF @@TRANCOUNT > 0
		BEGIN 
			ROLLBACK TRANSACTION;
		END
	END CATCH;
END;
