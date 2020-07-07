CREATE PROCEDURE [dbo].[spPersonT_GetById]

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
