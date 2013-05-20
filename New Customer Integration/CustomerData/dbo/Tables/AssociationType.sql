CREATE TABLE [dbo].[AssociationType] (
    [AssociationTypeId]   BIGINT         NOT NULL,
    [AssociationTypeName] NVARCHAR (100) NOT NULL,
    [CreatedDateTime]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]           NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]    DATETIME       NULL,
    [ModifiedBy]          NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([AssociationTypeId] ASC)
);

