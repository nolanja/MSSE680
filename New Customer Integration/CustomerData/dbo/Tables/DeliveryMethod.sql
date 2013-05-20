CREATE TABLE [dbo].[DeliveryMethod] (
    [DeliveryMethodId]          BIGINT         NOT NULL,
    [DeliveryMethodName]        NVARCHAR (100) NOT NULL,
    [DeliveryMethodDescription] NVARCHAR (200) NULL,
    [CreatedDateTime]           DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]                 NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime]          DATETIME       NULL,
    [ModifiedBy]                NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([DeliveryMethodId] ASC)
);

