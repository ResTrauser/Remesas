
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/15/2023 22:05:27
-- Generated from EDMX file: C:\Users\restr\Desktop\Escritorio\Progaramacion BD\Remesas - copia\RemesasEDM\ModeloApp\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Remesas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteEmisorEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Envio] DROP CONSTRAINT [FK_ClienteEmisorEnvio];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteReceptorEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Envio] DROP CONSTRAINT [FK_ClienteReceptorEnvio];
GO
IF OBJECT_ID(N'[dbo].[FK_EnvioNotificaciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Notificaciones] DROP CONSTRAINT [FK_EnvioNotificaciones];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoRemesaEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Envio] DROP CONSTRAINT [FK_EstadoRemesaEnvio];
GO
IF OBJECT_ID(N'[dbo].[FK_MonedaTipoDeCambio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TipoDeCambio] DROP CONSTRAINT [FK_MonedaTipoDeCambio];
GO
IF OBJECT_ID(N'[dbo].[FK_PaisClienteEmisor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClienteEmisor] DROP CONSTRAINT [FK_PaisClienteEmisor];
GO
IF OBJECT_ID(N'[dbo].[FK_PaisClienteReceptor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClienteReceptor] DROP CONSTRAINT [FK_PaisClienteReceptor];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoDeCambioEnvio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Envio] DROP CONSTRAINT [FK_TipoDeCambioEnvio];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClienteEmisor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteEmisor];
GO
IF OBJECT_ID(N'[dbo].[ClienteReceptor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteReceptor];
GO
IF OBJECT_ID(N'[dbo].[Envio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Envio];
GO
IF OBJECT_ID(N'[dbo].[EstadoRemesa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoRemesa];
GO
IF OBJECT_ID(N'[dbo].[Moneda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moneda];
GO
IF OBJECT_ID(N'[dbo].[Notificaciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Notificaciones];
GO
IF OBJECT_ID(N'[dbo].[Pais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pais];
GO
IF OBJECT_ID(N'[dbo].[TipoDeCambio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoDeCambio];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EstadoRemesa'
CREATE TABLE [dbo].[EstadoRemesa] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoEstadoRemesa] nvarchar(max)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Envio'
CREATE TABLE [dbo].[Envio] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoEnvio] nvarchar(max)  NOT NULL,
    [MontoPagado] float  NOT NULL,
    [FechaPago] datetime  NOT NULL,
    [CodigoRetiro] int  NOT NULL,
    [EstadoRemesaId] int  NOT NULL,
    [ClienteEmisorId] int  NOT NULL,
    [ClienteReceptorId] int  NOT NULL,
    [TipoDeCambioId] int  NOT NULL
);
GO

-- Creating table 'Notificaciones'
CREATE TABLE [dbo].[Notificaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoNotificacion] nvarchar(max)  NOT NULL,
    [FechaNotificacion] datetime  NOT NULL,
    [EnvioId] int  NOT NULL
);
GO

-- Creating table 'ClienteEmisor'
CREATE TABLE [dbo].[ClienteEmisor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoEmisor] nvarchar(max)  NOT NULL,
    [NombresEmisor] nvarchar(max)  NOT NULL,
    [Apellido1Emisor] nvarchar(max)  NOT NULL,
    [Apellido2Emisor] nvarchar(max)  NULL,
    [DireccionEmisor] nvarchar(max)  NOT NULL,
    [TelefonoEmisor] int  NOT NULL,
    [Cedula] nvarchar(14)  NOT NULL,
    [PaisId] int  NOT NULL
);
GO

-- Creating table 'ClienteReceptor'
CREATE TABLE [dbo].[ClienteReceptor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoReceptor] nvarchar(max)  NOT NULL,
    [NombresReceptor] nvarchar(max)  NOT NULL,
    [Apellido1Receptor] nvarchar(max)  NOT NULL,
    [Apellido2Receptor] nvarchar(max)  NULL,
    [DireccionReceptor] nvarchar(max)  NOT NULL,
    [TelefonoReceptor] int  NOT NULL,
    [Cedula] nvarchar(14)  NOT NULL,
    [PaisId] int  NOT NULL
);
GO

-- Creating table 'Pais'
CREATE TABLE [dbo].[Pais] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoPais] nvarchar(max)  NOT NULL,
    [NombrePais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoDeCambio'
CREATE TABLE [dbo].[TipoDeCambio] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoTipoCambio] nvarchar(max)  NOT NULL,
    [CambioDia] float  NOT NULL,
    [FechaTipoCambio] datetime  NOT NULL,
    [MonedaId] int  NOT NULL
);
GO

-- Creating table 'Moneda'
CREATE TABLE [dbo].[Moneda] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoMoneda] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EstadoRemesa'
ALTER TABLE [dbo].[EstadoRemesa]
ADD CONSTRAINT [PK_EstadoRemesa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Envio'
ALTER TABLE [dbo].[Envio]
ADD CONSTRAINT [PK_Envio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Notificaciones'
ALTER TABLE [dbo].[Notificaciones]
ADD CONSTRAINT [PK_Notificaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClienteEmisor'
ALTER TABLE [dbo].[ClienteEmisor]
ADD CONSTRAINT [PK_ClienteEmisor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClienteReceptor'
ALTER TABLE [dbo].[ClienteReceptor]
ADD CONSTRAINT [PK_ClienteReceptor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pais'
ALTER TABLE [dbo].[Pais]
ADD CONSTRAINT [PK_Pais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoDeCambio'
ALTER TABLE [dbo].[TipoDeCambio]
ADD CONSTRAINT [PK_TipoDeCambio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Moneda'
ALTER TABLE [dbo].[Moneda]
ADD CONSTRAINT [PK_Moneda]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EstadoRemesaId] in table 'Envio'
ALTER TABLE [dbo].[Envio]
ADD CONSTRAINT [FK_EstadoRemesaEnvio]
    FOREIGN KEY ([EstadoRemesaId])
    REFERENCES [dbo].[EstadoRemesa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoRemesaEnvio'
CREATE INDEX [IX_FK_EstadoRemesaEnvio]
ON [dbo].[Envio]
    ([EstadoRemesaId]);
GO

-- Creating foreign key on [EnvioId] in table 'Notificaciones'
ALTER TABLE [dbo].[Notificaciones]
ADD CONSTRAINT [FK_EnvioNotificaciones]
    FOREIGN KEY ([EnvioId])
    REFERENCES [dbo].[Envio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EnvioNotificaciones'
CREATE INDEX [IX_FK_EnvioNotificaciones]
ON [dbo].[Notificaciones]
    ([EnvioId]);
GO

-- Creating foreign key on [PaisId] in table 'ClienteEmisor'
ALTER TABLE [dbo].[ClienteEmisor]
ADD CONSTRAINT [FK_PaisClienteEmisor]
    FOREIGN KEY ([PaisId])
    REFERENCES [dbo].[Pais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisClienteEmisor'
CREATE INDEX [IX_FK_PaisClienteEmisor]
ON [dbo].[ClienteEmisor]
    ([PaisId]);
GO

-- Creating foreign key on [PaisId] in table 'ClienteReceptor'
ALTER TABLE [dbo].[ClienteReceptor]
ADD CONSTRAINT [FK_PaisClienteReceptor]
    FOREIGN KEY ([PaisId])
    REFERENCES [dbo].[Pais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisClienteReceptor'
CREATE INDEX [IX_FK_PaisClienteReceptor]
ON [dbo].[ClienteReceptor]
    ([PaisId]);
GO

-- Creating foreign key on [ClienteEmisorId] in table 'Envio'
ALTER TABLE [dbo].[Envio]
ADD CONSTRAINT [FK_ClienteEmisorEnvio]
    FOREIGN KEY ([ClienteEmisorId])
    REFERENCES [dbo].[ClienteEmisor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteEmisorEnvio'
CREATE INDEX [IX_FK_ClienteEmisorEnvio]
ON [dbo].[Envio]
    ([ClienteEmisorId]);
GO

-- Creating foreign key on [ClienteReceptorId] in table 'Envio'
ALTER TABLE [dbo].[Envio]
ADD CONSTRAINT [FK_ClienteReceptorEnvio]
    FOREIGN KEY ([ClienteReceptorId])
    REFERENCES [dbo].[ClienteReceptor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteReceptorEnvio'
CREATE INDEX [IX_FK_ClienteReceptorEnvio]
ON [dbo].[Envio]
    ([ClienteReceptorId]);
GO

-- Creating foreign key on [MonedaId] in table 'TipoDeCambio'
ALTER TABLE [dbo].[TipoDeCambio]
ADD CONSTRAINT [FK_MonedaTipoDeCambio]
    FOREIGN KEY ([MonedaId])
    REFERENCES [dbo].[Moneda]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MonedaTipoDeCambio'
CREATE INDEX [IX_FK_MonedaTipoDeCambio]
ON [dbo].[TipoDeCambio]
    ([MonedaId]);
GO

-- Creating foreign key on [TipoDeCambioId] in table 'Envio'
ALTER TABLE [dbo].[Envio]
ADD CONSTRAINT [FK_TipoDeCambioEnvio]
    FOREIGN KEY ([TipoDeCambioId])
    REFERENCES [dbo].[TipoDeCambio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDeCambioEnvio'
CREATE INDEX [IX_FK_TipoDeCambioEnvio]
ON [dbo].[Envio]
    ([TipoDeCambioId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------