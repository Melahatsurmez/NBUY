USE SampleDb
/*
	urunler tablosu
	-id 
	-ad
	-stokMiktari
	-fiyat
	not null primary key
*/

CREATE TABLE Urunler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	stokMiktari INT NOT NULL,
	fiyat MONEY NOT NULL
)