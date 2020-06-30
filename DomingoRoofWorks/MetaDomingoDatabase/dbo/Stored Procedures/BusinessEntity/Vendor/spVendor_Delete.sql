CREATE PROCEDURE [dbo].[spVendor_Delete]
	@VendorId nvarchar(14),
	@EntityId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @Rowcount int

	EXEC @Rowcount = spBusinessEntity_Delete @EntityId

	DELETE FROM [dbo].[Vendor]
	WHERE VendorId = @VendorId;

END;
