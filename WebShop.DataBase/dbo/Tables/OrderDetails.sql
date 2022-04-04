CREATE TABLE [dbo].[OrderDetails] (
    [OrderDetailId] INT          IDENTITY (1, 1) NOT NULL,
    [OrderId]       INT          NOT NULL,
    [ProductId]     INT          NOT NULL,
    [Price]         DECIMAL (18) NOT NULL,
    [Quantity]      INT          NOT NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED ([OrderDetailId] ASC),
    CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]),
    CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId])
);

