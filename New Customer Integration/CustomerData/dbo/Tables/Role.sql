CREATE TABLE [dbo].[Role] (
    [RoleId]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [RoleTypeId]       BIGINT         NOT NULL,
    [OrganizationId]   BIGINT         NOT NULL,
    [RoleName]         NVARCHAR (100) NOT NULL,
    [RoleDescription]  NVARCHAR (200) NULL,
    [DefaultRoleFlag]  BIT            NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([RoleId] ASC),
    CONSTRAINT [FK_Role_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId]),
    CONSTRAINT [FK_Role_RoleType] FOREIGN KEY ([RoleTypeId]) REFERENCES [dbo].[RoleType] ([RoleTypeId])
);

