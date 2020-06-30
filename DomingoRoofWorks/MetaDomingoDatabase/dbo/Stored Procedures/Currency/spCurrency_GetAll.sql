CREATE PROCEDURE [dbo].[spCurrency_GetAll]

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
END;

