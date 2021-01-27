--Select
--ANSII standardı
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'
--case insensitive
select * from Products where CategoryID = 3 or CategoryID = 1

select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products  order by CategoryID, ProductName

select * from Products order by UnitPrice asc --ascending = artan

select * from Products where CategoryID = 1 order by UnitPrice desc --descending = azalan

select count(*) Adet from Products where CategoryID = 2

select CategoryID, count(*) from Products where UnitPrice>20  group by CategoryID having count(*) < 10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where products.UnitPrice > 10

--DTO Data Transformation object C#da bu şekilde göreceğiz.

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null -- buradaki null ordersın olmayışıdır. bu primery keye uygulanır.

select * from Customers c right join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null


