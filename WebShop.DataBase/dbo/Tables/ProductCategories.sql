CREATE TABLE [dbo].[ProductCategories] (
    [ProductCategoryId] INT IDENTITY (1, 1) NOT NULL,
    [ProductId]         INT NOT NULL,
    [CategoryId]        INT NOT NULL,
    CONSTRAINT [PK_ProductCategories] PRIMARY KEY CLUSTERED ([ProductCategoryId] ASC),
    CONSTRAINT [FK_ProductCategories_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId]),
    CONSTRAINT [FK_ProductCategories_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId])
);

