USE dmyo_oop_final_assigment;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'Authority' AND type = 'U')
BEGIN
	CREATE TABLE Authority (
		id			INT PRIMARY		KEY IDENTITY(1,1),
		name		NVARCHAR(100)	NOT NULL UNIQUE,
		password	NVARCHAR(256)	NOT NULL
	);

	INSERT INTO Authority (name, password)
		VALUES ('dmyo', '2025');
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteUnit' AND type = 'U')
BEGIN
	CREATE TABLE WasteUnit (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		abbr		NVARCHAR(10)	NOT NULL DEFAULT 'pcs'
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCategory' AND type = 'U')
BEGIN
	CREATE TABLE WasteCategory (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		description NVARCHAR(500),
		hazardLevel INT DEFAULT(0),
		recyclable	BIT DEFAULT(0)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteType' AND type = 'U')
BEGIN
	CREATE TABLE WasteType (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		description NVARCHAR(500),
		unit		INT				FOREIGN KEY REFERENCES WasteUnit(id),
		category	INT				FOREIGN KEY REFERENCES WasteCategory(id)
	);
END;


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteRecord' AND type = 'U')
BEGIN
	CREATE TABLE WasteRecord (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		type		INT				FOREIGN KEY REFERENCES WasteType(id) DEFAULT 0,
		quantity	DECIMAL(10,2),
		date		DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCollection' AND type = 'U')
BEGIN
	CREATE TABLE WasteCollection (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		date		DATETIME		NOT NULL DEFAULT GETDATE(),
		location	NVARCHAR(100)	DEFAULT 'no location entered'
	);
END;