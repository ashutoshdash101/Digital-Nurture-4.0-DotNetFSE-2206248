
USE week_2_practice;
GO

IF OBJECT_ID('Employees', 'U') IS NOT NULL DROP TABLE Employees;
IF OBJECT_ID('Departments', 'U') IS NOT NULL DROP TABLE Departments;
GO

CREATE TABLE Departments (
 DepartmentID INT PRIMARY KEY,
 DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
 EmployeeID INT PRIMARY KEY IDENTITY(1,1),
 FirstName VARCHAR(50),
 LastName VARCHAR(50),
 DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
 Salary DECIMAL(10,2),
 JoinDate DATE
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');

IF OBJECT_ID('sp_InsertEmployee', 'P') IS NOT NULL DROP PROCEDURE sp_InsertEmployee;
IF OBJECT_ID('sp_GetEmployeesByDepartment', 'P') IS NOT NULL DROP PROCEDURE sp_GetEmployeesByDepartment;
GO

CREATE PROCEDURE sp_InsertEmployee
 @FirstName VARCHAR(50),
 @LastName VARCHAR(50),
 @DepartmentID INT,
 @Salary DECIMAL(10,2),
 @JoinDate DATE
AS
BEGIN
 INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
 VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO

CREATE PROCEDURE sp_GetEmployeesByDepartment
 @DeptID INT
AS
BEGIN
 SELECT * FROM Employees WHERE DepartmentID = @DeptID;
END;
GO


EXEC sp_InsertEmployee 
    @FirstName = 'Ashutosh',
    @LastName = 'Dash',
    @DepartmentID = 1,
    @Salary = 30000.00,
    @JoinDate = '2024-08-28';
GO

EXEC sp_GetEmployeesByDepartment @DeptID = 1;