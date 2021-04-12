CREATE TABLE [dbo].[Consumeable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NOT NULL, 
    [discription] NVARCHAR(MAX) NOT NULL, 
    [type] INT NOT NULL, 
    [price] MONEY NOT NULL
)
