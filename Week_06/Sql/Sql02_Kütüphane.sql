/*
1)KutuphaneDb ad�nda bir veri taban� olu�turunuz.
2)Veri taban�nda a�a��daki tablolar bulunsuz
	Turler =�d Ad
	Yazarlar= id adSoad Cinsiyet ya� 
	Yay�nEvleri adres ad
	Uyeler=ad 
	Kitaplar= ad yay�n evi yazar t�r 
	OduncIslemleri= hangi kitap kime hangi tarihte �d�n� verildi.

	yeteri kaadadr �rnek veri giri�i yap�n�z.
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
		('Sanat'),('Ki�isel Geli�im'),('Macera')
	GO
	
	CREATE TABLE Yazarlar(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		cinsiyet CHAR(1) NOT NULL,
		yas INT NOT NULL
	)
	GO

	INSERT INTO Yazarlar VALUES
		('Ahmet �mit','E','55'),
		('Can Ozan','E','45'),
		('Selcim Kira','K','38'),
		('Selim Onur','E','50'),
		('K�ymet Derya','K','55'),
		('Ay�e �l','K','35'),
		('Kevser But','K','30'),
		('�lyas Yar','E','38')
	GO
	CREATE TABLE Yayinevi(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(50) NOT NULL,
		adres NVARCHAR(50)
	)
	GO

	INSERT INTO Yayinevi VALUES
		('U�ur Yay�nlar�','�stanbul'),
		('Can Yay�nlar�','Ankara'),
		('Palme Yay�nlar�','�zmir'),
		('Kitapevi Yay�nlar�','�stanbul'),
		('�iir Yay�nlar�','�zmir')
	GO

	CREATE TABLE Uyeler(
		id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL
	)
	GO
	
	INSERT INTO Uyeler VALUES
		('Ay�e Karacan'), ('Selvi Boyundur'),('U�urcan K�se'),
		('Mekan Gochov'),('Berkay �all�'),('Taha �lter')
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
		('U�urtma Avc�s�',5,8,6),
		('Sefiller',4,7,5),
		('Satran�',3,6,4),
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
	