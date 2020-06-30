CREATE PROCEDURE [dbo].[spTax_GetAll]

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
END;
