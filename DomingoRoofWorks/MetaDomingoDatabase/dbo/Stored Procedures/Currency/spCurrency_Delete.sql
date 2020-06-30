CREATE PROCEDURE [dbo].[spCurrency_Delete]
	@CurrencyId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM [dbo].[Currency]
	WHERE CurrencyId = @CurrencyId;
END;
