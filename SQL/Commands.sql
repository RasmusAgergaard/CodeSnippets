/* Create table */
CREATE TABLE Customer
(
	Id INT PRIMARY KEY IDENTITY(1,1),					-- Sets a primary key, starts with 1, and increse with 1
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Age INT,
	City VARCHAR(50)
);

/* Insert */
INSERT INTO dbo.Customer (FirstName, LastName, Age) values ('Joey', 'Blue', 40);

/* Select */
SELECT *									-- Returns all columns
FROM Customer;

SELECT FirstName, LastName, Age							-- Returns the 3 selected columns
FROM Customer;

SELECT FirstName, LastName, Age							-- Filters on FirstName and LastName
FROM Customer
WHERE FirstName='Joey'
AND LastName='Blue';

SELECT FirstName, LastName, Age							-- Returns all where FirstName starts with 'J'
FROM Customer
WHERE FirstName like 'J%';							-- "%" returns everything, "_" returns at least one character

/* Update */
UPDATE Customer 
SET Age = 20
WHERE FirstName = 'Small'
AND LastName = 'Blue';

/* Delete */
DELETE Customer;								-- Deletes all data in the table, but not the table itself

DELETE Customer
WHERE FirstName = 'Paul'
AND LastName LIKE 'H%';								-- Deletes all contacts the fits the WHERE

/* Drop */
DROP TABLE Customer;								-- Deletes the table and all data in it

/* Alter */
ALTER TABLE dbo.Customer
ADD City VARCHAR(50);								-- Adds a City column to the table

/* Add Foreign Key */
ALTER TABLE Orders
ADD FOREIGN KEY (CustomerId) REFERENCES Customer(Id);				-- Adds a reference from CustomerId to the Id column in the Customer table

/* Join */
SELECT * FROM Orders
INNER JOIN Product ON Orders.ProduceId = Product.Id				-- Shows the columns from the Product table after the order columns

/* Group By */
SELECT Customer.LastName, SUM(Product.Price) AS Total
FROM Orders
INNER JOIN Product ON Orders.ProduceId = Product.Id
INNER JOIN Customer ON Orders.CustomerId = Customer.Id
GROUP BY Customer.LastName;							-- Shows the sum of money spend, grouped by customer lastname
