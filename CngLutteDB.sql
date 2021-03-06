/*    ==Paramètres de script==

    Version du serveur source : SQL Server 2016 (13.0.4224)
    Édition du moteur de base de données source : Microsoft SQL Server Enterprise Edition
    Type du moteur de base de données source : SQL Server autonome

    Version du serveur cible : SQL Server 2016
    Édition du moteur de base de données cible : Microsoft SQL Server Enterprise Edition
    Type du moteur de base de données cible : SQL Server autonome
*/

USE [master]
GO

/****** Object:  Database [CNGLUTTEDB]    Script Date: 15/11/2018 23:00:28 ******/
CREATE DATABASE [CNGLUTTEDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CNGLUTTEDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.FALLSQLSERVER\MSSQL\DATA\CNGLUTTEDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CNGLUTTEDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.FALLSQLSERVER\MSSQL\DATA\CNGLUTTEDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [CNGLUTTEDB] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CNGLUTTEDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CNGLUTTEDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CNGLUTTEDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CNGLUTTEDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CNGLUTTEDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CNGLUTTEDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET RECOVERY FULL 
GO

ALTER DATABASE [CNGLUTTEDB] SET  MULTI_USER 
GO

ALTER DATABASE [CNGLUTTEDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CNGLUTTEDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CNGLUTTEDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CNGLUTTEDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CNGLUTTEDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CNGLUTTEDB] SET QUERY_STORE = OFF
GO

USE [CNGLUTTEDB]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [CNGLUTTEDB] SET  READ_WRITE 
GO

