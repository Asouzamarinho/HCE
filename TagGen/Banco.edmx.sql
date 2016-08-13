
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/13/2016 19:03:13
-- Generated from EDMX file: C:\Users\Marcos\Source\Repos\HCE\TagGen\Banco.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Banco];
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

-- Creating table 'TagueadoSet'
CREATE TABLE [dbo].[TagueadoSet] (
    [EPC] nvarchar(max)  NULL,
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'TagueadoSet_Terceirizado'
CREATE TABLE [dbo].[TagueadoSet_Terceirizado] (
    [Nome] nvarchar(max)  NOT NULL,
    [Empresa] nvarchar(max)  NOT NULL,
    [Identificacao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'TagueadoSet_Veiculo'
CREATE TABLE [dbo].[TagueadoSet_Veiculo] (
    [Placa] nvarchar(max)  NOT NULL,
    [Selo] nvarchar(max)  NOT NULL,
    [Motorista] nvarchar(max)  NOT NULL,
    [Cor] nvarchar(max)  NOT NULL,
    [Patente] nvarchar(max)  NOT NULL,
    [Setor] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'TagueadoSet_Visitante'
CREATE TABLE [dbo].[TagueadoSet_Visitante] (
    [Nome] nvarchar(max)  NOT NULL,
    [Identificacao] nvarchar(max)  NOT NULL,
    [Leito] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TagueadoSet'
ALTER TABLE [dbo].[TagueadoSet]
ADD CONSTRAINT [PK_TagueadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TagueadoSet_Terceirizado'
ALTER TABLE [dbo].[TagueadoSet_Terceirizado]
ADD CONSTRAINT [PK_TagueadoSet_Terceirizado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TagueadoSet_Veiculo'
ALTER TABLE [dbo].[TagueadoSet_Veiculo]
ADD CONSTRAINT [PK_TagueadoSet_Veiculo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TagueadoSet_Visitante'
ALTER TABLE [dbo].[TagueadoSet_Visitante]
ADD CONSTRAINT [PK_TagueadoSet_Visitante]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'TagueadoSet_Terceirizado'
ALTER TABLE [dbo].[TagueadoSet_Terceirizado]
ADD CONSTRAINT [FK_Terceirizado_inherits_Tagueado]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TagueadoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TagueadoSet_Veiculo'
ALTER TABLE [dbo].[TagueadoSet_Veiculo]
ADD CONSTRAINT [FK_Veiculo_inherits_Tagueado]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TagueadoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TagueadoSet_Visitante'
ALTER TABLE [dbo].[TagueadoSet_Visitante]
ADD CONSTRAINT [FK_Visitante_inherits_Tagueado]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TagueadoSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------