--Product tablosunu Unýt price kolonuna göre büyükten küçüðe sýralayýnýz.
USE Northwind
--SELECT * FROM Products 
--ORDER BY UnitPrice DESC

--UNIT PRÝCE I 100 VE ÜZERÝ OLANLAR
--SELECT* FROM Products
--WHERE UnitPrice>=100

----kategorisi 7-8 olan ürünlerden stok miktarý unýtsinstock <=10 olan ürünler
--SELECT * FROM Products
--WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10

--kategorisi 7-8 olan ürünlerden stok miktarý unýtsinstock <=10 olan ürünlerÝN TOPLAM SAYISI!
--SELECT COUNT(*) FROM Products
----WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10
--WHERE (CategoryID=9 OR CategoryID=3) AND UnitsInStock<=50


--INNER JOIN
--SELECT Products.ProductName, Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID= Categories.CategoryID

--SELECT P.ProductName, C.CategoryName 
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID= C.CategoryID

--SELECT P.ProductName, C.CategoryName,P.UnitPrice
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID= C.CategoryID
--WHERE CategoryName= 'Beverages' AND P.UnitPrice<=40
--ORDER BY P.UnitPrice DESC

--PRODUCT NAME VE SUPPLÝER COMPANY NAME Ý GÖSTEREN BÝR SORGU YAZINIZ

--SELECT P.ProductName,S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID


-- germanyden tedarik edilenler (sadece product name olsun)
--SELECT P.ProductName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID
--WHERE S.Country='Germany'

--Sweden ürünlerin toplam tutarý
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID
--WHERE S.Country='Sweden'

----Chai satýþlarýnýn toplam tutarý
--SELECT SUM (OD.UnitPrice*OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE P.ProductName='CHAÝ'

-- GERMANY Chai satýþlarýnýn toplam tutarý
--SELECT SUM(OD.UnitPrice*OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='CHAÝ' AND O.ShipCountry='Germany'

--Ernst HAndel müþterisine ypaýlan satýþ tutarýnýn toplamý
SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='Ernst Handel'
