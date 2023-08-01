
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/31/2023 17:02:17
-- Generated from EDMX file: D:\ismekKurs\ASP.NET_WEB\Odev2\Odev2\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TurhanKitabevi];
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

-- Creating table 'KullanicilarSet'
CREATE TABLE [dbo].[KullanicilarSet] (
    [KullaniciID] int IDENTITY(1,1) NOT NULL,
    [KullaniciAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KitaplarSet'
CREATE TABLE [dbo].[KitaplarSet] (
    [KitapID] int IDENTITY(1,1) NOT NULL,
    [KitapAdi] nvarchar(max)  NOT NULL,
    [KitapSeriNo] nvarchar(max)  NOT NULL,
    [Kategori] nvarchar(max)  NOT NULL,
    [YazarAdi] nvarchar(max)  NOT NULL,
    [SatisFiyati] int  NOT NULL,
    [StokDurum] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [KullaniciID] in table 'KullanicilarSet'
ALTER TABLE [dbo].[KullanicilarSet]
ADD CONSTRAINT [PK_KullanicilarSet]
    PRIMARY KEY CLUSTERED ([KullaniciID] ASC);
GO

-- Creating primary key on [KitapID] in table 'KitaplarSet'
ALTER TABLE [dbo].[KitaplarSet]
ADD CONSTRAINT [PK_KitaplarSet]
    PRIMARY KEY CLUSTERED ([KitapID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------