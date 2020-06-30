CREATE PROCEDURE [dbo].[spItem_GetAll]

WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		ItemId,
		ItemName,
		ItemDescription,
		VendorId,
		PreferredVendor,
		CostPrice,
		MarkupPerc,
		UnitPrice
	FROM
		[dbo].[Item]

END;
