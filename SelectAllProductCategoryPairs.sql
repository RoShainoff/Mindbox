SELECT p.Name as ProductName, COALESCE(c.Name, N'У данного продукта нет ни одной привязанной категории') as CategoryName
FROM Product p
LEFT JOIN Category c ON p.ID = c.ProductID