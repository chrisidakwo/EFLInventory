
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/10/2017 00:38:48
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

IF OBJECT_ID(N'[dbo].[FK_DealerSelling_History]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Selling_Histories] DROP CONSTRAINT [FK_DealerSelling_History];
GO
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
IF OBJECT_ID(N'[dbo].[FK_TransactionType_SellingHistory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Selling_Histories] DROP CONSTRAINT [FK_TransactionType_SellingHistory];
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
IF OBJECT_ID(N'[dbo].[Selling_Histories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Selling_Histories];
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

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [image_url] nvarchar(max)  NULL,
    [brand] nvarchar(max)  NULL,
    [dealer_id] int  NOT NULL,
    [Category_id] int  NOT NULL,
    [subCategory_id] int  NOT NULL,
    [weight] nvarchar(max)  NOT NULL,
    [cost_price] decimal(18,0)  NOT NULL,
    [sell_price] decimal(18,0)  NOT NULL,
    [status] bit  NOT NULL,
    [stock_threshold] int  NOT NULL,
    [Stock] int  NULL,
    [date_created] datetime  NOT NULL,
    [last_updated] datetime  NULL
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

-- Creating table 'Selling_Histories'
CREATE TABLE [dbo].[Selling_Histories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dealer_id] int  NULL,
    [product_id] int  NOT NULL,
    [quantity] int  NOT NULL,
    [credit] decimal(18,0)  NULL,
    [debit] decimal(18,0)  NULL,
    [transaction_type_id] int  NOT NULL,
    [customer_info] nvarchar(max)  NULL,
    [payment_type] nvarchar(max)  NOT NULL,
    [payment_date] datetime  NOT NULL,
    [customer_name] nvarchar(max)  NULL,
    [remarks] nvarchar(max)  NULL
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
    [last_updated] datetime  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [full_name] nvarchar(max)  NULL,
    [date_created] nvarchar(max)  NOT NULL,
    [last_updated] nvarchar(max)  NULL,
    [is_superuser] bit  NOT NULL
);
GO

-- Creating table 'ActionHistories'
CREATE TABLE [dbo].[ActionHistories] (
    [ActionHistoryID] uniqueidentifier  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [timestamp] nvarchar(max)  NOT NULL,
    [userid] int  NOT NULL
);
GO

-- Creating table 'ErrorLogs'
CREATE TABLE [dbo].[ErrorLogs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [error_time] datetime  NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [error_number] nvarchar(max)  NOT NULL,
    [error_severity] nvarchar(max)  NOT NULL,
    [error_state] nvarchar(max)  NOT NULL,
    [error_proceedure] nvarchar(max)  NOT NULL,
    [error_line] nvarchar(max)  NOT NULL,
    [error_message] nvarchar(max)  NOT NULL
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

-- Creating primary key on [id] in table 'Selling_Histories'
ALTER TABLE [dbo].[Selling_Histories]
ADD CONSTRAINT [PK_Selling_Histories]
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [dealer_id] in table 'Selling_Histories'
ALTER TABLE [dbo].[Selling_Histories]
ADD CONSTRAINT [FK_DealerSelling_History]
    FOREIGN KEY ([dealer_id])
    REFERENCES [dbo].[Dealers]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DealerSelling_History'
CREATE INDEX [IX_FK_DealerSelling_History]
ON [dbo].[Selling_Histories]
    ([dealer_id]);
GO

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

-- Creating foreign key on [transaction_type_id] in table 'Selling_Histories'
ALTER TABLE [dbo].[Selling_Histories]
ADD CONSTRAINT [FK_TransactionType_SellingHistory]
    FOREIGN KEY ([transaction_type_id])
    REFERENCES [dbo].[Transaction_Types]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionType_SellingHistory'
CREATE INDEX [IX_FK_TransactionType_SellingHistory]
ON [dbo].[Selling_Histories]
    ([transaction_type_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------