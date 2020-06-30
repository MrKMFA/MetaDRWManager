CREATE PROCEDURE [dbo].[spPerson_GetById]

	@PersonId NVARCHAR(14)

WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		p.PersonId,
		b.EntityId,
		p.FirstName,
		p.LastName,
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
		[dbo].[Person] p
	INNER JOIN [dbo].[BusinessEntity] b
		ON
			p.EntityId = b.EntityId
	WHERE
		p.PersonId = @PersonId;
END;
