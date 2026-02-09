-- DDL COMMANDS
	
	/*
	1. CREATE COMMAND to
		A. CREATE a DB
		B. CREATE a table
	*/

		/*
		A. CREATE a DB syntax:
			CREATE DATABASE database_name;
		*/

		CREATE DATABASE practice_db;

		-- To change currently used DB context
		-- Syntax: USE database_name

		USE practice_db;

		/*
		B. CREATE a table syntax:
			CREATE TABLE table_name(
				column_name datatype [constraints],
				column_name datatype [constraints]
			);
		*/

		CREATE TABLE Employee(
			EmpID INT PRIMARY KEY,
			EmpName VARCHAR(50) NOT NULL,
			EmpAge INT,
			Salary DECIMAL(10, 2),
			JoinDate Date
		);
	
	/*
	2. ALTER COMMAND to
		A. Add a new column
		B. Modify/Change datatype of a column
		C. Add a constraint
		D. Drop a column
		E. Drop a constraint
		F. Rename a column
		G. Rename a table
	*/
		
		/*
		A. Add a new column Syntax
			ALTER TABLE table_name
			ADD column_name datatype [constraints];
		*/

		ALTER TABLE Employee
		ADD Email VARCHAR(100);

		/*
		B. Modify/Change datatype of a column Syntax
			ALTER TABLE table_name
			ALTER COLUMN column_name new_datatype;
		*/

		ALTER TABLE Employee
		ALTER COLUMN EmpName VARCHAR(100) NOT NULL;

		/*
		C. Add a constraint
			a. Add primary key
			b. Add unique
			c. Add check
			d. Add default
		*/

			/*
			a. Add primary key Syntax
				ALTER TABLE table_name
				ADD CONSTRAINT constraint_name PRIMARY KEY (column_name);
			*/

			ALTER TABLE Employee
			ADD CONSTRAINT PK_Employee_EmpID PRIMARY KEY (EmpID);

			/*
			b. Add unique syntax
				ALTER TABLE table_name
				ADD CONSTRAINT constraint_name UNIQUE (column_name);
			*/

			ALTER TABLE Employee
			ADD CONSTRAINT UQ_Employee_Email UNIQUE (Email);

			/*
			c. Add check syntax
				ALTER TABLE table_name
				ADD CONSTRAINT constraint_name CHECK (condition);
			*/

			ALTER TABLE Employee
			ADD CONSTRAINT CK_Employee_EmpAge CHECK (EmpAge >= 18);

			/*
			d. Add default constraint
				ALTER TABLE table_name
				ADD CONSTRAINT constraint_name DEFAULT value FOR column_name;
			*/

			ALTER TABLE Employee
			ADD CONSTRAINT DK_Employee_JoinDate DEFAULT GETDATE() FOR JoinDate;

		/*
		D. Drop a column syntax
			ALTER TABLE table_name
			DROP COLUMN column_name;

			NOTE: You can't drop a column if it has a constraint defined on it. First you'll have to drop that constraint.
		*/

		ALTER TABLE Employee
		DROP CONSTRAINT CK_Employee_EmpAge;

		ALTER TABLE Employee
		DROP COLUMN EmpAge;

		/*
		E. Drop a constraint syntax
			ALTER TABLE table_name
			DROP CONSTRAINT constraint_name;
		*/

		ALTER TABLE Employee
		DROP CONSTRAINT UQ_Employee_Email;

		/*
		F. Rename a column syntax
			EXEC sp_rename 'table_name.old_column', 'new_column', 'COLUMN';
		*/

		EXEC sp_rename 'Employee.EmpName', 'FullName', 'COLUMN';

		/*
		G. Rename a table
			EXEC sp_rename 'old_table_name', 'new_table_name';
		*/

		EXEC sp_rename 'Employee', 'EmployeeDetails';

	/*
	3. DROP Command Syntax
		DROP TABLE table_name;
		NOTE: Not going to DROP the table as of now because it will cause problem for the further commands'
		practicals.

	*/

	/*
	4. TRUNCATE Command syntax
		TRUNCATE TABLE table_name;
	*/

	TRUNCATE TABLE EmployeeDetails;

-- DML COMMANDS

	/*
	1. INSERT COMMAND to
		a. Insert a single row
		b. Insert multiple rows in one query
		c. Insert values in all columns (order matters)
	*/

	/*
	a. Insert a single row
	*/

	INSERT INTO EmployeeDetails (EmpID, FullName, Salary, JoinDate, Email)
	VALUES (1, 'Rahul Sharma', 45000, '2023-01-10', 'rahul@gmail.com');

	/*
	b. Insert multiple rows
	*/

	INSERT INTO EmployeeDetails (EmpID, FullName, Salary, JoinDate, Email)
	VALUES
	(2, 'Anita Verma', 52000, '2022-11-15', 'anita@gmail.com'),
	(3, 'Karan Singh', 40000, '2023-03-01', 'karan@gmail.com');

	/*
	c. Insert values in all columns (order matters)
	*/

	INSERT INTO EmployeeDetails
	VALUES (4, 'Neha Patel', 48000, '2023-02-20', 'neha@gmail.com');

	/*
	2. UPDATE COMMAND
	*/

	UPDATE EmployeeDetails
	SET Salary = Salary + 2000
	WHERE EmpID = 1;

	/*
	3. DELETE COMMAND
	*/

	DELETE FROM EmployeeDetails
	WHERE EmpID = 3;

-- DQL COMMANDS

	/*
	1. SELECT COMMAND to
		a. Fetch all records
		b. Fetch specific columns
		c. Use WHERE condition
	*/

	/*
	a. Fetch all records
	*/

	SELECT * FROM EmployeeDetails;

	/*
	b. Fetch specific columns
	*/

	SELECT FullName, Salary FROM EmployeeDetails;

	/*
	c. Use WHERE condition
	*/

	SELECT * FROM EmployeeDetails
	WHERE Salary > 45000;

-- DCL COMMANDS

	/*
	1. GRANT COMMAND
	*/

	GRANT SELECT, INSERT
	ON EmployeeDetails
	TO PUBLIC;

	/*
	2. REVOKE COMMAND
	*/

	REVOKE INSERT
	ON EmployeeDetails
	FROM PUBLIC;

-- TCL COMMANDS

	/*
	1. TRANSACTION CONTROL COMMANDS
		a. BEGIN TRANSACTION
		b. COMMIT
		c. ROLLBACK
	*/

	BEGIN TRANSACTION;

	INSERT INTO EmployeeDetails
	VALUES (5, 'Amit Kumar', 50000, '2023-04-01', 'amit@gmail.com');

	ROLLBACK;

	-- Record not inserted

	BEGIN TRANSACTION;

	INSERT INTO EmployeeDetails
	VALUES (6, 'Pooja Mehta', 47000, '2023-05-05', 'pooja@gmail.com');

	COMMIT;
