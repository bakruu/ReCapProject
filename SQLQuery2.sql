--Select 
--Select ContactName Adi, CompanyName, City from Customers

--Select * from Customers where City = 'Berlin'

--Select * from Products where CategoryID = 1 and UnitPrice>= 10

--select * from Products order by CategoryID,ProductName


--Tüm satırları say:
select count(*) Adet from Products

select CategoryID, count(*) from products where unitprice>20 group by CategoryID having count (*)<10


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on products.CategoryID = categories.categoryID

--DTO Data Transofmration Object 

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID


Select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null