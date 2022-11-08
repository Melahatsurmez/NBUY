USE Northwind
--SELECT DISTINCT CategoryId FROM Products

--1)HANGÝ ÜLKELERE SATIÞ YAPTIK?
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--2)HANGÝ ÜLKEYE NE KADAR SATIÞ YAPMIÞIZ
--SELECT O.ShipCountry,SUM(OD.Quantity *OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'TOPLAM TUTAR' DESC

--3)EN ÇOK SATIÞ YAPILAN 3 ÜLKE
--SELECT TOP(3) O.ShipCountry,SUM(OD.Quantity *OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'TOPLAM TUTAR' DESC

--4)ELÝMÝZDE EN ÇOK STOÐU BULUNAN ÝLK 3 ÜRÜN
--SELECT TOP(3)P.ProductName, P.UnitsInStock FROM Products P
--ORDER BY P.UnitsInStock DESC

--5)HANGÝ KATEGORÝDE KAÇ ADET ÜRÜNÜMÜZ VAR
--SELECT C.CategoryName,COUNT(*) as Adet FROM Categories C INNER JOIN Products P
--ON C.CategoryID=P.CategoryID
--GROUP BY C.CategoryName
--10 DAN BÜYÜK OLANLARI BULALIM
--HAVING COUNT(*)>10
--ORDER BY Adet DESC

--6)HANGÝ ÜRÜNDEN KAÇ TANE SATILMIÞTIR?
--SELECT P.ProductName,COUNT(*) as 'Adet' FROM [Order Details] OD INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--GROUP BY P.ProductName
--ORDER BY ADET DESC

--7)EN ÇOK KAZANDIRAN ÝLK ÜÇ ÜRÜN?
--SELECT TOP(3) P.ProductName,SUM(OD.Quantity*OD.UnitPrice) as 'Total' FROM [Order Details] OD INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC

--8)HANGÝ KARGO ÞÝRKETÝNE NE KADAR ÖDEME YAPILMIÞTIR?
--SELECT S.CompanyName,SUM(O.Freight) as Total FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total DESC

--9)EN AZ ÖDEME YAPILMIÞ KARGO ÞÝRKETÝ
--SELECT TOP(1) S.CompanyName,SUM(O.Freight) as 'Total' FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total 

--10)HANGÝ MÜÞTERÝYE NE KADAR TUTARINDA SATIÞ YAPILMIÞ?
--SELECT C.CompanyName,SUM(OD.Quantity*OD.UnitPrice) AS TOTAL 
--FROM Customers C 
--INNER JOIN ORDERS O ON C.CustomerID=O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

--11)BÖLGELERE GÖRE SATIÞ TUTARLARINI BULALIM
--SELECT R.RegionDescription,SUM(OD.Quantity*OD.UnitPrice) TOTAL -- E.FirstName,T.TerritoryID,T.RegionID SELECTTEN SONRA BAÞTA BUNLARI YAZDIK GÖRMEK ÝÇÝN
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON T.RegionID=R.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

--12)KAFA YAKAN SORU= HANGÝ BÖLGEDE HANGÝ ÜRÜNDEN KAÇ PARALIK SATIÞ YAPILMIÞTIR?
--SELECT R.RegionDescription,P.ProductName, SUM(OD.Quantity*OD.UnitPrice) TOTAL -- E.FirstName,T.TerritoryID,T.RegionID SELECTTEN SONRA BAÞTA BUNLARI YAZDIK GÖRMEK ÝÇÝN
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON T.RegionID=R.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--INNER JOIN Products P ON OD.ProductID=P.ProductID
--GROUP BY R.RegionDescription,P.ProductName
--ORDER BY R.RegionDescription,P.ProductName,TOTAL DESC
