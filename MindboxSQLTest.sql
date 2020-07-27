--В базе данных MS SQL Server есть продукты и категории. 
--Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

--Table Products
create table Products (
      	Id int primary key,
      	Name nvarchar(100),
      	CategorieId int foreign key references Categories(Id)
)
 
--Table Categories
create table Categories (
      	Id int primary key,
      	Name nvarchar(100)
)

select p.name as "Продукт", c.name as "Категория" from dbo.products p
left join dbo.categories c
on p.categorieId = c.id