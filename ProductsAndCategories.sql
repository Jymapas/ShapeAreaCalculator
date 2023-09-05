-- �� ������� �2 �� ���� ����, ����� ������� ���� � ������� ���������. 
-- ������ �������������, ��� ������, ����������, ��������, ���� ����� ������� category_id � ����� INT, 
-- �.�. ���� �� ��� ��� ������� category � ����� NVARCHAR, � ������� �� ���� ���������� � ���������, 
-- �� ������� �� ��������� � ��������� �������� SELECT ��� ������� products (�.�. ��� ������� ������� categories).

SELECT	products.product AS product,
	categories.category AS category
FROM products
LEFT JOIN categories
       ON products.category_id = categories.id;