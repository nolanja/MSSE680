CREATE TABLE [dbo].[OrganizationCycleFrequency] (
    [OrganizationId]      BIGINT         NOT NULL,
    [CycleFrequencyId]    BIGINT         DEFAULT ((3)) NOT NULL,
    [ApplyToChildren]     BIT            DEFAULT ((0)) NOT NULL,
    [AssociationTypeName] NVARCHAR (100) NOT NULL,
    [CreatedDateTime]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]           NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]    DATETIME       NULL,
    [ModifiedBy]          NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([OrganizationId] ASC),
    CONSTRAINT [FK_OrganizationCycleFrequency_CycleFrequency] FOREIGN KEY ([CycleFrequencyId]) REFERENCES [dbo].[CycleFrequency] ([CycleFrequencyId]),
    CONSTRAINT [FK_OrganizationCycleFrequency_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId])
);

