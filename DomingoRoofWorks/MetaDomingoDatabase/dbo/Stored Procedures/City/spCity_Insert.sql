CREATE PROCEDURE [dbo].[spCity_Insert]
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

		--Insert into table
		INSERT INTO [dbo].[City]
			(CityId, CityCode, CityName, CreatedAt, ModifiedDate)
		VALUES
			(@CityId, @CityCode, @CityName, @CreatedAt, @ModifiedDate)
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