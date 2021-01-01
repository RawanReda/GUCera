use GUCera; 

go
create proc studentRegister 
@first_name varchar(20), @last_name varchar(20), @password varchar(20), @email varchar(50),
@gender bit, @address varchar(10)
AS
INSERT INTO Users(firstName,lastName,password,gender,email,address)
VALUES(@first_name,@last_name,@password,@gender,@email,@address)
DECLARE @id int
SELECT @id = max(id) FROM Users 
INSERT INTO Student(id)
VALUES(@id)

go
create proc InstructorRegister 
@first_name varchar(20), @last_name varchar(20), @password varchar(20), @email varchar(50),
@gender bit, @address varchar(10)
AS
INSERT INTO Users(firstName,lastName,password,gender,email,address)
VALUES(@first_name,@last_name,@password,@gender,@email,@address)
DECLARE @id int
SELECT @id = max(id) FROM Users 
INSERT INTO Instructor(id)
VALUES(@id)
