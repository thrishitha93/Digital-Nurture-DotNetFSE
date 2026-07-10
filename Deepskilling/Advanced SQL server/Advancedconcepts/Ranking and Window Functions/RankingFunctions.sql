-- ==========================================
-- Exercise 1: Ranking and Window Functions
-- ==========================================

-- Step 1: Create Database
CREATE DATABASE ProductDB;
GO

USE ProductDB;
GO

-- Step 2: Create Products Table
CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Step 3: Insert Sample Data
INSERT INTO Products VALUES
(1,'Laptop','Electronics',85000),
(2,'Mobile','Electronics',50000),
(3,'Tablet','Electronics',50000),
(4,'TV','Electronics',75000),
(5,'Office Chair','Furniture',5000),
(6,'Dining Table','Furniture',9000),
(7,'L-Shaped Sofa','Furniture',25000),
(8,'wardrobe','Furniture',30000),
(9,'Fan','Home Appliances',2500),
(10,'AC','Home Appliances',45000),
(11,'Refrigerator','Home Appliances',40000),
(12,'Washing Machine','Home Appliances',35000);

-- ==========================================
-- ROW_NUMBER()
-- ==========================================

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber
FROM Products;

-- ==========================================
-- RANK()
-- ==========================================

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNumber
FROM Products;

-- ==========================================
-- DENSE_RANK()
-- ==========================================

SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank
FROM Products;

-- ==========================================
-- Top 3 Most Expensive Products in Each Category
-- ==========================================

WITH RankedProducts AS
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
        ) AS RowNumber
    FROM Products
)

SELECT *
FROM RankedProducts
WHERE RowNumber <= 3
ORDER BY Category, RowNumber;