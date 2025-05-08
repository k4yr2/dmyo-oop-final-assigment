USE dmyo_oop_final_assigment;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCollections' AND type = 'U')
BEGIN
	CREATE TABLE WasteCollections (
		id INT PRIMARY KEY IDENTITY(1,1),
		date DATETIME,
		place NVARCHAR(255),
		status NVARCHAR(50)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteTypes' AND type = 'U')
BEGIN
	CREATE TABLE WasteTypes (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		description NVARCHAR(500)
	);

	INSERT INTO WasteTypes (name, description) VALUES 
	('Plastic', 'Plastic waste collection'),
	('Paper', 'Paper waste collection'),
	('Metal', 'Metal waste collection'),
	('Glass', 'Glass waste collection'),
	('Organic', 'Organic waste collection'),
	('Hazardous', 'Hazardous waste collection'),
	('E-waste', 'Electronic waste collection'),
	('Bulky', 'Bulky waste collection'),
	('Construction', 'Construction waste collection'),
	('Medical', 'Medical waste collection'),
	('Textile', 'Textile waste collection'),
	('Food', 'Food waste collection'),
	('Garden', 'Garden waste collection'),
	('Batteries', 'Battery waste collection'),
	('Furniture', 'Furniture waste collection'),
	('Household', 'Household waste collection'),
	('Miscellaneous', 'Miscellaneous waste collection');
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteRecords' AND type = 'U')
BEGIN
	CREATE TABLE WasteRecords (
		id INT PRIMARY KEY IDENTITY(1,1),
		type INT FOREIGN KEY REFERENCES WasteTypes(id),
		amount DECIMAL(10, 2),
		collection INT FOREIGN KEY REFERENCES WasteCollections(id)
	);
END;