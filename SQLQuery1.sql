use [D:\VISUAL STUDIO C#\TRENDTRACKAPPLICATION\TRENDTRACKAPPLICATION\TRENDDB.MDF];
DROP TABLE Orders;
SELECT * FROM Users;
SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Customers;
SELECT * FROM Orders;

SELECT DATEADD(dd, 0, DATEDIFF(dd, 0, o.date)) AS OrderDate, 
       SUM((p.salePrice - p.costPrice) * o.quantity) AS Profit
FROM Orders o
INNER JOIN Products p ON o.productID = p.productID
GROUP BY DATEADD(dd, 0, DATEDIFF(dd, 0, o.date))
ORDER BY OrderDate;


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


    SELECT * FROM Orders;
    SELECT * FROM Customers;

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
    productID VARCHAR(255) NOT NULL, 
    quantity INT NOT NULL,
    originalPrice DECIMAL(10, 2) NOT NULL,
    totalPrice DECIMAL(10, 2) NOT NULL,
    date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (customerID) REFERENCES Customers(customerID),
    FOREIGN KEY (productID) REFERENCES Products(productID) 
);
-- Customers Table
CREATE TABLE Customers (
    customerID INT PRIMARY KEY IDENTITY,
    price DECIMAL(10, 2) NOT NULL,
    amount DECIMAL(10, 2) NOT NULL,
    change DECIMAL(10, 2) NOT NULL,
    date DATETIME NOT NULL DEFAULT GETDATE()
);
-- AuditTrail Table
CREATE TABLE AuditTrail (
    auditID INT PRIMARY KEY IDENTITY,
    userID INT NOT NULL,
    activity NVARCHAR(255) NOT NULL,
    date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (userID) REFERENCES Users(userID)
);

-- ActivityLog Table
CREATE TABLE ActivityLog (
    logID INT PRIMARY KEY IDENTITY,
    userID INT NOT NULL,
    action NVARCHAR(255) NOT NULL,
    date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (userID) REFERENCES Users(userID)
);

-- Archive Table
CREATE TABLE Archive (
    archiveID INT PRIMARY KEY IDENTITY,
    dataID VARCHAR(255) NOT NULL,
    dataType NVARCHAR(50) NOT NULL,
    archivedData VARBINARY(MAX) NOT NULL,
    dateArchived DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Notifications (
    notificationID INT PRIMARY KEY IDENTITY,
    userID INT NOT NULL,
    notificationMessage NVARCHAR(255) NOT NULL,
    notificationType NVARCHAR(50) NOT NULL,
    notificationDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (userID) REFERENCES Users(userID)
);


