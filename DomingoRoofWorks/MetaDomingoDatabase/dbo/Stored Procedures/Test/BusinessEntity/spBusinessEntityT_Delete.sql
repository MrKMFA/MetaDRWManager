CREATE PROCEDURE [dbo].[spBusinessEntityT_Delete]
	@EntityId nvarchar(14)
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM [dbo].[BusinessEntity]
	WHERE EntityId = @EntityId;
END;
