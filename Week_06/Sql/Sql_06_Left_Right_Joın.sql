USE Northwind

--SELECT C.CompanyName FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID

--HÝÇ SÝPARÝÞ VERMEYEN ÞÝRKETLER
--SELECT C.CompanyName FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--SELECT C.CompanyName FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--HENÜZ HÝÇ SATIÞI YAPILMAMIÞ ÜRÜNLER
--SELECT P.ProductName,OD.ProductID,OD.OrderID FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--Henüz satýþ yapamamýþ çalýþanlarý listeleyin
SELECT E.FirstName + ' ' +E.LastName as'Ad Soyad' FROM  Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL