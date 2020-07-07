CREATE PROCEDURE [dbo].[spCustomer_GetAll]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		CustomerId,
		PersonId
	FROM
		[dbo].[Customer]
END;
