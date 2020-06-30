CREATE PROCEDURE [dbo].[spTax_Insert]
	@TaxId nvarchar(14),
	@TaxLabel nvarchar(10),
	@TaxPerc decimal(3,2),
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
		INSERT INTO [dbo].[Tax]
			(TaxId, TaxLabel, TaxPerc, CreatedAt, ModifiedDate)
		VALUES
			(@TaxId, @TaxLabel, @TaxPerc, @CreatedAt, @ModifiedDate)
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
END
