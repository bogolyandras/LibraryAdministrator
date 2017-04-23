/*
 * Script for initializing the database
 */

CREATE TABLE application_users (
    id int IDENTITY(1,1) PRIMARY KEY,
    username nvarchar(255) NOT NULL,
    password nvarchar(255) NOT NULL,
	role nvarchar(255) CHECK (role IN ('Customer', 'Administrator'))
);

CREATE TABLE customer_details (
	id int IDENTITY(1,1) PRIMARY KEY,
	application_user_id int NOT NULL,
	name nvarchar(255),
	lakcim nvarchar (255),
	szuletesi_ev int,
	FOREIGN KEY (application_user_id) REFERENCES application_users(id)
);

CREATE TABLE categories (
	id int IDENTITY(1,1) PRIMARY KEY,
	name varchar(255)
);

CREATE TABLE books (
	id int IDENTITY(1,1) PRIMARY KEY,
	title nvarchar(255) NOT NULL,
	category int NOT NULL,
	description nvarchar(255),
	author nvarchar(255),
	year_of_publish int,
	isbn nvarchar(255),
	available INT NOT NULL CHECK (available >= 0),
	FOREIGN KEY (category) REFERENCES categories(id)
);

CREATE TABLE book_lendings (
	id int IDENTITY(1,1) PRIMARY KEY,
	transaction_finished bit NOT NULL DEFAULT 0,
	application_user_id int NOT NULL,
	start_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	end_date DATETIME,
	FOREIGN KEY (application_user_id) REFERENCES application_users(id)
);