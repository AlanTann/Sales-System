CREATE TABLE [dbo].[Table]
(
	[Product Name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Type] VARCHAR(50) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Discount] DECIMAL NOT NULL, 
    [GST ID] INT NOT NULL DEFAULT 0, 
    [Product Quantity] INT NOT NULL DEFAULT 0
)
