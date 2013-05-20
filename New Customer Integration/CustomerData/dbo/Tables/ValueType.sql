CREATE TABLE [dbo].[ValueType] (
    [ValueTypeId]          BIGINT         NOT NULL,
    [ValueTypeName]        NVARCHAR (50)  NOT NULL,
    [ValueTypeDescription] NVARCHAR (100) NULL,
    [CreatedDateTime]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]            NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]     DATETIME       NULL,
    [ModifiedBy]           NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ValueTypeId] ASC)
);

