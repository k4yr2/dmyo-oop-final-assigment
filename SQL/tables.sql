USE dmyo_oop_final_assigment;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCategory' AND type = 'U')
BEGIN
	CREATE TABLE WasteCategory (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		description NVARCHAR(500),
		hazardLevel INT DEFAULT(0),
		recyclable BIT DEFAULT(0)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteUnit' AND type = 'U')
BEGIN
	CREATE TABLE WasteUnit (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		abbreviation  NVARCHAR(8)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteType' AND type = 'U')
BEGIN
	CREATE TABLE WasteType (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		description NVARCHAR(500),
		category INT FOREIGN KEY REFERENCES WasteCategory(id),
		unit INT FOREIGN KEY REFERENCES WasteUnit(id),
	);
END;