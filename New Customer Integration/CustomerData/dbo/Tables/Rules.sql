CREATE TABLE [dbo].[Rules] (
    [RuleId]           BIGINT         NOT NULL,
    [ValueTypeId]      BIGINT         NOT NULL,
    [RuleName]         NVARCHAR (50)  NOT NULL,
    [RuleDescription]  NVARCHAR (100) NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([RuleId] ASC),
    CONSTRAINT [FK_Rules_ValueType] FOREIGN KEY ([ValueTypeId]) REFERENCES [dbo].[ValueType] ([ValueTypeId])
);

