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

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323195557_InitialMigration'
)
BEGIN
    CREATE TABLE [Coachs] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Coachs] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323195557_InitialMigration'
)
BEGIN
    CREATE TABLE [Teams] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Teams] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323195557_InitialMigration'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240323195557_InitialMigration', N'8.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323203247_seedingTeams'
)
BEGIN
    ALTER TABLE [Teams] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323203247_seedingTeams'
)
BEGIN
    ALTER TABLE [Coachs] ADD [CreatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323203247_seedingTeams'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Teams]'))
        SET IDENTITY_INSERT [Teams] ON;
    EXEC(N'INSERT INTO [Teams] ([Id], [CreatedDate], [Name])
    VALUES (1, ''2024-03-23T20:32:47.1997002'', N''Tivoli Garden F.C.''),
    (2, ''2024-03-23T20:32:47.1997023'', N''Waterhourse  F.C.''),
    (3, ''2024-03-23T20:32:47.1997024'', N''Humble Lions F.C.'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Teams]'))
        SET IDENTITY_INSERT [Teams] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240323203247_seedingTeams'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240323203247_seedingTeams', N'8.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324143719_addingMoreTeams'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T14:37:16.9378910''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324143719_addingMoreTeams'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T14:37:16.9378925''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324143719_addingMoreTeams'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T14:37:16.9378926''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324143719_addingMoreTeams'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Teams]'))
        SET IDENTITY_INSERT [Teams] ON;
    EXEC(N'INSERT INTO [Teams] ([Id], [CreatedDate], [Name])
    VALUES (4, ''2024-03-24T14:37:16.9378927'', N''Chelsea F.C.''),
    (5, ''2024-03-24T14:37:16.9378929'', N''Real Madrid ''),
    (6, ''2024-03-24T14:37:16.9378933'', N''Inter Milan''),
    (7, ''2024-03-24T14:37:16.9378934'', N''Inter Miami''),
    (8, ''2024-03-24T14:37:16.9378936'', N''Seba United'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedDate', N'Name') AND [object_id] = OBJECT_ID(N'[Teams]'))
        SET IDENTITY_INSERT [Teams] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324143719_addingMoreTeams'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240324143719_addingMoreTeams', N'8.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Teams] ADD [CoachId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Teams] ADD [CreatedBy] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Teams] ADD [LeagueId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Teams] ADD [UpdatedBy] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Teams] ADD [UpdatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Coachs] ADD [CreatedBy] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Coachs] ADD [TeamId] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Coachs] ADD [UpdatedBy] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    ALTER TABLE [Coachs] ADD [UpdatedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    CREATE TABLE [Leagues] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [UpdatedDate] datetime2 NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Leagues] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    CREATE TABLE [Matchs] (
        [Id] int NOT NULL IDENTITY,
        [HomeTeamId] int NOT NULL,
        [AwayTeamId] int NOT NULL,
        [TicketPrice] decimal(18,2) NOT NULL,
        [Date] datetime2 NOT NULL,
        [CreatedDate] datetime2 NOT NULL,
        [UpdatedDate] datetime2 NOT NULL,
        [CreatedBy] nvarchar(max) NULL,
        [UpdatedBy] nvarchar(max) NULL,
        CONSTRAINT [PK_Matchs] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521284'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521297'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521299'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521300'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521302'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521307'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521308'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CoachId] = 0, [CreatedBy] = NULL, [CreatedDate] = ''2024-03-24T20:07:32.6521309'', [LeagueId] = 0, [UpdatedBy] = NULL, [UpdatedDate] = ''0001-01-01T00:00:00.0000000''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324200735_AddMoreEntities'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240324200735_AddMoreEntities', N'8.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedDate', N'Name', N'UpdatedBy', N'UpdatedDate') AND [object_id] = OBJECT_ID(N'[Leagues]'))
        SET IDENTITY_INSERT [Leagues] ON;
    EXEC(N'INSERT INTO [Leagues] ([Id], [CreatedBy], [CreatedDate], [Name], [UpdatedBy], [UpdatedDate])
    VALUES (1, NULL, ''0001-01-01T00:00:00.0000000'', N''Jamica Premiere League '', NULL, ''0001-01-01T00:00:00.0000000''),
    (2, NULL, ''0001-01-01T00:00:00.0000000'', N''English Premier League'', NULL, ''0001-01-01T00:00:00.0000000''),
    (3, NULL, ''0001-01-01T00:00:00.0000000'', N''La Liga'', NULL, ''0001-01-01T00:00:00.0000000'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedDate', N'Name', N'UpdatedBy', N'UpdatedDate') AND [object_id] = OBJECT_ID(N'[Leagues]'))
        SET IDENTITY_INSERT [Leagues] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844482''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844498''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844500''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844501''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844502''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844506''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844508''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    EXEC(N'UPDATE [Teams] SET [CreatedDate] = ''2024-03-24T20:58:25.4844509''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240324205826_SeedingLeagues'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240324205826_SeedingLeagues', N'8.0.3');
END;
GO

COMMIT;
GO

