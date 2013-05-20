CREATE TABLE [dbo].[Catalog] (
    [CatalogId]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [SiteId]           BIGINT         NOT NULL,
    [CatalogCode]      NVARCHAR (50)  NOT NULL,
    [CatalogName]      NVARCHAR (200) NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([CatalogId] ASC),
    CONSTRAINT [FK_Catalog_Site] FOREIGN KEY ([SiteId]) REFERENCES [dbo].[Site] ([SiteId])
);

