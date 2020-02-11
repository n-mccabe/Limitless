USE master;

IF DB_ID(N'LibraryDB') IS NOT NULL DROP DATABASE LibraryDB;
CREATE DATABASE LibraryDB;
GO

USE LibraryDB;
GO
/*
Fields for the table for books
*/

CREATE TABLE Books (
    Id INT NOT NULL,
    Title VARCHAR(50) NOT NULL,
    BookYear INT,
    ISBN BIGINT,
    BookLocation CHAR,
    CopiesAvailable INT,
    PRIMARY KEY(Id)
);

INSERT INTO Books
    (Id, Title, BookYear, ISBN, BookLocation, CopiesAvailable)
VALUES
    (1, 'The Catcher in the Rye', 1940, 1234567891231, 'A', 10),
    (2, 'Nine Stories', 1945, 1234567891232, 'A', 12),
    (3, 'Franny and Zooey', 1960, 1234567891233, 'B', 3),
    (4, 'The Great Gatsby', 1976, 1234567891234, 'C', 5),
    (5, 'Tender id the Night', 1965, 1234567891235, 'D', 7),
    (6, 'Pride and Prejudice', 1976, 1234567891236, 'D', 9),
    (7, 'Professional ASP.NET 4.5 in C# and VB', 2017, 1234567891237, 'E', 17)
;
/*
fields for author
*/

CREATE TABLE Authors (
    Id INT NOT NULL IDENTITY,
    FirstName VARCHAR(70) NOT NULL,
    LastName VARCHAR(70) NOT NULL,
    AboutAuthor VARCHAR (100) NOT NULL,
    PRIMARY KEY(Id)
);

INSERT INTO Authors
    (FirstName, LastName, AboutAuthor)
VALUES
    ('J.D.', 'Salinger', 'From Island'),
    ('F. Scott.', 'Fitzgerald','From USA'),
    ('Jane', 'Austen', 'From Canada'),
    ('Scott', 'Hanselman', 'From Mexico'),
    ('Jason N.', 'Gaylord', 'From Guam'),
    ('Pranav', 'Rastogi', 'From Germany'),
    ('Todd', 'Miranda', 'From France'),
    ('Christian', 'Wenz', 'From Japan')
;
/*
fields to create table to combine book and author
*/
CREATE TABLE BooksAuthors (
    AuthorId INT NOT NULL,
    BookId  INT NOT NULL,
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
    FOREIGN KEY (BookId) REFERENCES Books(Id)
);

INSERT INTO BooksAuthors
    (BookId, AuthorId)
VALUES
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 2),
    (5, 2),
    (6, 3),
    (7, 4),
    (7, 5),
    (7, 6),
    (7, 7),
    (7, 8)
;
/*
fields for borrower
*/
CREATE TABLE Borrower (
    SchoolId INT NOT NULL,
    FirstName VARCHAR(70) NOT NULL,
    LastName VARCHAR(70) NOT NULL,
    NumberBooks INT,
    PRIMARY KEY(SchoolId)
);

INSERT INTO Borrower
    (SchoolId, FirstName, LastName, NumberBooks)
VALUES
    (111, 'Bruce', 'Black', 1),
    (222, 'Anthony', 'Dick', 2),
    (333, 'Nathan', 'McCabe', 3),
    (444, 'Charles', 'Roseboro', 4),
    (555, 'Jarrell', 'Roland', 5),
    (666, 'Teresa', 'Graham', 6)
;
/*
SEARCH FIELDS, COPY AND PASTE OUTSIDE OF COMMENTS TO SEARCH COMMON FIELDS
select * from Authors
select * from Books
select * from BooksAuthors
select * from Borrower
*/
select * from Books
select * from Authors
select * from Borrower
;

