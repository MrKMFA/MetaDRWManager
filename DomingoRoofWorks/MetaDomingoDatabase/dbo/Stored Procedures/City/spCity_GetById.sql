CREATE PROCEDURE [dbo].[spCity_GetById]
	@CityId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		CityId,
		CityCode,
		CityName,
		CreatedAt,
		ModifiedDate
	FROM
		[dbo].[City]
	WHERE
		CityId = @CityId

END;
