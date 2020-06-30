CREATE PROCEDURE [dbo].[spCurrency_Update]
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
			UPDATE [dbo].[Currency]
			SET
				CurrencySymbol = @CurrencySymbol,
				CurrencyName = @CurrencyName,
				ModifiedDate = @ModifiedDate
			WHERE
				CurrencyId = @CurrencyId
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
