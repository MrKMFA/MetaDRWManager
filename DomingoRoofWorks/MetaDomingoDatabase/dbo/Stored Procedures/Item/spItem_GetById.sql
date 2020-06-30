CREATE PROCEDURE [dbo].[spItem_GetById]
	@ItemId nvarchar(14)
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
	WHERE
		ItemId = @ItemId;
END;
