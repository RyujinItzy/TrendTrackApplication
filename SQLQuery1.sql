use [D:\VISUAL STUDIO C#\TRENDTRACKAPPLICATION\TRENDTRACKAPPLICATION\TRENDDB.MDF];
SELECT * FROM Users;
--SELECT * FROM Categories;
SELECT * FROM Products;






--INSERT INTO Users (username, password, role, status, dateCreated) VALUES ('admin', 'admin123', 'Admin', 'Active', GETDATE());


CREATE TABLE Users (
    userID int PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(MAX) NULL,
    password VARCHAR(MAX) NULL,
    role VARCHAR(MAX) NULL,
    status VARCHAR(MAX) NULL,
    dateCreated DATETIME NULL
);

CREATE TABLE Categories(
	categoryID int PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	dateCreated DATETIME NULL);




CREATE TABLE Products (
   id INT PRIMARY KEY IDENTITY(1,1),
   productID VARCHAR(255) UNIQUE,
   productName VARCHAR(MAX) NULL,
   categoryID INT,
   costPrice DECIMAL(18,2),
   salePrice DECIMAL(18,2),
   stock INT NULL,
   image_path VARCHAR(MAX) NULL,
   status VARCHAR(MAX) NULL,
   date DATETIME NULL,
   FOREIGN KEY (categoryID) REFERENCES Categories(categoryID)
);

-- Orders Table
CREATE TABLE Orders (
    orderID INT PRIMARY KEY IDENTITY,
    customerID INT NOT NULL,
    productID INT NOT NULL,
    quantity INT NOT NULL,
    originalPrice DECIMAL(10, 2) NOT NULL,
    totalPrice DECIMAL(10, 2) NOT NULL,
    date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (customerID) REFERENCES Customers(customerID),
    FOREIGN KEY (productID) REFERENCES Products(id)
);
-- Customers Table
CREATE TABLE Customers (
    customerID INT PRIMARY KEY IDENTITY,
    price DECIMAL(10, 2) NOT NULL,
    amount DECIMAL(10, 2) NOT NULL,
    change DECIMAL(10, 2) NOT NULL,
    date DATETIME NOT NULL DEFAULT GETDATE()
);

