/*
    Script de criação do banco para o LeitorXML (SQL Server)
    - Cria o banco LeitorXmlDb se não existir
    - Cria a tabela dbo.NotasFiscais se não existir
    - Cria índice único para ChaveAcesso
*/

USE master;
GO

IF DB_ID(N'LeitorXmlDb') IS NULL
BEGIN
    CREATE DATABASE LeitorXmlDb;
END
GO

USE LeitorXmlDb;
GO

IF OBJECT_ID(N'dbo.NotasFiscais', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.NotasFiscais
    (
        Id INT IDENTITY(1,1) NOT NULL,
        Numero NVARCHAR(30) NOT NULL,
        Serie NVARCHAR(20) NOT NULL,
        DataEmissao NVARCHAR(50) NOT NULL,
        ValorTotal NVARCHAR(30) NOT NULL,
        Emitente NVARCHAR(200) NOT NULL,
        CnpjEmitente NVARCHAR(20) NOT NULL,
        ChaveAcesso NVARCHAR(60) NOT NULL,
        CONSTRAINT PK_NotasFiscais PRIMARY KEY (Id)
    );
END
GO

IF NOT EXISTS
(
    SELECT 1
    FROM sys.indexes
    WHERE name = N'IX_NotasFiscais_ChaveAcesso'
      AND object_id = OBJECT_ID(N'dbo.NotasFiscais')
)
BEGIN
    CREATE UNIQUE INDEX IX_NotasFiscais_ChaveAcesso
        ON dbo.NotasFiscais (ChaveAcesso);
END
GO
