CREATE TABLE [dbo].[OrganizationAdministrator] (
    [UserId]           BIGINT         NOT NULL,
    [OrganizationId]   BIGINT         NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    CONSTRAINT [PK_OrganizationAdministrator] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_OrganizationAdministrator_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId]),
    CONSTRAINT [FK_OrganizationAdministrator_Person] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Person] ([UserId])
);

