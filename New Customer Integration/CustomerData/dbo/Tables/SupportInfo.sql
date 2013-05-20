CREATE TABLE [dbo].[SupportInfo] (
    [SupportInfoId]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [OrganizationId]   BIGINT         NOT NULL,
    [SupportEmail]     NVARCHAR (100) NULL,
    [SupportPhone]     NVARCHAR (50)  NULL,
    [ReplyToEmail]     NVARCHAR (100) NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([SupportInfoId] ASC),
    CONSTRAINT [FK_SupportInfo_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId])
);

