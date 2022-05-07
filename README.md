# LibManagement
This is C# project of University RUPP Year 3

CREATE A NEW SQL DATABASE AND RUN CREATE A TABLE "Users" AND RUN This SQL CODE:


CREATE TABLE [dbo].[Users] (
    [userID]   INT          IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([userID] ASC)
);
