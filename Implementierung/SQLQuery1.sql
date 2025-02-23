use EventPlaner;
go 

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Events')
BEGIN
    CREATE TABLE [dbo].[Events]
    (
        Id INT IDENTITY(1,1) NOT NULL,
        Titel NVARCHAR(200) NOT NULL,
        Datum DATE NOT NULL,
        Details NVARCHAR(MAX) NULL,
        CONSTRAINT PK_Events PRIMARY KEY CLUSTERED (Id ASC)
    );
END;

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Teilnehmer')
BEGIN
    CREATE TABLE [dbo].[Teilnehmer]
    (
        TeilnehmerId INT IDENTITY(1,1) NOT NULL,
        [Name] NVARCHAR(200) NOT NULL,
        [Email] NVARCHAR(100) NOT NULL,
        [Age] INT NOT NULL,
        EventId INT NULL,  

        CONSTRAINT PK_Teilnehmer PRIMARY KEY CLUSTERED (TeilnehmerId ASC),

       
        CONSTRAINT FK_Teilnehmer_Events
            FOREIGN KEY (EventId)
            REFERENCES [dbo].[Events](EventId)
            ON DELETE SET NULL  
    );
END;
