USE dmyo_oop_final_assigment;

IF OBJECT_ID('User', 'U') IS NULL
BEGIN
	CREATE TABLE [User] (
		id			INT PRIMARY		KEY IDENTITY(1,1),
		role		INT				NOT NULL CHECK (role BETWEEN 0 AND 2),
		name		NVARCHAR(100)	NOT NULL UNIQUE,
		password	NVARCHAR(32)	NOT NULL
	);

	INSERT INTO [User] (name, password, role)
	VALUES ('dmyo', '2025', 2), ('sinan', 'demirci', 0), ('serhat', 'genc', 1);
END;

IF OBJECT_ID('WasteUnit', 'U') IS NULL
BEGIN
	CREATE TABLE [WasteUnit] (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		abbr		NVARCHAR(10)	NOT NULL DEFAULT 'pcs'
	);
END;

IF OBJECT_ID('WasteCategory', 'U') IS NULL
BEGIN
	CREATE TABLE [WasteCategory] (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		description NVARCHAR(500),
		hazardLevel INT				DEFAULT 0 CHECK (hazardLevel BETWEEN 0 AND 5),
		recyclable	BIT				DEFAULT(0)
	);
END;

IF OBJECT_ID('WasteType', 'U') IS NULL
BEGIN
	CREATE TABLE [WasteType] (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		name		NVARCHAR(50)	NOT NULL UNIQUE,
		description NVARCHAR(500),
		unit		INT				FOREIGN KEY REFERENCES WasteUnit(id),
		category	INT				FOREIGN KEY REFERENCES WasteCategory(id)
	);
END;

IF OBJECT_ID('WasteCollection', 'U') IS NULL
BEGIN
	CREATE TABLE [WasteCollection] (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		date		DATETIME		NOT NULL DEFAULT GETDATE(),
		[user]		INT				FOREIGN KEY REFERENCES [User](id),
		active		BIT				DEFAULT(0)
	);
END;

IF OBJECT_ID('WasteEntry', 'U') IS NULL
BEGIN
	CREATE TABLE [WasteEntry] (
		id			INT				PRIMARY KEY IDENTITY(1,1),
		date		DATETIME		NOT NULL DEFAULT GETDATE(),
		collection	INT				FOREIGN KEY REFERENCES WasteCollection(id) DEFAULT 0,
		type		INT				FOREIGN KEY REFERENCES WasteType(id) DEFAULT 0,
		quantity	DECIMAL(10, 2)
	);
END;