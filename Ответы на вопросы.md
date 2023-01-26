# AreaLibrary
Вопрос №1. Опыт в веб разработки нет, если только в качестве самостоятельного изучения (ASP.NET MVC, MVVM);оргб
Вопрос №2. Библиотека на GitHub;

Вопрос №3. SQL запрос
  3.1 Таблица products: 
use Baza;
create table products
(id int not null primary key, product_name varchar(50));
insert into products
(id, product_name)
values
(1, 'Orange'),
(2, 'Lime'),
(3, 'Strawberry'),
(4, 'Raspberry');

  3.2 Таблица categories: 
use Baza;
create table categories
(id int not null primary key, category varchar(50));
insert into categories
(id, category)
values
(1, 'good'),
(2, 'bad'),
(3, 'good'),
(4, 'bad');

  3.3 Создаем дополнительную таблицу products_categories
use Baza
create table products_categories
(product_id int not null, category_id int not null,
foreign key (product_id) references products(id),
foreign key (category_id) references categories(id))

  3.4 Добавили записи 
USE Baza
INSERT INTO products_categories
           (product_id,
            category_id)
     VALUES
           (1,1), (1,2), (1,3), (2,1), (2,3), (2,4);

  3.5 Запрос на выбор всех пар
USE Baza
SELECT *from conditions as c
join products_conditions as pc ON c.id=pc.condition_id
right join products as p ON p.id=pc.product_id
where p.id=c.id

Вопрос №4
В случае успешного завершения стажировки готов выйти на фуллтайм (удаленно)
