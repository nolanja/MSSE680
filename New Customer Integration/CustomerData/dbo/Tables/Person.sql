CREATE TABLE [dbo].[Person] (
    [UserId]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrganizationId]   BIGINT         NOT NULL,
    [UserTypeId]       BIGINT         NOT NULL,
    [FirstName]        NVARCHAR (50)  NOT NULL,
    [LastName]         NVARCHAR (50)  NOT NULL,
    [PhoneNumber]      NVARCHAR (50)  NULL,
    [EmailAddress]     NVARCHAR (50)  NULL,
    [UnitName]         NVARCHAR (50)  NULL,
    [UnitNumber]       NVARCHAR (25)  NULL,
    [Department]       NVARCHAR (50)  NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Person_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId])
);

