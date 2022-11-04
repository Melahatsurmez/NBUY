CREATE DATABASE SirketDb2
GO
USE SirketDb2

CREATE TABLE Departmanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL
)

INSERT INTO Departmanlar(ad) VALUES
	('Muhasebe'),
	('Teknik servis'),
	('Satýþ'),
	('ÝK'),
	('Yönetim')

/*
	iþçi, muhasebe uzmaný,satýþçý, ik uzmaný, ik stajyeri,yönetici,yönetici yardýmcýsý
*/
USE  SirketDb2
CREATE TABLE Unvanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL
)
INSERT INTO Unvanlar(ad) VALUES
	('Ýþçi'),
	('Muhasebe Uzmaný'),
	('Satýþçý'),
	('ÝK Uzmaný'),
	('ÝK Stajyeri'),
	('Yönetici'),	
	('Yönetici Yardýmcýsý')

USE SirketDb2
CREATE TABLE Iller(
	id CHAR(2) NOT NULL PRIMARY KEY,
	ad NVARCHAR(30) NOT NULL
)

INSERT INTO Iller(id,ad) VALUES
	('34','Ýstanbul'),
	('06','Ankara'),
	('35','Ýzmir'),
	('58','Sivas'),
	('41','Ýzmit')

USE SirketDb2
CREATE TABLE Ilceler(
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,
	ilId CHAR(2) NOT NULL,
	FOREIGN KEY (ilId) REFERENCES Iller(id)
)

INSERT INTO Ilceler(ad,ilId) Values
('Kadýköy','34'),
('Beþiktaþ','34'),
('Avcýlar','34'),
('Konak','35'),
('Yenimahalle','06'),
('Çankaya','06'),
('Suþehri','58')

USE SirketDb2
CREATE TABLE Personeller(
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL,
	soyad NVARCHAR(25) NOT NULL,
	cinsiyet BIT NOT NULL,
	dogumTarihi DATE NOT NULL,
	ikametgahIlceId INT NOT NULL,
	iseBaslamaTarihi DATE NOT NULL,
	departmanId INT NOT NULL,
	unvanId INT NOT NULL,
	maas MONEY NOT NULL
	FOREIGN KEY (ikametgahIlceId) REFERENCES Ilceler(id),
	FOREIGN KEY (departmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY (unvanId) REFERENCES Unvanlar(id)
)

INSERT INTO Personeller(ad,soyad,cinsiyet,dogumTarihi,ikametgahIlceId,iseBaslamaTarihi,departmanId,UnvanId,Maas) VALUES
	('Alican','Kabak',0,'1999-05-15',1,'2021-11-10',1,3,12500),
	('Alican','Yumuþak',0,'1999-05-15',2,'2021-11-10',2,4,12500),
	('Merve','Kabak',0,'1999-05-15',3,'2021-11-10',3,5,22500),
	('Sevim','Muazzan',0,'1999-05-15',4,'2021-11-10',4,6,2500),
	('Altan','Kabak',1,'1999-05-15',5,'2021-11-10',5,7,42500),
	('Meryam','Alda',1,'1999-05-15',6,'2021-11-10',5,6,22500),
	('Þadiye','Kabak',0,'1999-05-15',7,'2021-11-10',2,5,32500),
	('Kemal','Sert',0,'1999-05-15',1,'2021-11-10',3,4,10500),
	('Yaþar','Köse',1,'1999-05-15',2,'2021-11-10',4,3,10500),
	('Serdar','HÝkaye',0,'1999-05-15',3,'2021-11-10',5,2,12000),
	('Pakize','Þiir',0,'1999-05-15',4,'2021-11-10',1,1,12200),
	('Peykýz','Þiir',1,'1999-05-15',5,'2021-11-10',1,1,12200)
	
USE SirketDb2
CREATE TABLE Projeler(
	id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	baslamaTarihi DATE NOT NULL,
	planlananBitisTarihi DATE NOT NULL
)

INSERT INTO PROJELER(ad,baslamaTarihi,planlananBitisTarihi) VALUES
	('Mutlu Çocuklar','2022-5-5','2022-8-5'),	
	('Mutlu Çocuklar','2022-5-5','2022-8-5'),
	('Mutlu Çocuklar','2022-5-5','2022-8-5'),
	('Mutlu Çocuklar','2022-5-5','2022-8-5')