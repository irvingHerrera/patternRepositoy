
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/28/2017 01:56:17
-- Generated from EDMX file: C:\Users\usuario\Source\Repos\patternRepositoy\GameFootball\GameFootball.Data\GameModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GameFootball];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Team'
CREATE TABLE [dbo].[Team] (
    [TeamId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Image] nvarchar(max)  NOT NULL,
    [FoundationDate] nvarchar(max)  NOT NULL,
    [GameGameId] int  NOT NULL
);
GO

-- Creating table 'Player'
CREATE TABLE [dbo].[Player] (
    [PlayerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [BirthDate] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [TeamId] nvarchar(max)  NOT NULL,
    [TeamTeamId] int  NOT NULL
);
GO

-- Creating table 'Game'
CREATE TABLE [dbo].[Game] (
    [GameId] int IDENTITY(1,1) NOT NULL,
    [TeamIdOne] nvarchar(max)  NOT NULL,
    [TeamIdTwo] nvarchar(max)  NOT NULL,
    [Marker] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TeamId] in table 'Team'
ALTER TABLE [dbo].[Team]
ADD CONSTRAINT [PK_Team]
    PRIMARY KEY CLUSTERED ([TeamId] ASC);
GO

-- Creating primary key on [PlayerId] in table 'Player'
ALTER TABLE [dbo].[Player]
ADD CONSTRAINT [PK_Player]
    PRIMARY KEY CLUSTERED ([PlayerId] ASC);
GO

-- Creating primary key on [GameId] in table 'Game'
ALTER TABLE [dbo].[Game]
ADD CONSTRAINT [PK_Game]
    PRIMARY KEY CLUSTERED ([GameId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TeamTeamId] in table 'Player'
ALTER TABLE [dbo].[Player]
ADD CONSTRAINT [FK_TeamPlayer]
    FOREIGN KEY ([TeamTeamId])
    REFERENCES [dbo].[Team]
        ([TeamId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer'
CREATE INDEX [IX_FK_TeamPlayer]
ON [dbo].[Player]
    ([TeamTeamId]);
GO

-- Creating foreign key on [GameGameId] in table 'Team'
ALTER TABLE [dbo].[Team]
ADD CONSTRAINT [FK_GameTeam]
    FOREIGN KEY ([GameGameId])
    REFERENCES [dbo].[Game]
        ([GameId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GameTeam'
CREATE INDEX [IX_FK_GameTeam]
ON [dbo].[Team]
    ([GameGameId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------