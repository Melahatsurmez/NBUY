USE Northwind
--SELECT DISTINCT CategoryId FROM Products

--1)HANG� �LKELERE SATI� YAPTIK?
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--2)HANG� �LKEYE NE KADAR SATI� YAPMI�IZ
--SELECT O.ShipCountry,SUM(OD.Quantity *OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'TOPLAM TUTAR' DESC

--3)EN �OK SATI� YAPILAN 3 �LKE
--SELECT TOP(3) O.ShipCountry,SUM(OD.Quantity *OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'TOPLAM TUTAR' DESC

--4)EL�M�ZDE EN �OK STO�U BULUNAN �LK 3 �R�N
--SELECT TOP(3)P.ProductName, P.UnitsInStock FROM Products P
--ORDER BY P.UnitsInStock DESC

--5)HANG� KATEGOR�DE KA� ADET �R�N�M�Z VAR
--SELECT C.CategoryName,COUNT(*) as Adet FROM Categories C INNER JOIN Products P
--ON C.CategoryID=P.CategoryID
--GROUP BY C.CategoryName
--10 DAN B�Y�K OLANLARI BULALIM
--HAVING COUNT(*)>10
--ORDER BY Adet DESC

--6)HANG� �R�NDEN KA� TANE SATILMI�TIR?
--SELECT P.ProductName,COUNT(*) as 'Adet' FROM [Order Details] OD INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--GROUP BY P.ProductName
--ORDER BY ADET DESC

--7)EN �OK KAZANDIRAN �LK �� �R�N?
--SELECT TOP(3) P.ProductName,SUM(OD.Quantity*OD.UnitPrice) as 'Total' FROM [Order Details] OD INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC

--8)HANG� KARGO ��RKET�NE NE KADAR �DEME YAPILMI�TIR?
--SELECT S.CompanyName,SUM(O.Freight) as Total FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total DESC

--9)EN AZ �DEME YAPILMI� KARGO ��RKET�
--SELECT TOP(1) S.CompanyName,SUM(O.Freight) as 'Total' FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY Total 

--10)HANG� M��TER�YE NE KADAR TUTARINDA SATI� YAPILMI�?
--SELECT C.CompanyName,SUM(OD.Quantity*OD.UnitPrice) AS TOTAL 
--FROM Customers C 
--INNER JOIN ORDERS O ON C.CustomerID=O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

--11)B�LGELERE G�RE SATI� TUTARLARINI BULALIM
--SELECT R.RegionDescription,SUM(OD.Quantity*OD.UnitPrice) TOTAL -- E.FirstName,T.TerritoryID,T.RegionID SELECTTEN SONRA BA�TA BUNLARI YAZDIK G�RMEK ���N
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON T.RegionID=R.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

--12)KAFA YAKAN SORU= HANG� B�LGEDE HANG� �R�NDEN KA� PARALIK SATI� YAPILMI�TIR?
--SELECT R.RegionDescription,P.ProductName, SUM(OD.Quantity*OD.UnitPrice) TOTAL -- E.FirstName,T.TerritoryID,T.RegionID SELECTTEN SONRA BA�TA BUNLARI YAZDIK G�RMEK ���N
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON T.RegionID=R.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--INNER JOIN Products P ON OD.ProductID=P.ProductID
--GROUP BY R.RegionDescription,P.ProductName
--ORDER BY R.RegionDescription,P.ProductName,TOTAL DESC
