
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/27/2019 20:04:04
-- Generated from EDMX file: C:\Users\ruben\Desktop\Stand_Automóveis\Stand_Automóveis\StandLocalDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StandLocalDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteIdCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroOficina] DROP CONSTRAINT [FK_ClienteIdCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteIdVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteIdVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteIdAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluguer] DROP CONSTRAINT [FK_ClienteIdAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_AluguerCarroAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aluguer] DROP CONSTRAINT [FK_AluguerCarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoIdServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parcela] DROP CONSTRAINT [FK_ServicoIdServico];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCarroVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_VendaCarroVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servico] DROP CONSTRAINT [FK_ServicoCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroOficina] DROP CONSTRAINT [FK_CarroOficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carro_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Carro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro];
GO
IF OBJECT_ID(N'[dbo].[Parcela]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parcela];
GO
IF OBJECT_ID(N'[dbo].[Servico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servico];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Aluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aluguer];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroOficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroOficina];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[Carro_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carro_CarroVenda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carro'
CREATE TABLE [dbo].[Carro] (
    [idCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Parcela'
CREATE TABLE [dbo].[Parcela] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServico] int  NOT NULL
);
GO

-- Creating table 'Servico'
CREATE TABLE [dbo].[Servico] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [CarroOficinaIdCarroOficina] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [DataSaida] datetime  NOT NULL,
    [CarroOficina_idCarro] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroVenda_idCarro] int  NOT NULL
);
GO

-- Creating table 'Aluguer'
CREATE TABLE [dbo].[Aluguer] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] datetime  NOT NULL,
    [Valor] float  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroAluguer_idCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroOficina'
CREATE TABLE [dbo].[Carro_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [idCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroAluguer'
CREATE TABLE [dbo].[Carro_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [idCarro] int  NOT NULL
);
GO

-- Creating table 'Carro_CarroVenda'
CREATE TABLE [dbo].[Carro_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [idCarro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [idCarro] in table 'Carro'
ALTER TABLE [dbo].[Carro]
ADD CONSTRAINT [PK_Carro]
    PRIMARY KEY CLUSTERED ([idCarro] ASC);
GO

-- Creating primary key on [IdParcela] in table 'Parcela'
ALTER TABLE [dbo].[Parcela]
ADD CONSTRAINT [PK_Parcela]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [PK_Servico]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'Aluguer'
ALTER TABLE [dbo].[Aluguer]
ADD CONSTRAINT [PK_Aluguer]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [idCarro] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [PK_Carro_CarroOficina]
    PRIMARY KEY CLUSTERED ([idCarro] ASC);
GO

-- Creating primary key on [idCarro] in table 'Carro_CarroAluguer'
ALTER TABLE [dbo].[Carro_CarroAluguer]
ADD CONSTRAINT [PK_Carro_CarroAluguer]
    PRIMARY KEY CLUSTERED ([idCarro] ASC);
GO

-- Creating primary key on [idCarro] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [PK_Carro_CarroVenda]
    PRIMARY KEY CLUSTERED ([idCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [FK_ClienteIdCliente]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteIdCliente'
CREATE INDEX [IX_FK_ClienteIdCliente]
ON [dbo].[Carro_CarroOficina]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteIdVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteIdVenda'
CREATE INDEX [IX_FK_ClienteIdVenda]
ON [dbo].[Vendas]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Aluguer'
ALTER TABLE [dbo].[Aluguer]
ADD CONSTRAINT [FK_ClienteIdAluguer]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteIdAluguer'
CREATE INDEX [IX_FK_ClienteIdAluguer]
ON [dbo].[Aluguer]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroAluguer_idCarro] in table 'Aluguer'
ALTER TABLE [dbo].[Aluguer]
ADD CONSTRAINT [FK_AluguerCarroAluguer]
    FOREIGN KEY ([CarroAluguer_idCarro])
    REFERENCES [dbo].[Carro_CarroAluguer]
        ([idCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AluguerCarroAluguer'
CREATE INDEX [IX_FK_AluguerCarroAluguer]
ON [dbo].[Aluguer]
    ([CarroAluguer_idCarro]);
GO

-- Creating foreign key on [ServicoIdServico] in table 'Parcela'
ALTER TABLE [dbo].[Parcela]
ADD CONSTRAINT [FK_ServicoIdServico]
    FOREIGN KEY ([ServicoIdServico])
    REFERENCES [dbo].[Servico]
        ([IdServico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoIdServico'
CREATE INDEX [IX_FK_ServicoIdServico]
ON [dbo].[Parcela]
    ([ServicoIdServico]);
GO

-- Creating foreign key on [CarroVenda_idCarro] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_idCarro])
    REFERENCES [dbo].[Carro_CarroVenda]
        ([idCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[Vendas]
    ([CarroVenda_idCarro]);
GO

-- Creating foreign key on [CarroOficina_idCarro] in table 'Servico'
ALTER TABLE [dbo].[Servico]
ADD CONSTRAINT [FK_ServicoCarroOficina]
    FOREIGN KEY ([CarroOficina_idCarro])
    REFERENCES [dbo].[Carro_CarroOficina]
        ([idCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoCarroOficina'
CREATE INDEX [IX_FK_ServicoCarroOficina]
ON [dbo].[Servico]
    ([CarroOficina_idCarro]);
GO

-- Creating foreign key on [idCarro] in table 'Carro_CarroOficina'
ALTER TABLE [dbo].[Carro_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([idCarro])
    REFERENCES [dbo].[Carro]
        ([idCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idCarro] in table 'Carro_CarroAluguer'
ALTER TABLE [dbo].[Carro_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([idCarro])
    REFERENCES [dbo].[Carro]
        ([idCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idCarro] in table 'Carro_CarroVenda'
ALTER TABLE [dbo].[Carro_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([idCarro])
    REFERENCES [dbo].[Carro]
        ([idCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------