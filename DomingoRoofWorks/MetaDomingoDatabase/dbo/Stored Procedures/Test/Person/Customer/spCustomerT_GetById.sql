﻿CREATE PROCEDURE [dbo].[spCustomerT_GetById]

	@CustomerId nvarchar(14)

AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		c.CustomerId,
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
		[dbo].[Customer] c
		INNER JOIN [dbo].[Person] p
			ON p.PersonId = c.PersonId
		INNER JOIN [dbo].[BusinessEntity] b
			ON b.EntityId = p.EntityId
	WHERE
		c.CustomerId = @CustomerId;
END;
