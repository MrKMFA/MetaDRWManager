CREATE PROCEDURE [dbo].[spBusinessEntity_Delete]
	@EntityId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM [dbo].[BusinessEntity]
	WHERE EntityId = @EntityId;
END;
