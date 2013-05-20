CREATE TABLE [dbo].[Profile] (
    [ProfileId]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserId]           BIGINT         NOT NULL,
    [UserTypeId]       BIGINT         NOT NULL,
    [NavigationId]     BIGINT         NOT NULL,
    [GridPageSize]     INT            DEFAULT ((20)) NOT NULL,
    [ControlSettings]  NVARCHAR (MAX) NULL,
    [CreatedDateTime]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [CreatedBy]        NVARCHAR (100) DEFAULT (suser_sname()) NOT NULL,
    [ModifiedDateTime] DATETIME       NULL,
    [ModifiedBy]       NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ProfileId] ASC),
    CONSTRAINT [FK_Profile_Navigation] FOREIGN KEY ([NavigationId]) REFERENCES [dbo].[Navigation] ([NavigationId]),
    CONSTRAINT [FK_Profile_Person] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Person] ([UserId]),
    CONSTRAINT [FK_Profile_PersonType] FOREIGN KEY ([UserTypeId]) REFERENCES [dbo].[UserType] ([UserTypeId])
);

