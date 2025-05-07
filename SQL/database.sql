-- Check if database does not exist and create if missing.
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'dmyo_oop_final_assigment')
    BEGIN
        CREATE DATABASE dmyo_oop_final_assignment;
    END;
ELSE
    BEGIN
        PRINT 'Database "dmyo_oop_final_assigment" already exists.';
    END;