CREATE PROCEDURE [dbo].[spJobtype_Insert]
	@JobtypeId nvarchar(14),
	@JobtypeName nvarchar(50),
	@JobtypeDescription nvarchar(max),
	@Rate money,
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
		INSERT INTO [dbo].[Jobtype]
			(JobtypeId, JobtypeName, JobtypeDescription, Rate, CreatedAt, ModifiedDate)
		VALUES
			(@JobtypeId, @JobtypeName, @JobtypeDescription, @Rate, @CreatedAt, @ModifiedDate)
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