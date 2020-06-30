CREATE PROCEDURE [dbo].[spTax_GetById]
	@TaxId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		TaxId,
		TaxLabel,
		TaxPerc,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[Tax]
	WHERE
		TaxId = @TaxId;
END;
