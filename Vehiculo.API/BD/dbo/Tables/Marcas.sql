﻿CREATE TABLE [dbo].[Marcas] (
    [Id]     UNIQUEIDENTIFIER NOT NULL,
    [Nombre] VARCHAR (MAX)    NULL,
    CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

