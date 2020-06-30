CREATE PROCEDURE [dbo].[spInternalCompany_GetAll]

WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		i.InternalCompanyId,
		i.InternalCompanyName,
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
		[dbo].[InternalCompany] i
	INNER JOIN [dbo].[BusinessEntity] b
		ON
			i.EntityId = b.EntityId;
END;
