--Product tablosunu Un�t price kolonuna g�re b�y�kten k����e s�ralay�n�z.
USE Northwind
--SELECT * FROM Products 
--ORDER BY UnitPrice DESC

--UNIT PR�CE I 100 VE �ZER� OLANLAR
--SELECT* FROM Products
--WHERE UnitPrice>=100

----kategorisi 7-8 olan �r�nlerden stok miktar� un�tsinstock <=10 olan �r�nler
--SELECT * FROM Products
--WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10

--kategorisi 7-8 olan �r�nlerden stok miktar� un�tsinstock <=10 olan �r�nler�N TOPLAM SAYISI!
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

--PRODUCT NAME VE SUPPL�ER COMPANY NAME � G�STEREN B�R SORGU YAZINIZ

--SELECT P.ProductName,S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID


-- germanyden tedarik edilenler (sadece product name olsun)
--SELECT P.ProductName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID
--WHERE S.Country='Germany'

--Sweden �r�nlerin toplam tutar�
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID
--WHERE S.Country='Sweden'

----Chai sat��lar�n�n toplam tutar�
--SELECT SUM (OD.UnitPrice*OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE P.ProductName='CHA�'

-- GERMANY Chai sat��lar�n�n toplam tutar�
--SELECT SUM(OD.UnitPrice*OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='CHA�' AND O.ShipCountry='Germany'

--Ernst HAndel m��terisine ypa�lan sat�� tutar�n�n toplam�
SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='Ernst Handel'
