CREATE TABLE [dbo].[ConsumeableOrder]
(
	[orderId] INT NOT NULL PRIMARY KEY, 
    [consumeableId] INT NOT NULL, 
    [remarks] NVARCHAR(MAX) NULL, 
    [price] MONEY NOT NULL, 
    [ready] BIT NOT NULL
)
