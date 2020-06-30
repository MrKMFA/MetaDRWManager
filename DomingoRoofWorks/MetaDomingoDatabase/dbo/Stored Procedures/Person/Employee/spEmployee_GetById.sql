CREATE PROCEDURE [dbo].[spEmployee_GetById]

	@EmployeeId nvarchar(14)

WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		e.EmployeeId,
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
		[dbo].[Employee] e
		INNER JOIN [dbo].[Person] p
			ON p.PersonId = e.PersonId
		INNER JOIN [dbo].[BusinessEntity] b
			ON b.EntityId = p.EntityId
	WHERE
		e.EmployeeId = @EmployeeId;
END;
