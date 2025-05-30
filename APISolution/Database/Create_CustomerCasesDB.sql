-- Create the database
CREATE DATABASE CustomerCasesDB;
GO

-- Use the database
USE CustomerCasesDB;
GO

-- Create Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255),
    Phone NVARCHAR(50),
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Create Cases table
CREATE TABLE Cases (
    CaseID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    CreatedDate DATETIME DEFAULT GETDATE(),
    CustomerID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE
);
GO

-- Seed data for Customers
INSERT INTO Customers (FirstName, LastName, Email, Phone)
VALUES 
('Ahmed', 'Ali', 'ahmed.ali@example.com', '0501234567'),
('Sara', 'Mahmoud', 'sara.mahmoud@example.com', '0507654321'),
('Khaled', 'Youssef', 'khaled.youssef@example.com', '0509988776'),
('Mostafa', 'ElSayed', 'mostafa@mail.com', '0505555555');
GO

-- Seed data for Cases
INSERT INTO Cases (Title, Description, CustomerID)
VALUES
('Order Issue', 'Customer has an issue with the recent order.', 1),
('Login Problem', 'Unable to login to the account.', 2),
('Billing Error', 'Received incorrect billing for the last month.', 1),
('Shipping Delay', 'Order has not been shipped yet.', 3),
('Account Locked', 'Customer’s account has been locked for unknown reasons.', 4);
GO
