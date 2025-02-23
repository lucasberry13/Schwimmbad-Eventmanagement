use EventPlaner;
go

EXEC sp_rename 
    'dbo.Teilnehmer.Age',  
    'Alter',                   
    'COLUMN';  