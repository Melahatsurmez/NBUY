	USE master
	GO
	
	DROP DATABASE IF EXISTS HastaneDb
	GO

	CREATE DATABASE HastaneDb
	GO

	--Üst taraf varsa HastaneDb yi silip yeniden oluþturur. Yoksa zaten oluþturur.

	USE HastaneDb
	GO --Üstteki iþlem uzunsa tamamlanmadan alta geçme komutudur.

	CREATE TABLE Hastalar(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		cinsiyet CHAR(1) NOT NULL,
		adres NVARCHAR(50),
		telefon CHAR(11)
	)
	GO

	INSERT INTO Hastalar(adSoyad, cinsiyet, adres) VALUES
		('Erencan Germirli','E','Ýstanbul'),
		('Selin Fergenç','K','Ankara'),
		('SAdi Kuloðlu','E','Ýzmir'),
		('Neþe Kalabalýk','K','Ýstanbul'),
		('Sevda Aðalar','K','Ýzmir'),
		('Nora Taþkesen','K','Ankara'),
		('Emma Çeteoðlu','K','Ýstanbul'),
		('Kerem Sözcü','E','Ankara'),
		('Suat Tartar','E','Ýzmir')
GO

CREATE TABLE Bolumler(
	id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Bolumler VALUES
	('Dahiliye'),('Nöroloji'),('Ortopedi'),
	('Diþ'),('Periodontoloji'),('Genel Cerrahi')
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
	('Ali Can','Ýstanbul',1),	
	('Demet Evgar','Bursa',2),
	('Sedat Kanar','Ýstanbul',3),
	('Ferhunde haným','Ýzmir',1),
	('Zafer Kimki','Ankara',2),
	('Hale Elveren','Ýstanbul',3),
	('Tuna Sefer','Ankara',4),
	('Kevser Tutku','Ýstanbul',4),
	('Tutkum Kapýþmak','Ýzmir',5),
	('Ýsa Canova','Ýzmir',5),
	('Tuðçe Bölümsüz','Ýzmir',null)
GO

--Yukarýdaki insert into satýrýrnýn sonuncusunun alternatifi burasýdýr.
--INSERT INTO Doktorlar (adSoyad,adres) Values
--	('Tuðçe Bölümsüz','Ýzmir')
--GO

	