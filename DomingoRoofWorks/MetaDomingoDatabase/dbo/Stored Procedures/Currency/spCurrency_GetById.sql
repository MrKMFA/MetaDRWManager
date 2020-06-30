CREATE PROCEDURE [dbo].[spCurrency_GetById]
	@CurrencyId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		CurrencyId,
		CurrencySymbol,
		CurrencyCode,
		CurrencyName,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[Currency]
	WHERE
		CurrencyId = @CurrencyId
END;
