CREATE PROCEDURE [dbo].[spEmployee_Update]
	@EntityId nvarchar(14),
	@ContactName nvarchar(50),
	@Email nvarchar(256),
	@Phone nvarchar(13),
	@TaxRegNum nvarchar(14),
	@WebsiteUrl nvarchar(256),
	@AddrLine1 nvarchar(max),
	@AddrLine2 nvarchar(max),
	@CityId nvarchar(14),
	@PostCode nvarchar(4),
	@AdditionInfo nvarchar(max),
	@Modified datetime2(7),
	@PersonId nvarchar(14),
	@FName nvarchar(50),
	@LName nvarchar(50),
	@EmployeeId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION
		--Execute sproc to update person
		EXEC @Rowcount = spPerson_Update @EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
				@WebsiteUrl, @AddrLine1, @AddrLine2, @CityId, @PostCode, @AdditionInfo, @Modified,
				@PersonId, @FName, @LName;
		--IF @Rowcount > 0
		--	-- Update Employee
		--	UPDATE [dbo].[Employee]
		--	SET
		--		--attributes
		--	WHERE
		--		EmployeeId = @EmployeeId
		--		SET @Rowcount = @@ROWCOUNT;

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
