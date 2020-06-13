﻿/*
Deployment script for MetaDomingoDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "MetaDomingoDatabase"
:setvar DefaultFilePrefix "MetaDomingoDatabase"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The column CustomerInvoiceId on table [dbo].[CustomerInvoiceLine] must be changed from NULL to NOT NULL. If the table contains data, the ALTER script may not work. To avoid this issue, you must add values to this column for all rows or mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[CustomerInvoiceLine])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping [dbo].[FK_CustomerInvoiceLine_CustomerInvoice_CustomerInvoiceId]...';


GO
ALTER TABLE [dbo].[CustomerInvoiceLine] DROP CONSTRAINT [FK_CustomerInvoiceLine_CustomerInvoice_CustomerInvoiceId];


GO
PRINT N'Altering [dbo].[CustomerInvoiceLine]...';


GO
ALTER TABLE [dbo].[CustomerInvoiceLine] ALTER COLUMN [CustomerInvoiceId] NVARCHAR (450) NOT NULL;


GO
PRINT N'Creating unnamed constraint on [dbo].[CustomerInvoice]...';


GO
ALTER TABLE [dbo].[CustomerInvoice]
    ADD DEFAULT NULL FOR [InvoiceReference];


GO
PRINT N'Creating unnamed constraint on [dbo].[CustomerInvoice]...';


GO
ALTER TABLE [dbo].[CustomerInvoice]
    ADD DEFAULT NULL FOR [NoteToRecipient];


GO
PRINT N'Creating unnamed constraint on [dbo].[CustomerInvoice]...';


GO
ALTER TABLE [dbo].[CustomerInvoice]
    ADD DEFAULT NULL FOR [TermsAndConditions];


GO
PRINT N'Creating unnamed constraint on [dbo].[CustomerInvoiceLine]...';


GO
ALTER TABLE [dbo].[CustomerInvoiceLine]
    ADD DEFAULT NULL FOR [Description];


GO
PRINT N'Creating [dbo].[FK_CustomerInvoiceLine_CustomerInvoice_CustomerInvoiceId]...';


GO
ALTER TABLE [dbo].[CustomerInvoiceLine] WITH NOCHECK
    ADD CONSTRAINT [FK_CustomerInvoiceLine_CustomerInvoice_CustomerInvoiceId] FOREIGN KEY ([CustomerInvoiceId]) REFERENCES [dbo].[CustomerInvoice] ([CustomerInvoiceId]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[CustomerInvoiceLine] WITH CHECK CHECK CONSTRAINT [FK_CustomerInvoiceLine_CustomerInvoice_CustomerInvoiceId];


GO
PRINT N'Update complete.';


GO
