CREATE TABLE [dbo].[Address] (
    [AddressId]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [SiteId]                BIGINT         NOT NULL,
    [AddressTypeId]         BIGINT         NOT NULL,
    [AddressLine1]          NVARCHAR (200) NULL,
    [AddressLine2]          NVARCHAR (200) NULL,
    [AddressLine3]          NVARCHAR (200) NULL,
    [City]                  NVARCHAR (100) NULL,
    [StateProvinceRegionId] BIGINT         NULL,
    [PostalCode]            NVARCHAR (50)  NULL,
    [CountryRegionId]       BIGINT         NULL,
    [CreatedDateTime]       DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]             NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]      DATETIME       NULL,
    [ModifiedBy]            NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [FK_Address_AddressType] FOREIGN KEY ([AddressTypeId]) REFERENCES [dbo].[AddressType] ([AddressTypeId]),
    CONSTRAINT [FK_Address_CountryRegion] FOREIGN KEY ([CountryRegionId]) REFERENCES [dbo].[Region] ([RegionId]),
    CONSTRAINT [FK_Address_Site] FOREIGN KEY ([SiteId]) REFERENCES [dbo].[Site] ([SiteId]),
    CONSTRAINT [FK_Address_StateProvinceRegion] FOREIGN KEY ([StateProvinceRegionId]) REFERENCES [dbo].[Region] ([RegionId])
);

