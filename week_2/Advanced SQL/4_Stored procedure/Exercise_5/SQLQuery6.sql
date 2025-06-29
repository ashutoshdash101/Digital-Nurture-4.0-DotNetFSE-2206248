IF OBJECT_ID('Employees', 'U') IS NOT NULL DROP TABLE Employees;
IF OBJECT_ID('Departments', 'U') IS NOT NULL DROP TABLE Departments;
GO

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
GO

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);
GO

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');
GO

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Ashutosh', 'Dash', 1, 60000.00, '2024-08-27'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22');
GO

IF OBJECT_ID('sp_CountEmployeesByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_CountEmployeesByDepartment;
GO

CREATE PROCEDURE sp_CountEmployeesByDepartment
    @DeptID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DeptID;
END;
GO

EXEC sp_CountEmployeesByDepartment @DeptID = 1;