CREATE PROCEDURE [dbo].[spPerson_GetAll]
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
END;
