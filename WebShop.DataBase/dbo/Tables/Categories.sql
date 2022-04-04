CREATE TABLE [dbo].[Categories] (
    [CategoryId] INT          IDENTITY (1, 1) NOT NULL,
    [Category]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

