CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] NCHAR(10) NULL, 
    [InventoryID] NCHAR(10) NULL, 
    [MenuID] NCHAR(10) NULL, 
    [MenuPrice] NCHAR(10) NULL, 
    [MenuQuantity] NCHAR(10) NULL, 
    [OrderDate] NCHAR(10) NULL, 
    [OrderStatus] NCHAR(10) NULL
)
