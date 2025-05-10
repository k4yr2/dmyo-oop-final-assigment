USE dmyo_oop_final_assigment;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteCategory' AND type = 'U')
BEGIN
	CREATE TABLE WasteCategory (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL UNIQUE,
		description NVARCHAR(500),
		hazardLevel INT DEFAULT(0),
		recyclable BIT DEFAULT(0)
	);

	INSERT INTO WasteCategory (name, description, hazardLevel, recyclable)  
	VALUES  
	  ('Packaging',   'Packaging materials such as plastic, paper, and glass',      0, 1),  
	  ('Organic',     'Food and garden organic waste',                              0, 1),  
	  ('Electronic',  'Discarded electronic devices and components',                2, 1),  
	  ('Hazardous',   'Hazardous waste including chemicals, batteries, etc.',       3, 0),  
	  ('Medical',     'Medical waste such as syringes and expired pharmaceuticals', 3, 0);
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteUnit' AND type = 'U')
BEGIN
	CREATE TABLE WasteUnit (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL UNIQUE,
		abbreviation  NVARCHAR(8)
	);

	INSERT INTO WasteUnit (name, abbreviation)  
	VALUES  
	  ('Kilogram', 'kg'),
	  ('Liter',    'L'), 
	  ('Piece',    'pcs'),
	  ('Ton',      't');
END;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteType' AND type = 'U')
BEGIN
	CREATE TABLE WasteType (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL UNIQUE,
		description NVARCHAR(500),
		category INT FOREIGN KEY REFERENCES WasteCategory(id),
		unit INT FOREIGN KEY REFERENCES WasteUnit(id),
	);

	INSERT INTO WasteType (name, description, category, unit)  
	VALUES  
	  ('PET Bottle',        'Clear plastic bottle (PET)',                   1, 1),
	  ('Glass Jar',         'Glass jar for preserving and storage',         1, 1),  
	  ('Cardboard Box',     'Corrugated cardboard box',                     1, 1),  
	  ('Food Waste',        'Kitchen food scraps and leftover food',        2, 1),
	  ('Yard Trimmings',    'Garden trimmings: branches, leaves, grass',    2, 1),  
	  ('Mobile Phone',      'Discarded mobile phone',                       3, 3),
	  ('Laptop',            'Used laptop computer',                         3, 3),  
	  ('Battery (AA)',      'AA type alkaline battery',                     4, 1), 
	  ('Used Syringe',      'Single-use medical syringe',                   5, 3),
	  ('Expired Medicine',  'Pharmaceutical products past expiration date', 5, 3);
END;