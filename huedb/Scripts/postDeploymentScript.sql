/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (SELECT * FROM [dbo].[Users])
    Insert into [dbo].[Users](Admin, Email, Password)
    Values(TRUE, 'mati279@gmail.com', '34811105');

if not exists (SELECT * FROM [dbo].[Accesories])
Insert into [dbo].[Accesories](Name, Stock, Price)
Values('Cuchillo punta plana', 3, 6588),
('Pastilla de Plomo x 1kg', 500, 1500);


if not exists (SELECT * FROM [dbo].[Body])
Insert into [dbo].[Body](Name, Stock, Size, Brand, Mm, Price)
Values('Chaqueta C/casco 5mm. M', 13, 'M', 'Mares', 5, 8000),
('Pantalón Long Yong 5mm. M', 13, 'M', 'Mares', 5, 8000);

if not exists (SELECT * FROM [dbo].[Footwear])
Insert into [dbo].[Footwear](Name, Stock, Size, Brand, Price)
Values('Par de Botas IST talle 41', 5, 41, 'IST', 2000),
('Par de Aletas Antenal', 35, null,'Antenal', 7000);


if not exists (SELECT * FROM [dbo].[Rentals])
Insert into [dbo].[Rentals](UserId, Date, AccId, BodyId, FootwearId, Quantity)
Values(1, null ,null, 1, null, 1),
(1, null, null, null, 1, 1);


