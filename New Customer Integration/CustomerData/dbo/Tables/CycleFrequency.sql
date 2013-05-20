CREATE TABLE [dbo].[CycleFrequency] (
    [CycleFrequencyId] BIGINT         NOT NULL,
    [CycleFrequency]   INT            NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([CycleFrequencyId] ASC)
);

