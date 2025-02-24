use EventPlaner;
go

CREATE TABLE [dbo].[EventParticipants]
(
    EventID INT NOT NULL,
    TeilnehmerID INT NOT NULL,

    CONSTRAINT PK_EventParticipants PRIMARY KEY (EventID, TeilnehmerID),

    CONSTRAINT FK_EventParticipants_Events
        FOREIGN KEY (EventID)
        REFERENCES [dbo].[Events](EventID)
        ON DELETE CASCADE,

    CONSTRAINT FK_EventParticipants_Participants
        FOREIGN KEY (TeilnehmerID)
        REFERENCES [dbo].Teilnehmer(TeilnehmerID)
        ON DELETE CASCADE
);