﻿/*
Deployment script for MedicalTravelDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "MedicalTravelDB"
:setvar DefaultFilePrefix "MedicalTravelDB"
:setvar DefaultDataPath "C:\Users\patel\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\patel\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Doctors]...';


GO
CREATE TABLE [dbo].[Doctors] (
    [DoctorID]    INT         NOT NULL,
    [DoctorName]  VARCHAR (1) NOT NULL,
    [DoctorPhone] INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([DoctorID] ASC)
);


GO
PRINT N'Creating [dbo].[Inquiry]...';


GO
CREATE TABLE [dbo].[Inquiry] (
    [PatientEmail]    NVARCHAR (50) NOT NULL,
    [PatientFullName] NVARCHAR (50) NOT NULL,
    [PhoneNumber]     INT           NULL,
    [InquiryStatus]   BIT           NOT NULL,
    [SourceOfInquiry] NVARCHAR (50) NOT NULL,
    [TreatmentID]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([PatientEmail] ASC)
);


GO
PRINT N'Creating [dbo].[Sales]...';


GO
CREATE TABLE [dbo].[Sales] (
    [SalesID]                  INT           IDENTITY (1, 1) NOT NULL,
    [PatientEmail]             NVARCHAR (50) NOT NULL,
    [DoctorID]                 INT           NOT NULL,
    [TreatmentID]              INT           NOT NULL,
    [PatientsFullName]         VARCHAR (50)  NOT NULL,
    [PhoneNumber]              INT           NOT NULL,
    [DepositRequired]          INT           NOT NULL,
    [TotalRemainingBalance]    INT           NOT NULL,
    [RemainingBalanceToDoctor] INT           NOT NULL,
    [NetProfit]                INT           NOT NULL,
    [DoctorAppointedDate]      DATE          NOT NULL
);


GO
PRINT N'Creating [dbo].[Treatment]...';


GO
CREATE TABLE [dbo].[Treatment] (
    [TreatmentID]    INT           NOT NULL,
    [TreatmentName]  NVARCHAR (50) NOT NULL,
    [TreatmentPrice] NVARCHAR (50) NOT NULL,
    [DoctorID]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([TreatmentID] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Treatment_Inquiry_TreatmentID]...';


GO
ALTER TABLE [dbo].[Inquiry]
    ADD CONSTRAINT [FK_Treatment_Inquiry_TreatmentID] FOREIGN KEY ([TreatmentID]) REFERENCES [dbo].[Treatment] ([TreatmentID]) ON DELETE CASCADE ON UPDATE CASCADE;


GO
PRINT N'Creating [dbo].[FK_Inquiry_Sales_PatientEmail]...';


GO
ALTER TABLE [dbo].[Sales]
    ADD CONSTRAINT [FK_Inquiry_Sales_PatientEmail] FOREIGN KEY ([PatientEmail]) REFERENCES [dbo].[Inquiry] ([PatientEmail]) ON DELETE CASCADE ON UPDATE CASCADE;


GO
PRINT N'Creating [dbo].[FK_Doctor_Sales_DoctorID]...';


GO
ALTER TABLE [dbo].[Sales]
    ADD CONSTRAINT [FK_Doctor_Sales_DoctorID] FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctors] ([DoctorID]) ON DELETE CASCADE ON UPDATE CASCADE;


GO
PRINT N'Creating [dbo].[FK_Treatment_Sales_TreatmentID]...';


GO
ALTER TABLE [dbo].[Sales]
    ADD CONSTRAINT [FK_Treatment_Sales_TreatmentID] FOREIGN KEY ([TreatmentID]) REFERENCES [dbo].[Treatment] ([TreatmentID]) ON DELETE CASCADE ON UPDATE CASCADE;


GO
PRINT N'Creating [dbo].[FK_Doctors_Treatment_DoctorID]...';


GO
ALTER TABLE [dbo].[Treatment]
    ADD CONSTRAINT [FK_Doctors_Treatment_DoctorID] FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctors] ([DoctorID]) ON DELETE CASCADE ON UPDATE CASCADE;


GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
delete from dbo.Doctors
DBCC CHECKIDENT (Doctors, RESEED, 0)
GO
DELETE FROM [dbo].Inquiry
DBCC CHECKIDENT (Inquiry, RESEED, 0)
GO
DELETE FROM [dbo].Sales
DBCC CHECKIDENT (Sales, RESEED, 0)
GO
DELETE FROM [dbo].Treatment
DBCC CHECKIDENT (Treatment, RESEED, 0)
GO

SET IDENTITY_INSERT [dbo].Doctors ON
INSERT INTO [dbo].[Doctors] ([Doctor_ID], [DoctorName], [DoctorPhone]) VALUES (1, N'Gamze Savas', N'905322751423')
INSERT INTO [dbo].[Doctors] ([Doctor_ID], [DoctorName], [DoctorPhone]) VALUES (2, N'Selahattin Tulunay', N'905432123436')
INSERT INTO [dbo].[Doctors] ([Doctor_ID], [DoctorName], [DoctorPhone]) VALUES (3, N'Resat Aktug', N'905332123435')
INSERT INTO [dbo].[Doctors] ([Doctor_ID], [DoctorName], [DoctorPhone]) VALUES (4, N'Mjholly', N'4475023425')
INSERT INTO [dbo].[Doctors] ([Doctor_ID], [DoctorName], [DoctorPhone]) VALUES (5, N'Mustafe Bese', N'905442326782')
INSERT INTO [dbo].[Doctors] ([Doctor_ID], [DoctorName], [DoctorPhone]) VALUES (6, N'Esra Drago', N'905442326782')
SET IDENTITY_INSERT [dbo].[Doctors] OFF
GO

SET IDENTITY_INSERT [dbo].Treatment ON
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (1, 1, N'Hair Transplant', N'1550')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (1, 2, N'Hair Transplant', N'1750')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (1, 3, N'Hair Transplant', N'2000')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (1, 4, N'Hair Transplant', N'2250')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, 1, N'Hair Transplant', N'1550')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, 2, N'Hair Transplant', N'1750')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, 3, N'Hair Transplant', N'2000')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (2, 4, N'Hair Transplant', N'2250')


INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (3, 2, N'Liposuction', N'1250')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (3, 3, N'Liposuction', N'1350')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (3, 4, N'Liposuction', N'1550')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (4, 2, N'Gynecommasty', N'1950')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (4, 3, N'Gynecommasty', N'2150')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (4, 4, N'Gynecommasty', N'2150')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, 2, N'Breast Reduction', N'1700')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, 3, N'Breast Reduction', N'1750')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (5, 4, N'Breast Reduction', N'1900')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (6, 2, N'Breast Enlargement', N'1700')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (6, 3, N'Breast Enlargement', N'1750')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (6, 4, N'Breast Enlargement', N'1900')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (7, 2, N'Uplift', N'1300')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (7, 3, N'Uplift', N'1400')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (7, 4, N'Uplift', N'1600')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (8, 2, N'Rhinoplasty', N'2100')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (8, 3, N'Rhinoplasty', N'2300')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (8, 4, N'Rhinoplasty', N'2700')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (9,2, N'Tummy Tuck', N'2500')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (9,3, N'Tummy Tuck', N'2700')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (9,4, N'Tummy Tuck', N'3000')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (10,2, N'Chin Implant', N'2000')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (10,3, N'Chin Implant', N'2100')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (10,4, N'Chin Implant', N'2250')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (11,2, N'Forehead Lifting', N'1900')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (11,3, N'Forehead Lifting', N'2100')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (11,4, N'Forehead Lifting', N'2300')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (12, 5, N'Porcelan Veneer', N'1100')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (12, 6, N'Porcelan Veneer', N'1000')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (13, 5, N'Dental Implant', N'1400')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (13, 6, N'Dental Implant', N'1300')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (14, 5, N'Hollywood Smile', N'3400')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (14, 6, N'Hollywood Smile', N'3100')

INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (15, 5, N'Dental Cleaning', N'300')
INSERT INTO [dbo].[Treatment] ([TreatmentID], [DoctorID], [TreatmentName], [TreatmentPrice]) VALUES (15, 6, N'Dental Cleaning', N'450')

SET IDENTITY_INSERT [dbo].[Treatment] OFF
GO


SET IDENTITY_INSERT [dbo].Inquiry ON
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'ehezzynz@gmail.com', N'Ezzedine Hamdallah', N'61406571656', N'Active', 'Facebook', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'sarahfaiz99@gmail.com', N'Sara Faiz', N'212668023354', N'Treated', N'Website', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'suleyman5555@gmail.com', N'Suleyman', N'447840009007', N'Inactive', N'Instagram', 3)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'ghakhar@hotmail.co.uk', N'Azhar', N'447791287332', N'Treated', N'WhatsApp', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'jamescs1981@hotmail.co.uk', N'Alize Nal', N'4412353123', N'Treated', N'Website', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'homez247@hotmail.co.uk', N'Mlai Aps', N'44123512312', N'Active', N'Website', 1)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'munirahmad_786@hotmail.com', N'Munir Ahmad', N'331235544', N'Inactive', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'gdr1a@yahoo.it', N'Oplik Mikl', N'90213451231', N'Active', N'Instagram', 3)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'cpkumara1@gmail.com', N'Pathmakumar', N'445431233', N'Active', N'Website', 4)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
INSERT INTO [dbo].[Inquiry] ([PatientEmail], [PatientFullName], [PhoneNumber], [InquiryStatus], [SourceOfInquiry], [TreatmentID]) VALUES (N'nadeemakhtar_155@yahoo.com', N'Nadeem Akhtar', N'448987123123', N'Treated', N'Facebook', 2)
SET IDENTITY_INSERT [dbo].[Inquiry] OFF
GO
insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'sarahfaiz99@gmail.com', 1, 1, N'Sara Faiz', N'212668023354', N'100', N'1450', N'700', N'850', N'12/11/2012')
insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'ghakhar@hotmail.co.uk', 2, 1, N'Azhar', N'447791287332', N'100', N'1650', N'900', N'850', N'11/10/2014')
insert into [dbo].[Sales] ([PatientEmail], [DoctorID], [TreatmentID], [PatientsFullName], [PhoneNumber], [DepositRequired], [TotalRemainingBalance], [RemainingBalanceToDoctor], [NetProfit], [DoctorAppointedDate]) VALUES (N'jamescs1981@hotmail.co.uk', 3, 1, N'Alize Nal', N'4412353123', N'100', N'1900', N'1100', N'900', N'04/03/2017')
GO





GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
