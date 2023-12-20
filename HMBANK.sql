create database HMBank

use  HMBank

CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    DOB DATE,
    email VARCHAR(100),
    phone_number VARCHAR(20),
    address VARCHAR(255)
);

CREATE TABLE Accounts (
    account_id INT PRIMARY KEY,
    customer_id INT,
    account_type VARCHAR(50),
    balance DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

CREATE TABLE Transactions (
    transaction_id INT PRIMARY KEY,
    account_id INT,
    transaction_type VARCHAR(50),
    amount DECIMAL(10, 2),
    transaction_date DATE,
    FOREIGN KEY (account_id) REFERENCES Accounts(account_id)
);


-- Inserting 10 sample values into Customers table
INSERT INTO Customers (customer_id, first_name, last_name, DOB, email, phone_number, address)
VALUES
  (1, 'John', 'Doe', '1990-05-15', 'john.doe@email.com', '123-456-7890', '123 Main St'),
  (2, 'Jane', 'Smith', '1985-08-22', 'jane.smith@email.com', '987-654-3210', '456 Oak Ave'),
  (3, 'Bob', 'Johnson', '1978-03-10', 'bob.johnson@email.com', '555-123-4567', '789 Pine Rd'),
  (4, 'Alice', 'Williams', '1995-11-18', 'alice.williams@email.com', '111-222-3333', '101 Maple Blvd'),
  (5, 'Charlie', 'Brown', '1982-09-30', 'charlie.brown@email.com', '444-555-6666', '202 Cedar Ln'),
  (6, 'Eva', 'Davis', '1998-07-25', 'eva.davis@email.com', '777-888-9999', '303 Elm St'),
  (7, 'Frank', 'Moore', '1975-04-05', 'frank.moore@email.com', '666-999-1111', '404 Oak Dr'),
  (8, 'Grace', 'Taylor', '1989-12-12', 'grace.taylor@email.com', '222-333-4444', '505 Pine Ave'),
  (9, 'Henry', 'Clark', '1993-06-28', 'henry.clark@email.com', '999-111-2222', '606 Birch Rd'),
  (10, 'Ivy', 'Martin', '1980-01-08', 'ivy.martin@email.com', '333-444-5555', '707 Maple St');

-- Inserting 10 sample values into Accounts table
INSERT INTO Accounts (account_id, customer_id, account_type, balance)
VALUES
  (101, 1, 'savings', 5000.00),
  (102, 2, 'current', 15000.00),
  (103, 3, 'savings', 1000.00),
  (104, 4, 'current', 7500.00),
  (105, 5, 'savings', 3000.00),
  (106, 6, 'current', 12000.00),
  (107, 7, 'savings', 6000.00),
  (108, 8, 'current', 20000.00),
  (109, 9, 'savings', 2500.00),
  (110, 10, 'current', 18000.00);

-- Inserting 10 sample values into Transactions table
INSERT INTO Transactions (transaction_id, account_id, transaction_type, amount, transaction_date)
VALUES
  (1001, 101, 'deposit', 1000.00, '2023-01-05'),
  (1002, 102, 'withdrawal', 500.00, '2023-02-10'),
  (1003, 103, 'deposit', 200.00, '2023-03-20'),
  (1004, 104, 'withdrawal', 1000.00, '2023-04-02'),
  (1005, 105, 'deposit', 300.00, '2023-05-15'),
  (1006, 106, 'withdrawal', 800.00, '2023-06-28'),
  (1007, 107, 'deposit', 500.00, '2023-07-10'),
  (1008, 108, 'withdrawal', 1500.00, '2023-08-22'),
  (1009, 109, 'deposit', 100.00, '2023-09-05'),
  (1010, 110, 'withdrawal', 1200.00, '2023-10-18 ');
