create database EventPlaner
go

use EventPlaner
go

CREATE TABLE Events (
    EventID INT PRIMARY KEY,
    Titel VARCHAR(100) NOT NULL,
    Datum DATE NOT NULL,
    Details TEXT
);

CREATE TABLE Teilnehmer (
    TeilnehmerID INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    EventID INT,
    FOREIGN KEY (EventID) REFERENCES Events(EventID)
	);

