﻿CREATE PROCEDURE [dbo].[spPerson_Insert]
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
	@LName nvarchar(50),
	@Created datetime2(7),
	@Mod datetime2(7)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int

	BEGIN TRY
		BEGIN TRANSACTION
		--execute sproc to insert businessEntity
		EXEC @Rowcount = spBusinessEntity_Insert @EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
				@WebsiteUrl, @AddrLine1, @AddrLine2, @CityId, @PostCode, 
				@AdditionInfo, @CreatedAt, @Modified;
		IF @Rowcount > 0
			-- Insert Person
			INSERT INTO [dbo].[Person]
				(PersonId, EntityId, FirstName, LastName, CreatedAt, ModifiedDate)
			VALUES(@PersonId, @EntityId, @FName, @LName, @Created, @Mod)
				SET @Rowcount = @@ROWCOUNT;

			COMMIT TRANSACTION;

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