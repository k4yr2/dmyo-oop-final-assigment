USE dmyo_oop_final_assigment;

IF OBJECT_ID('Factory', 'U') IS NULL
BEGIN
	CREATE TABLE Factory (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		name			NVARCHAR(50)	NOT NULL DEFAULT 'My Factory',
	);
END;

IF OBJECT_ID('Person', 'U') IS NULL
BEGIN
	CREATE TABLE Person (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		name			NVARCHAR(100)	NOT NULL UNIQUE,
		password		NVARCHAR(32)	NOT NULL,
		role			INT				NOT NULL CHECK (role BETWEEN 0 AND 2),
		factory			INT				FOREIGN KEY REFERENCES Factory(id) NULL,
	);

	INSERT INTO Person (name, password, role)
	VALUES ('dmyo', '2025', 2), ('sinan', 'demirci', 0), ('semih', 'altun', 0), ('serhat', 'genc', 1);
END;

-- Waste Unit ve Kategori

IF OBJECT_ID('WasteUnit', 'U') IS NULL
BEGIN
	CREATE TABLE WasteUnit (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		name			NVARCHAR(50)	NOT NULL UNIQUE,
		abbr			NVARCHAR(10)	NOT NULL DEFAULT 'pcs'
	);

	INSERT INTO WasteUnit (name, abbr)
	VALUES ('Kilogram', 'kg'), ('Liter', 'lt'), ('Piece', 'pcs');
END;

IF OBJECT_ID('WasteCategory', 'U') IS NULL
BEGIN
	CREATE TABLE WasteCategory (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		name			NVARCHAR(50)	NOT NULL UNIQUE,
		description		NVARCHAR(500),
		hazardLevel		INT				DEFAULT 0 CHECK (hazardLevel BETWEEN 0 AND 5),
		recyclable		BIT				DEFAULT(0)
	);

	INSERT INTO WasteCategory (name, description, hazardLevel, recyclable) VALUES 
	('Organic', 'Organic content such as food waste.', 1, 1),
	('Chemical', 'Industrial chemical waste.', 4, 0),
	('Electronic', 'Electronic device parts.', 2, 1);
END;

IF OBJECT_ID('WasteType', 'U') IS NULL
BEGIN
	CREATE TABLE WasteType (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		name			NVARCHAR(50)	NOT NULL UNIQUE,
		description		NVARCHAR(500),
		unit			INT				FOREIGN KEY REFERENCES WasteUnit(id),
		category		INT				FOREIGN KEY REFERENCES WasteCategory(id)
	);

	INSERT INTO WasteType (name, description, unit, category) VALUES
	('Food Waste', 'Leftover food materials', 1, 1),
	('Acid Solution', 'Laboratory acids', 2, 2),
	('Broken Phone', 'Non-functioning cell phones', 3, 3);
END;

-- Waste Collection & Waste

IF OBJECT_ID('WasteCollection', 'U') IS NULL
BEGIN
	CREATE TABLE WasteCollection (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		person			INT				FOREIGN KEY REFERENCES Person(id),
		status			INT				NOT NULL DEFAULT(0) CHECK (status BETWEEN 0 AND 3), -- 0: Active, 1: Processing, 2: Completed, 3: Canceled 
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

IF OBJECT_ID('Waste', 'U') IS NULL
BEGIN
	CREATE TABLE Waste (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		collection		INT				FOREIGN KEY REFERENCES WasteCollection(id),
		type			INT				FOREIGN KEY REFERENCES WasteType(id),
		quantity		DECIMAL(10, 2)	NOT NULL DEFAULT 0,
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

-- Waste Distribution & Waste Dispatch

IF OBJECT_ID('WasteDistribution', 'U') IS NULL
BEGIN
	CREATE TABLE WasteDistribution (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		collection		INT				FOREIGN KEY REFERENCES WasteCollection(id) NOT NULL,
		factory			INT				FOREIGN KEY REFERENCES Factory(id) NULL,
		status			INT				NOT NULL DEFAULT(0) CHECK (status BETWEEN 0 AND 3), -- 0: Active, 1: Processing, 2: Completed, 3: Canceled 
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

IF OBJECT_ID('WasteDispatch', 'U') IS NULL
BEGIN
	CREATE TABLE WasteDispatch (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		type			INT				FOREIGN KEY REFERENCES WasteType(id),
		distribution	INT				FOREIGN KEY REFERENCES WasteDistribution(id),
		quantity		DECIMAL(10, 2)	NOT NULL DEFAULT(0),
		capacity		DECIMAL(10, 2)	NOT NULL DEFAULT(0),
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

-- Waste Stock & Waste Receipt

IF OBJECT_ID('WasteStock', 'U') IS NULL
BEGIN
	CREATE TABLE WasteStock (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		person			INT				FOREIGN KEY REFERENCES Person(id),
		distribution	INT				FOREIGN KEY REFERENCES WasteDistribution(id),
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

IF OBJECT_ID('WasteReceipt', 'U') IS NULL
BEGIN
	CREATE TABLE WasteReceipt (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		dispatch		INT				FOREIGN KEY REFERENCES WasteDispatch(id),
		stock			INT				FOREIGN KEY REFERENCES WasteStock(id),
		quantity		DECIMAL(10, 2)	NOT NULL DEFAULT(0),
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

-- Waste Recycle & Waste Gain

IF OBJECT_ID('WasteRecycle', 'U') IS NULL
BEGIN
	CREATE TABLE WasteRecycle (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		factory			INT				FOREIGN KEY REFERENCES Factory(id),
		person			INT				FOREIGN KEY REFERENCES Person(id),
		active			BIT				NOT NULL DEFAULT(0),
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

IF OBJECT_ID('WasteGain', 'U') IS NULL
BEGIN
	CREATE TABLE WasteGain (
		id				INT				PRIMARY KEY IDENTITY(1,1),
		receipt			INT				FOREIGN KEY REFERENCES WasteReceipt(id),
		recycle			INT				FOREIGN KEY REFERENCES WasteRecycle(id),
		quantity		DECIMAL(10, 2)	NOT NULL DEFAULT(0),
		date			DATETIME		NOT NULL DEFAULT GETDATE()
	);
END;

SELECT *
FROM Waste
WHERE id IN (
    SELECT MIN(id)
    FROM Waste
    WHERE collection = 1006
    GROUP BY type
);