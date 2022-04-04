CREATE TABLE [dbo].[Customers] (
    [CustomerId]     INT           IDENTITY (1, 1) NOT NULL,
    [Fullname]       VARCHAR (100) NOT NULL,
    [Email]          VARCHAR (50)  NOT NULL,
    [Password]       VARCHAR (8)   NOT NULL,
    [BillingAddress] VARCHAR (100) NOT NULL,
    [CountryId]      INT           NOT NULL,
    [Phone]          VARCHAR (10)  NOT NULL,
    [CreateDate]     DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

