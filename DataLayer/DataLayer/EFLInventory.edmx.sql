
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/23/2017 12:04:39
-- Generated from EDMX file: C:\Users\chris\Source\Workspaces\EFLInventoryManagement\EFLInventoryManagement\DataLayer\DataLayer\EFLInventory.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EFLInventory];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProductCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_ProductCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductSubCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_ProductSubCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_CategorySubCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubCategories] DROP CONSTRAINT [FK_CategorySubCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductDealer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_ProductDealer];
GO
IF OBJECT_ID(N'[dbo].[FK_MesuringTypeProductVariation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductVariations] DROP CONSTRAINT [FK_MesuringTypeProductVariation];
GO
IF OBJECT_ID(N'[dbo].[FK_BrandProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_BrandProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_Product_ProductVariation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductVariations] DROP CONSTRAINT [FK_Product_ProductVariation];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductVariationTransaction_History]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transaction_Histories] DROP CONSTRAINT [FK_ProductVariationTransaction_History];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductVariation_DamagedProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DamagedProducts] DROP CONSTRAINT [FK_ProductVariation_DamagedProduct];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[SubCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubCategories];
GO
IF OBJECT_ID(N'[dbo].[Transaction_Types]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transaction_Types];
GO
IF OBJECT_ID(N'[dbo].[Transaction_Histories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transaction_Histories];
GO
IF OBJECT_ID(N'[dbo].[Dealers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dealers];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[ActionHistories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionHistories];
GO
IF OBJECT_ID(N'[dbo].[ErrorLogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ErrorLogs];
GO
IF OBJECT_ID(N'[dbo].[MeasuringTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeasuringTypes];
GO
IF OBJECT_ID(N'[dbo].[Brands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brands];
GO
IF OBJECT_ID(N'[dbo].[ProductVariations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductVariations];
GO
IF OBJECT_ID(N'[dbo].[DamagedProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DamagedProducts];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [brand_id] int  NOT NULL,
    [dealer_id] int  NOT NULL,
    [Category_id] int  NOT NULL,
    [subCategory_id] int  NOT NULL,
    [status] bit  NOT NULL,
    [date_created] datetime  NOT NULL,
    [last_updated] datetime  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SubCategories'
CREATE TABLE [dbo].[SubCategories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [Category_id] int  NOT NULL
);
GO

-- Creating table 'Transaction_Types'
CREATE TABLE [dbo].[Transaction_Types] (
    [id] int IDENTITY(1,1) NOT NULL,
    [type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Transaction_Histories'
CREATE TABLE [dbo].[Transaction_Histories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ProductVariationVariationID] uniqueidentifier  NOT NULL,
    [dealer] nvarchar(max)  NULL,
    [quantity] int  NOT NULL,
    [credit] decimal(18,0)  NOT NULL,
    [debit] decimal(18,0)  NOT NULL,
    [balance_due] decimal(18,0)  NOT NULL,
    [change] decimal(18,0)  NOT NULL,
    [payment_type] nvarchar(max)  NOT NULL,
    [payment_date] datetime  NOT NULL,
    [remarks] nvarchar(max)  NULL,
    [transaction_type] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Dealers'
CREATE TABLE [dbo].[Dealers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [phone] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NULL,
    [address] nvarchar(max)  NULL,
    [date_created] datetime  NOT NULL,
    [last_updated] datetime  NOT NULL,
    [Brand_id] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [full_name] nvarchar(max)  NULL,
    [date_created] datetime  NOT NULL,
    [last_updated] datetime  NOT NULL,
    [is_superuser] bit  NOT NULL,
    [is_staff] bit  NOT NULL,
    [last_login] datetime  NOT NULL
);
GO

-- Creating table 'ActionHistories'
CREATE TABLE [dbo].[ActionHistories] (
    [ActionHistoryID] uniqueidentifier  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [timestamp] datetime  NOT NULL,
    [username] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ErrorLogs'
CREATE TABLE [dbo].[ErrorLogs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [error_time] datetime  NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [error_severity] nvarchar(max)  NOT NULL,
    [error_proceedure] nvarchar(max)  NOT NULL,
    [error_line] nvarchar(max)  NOT NULL,
    [error_message] nvarchar(max)  NOT NULL,
    [timestamp] datetime  NOT NULL
);
GO

-- Creating table 'MeasuringTypes'
CREATE TABLE [dbo].[MeasuringTypes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductVariations'
CREATE TABLE [dbo].[ProductVariations] (
    [VariationID] uniqueidentifier  NOT NULL,
    [Product_id] int  NOT NULL,
    [VariationName] nvarchar(max)  NOT NULL,
    [image_url] nvarchar(max)  NULL,
    [measured_by] int  NOT NULL,
    [weight] decimal(18,0)  NOT NULL,
    [cost_price] decimal(18,0)  NOT NULL,
    [retail_price] decimal(18,0)  NOT NULL,
    [wholesale_price] decimal(18,0)  NOT NULL,
    [stock_threshold] int  NOT NULL,
    [stock] int  NOT NULL,
    [date_created] datetime  NOT NULL,
    [last_updated] datetime  NOT NULL
);
GO

-- Creating table 'DamagedProducts'
CREATE TABLE [dbo].[DamagedProducts] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ProductVariationID] uniqueidentifier  NOT NULL,
    [quantity] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [PK_SubCategories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Transaction_Types'
ALTER TABLE [dbo].[Transaction_Types]
ADD CONSTRAINT [PK_Transaction_Types]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Transaction_Histories'
ALTER TABLE [dbo].[Transaction_Histories]
ADD CONSTRAINT [PK_Transaction_Histories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Dealers'
ALTER TABLE [dbo].[Dealers]
ADD CONSTRAINT [PK_Dealers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [ActionHistoryID] in table 'ActionHistories'
ALTER TABLE [dbo].[ActionHistories]
ADD CONSTRAINT [PK_ActionHistories]
    PRIMARY KEY CLUSTERED ([ActionHistoryID] ASC);
GO

-- Creating primary key on [id] in table 'ErrorLogs'
ALTER TABLE [dbo].[ErrorLogs]
ADD CONSTRAINT [PK_ErrorLogs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'MeasuringTypes'
ALTER TABLE [dbo].[MeasuringTypes]
ADD CONSTRAINT [PK_MeasuringTypes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [VariationID] in table 'ProductVariations'
ALTER TABLE [dbo].[ProductVariations]
ADD CONSTRAINT [PK_ProductVariations]
    PRIMARY KEY CLUSTERED ([VariationID] ASC);
GO

-- Creating primary key on [id] in table 'DamagedProducts'
ALTER TABLE [dbo].[DamagedProducts]
ADD CONSTRAINT [PK_DamagedProducts]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Category_id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductCategory]
    FOREIGN KEY ([Category_id])
    REFERENCES [dbo].[Categories]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductCategory'
CREATE INDEX [IX_FK_ProductCategory]
ON [dbo].[Products]
    ([Category_id]);
GO

-- Creating foreign key on [subCategory_id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductSubCategory]
    FOREIGN KEY ([subCategory_id])
    REFERENCES [dbo].[SubCategories]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductSubCategory'
CREATE INDEX [IX_FK_ProductSubCategory]
ON [dbo].[Products]
    ([subCategory_id]);
GO

-- Creating foreign key on [Category_id] in table 'SubCategories'
ALTER TABLE [dbo].[SubCategories]
ADD CONSTRAINT [FK_CategorySubCategory]
    FOREIGN KEY ([Category_id])
    REFERENCES [dbo].[Categories]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategorySubCategory'
CREATE INDEX [IX_FK_CategorySubCategory]
ON [dbo].[SubCategories]
    ([Category_id]);
GO

-- Creating foreign key on [dealer_id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_ProductDealer]
    FOREIGN KEY ([dealer_id])
    REFERENCES [dbo].[Dealers]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductDealer'
CREATE INDEX [IX_FK_ProductDealer]
ON [dbo].[Products]
    ([dealer_id]);
GO

-- Creating foreign key on [measured_by] in table 'ProductVariations'
ALTER TABLE [dbo].[ProductVariations]
ADD CONSTRAINT [FK_MesuringTypeProductVariation]
    FOREIGN KEY ([measured_by])
    REFERENCES [dbo].[MeasuringTypes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MesuringTypeProductVariation'
CREATE INDEX [IX_FK_MesuringTypeProductVariation]
ON [dbo].[ProductVariations]
    ([measured_by]);
GO

-- Creating foreign key on [brand_id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_BrandProduct]
    FOREIGN KEY ([brand_id])
    REFERENCES [dbo].[Brands]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BrandProduct'
CREATE INDEX [IX_FK_BrandProduct]
ON [dbo].[Products]
    ([brand_id]);
GO

-- Creating foreign key on [Product_id] in table 'ProductVariations'
ALTER TABLE [dbo].[ProductVariations]
ADD CONSTRAINT [FK_Product_ProductVariation]
    FOREIGN KEY ([Product_id])
    REFERENCES [dbo].[Products]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Product_ProductVariation'
CREATE INDEX [IX_FK_Product_ProductVariation]
ON [dbo].[ProductVariations]
    ([Product_id]);
GO

-- Creating foreign key on [ProductVariationVariationID] in table 'Transaction_Histories'
ALTER TABLE [dbo].[Transaction_Histories]
ADD CONSTRAINT [FK_ProductVariationTransaction_History]
    FOREIGN KEY ([ProductVariationVariationID])
    REFERENCES [dbo].[ProductVariations]
        ([VariationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductVariationTransaction_History'
CREATE INDEX [IX_FK_ProductVariationTransaction_History]
ON [dbo].[Transaction_Histories]
    ([ProductVariationVariationID]);
GO

-- Creating foreign key on [ProductVariationID] in table 'DamagedProducts'
ALTER TABLE [dbo].[DamagedProducts]
ADD CONSTRAINT [FK_ProductVariation_DamagedProduct]
    FOREIGN KEY ([ProductVariationID])
    REFERENCES [dbo].[ProductVariations]
        ([VariationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductVariation_DamagedProduct'
CREATE INDEX [IX_FK_ProductVariation_DamagedProduct]
ON [dbo].[DamagedProducts]
    ([ProductVariationID]);
GO

-- Creating foreign key on [Brand_id] in table 'Dealers'
ALTER TABLE [dbo].[Dealers]
ADD CONSTRAINT [FK_BrandDealer]
    FOREIGN KEY ([Brand_id])
    REFERENCES [dbo].[Brands]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BrandDealer'
CREATE INDEX [IX_FK_BrandDealer]
ON [dbo].[Dealers]
    ([Brand_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------