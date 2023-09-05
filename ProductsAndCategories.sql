-- Из задания №2 не было ясно, какие столбцы есть в таблице продуктов. 
-- Сделал предположение, что помимо, собственно, продукта, есть некий столбец category_id с типом INT, 
-- т.к. если бы там был столбец category с типом NVARCHAR, в котором бы была информация о категории, 
-- то задание бы сводилось к написанию простого SELECT для таблицы products (т.е. без участия таблицы categories).

SELECT	products.product AS product,
	categories.category AS category
FROM products
LEFT JOIN categories
       ON products.category_id = categories.id;