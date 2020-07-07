CREATE PROCEDURE [dbo].[spPersonT_Update]
	@EntityId nvarchar(14),
	@PersonId nvarchar(14),
	@FName nvarchar(50),
	@LName nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION
		--Execute sproc to update businessEntity
		--EXEC @Rowcount = spBusinessEntity_Update @EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
			--	@WebsiteUrl, @AddrLine1, @AddrLine2, @CityId, @PostCode, 
			--	@AdditionInfo, @Modified;
		--IF @Rowcount > 0
			-- Update Person
			UPDATE [dbo].[Person]
			SET
				FirstName = @FName,
				LastName = @LName
			WHERE
				PersonId = @PersonId
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
