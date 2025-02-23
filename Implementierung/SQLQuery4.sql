use EventPlaner;
go

ALTER TABLE [dbo].[Teilnehmer]
ADD CONSTRAINT [PK_Teilnehmer]
    PRIMARY KEY CLUSTERED ([TeilnehmerID]);
GO











