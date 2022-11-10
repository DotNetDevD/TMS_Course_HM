CREATE DATABASE MyBudgetPlanner;

CREATE TABLE Person
(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20) NOT NULL,
Surname NVARCHAR(20) NOT NULL,
Age INT
CONSTRAINT CK_Person_Age CHECK (Age > 0 and Age < 110)
)

CREATE TABLE TypeOfIncome
(
Id INT PRIMARY KEY IDENTITY,
TypeOfIncomeName NVARCHAR(50) UNIQUE
)

CREATE TABLE TypeOfExpenses
(
Id int PRIMARY KEY IDENTITY,
TypeOfExpensesName NVARCHAR(50) UNIQUE
)

CREATE TABLE Currancy
(
Id int PRIMARY KEY IDENTITY,
CurrancyName NVARCHAR(50) UNIQUE
)

CREATE TABLE Income
(
Id int PRIMARY KEY IDENTITY,
PersonId INT REFERENCES Person (Id),
CurrancyId INT REFERENCES Currancy (Id),
Date DATE,
TypeOfIncomeId INT REFERENCES TypeOfIncome (Id),
CountIncome MONEY DEFAULT 0
)

CREATE TABLE Expenses
(
Id INT PRIMARY KEY IDENTITY,
PersonId INT REFERENCES Person (Id),
CurrancyId INT REFERENCES Currancy (Id),
Date DATE,
TypeOfExpensesId INT REFERENCES TypeOfExpenses (Id),
CountExpenses MONEY DEFAULT 0
)

INSERT INTO Person (Name, Surname, Age) VALUES 
('Vasya', 'Petrovich', 21),
('Nikita', 'Krasnoperov', 48),
('Sasha', 'Arbuznik', 11),
('Stas', 'Bochenkov', 91),
('Alex', 'Samovarov', 24),
('Alina', 'Seroborod', 24)

INSERT INTO TypeOfIncome VALUES
('FullTime'),
('PartTime'),
('Moonlight')

INSERT INTO TypeOfExpenses VALUES
('Rent'),
('FoodBasket'),
('Alcohol'),
('Transport'),
('Taxs'),
('HealthMaintenance'),
('Gifts')

INSERT INTO Currancy VALUES
('BYN'),
('USD'),
('EUR')

INSERT INTO Expenses (PersonId, CurrancyId, Date, TypeOfExpensesId, CountExpenses) VALUES
(1, 2, '20221220', 3, 40),
(1, 1, '20221021', 5, 50),
(2, 1, '20221123', 2, 1000),
(6, 2, '20220512', 6, 500),
(4, 1, '20220530', 3, 100),
(3, 1, '20221110', 5, 20),
(5, 1, '20210320', 1, 360)

INSERT INTO Income (PersonId, CurrancyId, Date, TypeOfIncomeId, CountIncome) VALUES
(2, 2, '20221031', 3, 400),
(3, 1, GETDATE(), 3, 150),
(2, 1, '20220908', 1, 500),
(4, 3, '20220810', 3, 340),
(5, 2, '20220512', 1, 1000),
(5, 1, GETDATE(), 3, 200),
(6, 1, '20221031', 2, 360)

SELECT * FROM Person
SELECT * FROM Income
SELECT * FROM Expenses
SELECT * FROM TypeOfIncome
SELECT * FROM TypeOfExpenses
SELECT * FROM Currancy

--Вывод всех расходов
SELECT CONCAT(Name, ' ', Surname) 'Person', TypeOfExpensesName, CountExpenses, CurrancyName, Date FROM Person 
JOIN Expenses ON Person.Id = Expenses.PersonId
JOIN TypeOfExpenses ON Expenses.ID = TypeOfExpenses.Id
JOIN Currancy ON Expenses.CurrancyId = Currancy.Id 

--Вывод всех доходов
SELECT CONCAT(Name, ' ', Surname) 'Person', TypeOfIncomeName, CountIncome, CurrancyName, Date FROM Person
JOIN Income ON Person.Id = Income.PersonId
JOIN TypeOfIncome ON TypeOfIncomeId = TypeOfIncome.Id
JOIN Currancy ON Income.CurrancyId = Currancy.Id 

--Доход в одной валюте
SELECT CONCAT(Name, ' ', Surname) 'Person',
CASE CurrancyName
WHEN 'BYN' THEN CAST(CountIncome AS FLOAT) 
WHEN 'USD' THEN CountIncome * 2.5
WHEN 'EUR' THEN CountIncome * 2.56
END AS ['Доход в BYN'], 
TypeOfIncomeName, Date FROM Person
JOIN Income ON Person.Id = Income.PersonId
JOIN TypeOfIncome ON TypeOfIncomeId = TypeOfIncome.Id
JOIN Currancy ON Income.CurrancyId = Currancy.Id

UPDATE Expenses
SET CountExpenses = 250 WHERE TypeOfExpensesId = 6

UPDATE Income
SET CountIncome = 200 WHERE TypeOfIncomeId = 1 AND CurrancyId = 1
