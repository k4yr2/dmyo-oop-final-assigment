USE dmyo_oop_final_assigment;

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'WasteTypes' AND type = 'U')
BEGIN
	CREATE TABLE WasteTypes (
		id INT PRIMARY KEY IDENTITY(1,1),
		name NVARCHAR(50) NOT NULL,
		description NVARCHAR(500)
	);
END;
