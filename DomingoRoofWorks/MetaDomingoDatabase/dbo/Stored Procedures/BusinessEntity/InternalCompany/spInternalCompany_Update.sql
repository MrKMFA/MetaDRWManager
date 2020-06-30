CREATE PROCEDURE [dbo].[spInternalCompany_Update]
	@InternalCompanyId nvarchar(14),
	@InternalCompanyName nvarchar(50),
	@EntityId nvarchar(14),
	@ContactName nvarchar(50),
	@Email nvarchar(256),
	@Phone nvarchar(13),
	@TaxRegNum nvarchar(14),
	@WebsiteURL nvarchar(256),
	@AddrLine1 nvarchar(max),
	@AddrLine2 nvarchar(max),
	@CityId nvarchar(14),
	@PostCode nvarchar(4),
	@AdditionInfo nvarchar(max),
	@CreatedAt datetime2(7),
	@Modified datetime2(7)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION
		--Execute sproc to update businessEntity
		EXEC @Rowcount = spBusinessEntity_Update @EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
				@WebsiteUrl, @AddrLine1, @AddrLine2, @CityId, @PostCode, 
				@AdditionInfo, @Modified;
		IF @Rowcount > 0
			-- Update InternalCompany
			UPDATE [dbo].[InternalCompany]
			SET
				InternalCompanyName = @InternalCompanyName
			WHERE
				InternalCompanyId = @InternalCompanyId
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
END;
