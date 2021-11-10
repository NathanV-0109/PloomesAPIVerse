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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105225906_Verse')
BEGIN
    CREATE TABLE [Verses] (
        [Book] nvarchar(450) NOT NULL,
        [Verse] int NOT NULL,
        [Chapter] int NOT NULL,
        [Text] nvarchar(max) NULL,
        CONSTRAINT [PK_Verses] PRIMARY KEY ([Book])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105225906_Verse')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211105225906_Verse', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105234812_Verse2')
BEGIN
    ALTER TABLE [Verses] DROP CONSTRAINT [PK_Verses];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105234812_Verse2')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Verses]') AND [c].[name] = N'Book');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Verses] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Verses] ALTER COLUMN [Book] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105234812_Verse2')
BEGIN
    ALTER TABLE [Verses] ADD [id] int NOT NULL IDENTITY;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105234812_Verse2')
BEGIN
    ALTER TABLE [Verses] ADD CONSTRAINT [PK_Verses] PRIMARY KEY ([id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211105234812_Verse2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211105234812_Verse2', N'5.0.11');
END;
GO

COMMIT;
GO

