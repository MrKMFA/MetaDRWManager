CREATE PROCEDURE [dbo].[spPersonT_GetAll]
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
