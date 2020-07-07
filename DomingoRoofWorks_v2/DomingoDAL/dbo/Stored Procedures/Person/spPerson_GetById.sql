CREATE PROCEDURE [dbo].[spPerson_GetById]
	@PersonId NVARCHAR(14)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		PersonId,
		EntityId,
		FirstName,
		LastName
	FROM
		[dbo].[Person]
	WHERE
		PersonId = @PersonId;
END;
