CREATE PROCEDURE [dbo].[spVendor_GetById]

	@VendorId NVARCHAR(14)

WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		v.VendorId,
		v.VendorName,
		b.EntityId,
		b.ContactName,
		b.Email,
		b.Phone,
		b.TaxRegistrationNumber,
		b.WebsiteUrl,
		b.AddressLine1,
		b.AddressLine2,
		b.CityId,
		b.PostCode,
		b.AdditionalInfo,
		b.CreatedAt,
		b.ModifiedDate
	FROM
		[dbo].[Vendor] v
	INNER JOIN [dbo].[BusinessEntity] b
		ON
			v.EntityId = b.EntityId
	WHERE 
		v.VendorId = @VendorId;

END;
