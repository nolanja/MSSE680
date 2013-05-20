CREATE TABLE [dbo].[Organization] (
    [OrganizationId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrganizationCode]       NVARCHAR (50)  NOT NULL,
    [OrganizationName]       NVARCHAR (100) NOT NULL,
    [PhoneNumber]            NVARCHAR (50)  NULL,
    [FaxNumber]              NVARCHAR (50)  NULL,
    [ParentOrganizationCode] NVARCHAR (50)  NULL,
    [Theme]                  NVARCHAR (50)  NOT NULL,
    [Skin]                   NVARCHAR (50)  NOT NULL,
    [Active]                 BIT            DEFAULT ((0)) NOT NULL,
    [DELETED]                BIT            DEFAULT ((0)) NOT NULL,
    [CreatedDateTime]        DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]              NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]       DATETIME       NULL,
    [ModifiedBy]             NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([OrganizationId] ASC)
);

