select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

select * from Customers where City = 'Berlin'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where categoryId=1 order by UnitPrice desc    --ascending  --descending

Select count(*) Adet from Products

select categoryID,count(*) from products

group by CategoryID having count(*)<10

select categoryID,count(*) from products where UnitPrice>20 

group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select ProductName AS 'Ürün Adı', SUM([Order Details].UnitPrice * [Order Details].Quantity) AS 'Kazanılan Toplam Miktar' 
From Products inner join [Order Details]
on Products.ProductID = [Order Details].ProductID
inner join Orders
on Orders.OrderID = [Order Details].OrderID
Group By ProductName