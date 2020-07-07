CREATE PROCEDURE [dbo].[spPerson_Delete]
	
	@PersonId nvarchar(14),
	@EntityId nvarchar(14)

AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @Rowcount int

	EXEC @Rowcount = spBusinessEntity_Delete @EntityId

	DELETE FROM [dbo].[Person]
	WHERE PersonId = @PersonId;

END;
