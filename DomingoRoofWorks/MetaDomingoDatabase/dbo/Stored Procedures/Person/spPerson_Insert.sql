CREATE PROCEDURE [dbo].[spPerson_Insert]
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
	@Modified datetime2(7),
	@PersonId nvarchar(14),
	@FName nvarchar(50),
	@LName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION
		--execute sproc to insert businessEntity
		EXEC @Rowcount = spBusinessEntity_Insert @EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
				@WebsiteUrl, @AddrLine1, @AddrLine2, @CityId, @PostCode, 
				@AdditionInfo, @CreatedAt, @Modified;
		IF @Rowcount > 0
			-- Insert Person
			INSERT INTO [dbo].[Person]
				(PersonId, EntityId, FirstName, LastName)
			VALUES(@PersonId, @EntityId, @FName, @LName)
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
