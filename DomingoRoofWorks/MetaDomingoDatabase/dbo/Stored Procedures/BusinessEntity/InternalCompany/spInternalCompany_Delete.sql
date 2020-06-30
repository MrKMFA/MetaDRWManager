CREATE PROCEDURE [dbo].[spInternalCompany_Delete]
	@InternalCompanyId nvarchar(14),
	@EntityId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @Rowcount int

	EXEC @Rowcount = spBusinessEntity_Delete @EntityId

	DELETE FROM [dbo].[InternalCompany]
	WHERE InternalCompanyId = @InternalCompanyId;

END;
