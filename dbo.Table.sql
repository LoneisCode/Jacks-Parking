﻿CREATE TABLE [dbo].[Table] (
    [Id]            INT           NOT NULL,
    [location]      NVARCHAR (50) NOT NULL,
    [name]          NVARCHAR (50) NOT NULL,
    [permits]       INT           NOT NULL,
    [#_of_spaces]   INT           NOT NULL,
    [level]         INT           NOT NULL,
    [building_near] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

