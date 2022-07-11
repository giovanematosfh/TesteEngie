IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Fornecedores] (
    [Id] uniqueidentifier NOT NULL,
    [Name] varchar(200) NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Fornecedores] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Usinas] (
    [Id] uniqueidentifier NOT NULL,
    [FornecedorId] uniqueidentifier NULL,
    [UcUsina] int NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Usinas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Usinas_Fornecedores_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [Fornecedores] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Usinas_FornecedorId] ON [Usinas] ([FornecedorId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220711002249_initial', N'5.0.0');
GO

COMMIT;
GO

