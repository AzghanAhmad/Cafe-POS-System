

use CMS;

CREATE TABLE Category (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100),
    Description VARCHAR(255)
);


CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Password VARCHAR(50)
);

CREATE TABLE Admin (
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Password VARCHAR(50),
    Phone VARCHAR(20),
    Email VARCHAR(100)
);

CREATE TABLE Employee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Position varchar(255),
    Password varchar(255),
    AdminID INT,
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
);

CREATE TABLE Orderr (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    EmployeeID INT,
    Date DATE,
    Status VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);



CREATE TABLE Supplier (
    SupplierID INT PRIMARY KEY,
    Name VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100)
);

CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT,
    Price DECIMAL(10,2),
    CategoryID INT,
    SupplierID INT,
    AdminID INT,
    StockQuantity INT,
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
);



CREATE TABLE Inventory (
    InventoryID INT PRIMARY KEY,
    ProductID INT,
    Quantity INT,
    DateReceived DATE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE OrderItems (
    OrderItemID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orderr(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE Cart (
    CartID INT PRIMARY KEY,
    CustomerID INT,
    Status VARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE CartItems (
    CartItemID INT PRIMARY KEY,
    CartID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (CartID) REFERENCES Cart(CartID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);



CREATE TABLE Discount (
    DiscountID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT,
    Percentage DECIMAL(5,2),
    ProductID INT,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,
    Ratings INT,
    Comment TEXT,
    Type VARCHAR(50),
    Date DATE,
    CustomerID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

drop table Feedback;


CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    TotalAmount DECIMAL(10,2),
    Date DATE,
    PaymentMethod VARCHAR(50),
    Status VARCHAR(50),
    CustomerID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE Receipt (
    ReceiptID INT PRIMARY KEY,
    Date DATE,
    Items TEXT,
    Discount DECIMAL(10,2),
    Total DECIMAL(10,2),
    PaymentID INT,
    FOREIGN KEY (PaymentID) REFERENCES Payment(PaymentID)
);


									
-- Inserting data

-- Categories
INSERT INTO Category (CategoryID, CategoryName, Description) 
VALUES 
    (1, 'Beverages', 'Soft drinks, coffees, teas, and other beverages'),
    (2, 'Condiments', 'Sauces, relishes, spreads, and seasonings'),
    (3, 'Confections', 'Desserts, candies, and sweet breads'),
    (4, 'Dairy Products', 'Cheeses and milk products'),
    (5, 'Grains/Cereals', 'Breads, crackers, pasta, and cereals'),
    (6, 'Meat/Poultry', 'Prepared meats'),
    (7, 'Produce', 'Fresh fruits and vegetables'),
    (8, 'Seafood', 'Fish and other seafood'),
    (9, 'Snacks', 'Potato chips, popcorn, and pretzels'),
    (10, 'Sauces', 'Marinades, dressings, and sauces');

-- Suppliers
INSERT INTO Supplier (SupplierID, Name, Phone, Email) 
VALUES 
    (1, 'ABC Suppliers', '0345-1234567', 'abc@example.com'),
    (2, 'XYZ Distributors', '0321-7654321', 'xyz@example.com'),
    (3, 'PQR Traders', '0300-9876543', 'pqr@example.com'),
    (4, 'LMN Enterprises', '0312-3456789', 'lmn@example.com'),
    (5, 'RST Foods', '0333-8765432', 'rst@example.com'),
    (6, 'MNO Corporation', '0344-2345678', 'mno@example.com'),
    (7, 'JKL Industries', '0322-9876543', 'jkl@example.com'),
    (8, 'GHI Suppliers', '0311-3456789', 'ghi@example.com'),
    (9, 'DEF Traders', '0333-8765432', 'def@example.com'),
    (10, 'VWX Distributors', '0321-2345678', 'vwx@example.com');

	-- Admins
INSERT INTO Admin ( Name, Password, Phone, Email) 
VALUES 
    ('Azghan','aaa','0336-6493156','azghan'),
    ('Ali', 'Ali2643', '0321-7654321', 'ali@example.com'),
    ( 'Ahmed', 'Ahmed2309', '0300-9876543', 'ahmed@example.com'),
    ( 'Usman', 'Usman23@', '0312-3456789', 'usman@example.com'),
    ( 'Talha', 'Talha23@', '0333-8765432', 'talha@example.com'),
    ( 'Zain', 'Zain23@', '0344-2345678', 'zain@example.com'),
    ( 'Ahsan', 'Ahsan23@', '0322-9876543', 'ahsan@example.com'),
    ( 'Bilal', 'Bilal23@', '0311-3456789', 'bilal@example.com'),
    ( 'Kashif', 'Kashif23@', '0333-8765432', 'kashif@example.com'),
    ( 'Noman', 'Noman23@', '0321-2345678', 'noman@example.com');

    -- Customers
INSERT INTO Customer ( Name, Phone, Email, Password) 
VALUES 
    ( 'Muhammad Ali', '0345-1234567', 'ali@example.com', 'Ali123@'),
    ( 'Fatima Khan', '0321-7654321', 'fatima@example.com', 'Fatima123@'),
    ( 'Ahmed Hassan', '0300-9876543', 'ahmed@example.com', 'Ahmed123@'),
    ( 'Ayesha Malik', '0312-3456789', 'ayesha@example.com', 'Ayesha123@'),
    ( 'Saad Ahmed', '0333-8765432', 'saad@example.com', 'Saad123@'),
    ( 'Amina Ali', '0344-2345678', 'amina@example.com', 'Amina123@'),
    ( 'Bilal Khan', '0322-9876543', 'bilal@example.com', 'Bilal123@'),
    ( 'Sana Ahmed', '0311-3456789', 'sana@example.com', 'Sana123@'),
    ( 'Kashif Malik', '0333-8765432', 'kashif@example.com', 'Kashif123@'),
    ( 'Noman Khan', '0321-2345678', 'noman@example.com', 'Noman123@'),
    ('Ahmad','0336-6493156','ahmad','aaa');


	
-- Employees
INSERT INTO Employee ( Name, Phone, Email, AdminID) 
VALUES 
    ( 'Adeel', '0311-1234567', 'adeel@example.com', 1),
    ( 'Fatima', '0321-7654321', 'fatima@example.com', 2),
    ( 'Khalid', '0300-9876543', 'khalid@example.com', 3),
    ( 'Ayesha', '0312-3456789', 'ayesha@example.com', 4),
    ( 'Saad', '0333-8765432', 'saad@example.com', 5),
    ( 'Amina', '0344-2345678', 'amina@example.com', 6),
    ('Bilal', '0322-9876543', 'bilal@example.com', 7),
    ( 'Sana', '0311-3456789', 'sana@example.com', 8),
    ( 'Ali', '0333-8765432', 'ali@example.com', 9),
    ( 'Mehak', '0321-2345678', 'mehak@example.com', 9),
    ('Hallian','0336-6493156','ahmad',2);


-- Products
INSERT INTO Product (ProductID, Name, Description, Price, CategoryID, SupplierID, AdminID, StockQuantity) 
VALUES
    (1, 'Coca-Cola', 'Refreshing carbonated soft drink', 50,  1, 1, 1, 100),
    (2, 'Nestle Pure Life Water', 'Purified bottled water', 30,  1, 2, 2, 150),
    (3, 'Lipton Yellow Label Tea', 'Premium blended tea', 100, 1, 3, 3, 80),
    (4, 'Nescafe Classic Coffee', 'Instant coffee powder', 200, 1, 4, 4, 90),
    (5, 'Tang Orange Powder', 'Orange flavored powdered drink', 80, 1, 5, 5, 120),
    (6, 'National Ketchup', 'Tomato ketchup', 70, 2, 6, 6, 100),
    (7, 'Shan Masala', 'Mixed spices for Pakistani cuisine', 150, 2, 7, 7, 70),
    (8, 'Mitchell''s Jam', 'Assorted fruit jam', 120, 3, 8, 8, 60),
    (9, 'Cadbury Dairy Milk', 'Milk chocolate bar', 120, 3, 9, 9, 110),
    (10, 'Snickers Bar', 'Chocolate bar with caramel and nuts', 100, 3, 10, 10, 100),
    (11, 'Haleeb Milk', 'Pasteurized milk', 110, 4, 1, 1, 200),
    (12, 'Nestle Yogurt', 'Plain yogurt', 80, 4, 2, 2, 150),
    (13, 'Cheddar Cheese', 'Hard cheese made from cow milk', 250, 4, 3, 3, 90),
    (14, 'Nestle Cerelac', 'Baby cereal', 200, 5, 4, 4, 120),
    (15, 'Shan Vermicelli', 'Fine wheat noodles', 150,  5, 5, 5, 80),
    (16, 'National Macaroni', 'Pasta tubes', 100, 5, 6, 6, 100),
    (17, 'Shan Biryani Masala', 'Spice mix for biryani', 50,  7, 7, 7, 150),
    (18, 'Chicken Seekh Kebab', 'Marinated minced chicken on skewers', 300,  6, 8, 8, 70),
    (19, 'Beef Burger Patties', 'Frozen beef burger patties', 400,  6, 9, 9, 60),
    (20, 'Shan Tikka Masala', 'Spice mix for chicken tikka', 60,  7, 10, 10, 80),
    (21, 'Potatoes', 'Fresh potatoes', 50,  7, 1, 1, 120),
    (22, 'Tomatoes', 'Fresh tomatoes', 60, 7, 2, 2, 150),
    (23, 'Apples', 'Fresh apples', 80, 7, 3, 3, 100),
    (24, 'Bananas', 'Fresh bananas', 70, 7, 4, 4, 110),
    (25, 'Pineapple', 'Fresh pineapple', 100,  7, 5, 5, 80),
    (26, 'Prawns', 'Freshwater prawns', 500, 8, 6, 6, 90),
    (27, 'Salmon Fish Fillet', 'Fresh salmon fillet', 600,  8, 7, 7, 70),
    (28, 'Surmai Fish', 'Fresh Surmai fish', 450, 8, 8, 8, 80),
    (29, 'Lays Potato Chips', 'Potato chips', 80, 9, 9, 9, 120),
    (30, 'Kurkure Masala Munch', 'Spicy corn puffs', 60, 9, 10, 10, 100),
    (31, 'Cheetos Crunchy', 'Cheese-flavored snack', 70, 9, 1, 1, 110),
    (32, 'Doritos Nacho Cheese', 'Tortilla chips', 100, 9, 2, 2, 90),
    (33, 'Mayonnaise', 'Creamy mayonnaise sauce', 120, 10, 3, 3, 80),
    (34, 'Soy Sauce', 'Soy-based seasoning sauce', 100, 10, 4, 4, 90),
    (35, 'BBQ Sauce', 'Barbecue sauce', 80, 10, 5, 5, 100),
    (36, 'Chilli Garlic Sauce', 'Spicy garlic sauce', 70,  10, 6, 6, 110),
    (37, 'Ketchup', 'Tomato ketchup', 60,  10, 7, 7, 120),
    (38, 'Soy Sauce', 'Soy-based seasoning sauce', 100,  10, 8, 8, 130),
    (39, 'Mayonnaise', 'Creamy mayonnaise sauce', 120,  10, 9, 9, 140),
    (40, 'Chilli Garlic Sauce', 'Spicy garlic sauce', 80, 10, 10, 10, 150);


-- Discounts
INSERT INTO Discount (DiscountID, Name, Description, Percentage, ProductID) 
VALUES 
    (1, 'Summer Sale', 'Summer discount offer', 10, 3),
    (2, 'Ramadan Offer', 'Special Ramadan discount', 15, 7),
    (3, 'Winter Sale', 'Winter discount offer', 20, 12),
    (4, 'Eid Special', 'Eid discount offer', 25, 18),
    (5, 'New Year Sale', 'New Year discount offer', 30, 25),
    (6, 'Independence Day', 'Independence Day special offer', 10, 31),
    (7, 'Labor Day', 'Labor Day discount offer', 15, 37),
    (8, 'Black Friday', 'Black Friday mega sale', 50, 40);

-- Inventory
INSERT INTO Inventory (InventoryID, ProductID, Quantity, DateReceived) 
VALUES 
    (1, 1, 100, '2024-04-01'),
    (2, 2, 150, '2024-04-05'),
    (3, 3, 80, '2024-04-10'),
    (4, 4, 90, '2024-04-15'),
    (5, 5, 120, '2024-04-20'),
    (6, 6, 100, '2024-04-25'),
    (7, 7, 70, '2024-05-01'),
    (8, 8, 60, '2024-05-05'),
    (9, 9, 110, '2024-05-10'),
    (10, 10, 100, '2024-05-15'),
    (11, 11, 200, '2024-05-20'),
    (12, 12, 150, '2024-05-25'),
    (13, 13, 90, '2024-05-01'),
    (14, 14, 120, '2024-05-05'),
    (15, 15, 80, '2024-05-10'),
    (16, 16, 100, '2024-05-15'),
    (17, 17, 150, '2024-05-20'),
    (18, 18, 70, '2024-05-25'),
    (19, 19, 60, '2024-05-01'),
    (20, 20, 80, '2024-05-05'),
    (21, 21, 120, '2024-05-10'),
    (22, 22, 150, '2024-05-15'),
    (23, 23, 100, '2024-05-20'),
    (24, 24, 110, '2024-05-25'),
    (25, 25, 80, '2024-05-01'),
    (26, 26, 90, '2024-05-05'),
    (27, 27, 70, '2024-05-10'),
    (28, 28, 80, '2024-05-15'),
    (29, 29, 120, '2024-05-20'),
    (30, 30, 100, '2024-05-25'),
    (31, 31, 110, '2024-05-01'),
    (32, 32, 90, '2024-05-05'),
    (33, 33, 100, '2024-05-10'),
    (34, 34, 120, '2024-05-15'),
    (35, 35, 150, '2024-05-20'),
    (36, 36, 80, '2024-05-25'),
    (37, 37, 90, '2024-05-01'),
    (38, 38, 100, '2024-05-05'),
    (39, 39, 110, '2024-05-10'),
    (40, 40, 120, '2024-05-15');

-- Carts
INSERT INTO Cart (CartID, CustomerID, Status) 
VALUES 
    (1, 1, 'Active'),
    (2, 2, 'Active'),
    (3, 3, 'Active'),
    (4, 4, 'Active'),
    (5, 5, 'Active'),
    (6, 6, 'Active'),
    (7, 7, 'Active'),
    (8, 8, 'Active'),
    (9, 9, 'Active'),
    (10, 10, 'Active');

-- CartItems
INSERT INTO CartItems (CartItemID, CartID, ProductID, Quantity) 
VALUES 
    (1, 1, 1, 2),
    (2, 1, 2, 3),
    (3, 2, 3, 1),
    (4, 2, 4, 2),
    (5, 3, 5, 2),
    (6, 3, 6, 1),
    (7, 4, 7, 3),
    (8, 4, 8, 2),
    (9, 5, 9, 1),
    (10, 5, 10, 2),
    (11, 6, 11, 3),
    (12, 6, 12, 2),
    (13, 7, 13, 1),
    (14, 7, 14, 2),
    (15, 8, 15, 2),
    (16, 8, 16, 1),
    (17, 9, 17, 3),
    (18, 9, 18, 2),
    (19, 10, 19, 1),
    (20, 10, 20, 2);

-- Orders
INSERT INTO Orderr (OrderID, CustomerID, EmployeeID, Date, Status) 
VALUES 
    (1, 1, 2, '2024-05-01', 'Pending'),
    (2, 2, 2, '2024-05-02', 'Processing'),
    (3, 3, 3, '2024-05-03', 'Shipped'),
    (4, 4, 4, '2024-05-04', 'Delivered'),
    (5, 5, 5, '2024-05-05', 'Pending'),
    (6, 6, 6, '2024-05-06', 'Processing'),
    (7, 7, 7, '2024-05-07', 'Shipped'),
    (8, 8, 8, '2024-05-08', 'Delivered'),
    (9, 9, 9, '2024-05-09', 'Pending'),
    (10, 10, 10, '2024-05-10', 'Processing');

-- OrderItems
INSERT INTO OrderItems (OrderItemID, OrderID, ProductID, Quantity, Price) 
VALUES 
    (1, 1, 1, 2, 100),
    (2, 1, 2, 3, 90),
    (3, 2, 3, 1, 100),
    (4, 2, 4, 2, 400),
    (5, 3, 5, 2, 160),
    (6, 3, 6, 1, 70),
    (7, 4, 7, 3, 210),
    (8, 4, 8, 2, 240),
    (9, 5, 9, 1, 120),
    (10, 5, 10, 2, 200),
    (11, 6, 11, 3, 330),
    (12, 6, 12, 2, 160),
    (13, 7, 13, 1, 250),
    (14, 7, 14, 2, 240),
    (15, 8, 15, 2, 300),
    (16, 8, 16, 1, 200),
    (17, 9, 17, 3, 150),
    (18, 9, 18, 2, 600),
    (19, 10, 19, 1, 400),
    (20, 10, 20, 2, 120);


INSERT INTO Feedback ( Ratings, Comment, Date, CustomerID)
VALUES
    ( 4, 'Great service and delicious food!', '2024-05-01', 1),
    ( 5, 'Awesome ambiance and friendly staff.', '2024-05-02', 2),
    ( 3, 'Food was good, but service was slow.', '2024-05-03', 3),
    (4, 'Loved the coffee and desserts!', '2024-05-04', 4),
    ( 5, 'Best cafe in town! Everything was perfect.', '2024-05-05', 5),
    ( 2, 'Disappointed with the quality of food.', '2024-05-06', 6),
    ( 4, 'Nice place to hang out with friends.', '2024-05-07', 7),
    ( 5, 'Excellent service and delicious food.', '2024-05-08', 8),
    (3, 'Food was average, expected more.', '2024-05-09', 9),
    ( 4, 'Enjoyed my coffee and sandwich.', '2024-05-10', 10);


INSERT INTO Payment (PaymentID, TotalAmount, Date, PaymentMethod, Status, CustomerID)
VALUES
    (1, 8700.00, '2024-05-01', 'Credit Card', 'Completed', 1),
    (2, 5220.00, '2024-05-02', 'Cash', 'Completed', 2),
    (3, 4350.00, '2024-05-03', 'Credit Card', 'Completed', 3),
    (4, 6960.00, '2024-05-04', 'Debit Card', 'Completed', 4),
    (5, 9570.00, '2024-05-05', 'Cash', 'Completed', 5),
    (6, 3480.00, '2024-05-06', 'Credit Card', 'Completed', 6),
    (7, 6090.00, '2024-05-07', 'Debit Card', 'Completed', 7),
    (8, 7830.00, '2024-05-08', 'Credit Card', 'Completed', 8),
    (9, 4872.00, '2024-05-09', 'Cash', 'Completed', 9),
    (10, 10440.00, '2024-05-10', 'Debit Card', 'Completed', 10);


INSERT INTO Receipt (ReceiptID, Date, Items, Discount, Total, PaymentID)
VALUES
    (1, '2024-05-01', 'Coffee, Sandwich', 870.00, 7830.00, 1),
    (2, '2024-05-02', 'Cake, Tea', 0.00, 5220.00, 2),
    (3, '2024-05-03', 'Pizza, Salad', 0.00, 4350.00, 3),
    (4, '2024-05-04', 'Burger, Fries', 0.00, 6960.00, 4),
    (5, '2024-05-05', 'Pasta, Garlic Bread', 870.00, 8700.00, 5),
    (6, '2024-05-06', 'Coffee, Muffin', 0.00, 3480.00, 6),
    (7, '2024-05-07', 'Sandwich, Smoothie', 0.00, 6090.00, 7),
    (8, '2024-05-08', 'Pancakes, Juice', 0.00, 7830.00, 8),
    (9, '2024-05-09', 'Sushi, Green Tea', 0.00, 4872.00, 9),
    (10, '2024-05-10', 'Steak, Wine', 0.00, 10440.00, 10);

select * from Inventory;
--trigger1 for updating stock quantity in inventory table after insertion in product table
CREATE TRIGGER trg_UpdateProductInventory
ON Product
AFTER UPDATE
AS
BEGIN
    DECLARE @ProductID INT
    DECLARE @StockQuantity INT

    SELECT @ProductID = ProductID FROM inserted
    SELECT @StockQuantity = StockQuantity FROM Product WHERE ProductID = @ProductID

    UPDATE Inventory SET Quantity = @StockQuantity, DateReceived = GETDATE()
    WHERE ProductID = @ProductID
END;

---trigger 2 to update OrderItems when an Order is updated
CREATE TRIGGER UpdateOrderItemsOnOrderUpdate
ON Orderr
AFTER UPDATE
AS
BEGIN
    UPDATE OrderItems
    SET Quantity = (SELECT Quantity FROM inserted)
    WHERE OrderID = (SELECT OrderID FROM inserted)
END


--------Views----------------
--1--
create view TotalSalesByProduct
as 
select P.Name AS ProductName, SUM(OI.Quantity * P.Price) as TotalSales
from OrderItems OI
join Product P ON OI.ProductID = P.ProductID
group by P.Name;

--2--
create view TotalProductsInEachCategory
as
select C.CategoryName, COUNT(P.ProductID) as TotalProducts
from Product P
join Category C ON P.CategoryID = C.CategoryID
group by C.CategoryName;

--3--
CREATE VIEW ActiveSuppliers AS
SELECT S.SupplierID, S.Name AS SupplierName, COUNT(P.ProductID) AS TotalProducts
FROM Supplier S
LEFT JOIN Product P ON S.SupplierID = P.SupplierID
GROUP BY S.SupplierID, S.Name;

--4--
CREATE VIEW CustomerCart AS
SELECT C.CartID, C.CustomerID, C.Status, COUNT(CI.CartItemID) AS TotalItems
FROM Cart C
LEFT JOIN CartItems CI ON C.CartID = CI.CartID
GROUP BY C.CartID, C.CustomerID, C.Status;

--5--
CREATE VIEW PaymentSummary AS
SELECT P.PaymentID, P.TotalAmount, P.Date, P.PaymentMethod, P.Status, C.Name AS CustomerName
FROM Payment P
JOIN Customer C ON P.CustomerID = C.CustomerID;