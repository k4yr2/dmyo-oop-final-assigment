USE dmyo_oop_final_assigment;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteTypes' AND type = 'U')
BEGIN
	CREATE TABLE WasteTypes (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		description NVARCHAR(500)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCategories' AND type = 'U')
BEGIN
	CREATE TABLE WasteCategories (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		description NVARCHAR(500),
		hazardLevel INT DEFAULT(0),
		recyclable BIT DEFAULT(0)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteUnits' AND type = 'U')
BEGIN
	CREATE TABLE WasteUnits (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		abbreviation  NVARCHAR(8)
	);
END;