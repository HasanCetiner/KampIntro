--Select
--ANSII
Select * from Customers
Select ContactName Adi, CompanyName Sirketadi,City sehir from  Customers
Select * from Customers where city = 'London'
--case insensitive (büyük küçük harf duyarsız, SQL için)
sELeCt * from Products where categoryId = 1 or categoryId = 3
Select * from Products where categoryId = 1 and UnitPrice >=10
-- <> 10  (10dan farklı sayıları çağır demek)
select * from Products order by UnitPrice asc --ascenting (artan) asc yazmasan da olur
select * from Products order by UnitPrice desc --descending(azalan) 
Select count(*) from Products where CategoryID = 2
select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID 
where Products.UnitPrice >10

--Data Transformation Object
-- inner join (her iki taploda olanları getir)
-- left join (solda olup sağda olmayanları da getir)