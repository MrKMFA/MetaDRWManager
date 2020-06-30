CREATE PROCEDURE [dbo].[spJobtype_Update]
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
			UPDATE [dbo].[Jobtype]
			SET
				JobtypeName = @JobtypeName,
				JobtypeDescription = @JobtypeDescription,
				Rate = @Rate,
				ModifiedDate = @ModifiedDate
			WHERE
				JobtypeId = @JobtypeId
				SET @Rowcount = @@ROWCOUNT;
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
