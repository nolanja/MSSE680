CREATE TABLE [dbo].[RuleSet] (
    [RuleSetId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrganizationId]    BIGINT         NOT NULL,
    [AssociationId]     BIGINT         NOT NULL,
    [AssociationTypeId] BIGINT         NOT NULL,
    [ApplicationId]     BIGINT         NOT NULL,
    [RuleId]            BIGINT         NOT NULL,
    [RuleValue]         NVARCHAR (100) NOT NULL,
    [CreatedDateTime]   DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]         NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]  DATETIME       NULL,
    [ModifiedBy]        NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([RuleSetId] ASC),
    CONSTRAINT [FK_RuleSet_AssociationType] FOREIGN KEY ([AssociationTypeId]) REFERENCES [dbo].[AssociationType] ([AssociationTypeId]),
    CONSTRAINT [FK_RuleSet_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId]),
    CONSTRAINT [FK_RuleSet_Rules] FOREIGN KEY ([RuleId]) REFERENCES [dbo].[Rules] ([RuleId])
);

