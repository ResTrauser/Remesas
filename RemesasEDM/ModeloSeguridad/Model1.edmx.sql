
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/12/2023 10:56:42
-- Generated from EDMX file: F:\Remesas\RemesasEDM\ModeloSeguridad\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GestionUsuario];
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

-- Creating table 'FuncionDeAcceso'
CREATE TABLE [dbo].[FuncionDeAcceso] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FuncionAsignada'
CREATE TABLE [dbo].[FuncionAsignada] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaVencimiento] datetime  NULL,
    [UsuarioId] int  NOT NULL,
    [FuncionDeAccesoId] int  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NombreUsuario] nvarchar(max)  NOT NULL,
    [ClaveUsuario] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FuncionDeAcceso'
ALTER TABLE [dbo].[FuncionDeAcceso]
ADD CONSTRAINT [PK_FuncionDeAcceso]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FuncionAsignada'
ALTER TABLE [dbo].[FuncionAsignada]
ADD CONSTRAINT [PK_FuncionAsignada]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioId] in table 'FuncionAsignada'
ALTER TABLE [dbo].[FuncionAsignada]
ADD CONSTRAINT [FK_UsuarioFuncionAsignada]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioFuncionAsignada'
CREATE INDEX [IX_FK_UsuarioFuncionAsignada]
ON [dbo].[FuncionAsignada]
    ([UsuarioId]);
GO

-- Creating foreign key on [FuncionDeAccesoId] in table 'FuncionAsignada'
ALTER TABLE [dbo].[FuncionAsignada]
ADD CONSTRAINT [FK_FuncionDeAccesoFuncionAsignada]
    FOREIGN KEY ([FuncionDeAccesoId])
    REFERENCES [dbo].[FuncionDeAcceso]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionDeAccesoFuncionAsignada'
CREATE INDEX [IX_FK_FuncionDeAccesoFuncionAsignada]
ON [dbo].[FuncionAsignada]
    ([FuncionDeAccesoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------