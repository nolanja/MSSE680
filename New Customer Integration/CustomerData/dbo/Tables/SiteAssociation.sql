CREATE TABLE [dbo].[SiteAssociation] (
    [OrganizationId]   BIGINT         NOT NULL,
    [SiteId]           BIGINT         NOT NULL,
    [OperationTypeId]  BIGINT         NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    CONSTRAINT [PK_SiteAssocation] PRIMARY KEY CLUSTERED ([OrganizationId] ASC, [SiteId] ASC, [OperationTypeId] ASC),
    CONSTRAINT [FK_SiteAssociation_OperationType] FOREIGN KEY ([OperationTypeId]) REFERENCES [dbo].[OperationType] ([OperationTypeId]),
    CONSTRAINT [FK_SiteAssociation_Site] FOREIGN KEY ([SiteId]) REFERENCES [dbo].[Site] ([SiteId])
);

