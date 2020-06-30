CREATE PROCEDURE [dbo].[spItem_Insert]
	@ItemId nvarchar(14),
	@ItemName nvarchar(50),
	@ItemDescription nvarchar(max),
	@VendorId nvarchar(14),
	@PreferredVendor bit,
	@CostPrice money, 
	@MarkupPerc decimal(3,2),
	@CreatedAt datetime2(7),
	@ModifiedDate datetime2(7)
WITH EXECUTE AS CALLER
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Rowcount int = -1

	BEGIN TRY
		BEGIN TRANSACTION

		--Insert into table
		INSERT INTO [dbo].[Item]
			(ItemId, ItemName, ItemDescription, VendorId, PreferredVendor,
				CostPrice, MarkupPerc, CreatedAt, ModifiedDate)
		VALUES
			(@ItemId, @ItemName, @ItemDescription, @VendorId, @PreferredVendor,
				@CostPrice, @MarkupPerc, @CreatedAt, @ModifiedDate)
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