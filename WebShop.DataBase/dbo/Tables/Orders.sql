CREATE TABLE [dbo].[Orders] (
    [OrderId]         INT           IDENTITY (1, 1) NOT NULL,
    [CustomerId]      INT           NOT NULL,
    [OrderStatus]     INT           NOT NULL,
    [OrderDate]       DATETIME2 (7) NOT NULL,
    [OrderEmail]      VARCHAR (50)  NOT NULL,
    [OrderAddress]    VARCHAR (100) NOT NULL,
    [ShippingAddress] VARCHAR (100) NOT NULL,
    [Ammount]         DECIMAL (18)  NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

