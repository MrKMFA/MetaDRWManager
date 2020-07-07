CREATE PROCEDURE [dbo].[spBusinessEntity_GetAll]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		EntityId,
		ContactName,
		Email,
		Phone,
		TaxRegistrationNumber,
		WebsiteUrl,
		AddressLine1,
		AddressLine2,
		CityId,
		PostCode,
		AdditionalInfo,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[BusinessEntity]

END;
