CREATE PROCEDURE [dbo].[spCurrency_Insert]
	@CurrencyId nvarchar(14),
	@CurrencySymbol nvarchar(5),
	@CurrencyName nvarchar(50),
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
		INSERT INTO [dbo].[Currency]
			(CurrencyId, CurrencySymbol, CurrencyName, CreatedAt, ModifiedDate)
		VALUES
			(@CurrencyId, @CurrencySymbol, @CurrencyName, @CreatedAt, @ModifiedDate)
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