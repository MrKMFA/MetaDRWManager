CREATE PROCEDURE [dbo].[spItem_Delete]
	@ItemId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM [dbo].[Item]
	WHERE ItemId = @ItemId;

END;
