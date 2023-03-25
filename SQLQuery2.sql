--Select
--ANSII
--case insensitive
Select ContactName Name, CompanyName Firma, City Stadt from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where CategoryID=1 or categoryid = 3

Select * from Products where CategoryID=1 and UnitPrice >= 10

select * from Products where CategoryID=1 order by UnitPrice desc -- asc ascending default --dsc descending max-min

select count(*) Stück from Products where CategoryID=2 

select categoryId, count(*) from products group by CategoryID

select categoryid, count(*) from Products where UnitPrice <20 group by CategoryId having count(*) <10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10 order by UnitPrice desc

Select * from Products p  left join [Order Details] od on p.ProductID=od.ProductID

Select * from Customers c left join Orders o  on c.CustomerID = o.CustomerID
where o.CustomerID is null



--DTO Data Transformation object