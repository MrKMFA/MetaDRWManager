CREATE PROCEDURE [dbo].[spCustomer_GetById]
	@CustomerId nvarchar(14)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT
		CustomerId,
		PersonId
	FROM
		[dbo].[Customer]
	WHERE
		CustomerId = @CustomerId;
END;
