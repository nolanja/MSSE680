CREATE TABLE [dbo].[Credential] (
    [UserId]             BIGINT         NOT NULL,
    [UserName]           NVARCHAR (100) NOT NULL,
    [Password]           NVARCHAR (50)  NOT NULL,
    [Salt]               NVARCHAR (50)  NOT NULL,
    [IsLockedOut]        BIT            NOT NULL,
    [IsDeactivated]      BIT            NOT NULL,
    [IsDeleted]          BIT            NOT NULL,
    [MustChangePassword] BIT            NOT NULL,
    [PasswordQuestion]   NVARCHAR (500) NULL,
    [PasswordAnswer]     NVARCHAR (100) NULL,
    [CreatedDateTime]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]          NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]   DATETIME       NULL,
    [ModifiedBy]         NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Credential_Person] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Person] ([UserId])
);

