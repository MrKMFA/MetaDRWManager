CREATE PROCEDURE [dbo].[spCity_GetAll]

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

END;
