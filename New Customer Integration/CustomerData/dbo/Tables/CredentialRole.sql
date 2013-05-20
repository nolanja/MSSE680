CREATE TABLE [dbo].[CredentialRole] (
    [UserId]           BIGINT         NOT NULL,
    [RoleId]           BIGINT         NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    CONSTRAINT [PK_CredentialRole] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_CredentialRole_Person] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Person] ([UserId]),
    CONSTRAINT [FK_CredentialRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId])
);

