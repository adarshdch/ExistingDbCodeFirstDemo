# Existing Database Code First Demo
Existing Database Code First Demo Application With Migration

## Steps followed to create this application:

### Create an Existing Database
```
USE [master]
GO

/****** Object:  Database [ExistingDbCodeFirstDemo]    Script Date: 5/26/2016 1:18:14 PM ******/
CREATE DATABASE [ExistingDbCodeFirstDemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExistingDbCodeFirstDemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ExistingDbCodeFirstDemo.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ExistingDbCodeFirstDemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ExistingDbCodeFirstDemo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExistingDbCodeFirstDemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET ARITHABORT OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET RECOVERY FULL 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET  MULTI_USER 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ExistingDbCodeFirstDemo] SET  READ_WRITE 
GO
```

### Create an existing table

```
USE [ExistingDbCodeFirstDemo]
GO

/****** Object:  Table [dbo].[ExistingTable]    Script Date: 5/26/2016 1:20:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ExistingTable](
    [Id] [int] NOT NULL,
    [Data] [nvarchar](50) NULL,
 CONSTRAINT [PK_ExistingTable] PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
```
### Add some initial records in existing table
```
USE [ExistingDbCodeFirstDemo]
GO

INSERT INTO [dbo].[ExistingTable] ([Id], [Data]) VALUES (10, 'Some data 1')
INSERT INTO [dbo].[ExistingTable] ([Id], [Data]) VALUES (11, 'Some data 2')
INSERT INTO [dbo].[ExistingTable] ([Id], [Data]) VALUES (12, 'Some data 3')
GO
```

### Create the Application
> Its already done for you and shared in this repository.

### Update the DbContext to include the POCO class for new table
> Its already done for you and shared in this repository.
### Database Migration using "Nugget Package Manager Console"
> Database Migration should be done to create table for the newly added POCO classes
#### Enable Migrations
```
// Execute below command to enable database migration for your application
Enable-Migrations
```
#### Add/Generate Migration Configuration
```
// Execute below command to add database migration.
// It will generate the migration snapshot file.
// I am including this file for your reference but you can delete it and generate it again.
Add-Migration
```
#### Update Database using the Migration Configuration
> Be careful while executing this command.
> It may delete existing table and create again.
> If you do not want so just comment some lines in generated migration snapshot file as I have done in existing migration file.
> Update database after carefully reading and understanding the migration snapshot file.

```
Update-Database
```
### Run application to see it work

Note: Please feel free to raise any issue or suggestion.

Reference: https://msdn.microsoft.com/en-us/library/jj200620.aspx
