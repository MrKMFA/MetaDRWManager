CREATE TABLE [dbo].[City]
(
	[CityId]    NVARCHAR(450) NOT NULL, 
    [CreatedAt]     DATETIME2     NOT NULL DEFAULT GetDate(), 
    [CityCode]  NVARCHAR(MAX) NOT NULL, 
    [CityName]  NVARCHAR(MAX) NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([CityId] ASC)
)
