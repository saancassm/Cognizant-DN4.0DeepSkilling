--Exercise 1: Create a Stored Procedure 

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID, FirstName, LastName, Salary, JoinDate
    FROM 
        Employees
    WHERE 
        DepartmentID = @DepartmentID;
END;

EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;

--DROP PROCEDURE sp_GetEmployeesByDepartment;
