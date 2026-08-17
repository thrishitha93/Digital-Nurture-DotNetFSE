CREATE TABLE Products
(
    ProductID INTEGER PRIMARY KEY,
    ProductName TEXT,
    Category TEXT,
    Price REAL
);

INSERT INTO Products VALUES
(1,'Laptop','Electronics',80000),
(2,'Mobile','Electronics',60000),
(3,'Headphones','Electronics',60000),
(4,'TV','Electronics',90000),
(5,'Shoes','Fashion',3000),
(6,'Watch','Fashion',5000),
(7,'Bag','Fashion',5000),
(8,'Shirt','Fashion',2000);

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Row_Number
FROM Products;

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Rank_Value
FROM Products;

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS Dense_Rank
FROM Products;

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS Row_Number
    FROM Products
) AS RankedProducts
WHERE Row_Number <= 3;