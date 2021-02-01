select products.productName as ÜrünAdı, sum([Order Details].Quantity * [Order Details].UnitPrice) as KazanılanToplamMiktar from Products
inner join [Order Details] on [Order Details].ProductID = Products.ProductID inner join Orders
on Orders.OrderID=[Order Details].OrderID
group by Products.ProductName 
order by Products.ProductName 