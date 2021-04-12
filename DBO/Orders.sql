CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TableId] INT NOT NULL, 
    [completed] BIT NOT NULL
)
