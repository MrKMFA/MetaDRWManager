CREATE PROCEDURE [dbo].[spCity_Delete]
	@CityId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM [dbo].[City]
	WHERE CityId = @CityId;

END;
