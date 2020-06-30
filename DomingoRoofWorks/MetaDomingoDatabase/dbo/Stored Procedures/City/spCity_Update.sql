CREATE PROCEDURE [dbo].[spCity_Update]
	@CityId nvarchar(14),
	@CityCode nvarchar(10),
	@CityName nvarchar(50),
	@CreatedAt datetime2(7),
	@ModifiedDate datetime2(7)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[City]
			SET
				CityCode = @CityCode,
				CityName = @CityName,
				ModifiedDate = @ModifiedDate
			WHERE
				CityId = @CityId
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
