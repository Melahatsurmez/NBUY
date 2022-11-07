/*
1)KutuphaneDb adýnda bir veri tabaný oluþturunuz.
2)Veri tabanýnda aþaðýdaki tablolar bulunsuz
	Turler =Ýd Ad
	Yazarlar= id adSoad Cinsiyet yaþ 
	YayýnEvleri adres ad
	Uyeler=ad 
	Kitaplar= ad yayýn evi yazar tür 
	OduncIslemleri= hangi kitap kime hangi tarihte ödünç verildi.

	yeteri kaadadr örnek veri giriþi yapýnýz.
*/

USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
	GO

	CREATE DATABASE KutuphaneDb
	GO

	USE KutuphaneDb
	GO

	CREATE TABLE Turler(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(50) NOT NULL
	)
	GO

	INSERT INTO Turler VALUES
		('Genel'),('Tarih'),('Bilim Kurgu'),('Komedi'),
		('Sanat'),('Kiþisel Geliþim'),('Macera')
	GO
	
	CREATE TABLE Yazarlar(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		cinsiyet CHAR(1) NOT NULL,
		yas INT NOT NULL
	)
	GO

	INSERT INTO Yazarlar VALUES
		('Ahmet Ümit','E','55'),
		('Can Ozan','E','45'),
		('Selcim Kira','K','38'),
		('Selim Onur','E','50'),
		('Kýymet Derya','K','55'),
		('Ayþe Ýl','K','35'),
		('Kevser But','K','30'),
		('Ýlyas Yar','E','38')
	GO
	CREATE TABLE Yayinevi(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(50) NOT NULL,
		adres NVARCHAR(50)
	)
	GO

	INSERT INTO Yayinevi VALUES
		('Uður Yayýnlarý','Ýstanbul'),
		('Can Yayýnlarý','Ankara'),
		('Palme Yayýnlarý','Ýzmir'),
		('Kitapevi Yayýnlarý','Ýstanbul'),
		('Þiir Yayýnlarý','Ýzmir')
	GO

	CREATE TABLE Uyeler(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL
	)
	GO
	
	INSERT INTO Uyeler VALUES
		('Ayþe Karacan'), ('Selvi Boyundur'),('Uðurcan Köse'),
		('Mekan Gochov'),('Berkay Çallý'),('Taha Ýlter')
	GO

	CREATE TABLE Kitaplar(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(30) NOT NULL,
		yayineviId INT FOREIGN KEY REFERENCES Yayinevi (id) ON DELETE CASCADE,
		yazarlarId INT FOREIGN KEY REFERENCES Yazarlar (id) ON DELETE SET NULL,
		turlerId INT DEFAULT 1 FOREIGN KEY REFERENCES Turler (id) ON DELETE SET DEFAULT
		
	)
	GO

	INSERT INTO Kitaplar VALUES
		('Uçurtma Avcýsý',5,8,6),
		('Sefiller',4,7,5),
		('Satranç',3,6,4),
		('Oblomov',2,5,3),
		('Korku',2,4,2),
		('Fahrenheit 451',5,3,1)	
	GO
	CREATE TABLE OduncIslemleri(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		tarih DATE NOT NULL,
		uyelerId INT,
		kitaplarID INT,
		FOREIGN KEY (uyelerId) REFERENCES Uyeler (id),
		FOREIGN KEY (kitaplarId) REFERENCES Kitaplar(id)
	)
	GO
	INSERT INTO OduncIslemleri VALUES
		('2022-05-11',6,6),
		('2022-04-12',2,5),
		('2022-1-5',4,4),
		('2022-1-1',3,3),
		('2022-1-5',3,2),
		('2022-6-8',1,2)
	GO
	