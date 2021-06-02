

--Kreiranje tabele u bazi
USE TSQL;
GO
IF (OBJECT_ID('dbo.Klijenti') IS NOT NULL) DROP TABLE dbo.Klijenti;
GO


CREATE TABLE dbo.Klijenti (
KlijentId int IDENTITY PRIMARY KEY NOT NULL,
Naziv nvarchar(40) NOT NULL,
Kontakt nvarchar(30) NOT NULL,
Grad nvarchar (15) NOT NULL,
Zemlja nvarchar(15) NOT NULL);
GO
INSERT INTO dbo.Klijenti
(Naziv, Kontakt, Grad, Zemlja)
SELECT companyname, contactname, city, country
FROM Sales.Customers;


--Za prikaz svih klijenata i informacija o njima
GO

CREATE PROC dbo.SviKlijenti
AS
SET LOCK_TIMEOUT 3000; --max 3 sec za wait
BEGIN TRY
	SELECT KlijentId,Naziv, Kontakt, Grad, Zemlja
	FROM dbo.Klijenti
	ORDER BY Naziv;
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO

---------------------Kreiranje procedure za insert klijenta

CREATE PROC Dbo.KlijentInsert
@naziv nvarchar(40), @kontakt nvarchar(30), @grad nvarchar(15), @zemlja nvarchar(15)
AS
SET LOCK_TIMEOUT 3000;

BEGIN TRY 
	
		INSERT INTO dbo.Klijenti(Naziv, Kontakt, Grad, Zemlja)
		VALUES(@naziv, @kontakt, @grad, @zemlja)
		RETURN 0;

END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH

GO

--Kreiranje proc za brisanje klijenta


CREATE PROC Dbo.KlijentDelete
@klijentid int
AS
BEGIN TRY
	IF NOT EXISTS(SELECT KlijentId FROM DBO.Klijenti WHERE KlijentId=@klijentid)
	BEGIN
		RETURN -4;
	END
	DELETE FROM DBO.Klijenti
	WHERE KlijentId = @klijentid

END TRY
BEGIN CATCH 
	RETURN ERROR_NUMBER();
END CATCH

EXEC Dbo.KlijentDelete 92

SELECT * FROM dbo.Klijenti
ORDER BY Naziv;

GO

--Za prikaz u text box

CREATE PROC Dbo.PrikazKlijentTxt
	@klijentid int, 
	@naziv nvarchar(40) OUTPUT,
	@kontakt nvarchar(30) OUTPUT,
	@grad nvarchar(15) OUTPUT,
	@zemlja nvarchar(15) OUTPUT
AS
SET LOCK_TIMEOUT 3000
BEGIN TRY
	SELECT @naziv = Naziv, @kontakt = Kontakt, @grad = Grad, @zemlja = Zemlja
	FROM dbo.Klijenti
	WHERE KlijentId = @klijentid
	RETURN 0;
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO

--TEST PROCEDURE ZA OUTPUT PARAMETRE

DECLARE @naziv nvarchar(40), @kontakt nvarchar(30), @grad nvarchar(15), @zemlja nvarchar(15)
DECLARE @Ret int

EXEC @Ret = Dbo.PrikazKlijentTxt 1, @naziv OUTPUT, @kontakt OUTPUT, @grad OUTPUT, @zemlja OUTPUT
PRINT @naziv
PRINT @kontakt
PRINT @grad
PRINT @zemlja
GO

	
-- KREIRANJE PROCEDURE ZA UPDATE KORISNIKA

CREATE PROC dbo.KlijentUpdate
@klijentid int, @naziv nvarchar(40), @kontakt nvarchar(30), @grad nvarchar(15), @zemlja nvarchar(15)
AS
SET LOCK_TIMEOUT 3000
BEGIN TRY
	UPDATE dbo.Klijenti
	SET Naziv = @naziv, Kontakt = @kontakt, Grad = @grad, zemlja = @zemlja
	WHERE KlijentId = @klijentid;
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO

--TEST
EXEC dbo.KlijentUpdate 93, Marko, asd, Beo, Srbija