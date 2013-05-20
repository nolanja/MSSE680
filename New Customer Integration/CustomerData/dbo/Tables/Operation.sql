CREATE TABLE [dbo].[Operation] (
    [OperationId]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [OperationTypeId]  BIGINT         NOT NULL,
    [OrganizationId]   BIGINT         NOT NULL,
    [OperationName]    NVARCHAR (100) NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([OperationId] ASC),
    CONSTRAINT [FK_Operation_OperationType] FOREIGN KEY ([OperationTypeId]) REFERENCES [dbo].[OperationType] ([OperationTypeId]),
    CONSTRAINT [FK_Operation_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([OrganizationId])
);

