CREATE PROCEDURE [dbo].[spBusinessEntity_Insert]
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
	@CreatedAt datetime2(7),
	@Modified datetime2(7)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION

		--Insert into table
		INSERT INTO [dbo].[BusinessEntity]
			(EntityId, ContactName, Email, Phone, TaxRegistrationNumber,
				WebsiteUrl, AddressLine1, AddressLine2, CityId, PostCode, 
				AdditionalInfo, CreatedAt, ModifiedDate)
		VALUES
			(@EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
				@WebUrl, @AddrLine1, @AddrLine2, @CityId, @PostCode, 
				@AdditionInfo, @CreatedAt, @Modified)
			SET @Rowcount = @@ROWCOUNT

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
