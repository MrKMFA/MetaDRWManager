CREATE FUNCTION [dbo].[udfGetJobcardMaterials]
(
	@JobcardId nvarchar(450)
)
RETURNS @retMaterialsUsed TABLE
(
	ItemId nvarchar(450),
	ItemName nvarchar(max),
	ItemDescription nvarchar(max),
	Quantity int,
	CreatedAt datetime2
)
AS
BEGIN
	IF @JobcardId IS NOT NULL
		BEGIN
		IF EXISTS(SELECT * FROM [JobcardMaterial] x
					WHERE x.JobcardId = @JobcardId)
			INSERT INTO  @retMaterialsUsed
				SELECT
					i.ItemId,
					i.[ItemName],
					i.[ItemDescription],
					x.Quantity,
					x.CreatedAt
				FROM [Item] AS i
					INNER JOIN [JobcardMaterial] x
					ON i.ItemId = x.ItemId
				WHERE x.JobcardId = @JobcardId
		END
	RETURN;
END;
