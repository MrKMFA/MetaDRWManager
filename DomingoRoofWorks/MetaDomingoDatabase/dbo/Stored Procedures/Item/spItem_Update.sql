CREATE PROCEDURE [dbo].[spItem_Update]
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
			UPDATE [dbo].[Item]
			SET
				ItemName = @ItemName,
				ItemDescription = @ItemDescription,
				VendorId = @VendorId,
				PreferredVendor = @PreferredVendor,
				CostPrice = @CostPrice,
				MarkupPerc = @MarkupPerc,
				ModifiedDate = @ModifiedDate
			WHERE
				ItemId = @ItemId
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
