﻿IF NOT EXISTS(SELECT 1 FROM   INFORMATION_SCHEMA.COLUMNS
          WHERE  TABLE_NAME = 'CTRL_S' AND COLUMN_NAME = 'MinimumInterestEarningBalance') 
BEGIN
	ALTER TABLE CTRL_S
	ADD MinimumInterestEarningBalance MONEY
END    
GO