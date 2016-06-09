
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2016 19:34:08
-- Generated from EDMX file: E:\S2B\Source\Repos\S2BProjetoFinal\ProjetoFinal\ProjetoFinal\Models\Entity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_ProjetoFinal];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Table1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table1];
GO
IF OBJECT_ID(N'[dbo].[Table2]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table2];
GO
IF OBJECT_ID(N'[dbo].[Table3]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table3];
GO
IF OBJECT_ID(N'[dbo].[Table4]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table4];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Table1'
CREATE TABLE [dbo].[Table1] (
    [Id] int  NOT NULL,
    [C1] int  NULL
);
GO

-- Creating table 'Table2'
CREATE TABLE [dbo].[Table2] (
    [Id] int  NOT NULL,
    [C2] int  NULL
);
GO

-- Creating table 'Table3'
CREATE TABLE [dbo].[Table3] (
    [Id] int  NOT NULL,
    [C3] int  NULL,
    [C6] int  NOT NULL
);
GO

-- Creating table 'Table4'
CREATE TABLE [dbo].[Table4] (
    [Id] int  NOT NULL,
    [C4] int  NULL,
    [C5] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Table1'
ALTER TABLE [dbo].[Table1]
ADD CONSTRAINT [PK_Table1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Table2'
ALTER TABLE [dbo].[Table2]
ADD CONSTRAINT [PK_Table2]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [C6] in table 'Table3'
ALTER TABLE [dbo].[Table3]
ADD CONSTRAINT [PK_Table3]
    PRIMARY KEY CLUSTERED ([Id], [C6] ASC);
GO

-- Creating primary key on [Id] in table 'Table4'
ALTER TABLE [dbo].[Table4]
ADD CONSTRAINT [PK_Table4]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------