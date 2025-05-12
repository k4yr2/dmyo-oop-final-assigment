USE dmyo_oop_final_assigment;

IF OBJECT_ID('User', 'U') IS NULL
BEGIN
	CREATE TABLE [User] (
		id			INT PRIMARY		KEY IDENTITY(1,1),
		name		NVARCHAR(100)	NOT NULL UNIQUE,
		password	NVARCHAR(32)	NOT NULL,
		role		VARCHAR(20)		NOT NULL CHECK (role IN ('collector', 'recycler', 'admin'))
	);

	INSERT INTO [User] (name, password, role)
	VALUES ('dmyo', '2025', 'admin'), ('sinan', 'demirci', 'collector'), ('serhat', 'genc', 'recycler');
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
		hazardLevel INT				DEFAULT 0 CHECK (hazardLevel BETWEEN 0 AND 5),
		recyclable	BIT				DEFAULT(0),
		description NVARCHAR(500)
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteType' AND type = 'U')
BEGIN
	CREATE TABLE WasteType (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		unit		INT				FOREIGN KEY REFERENCES WasteUnit(id),
		category	INT				FOREIGN KEY REFERENCES WasteCategory(id),
		description NVARCHAR(500),
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCollection' AND type = 'U')
BEGIN
	CREATE TABLE WasteCollection (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL,
		date		DATETIME		NOT NULL DEFAULT GETDATE(),
		location	NVARCHAR(100)	DEFAULT 'no location entered'
	);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteEntry' AND type = 'U')
BEGIN
	CREATE TABLE WasteEntry (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		date		DATETIME		NOT NULL DEFAULT GETDATE(),
		type		INT				FOREIGN KEY REFERENCES WasteType(id) DEFAULT 0,
		collection	INT				FOREIGN KEY REFERENCES WasteCollection(id) DEFAULT 0,
		quantity	DECIMAL(10,2),
	);
END;