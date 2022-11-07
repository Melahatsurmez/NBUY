	USE master
	GO
	
	DROP DATABASE IF EXISTS HastaneDb
	GO

	CREATE DATABASE HastaneDb
	GO

	--�st taraf varsa HastaneDb yi silip yeniden olu�turur. Yoksa zaten olu�turur.

	USE HastaneDb
	GO --�stteki i�lem uzunsa tamamlanmadan alta ge�me komutudur.

	CREATE TABLE Hastalar(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		cinsiyet CHAR(1) NOT NULL,
		adres NVARCHAR(50),
		telefon CHAR(11)
	)
	GO

	INSERT INTO Hastalar(adSoyad, cinsiyet, adres) VALUES
		('Erencan Germirli','E','�stanbul'),
		('Selin Fergen�','K','Ankara'),
		('SAdi Kulo�lu','E','�zmir'),
		('Ne�e Kalabal�k','K','�stanbul'),
		('Sevda A�alar','K','�zmir'),
		('Nora Ta�kesen','K','Ankara'),
		('Emma �eteo�lu','K','�stanbul'),
		('Kerem S�zc�','E','Ankara'),
		('Suat Tartar','E','�zmir')
GO

CREATE TABLE Bolumler(
	id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Bolumler VALUES
	('Dahiliye'),('N�roloji'),('Ortopedi'),
	('Di�'),('Periodontoloji'),('Genel Cerrahi')
GO

CREATE TABLE Doktorlar(
	id INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	ADRES NVARCHAR(50),
	bolumId INT,
	FOREIGN KEY (bolumID) REFERENCES Bolumler(id)
)
GO
INSERT INTO Doktorlar VALUES
	('Ali Can','�stanbul',1),	
	('Demet Evgar','Bursa',2),
	('Sedat Kanar','�stanbul',3),
	('Ferhunde han�m','�zmir',1),
	('Zafer Kimki','Ankara',2),
	('Hale Elveren','�stanbul',3),
	('Tuna Sefer','Ankara',4),
	('Kevser Tutku','�stanbul',4),
	('Tutkum Kap��mak','�zmir',5),
	('�sa Canova','�zmir',5),
	('Tu��e B�l�ms�z','�zmir',null)
GO

--Yukar�daki insert into sat�r�rn�n sonuncusunun alternatifi buras�d�r.
--INSERT INTO Doktorlar (adSoyad,adres) Values
--	('Tu��e B�l�ms�z','�zmir')
--GO

	