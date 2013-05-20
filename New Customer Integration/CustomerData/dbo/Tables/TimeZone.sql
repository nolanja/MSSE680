CREATE TABLE [dbo].[TimeZone] (
    [TimeZoneId]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [DotNetTimeZoneId] NVARCHAR (50)  NOT NULL,
    [TimeZoneName]     NVARCHAR (100) NOT NULL,
    [UTCOffset]        NVARCHAR (6)   NOT NULL,
    [DaylightSaving]   BIT            NOT NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([TimeZoneId] ASC)
);

