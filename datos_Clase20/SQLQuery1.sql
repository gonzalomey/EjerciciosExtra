/****** Script para el comando SelectTopNRows de SSMS  ******/
/*SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas] */

  SELECT 
  id,nombre,apellido,edad
  

  FROM Padron.dbo.Personas

 /* INSERT INTO Padron.dbo.Personas /*NO SE PASA EL ID PORQUE ES UN VALOR AUTOINCREMENTABLE*/
  (nombre,apellido,edad)

  VALUES
  ('Carlos','Gardel',78)*/

 /* UPDATE Padron.dbo.Personas
  SET nombre = 'Gerardo',
	  edad = 54
  WHERE nombre = 'Alfredito'*/

  DELETE FROM Padron.dbo.Personas
  WHERE nombre = 'Carlos'

