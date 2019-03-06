/*
-- Q1a 
select * from Shippers

-- Q1b 
select * from Shippers 
order by CompanyName

-- Q2a 
select FirstName, LastName, Title, BirthDate, City from Employees

-- Q2b 
select distinct Title from Employees

-- Q3 
select * from Orders
where OrderDate = '1997-05-19'

-- Q4 
select * from Customers 
where City in ('London', 'Madrid')

-- Q5 
select CustomerID, CompanyName, ContactName from Customers 
where Country = 'UK' 
order by ContactName

-- Q6 
select OrderID, OrderDate from Orders 
where CustomerID = 'HANAR'

-- Q7 
select concat(TitleOfCourtesy, FirstName, LastName) as [Fully Qualified Name] from Employees 
order by LastName

-- Q8 
select OrderID, OrderDate from Orders 
where CustomerID = (select CustomerID from Customers where CompanyName = 'Maison Dewey')

-- Q9 
select * from Products 
where ProductName like '%lager%'

-- Q10 
select CustomerID, ContactName from Customers 
where not CustomerID in (select CustomerID from Orders)

-- Q11 
select avg(UnitPrice) from Products

-- Q12 
select distinct City from Customers

-- Q13 
select count(*) from Customers 
where CustomerID in (select CustomerID from Orders)

-- Q14 
select CompanyName, Phone from Customers 
where Fax is null

-- Q15 
select sum(UnitPrice * Quantity) from [Order Details]

-- Q16 
select OrderID from Orders 
where CustomerID in (select CustomerID from Customers where CompanyName in ('Alan Out', 'Blone Coy'))

-- Q17 
select c.CustomerID, count(o.OrderID) from Customers c, Orders o 
where c.CustomerID = o.CustomerID 
group by c.CustomerID

-- Q18 
select c.CompanyName, o.OrderID from Customers c, Orders o 
where c.CustomerID = 'BONAP' and o.CustomerID = 'BONAP'

-- Q19a 
select c.CustomerID, c.CompanyName, count(*) from Customers c, Orders o 
where c.CustomerID = o.CustomerID 
group by c.CustomerID, c.CompanyName 
having count(*) > 10 
order by count(*) desc

-- Q19b 
select c.CustomerID, c.CompanyName, count(*) from Customers c, Orders o
where c.CustomerID = 'BONAP' and o.CustomerID = 'BONAP'
group by c.CustomerID, c.CompanyName 

-- Q19c
select c.CustomerID, c.CompanyName, count(*) from Customers c, Orders o
where c.CustomerID = o.CustomerID
group by c.CustomerID, c.CompanyName 
having count(*) > (select count(*) from Customers c, Orders o where c.CustomerID = 'BONAP' and o.CustomerID = 'BONAP')

-- Q20a
select * from Products
where CategoryID in (1,2)
order by ProductID, ProductName

-- Q20b
select * from Products p
where p.CategoryID in (select CategoryID from Categories where CategoryName in ('Beverages', 'Condiments'))
order by p.ProductID, p.ProductName

-- Q21a
select count(*) from Employees

-- Q21b
select count(*) from Employees where Country = 'USA'

-- Q22
select * from Orders
where ShipVia = (select ShipperID from Shippers where CompanyName = 'United Package')
and EmployeeID in (select EmployeeID from Employees where Title = 'Sales Representative')

-- Q23
select concat(a.LastName, ' ',a.FirstName) as [Name], concat(b.LastName, ' ', b.FirstName) as Manager from Employees a, Employees b
where a.ReportsTo = b.EmployeeID

-- Q24
select top 5 ProductID from [Order Details]
group by ProductID
order by sum(UnitPrice * Discount) desc

-- Q25
select CompanyName, ContactName from Customers
where not City in (select City from Suppliers)

-- Q26
select distinct City from Customers
where City in (select City from Suppliers)

-- Q27a
select ContactName as [Business Associates' Names], [Address], Phone from Customers union
select ContactName as [Business Associates' Names], [Address], Phone from Suppliers

-- Q27b
select CompanyName as [Business Associates' Names], [Address], Phone from Customers union
select CompanyName as [Business Associates' Names], [Address], Phone from Suppliers union
select CompanyName as [Business Associates' Names], null, Phone from Shippers

-- Q28
select concat(LastName, ' ', FirstName) as [Name] from Employees
where EmployeeID = (select ReportsTo from Employees 
	where EmployeeID = (select EmployeeID from Orders
		where OrderID = 10248))

-- Q29
select ProductID, ProductName from Products
group by ProductID, ProductName
having avg(UnitPrice) > (select sum(UnitPrice) / count(*) from Products)

-- Q30
select OrderID, sum(UnitPrice * Quantity) as Amount from [Order Details]
group by OrderID
having sum(UnitPrice * Quantity) > 10000

-- Q31
select od.OrderID, o.CustomerID from [Order Details] od, Orders o
where o.OrderID = od.OrderID
group by od.OrderID, o.CustomerID
having sum(od.UnitPrice * od.Quantity) > 10000

-- Q32
select od.OrderID, o.CustomerID, c.CompanyName from [Order Details] od, Orders o,Customers c
where o.OrderID = od.OrderID and o.CustomerID = c.CustomerID
group by od.OrderID, o.CustomerID, c.CompanyName
having sum(od.UnitPrice * od.Quantity) > 10000

-- Q33
select o.CustomerID, sum(od.UnitPrice * od.Quantity) as Amount from [Order Details] od, Orders o
where o.OrderID = od.OrderID
group by o.CustomerID

-- Q34
select sum(od.UnitPrice * od.Quantity) / count(distinct o.CustomerID) from [Order Details] od, Orders o
where o.OrderID = od.OrderID

-- Q35
select o.CustomerID, c.CompanyName from [Order Details] od, Orders o,Customers c
where o.OrderID = od.OrderID and o.CustomerID = c.CustomerID
group by o.CustomerID, c.CompanyName
having sum(od.UnitPrice * od.Quantity) > 
	(
	select sum(od.UnitPrice * od.Quantity) / count(distinct o.CustomerID) from [Order Details] od, Orders o 
	where o.OrderID = od.OrderID
	)

-- Q36
select o.CustomerID, sum(od.UnitPrice * od.Quantity) as Amount from [Order Details] od, Orders o
where o.OrderID = od.OrderID and year(o.OrderDate) = 1997
group by o.CustomerID
*/