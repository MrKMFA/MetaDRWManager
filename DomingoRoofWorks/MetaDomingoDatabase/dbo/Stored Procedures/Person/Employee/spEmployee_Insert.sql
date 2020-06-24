CREATE PROCEDURE [dbo].[spEmployee_Insert]
@EntityId nvarchar(14),
	@ContactName nvarchar(50),
	@Email nvarchar(256),
	@Phone nvarchar(13),
	@TaxRegNum nvarchar(14),
	@Website nvarchar(256),
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
	@Mod datetime2(7), 
	@EmployeeId nvarchar(14)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int

	BEGIN TRY
		BEGIN TRANSACTION
		--execute sproc to insert person data
		EXEC @Rowcount = spPerson_Insert @EntityId, @ContactName, @Email, @Phone, @TaxRegNum,
				@Website, @AddrLine1, @AddrLine2, @CityId, @PostCode, 
				@AdditionInfo, @CreatedAt, @Modified, @PersonId, @LName, @FName, @Created, @Mod;
		IF @Rowcount > 0
			-- Insert employee
			INSERT INTO [dbo].[Employee](EmployeeId, PersonId)
			VALUES(@EmployeeId, @PersonId);
			COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
	--Err..something went wrong
	--Rollback any active or uncommited transactions
		BEGIN 
			ROLLBACK TRANSACTION;
		END
	END CATCH;
END
Return @Rowcount;
