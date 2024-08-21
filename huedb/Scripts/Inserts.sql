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
-- Insert para la tabla ProductTypes
INSERT INTO [dbo].[ProductTypes] ([Name])
VALUES 
('Neoprene'), 
('Fins'), 
('Hoods'), 
('Masks'), 
('Octopus'), 
('BCDs'), 
('Tanks');

-- Insert para la tabla Sizes
INSERT INTO [dbo].[Sizes] ([Name], [Value])
VALUES 
('XS', 1),
('S', 2),
('M', 3),
('L', 4),
('XL', 5);

-- Insert para la tabla States
INSERT INTO [dbo].[States] ([Name])
VALUES 
('Disponible'),
('Alquilado'),
('En revisión');

-- Insert para la tabla NeopreneGears
INSERT INTO [dbo].[NeopreneGears] 
([Id], [InternNumber], [Model], [SizeId], [Brand], [Color], [Condition], [StateId], [Acquired], [Price], [Notes])
VALUES 
(1, 1001, 'Modelo A', 3, 'Marca X', 'Negro', 'Usado, en buenas condiciones', 1, '2023-05-15', 5000, 'Traje de neopreno estándar.'),
(2, 1002, 'Modelo B', 4, 'Marca Y', 'Azul', 'Nuevo', 1, '2023-06-10', 5500, 'Traje con refuerzos térmicos.'),
(3, 1003, 'Modelo C', 2, 'Marca Z', 'Rojo', 'Usado, con algunos detalles', 3, '2023-07-20', 4800, 'Requiere pequeña reparación en la costura.');

-- Insert para la tabla Hoods
INSERT INTO [dbo].[Hoods] 
([Id], [InternNumber], [SizeId], [Brand], [Model], [Color], [Acquired], [Condition], [StateId], [Price], [Notes])
VALUES 
(1, 2001, 2, 'Marca A', 'Modelo X', 'Negro', '2023-04-10', 'Nuevo', 1, 1500, 'Capucha para agua fría.'),
(2, 2002, 3, 'Marca B', 'Modelo Y', 'Gris', '2023-05-18', 'Usado, en buenas condiciones', 2, 1200, 'Capucha ligera, talla mediana.'),
(3, 2003, 4, 'Marca C', 'Modelo Z', 'Verde', '2023-06-25', 'En revisión', 3, 1300, 'Capucha con refuerzos de neopreno.');

-- Insert para la tabla Fins
INSERT INTO [dbo].[Fins] 
([Id], [InternNumber], [Brand], [Model], [Color], [SizeId], [Acquired], [Condition], [StateId], [Price], [Notes])
VALUES 
(1, 3001, 'Marca D', 'Modelo 1', 'Amarillo', 2, '2023-07-01', 'Nuevo', 1, 2500, 'Aletas de buceo profesionales.'),
(2, 3002, 'Marca E', 'Modelo 2', 'Negro', 3, '2023-06-15', 'Usado', 2, 2200, 'Aletas estándar, buen estado.'),
(3, 3003, 'Marca F', 'Modelo 3', 'Azul', 4, '2023-08-05', 'En revisión', 3, 2100, 'Aletas con signos de desgaste.');

-- Insert para la tabla BCDs
INSERT INTO [dbo].[BCDs] 
([Id], [InternNumber], [Brand], [Model], [SizeId], [Valves], [Power], [Acquired], [Condition], [StateId], [Price], [Notes])
VALUES 
(1, 4001, 'Marca G', 'Modelo Alpha', 3, 'Válvulas estándar', '300W', '2023-05-10', 'Nuevo', 1, 8000, 'BCD con válvulas de inflado rápido.'),
(2, 4002, 'Marca H', 'Modelo Beta', 4, 'Válvulas avanzadas', '400W', '2023-07-11', 'Usado', 2, 7500, 'BCD con buena capacidad de flotación.'),
(3, 4003, 'Marca I', 'Modelo Gamma', 5, 'Válvulas simples', '350W', '2023-08-20', 'En revisión', 3, 7800, 'BCD requiere revisión de las válvulas.');

-- Insert para la tabla Octopus
INSERT INTO [dbo].[Octopus] 
([Id], [InternNumber], [Brand], [Model], [Acquired], [SerialNumber], [Condition], [StateId], [Price], [Composition], [Notes])
VALUES 
(1, 5001, 'Marca J', 'Modelo 10', '2023-03-05', 123456, 'Nuevo', 1, 3500, 'Acero inoxidable y aluminio', 'Octopus de última generación.'),
(2, 5002, 'Marca K', 'Modelo 20', '2023-05-15', 789101, 'Usado', 2, 3300, 'Aluminio anodizado', 'Octopus ligero y resistente.'),
(3, 5003, 'Marca L', 'Modelo 30', '2023-07-25', 112131, 'En revisión', 3, 3200, 'Plástico reforzado', 'Octopus compacto y versátil.');

-- Insert para la tabla Tanks
INSERT INTO [dbo].[Tanks] 
([Id], [InternNumber], [Name], [IsAluminium], [SerialNumber], [TankValves], [Color], [Capacity], [Pressure], [HT], [HTCertificate], [Condition], [StateId], [Acquired], [Price], [Notes])
VALUES 
(1, 6001, 'Tanque A', 1, 234567, 'Válvulas dobles', 'Plateado', 15, 200, '2023-01-01', 1, 'Nuevo', 1, '2023-04-01', 12000, 'Tanque de aluminio, recién certificado.'),
(2, 6002, 'Tanque B', 0, 890123, 'Válvula simple', 'Amarillo', 12, 180, '2023-02-15', 0, 'Usado, en buen estado', 2, '2023-05-10', 11000, 'Tanque de acero, próximo a certificación.'),
(3, 6003, 'Tanque C', 1, 456789, 'Válvulas triples', 'Azul', 18, 220, '2023-03-20', 1, 'En revisión', 3, '2023-07-20', 13000, 'Tanque con gran capacidad, revisión pendiente.');

  -- Insert para la tabla Masks
INSERT INTO [dbo].[Masks] 
([Id], [InternNumber], [Brand], [Model], [SizeId], [Acquired], [Condition], [StateId], [Color], [Price], [Notes])
VALUES 
(1, 7001, 'Marca M', 'Modelo A', 2, '2023-01-15', 'Nuevo', 1, 'Negro', 1800, 'Máscara de alta calidad para buceo.'),
(2, 7002, 'Marca N', 'Modelo B', 3, '2023-02-10', 'Usado, en buenas condiciones', 2, 'Azul', 1600, 'Máscara con visibilidad mejorada.'),
(3, 7003, 'Marca O', 'Modelo C', 4, '2023-03-20', 'En revisión', 3, 'Rojo', 1700, 'Máscara con correas ajustables y sellado.'),
(4, 7004, 'Marca P', 'Modelo D', 5, '2023-04-25', 'Nuevo', 1, 'Verde', 1900, 'Máscara con lente anti-rayas y antifog.');