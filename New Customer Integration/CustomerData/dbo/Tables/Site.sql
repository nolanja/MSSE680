CREATE TABLE [dbo].[Site] (
    [SiteId]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrganizationId]   BIGINT         NOT NULL,
    [SiteTypeId]       BIGINT         NOT NULL,
    [SiteName]         NVARCHAR (100) NOT NULL,
    [SiteCode]         NVARCHAR (50)  NULL,
    [TimeZoneId]       BIGINT         NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([SiteId] ASC),
    CONSTRAINT [FK_Site_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId]),
    CONSTRAINT [FK_Site_SiteType] FOREIGN KEY ([SiteTypeId]) REFERENCES [dbo].[SiteType] ([SiteTypeId]),
    CONSTRAINT [FK_Site_TimeZoneId] FOREIGN KEY ([TimeZoneId]) REFERENCES [dbo].[TimeZone] ([TimeZoneId])
);

