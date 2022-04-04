CREATE TABLE [dbo].[Products] (
    [ProductId]   INT           IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (200) NOT NULL,
    [Description] VARCHAR (500) NOT NULL,
    [Price]       DECIMAL (18)  NOT NULL,
    [CreateDate]  DATETIME2 (7) CONSTRAINT [DF_Products_Create_Date] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

