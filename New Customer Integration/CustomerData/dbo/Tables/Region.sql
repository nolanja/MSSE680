CREATE TABLE [dbo].[Region] (
    [RegionId]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [RegionTypeId]     BIGINT         NOT NULL,
    [RegionCode]       NVARCHAR (50)  NOT NULL,
    [RegionName]       NVARCHAR (100) NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([RegionId] ASC),
    CONSTRAINT [FK_Region_RegionType] FOREIGN KEY ([RegionTypeId]) REFERENCES [dbo].[RegionType] ([RegionTypeId])
);

