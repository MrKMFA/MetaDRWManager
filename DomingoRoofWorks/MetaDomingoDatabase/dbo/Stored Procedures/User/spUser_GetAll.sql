CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT Id, FirstName, LastName, EmailAddress, CreatedDate
	FROM [dbo].[User]

END;
