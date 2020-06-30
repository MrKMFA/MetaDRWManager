CREATE PROCEDURE [dbo].[spBusinessEntity_Update]
	@EntityId nvarchar(14),
	@ContactName nvarchar(50),
	@Email nvarchar(256),
	@Phone nvarchar(13),
	@TaxRegNum nvarchar(14),
	@WebURL nvarchar(256),
	@AddrLine1 nvarchar(max),
	@AddrLine2 nvarchar(max),
	@CityId nvarchar(14),
	@PostCode nvarchar(4),
	@AdditionInfo nvarchar(max),
	@Modified datetime2(7)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE [dbo].[BusinessEntity]
			SET
				ContactName = @ContactName,
				Email = @Email,
				Phone = @Phone,
				TaxRegistrationNumber = @TaxRegNum,
				WebsiteUrl = @WebURL,
				AddressLine1 = @AddrLine1,
				AddressLine2 = @AddrLine2,
				CityId = @CityId,
				PostCode = @PostCode,
				AdditionalInfo = @AdditionInfo,
				ModifiedDate = @Modified
			WHERE
				EntityId = @EntityId
				SET @Rowcount = @@ROWCOUNT;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
	--Err..something went wrong
	--Rollback any active or uncommited transactions
		IF @@TRANCOUNT > 0
		BEGIN 
			ROLLBACK TRANSACTION;
		END
	END CATCH;
END
Return @Rowcount;
