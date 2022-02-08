--Select
--ANSII
Select ContactName /*alias*/Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive büyük küçük harf duyarlı değil
sElEcT * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where categoryId=1 order by UnitPrice desc    --ascending  --descending

Select count(*) Adet from Products

select categoryID,count(*) from products where UnitPrice>20 
group by CategoryID having count(*)<10

--şu tablonun.şusu
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
--eşitliğe göre tabloları yan yana getir
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

/*inner join sadece iki tabloda eşleşen/ortak şeyleri birleştirir.*/
Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o --ikiden fazla tabloyu birleştirmek
on o.OrderID = od.OrderID

/*left join yazıma göre solda olup sağda olmayanları getir*/
--right join yazıma göre sağda olup solda olmayanları getir demek
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null