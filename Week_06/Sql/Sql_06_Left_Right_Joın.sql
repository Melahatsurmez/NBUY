USE Northwind

--SELECT C.CompanyName FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID

--H�� S�PAR�� VERMEYEN ��RKETLER
--SELECT C.CompanyName FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--SELECT C.CompanyName FROM Orders O RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--HEN�Z H�� SATI�I YAPILMAMI� �R�NLER
--SELECT P.ProductName,OD.ProductID,OD.OrderID FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--Hen�z sat�� yapamam�� �al��anlar� listeleyin
SELECT E.FirstName + ' ' +E.LastName as'Ad Soyad' FROM  Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL