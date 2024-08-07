INSERT INTO ProductTypes(Name) 
	Values('Neoprene'), ('BCDs'), ('Hoods'), ('Masks'), ('Octopus'), ('Tanks'), ('Fins')

INSERT INTO Sizes(Name, Value) 
	Values('XS', 1), ('S', 2), ('M', 3), ('L', 4), ('XL', 5), ('1', 1), ('2', 2), ('3', 3), ('4', 4), ('5', 5)

INSERT INTO States(Name) 
	Values('Disponible'), ('Alquilado'), ('En revisión')

-- Datos para el estado Disponible
INSERT INTO [dbo].[BCDs]
    ([Id], [InternNumber], [Brand], [Model], [SizeId], [Valves], [Power], [Acquired], [Condition], [StateId], [Price], [Notes])
VALUES
    (1, 2001, 'BrandX', 'ModelA', 3, 'Single', 'Standard', '2024-07-10', 'New', 1, 450, 'High-quality BCD with single valve system.'),
    (2, 2002, 'BrandY', 'ModelB', 4, 'Double', 'High Pressure', '2024-05-25', 'Like New', 1, 500, 'Double valve system, well-maintained.'),
    (3, 2003, 'BrandZ', 'ModelC', 2, 'Single', 'Standard', '2024-06-15', 'New', 1, 420, 'Compact and durable BCD.'),
    (4, 2004, 'BrandX', 'ModelD', 5, 'Double', 'Standard', '2024-04-05', 'New', 1, 550, 'Advanced BCD with double valve system.'),

-- Datos para el estado Alquilado
    (5, 2005, 'BrandY', 'ModelE', 3, 'Single', 'High Pressure', '2024-03-20', 'Used', 2, 480, 'High pressure valves, slightly worn.'),
    (6, 2006, 'BrandZ', 'ModelF', 4, 'Double', 'Standard', '2024-02-10', 'Used', 2, 510, 'Comfortable BCD, some signs of use.'),

-- Datos para el estado En revisión
    (7, 2007, 'BrandA', 'ModelG', 3, 'Single', 'Standard', '2024-08-01', 'In Review', 3, 430, 'In review, minor issues detected.'),
    (8, 2008, 'BrandB', 'ModelH', 4, 'Double', 'High Pressure', '2024-07-05', 'In Review', 3, 490, 'In review, needs some maintenance.');


-- Datos para el estado Disponible
INSERT INTO [dbo].[NeopreneGears]
    ([Id], [InternNumber], [Piece], [SizeId], [Brand], [Color], [Condition], [StateId], [Acquired], [Price], [Notes])
VALUES
    (1, 3001, 'Neoprene Vest', 3, 'BrandA', 'Black', 'New', 1, '2024-07-15', 150, 'Top quality vest for diving.'),
    (2, 3002, 'Neoprene Gloves', 2, 'BrandB', 'Blue', 'Like New', 1, '2024-06-20', 75, 'Comfortable gloves, minimal use.'),
    (3, 3003, 'Neoprene Boots', 4, 'BrandC', 'Green', 'New', 1, '2024-05-10', 120, 'Waterproof and durable boots.'),
    (4, 3004, 'Neoprene Suit', 5, 'BrandD', 'Red', 'New', 1, '2024-08-01', 300, 'Full suit, excellent for cold water.'),

-- Datos para el estado Alquilado
    (5, 3005, 'Neoprene Shorts', 2, 'BrandE', 'Yellow', 'Used', 2, '2024-04-25', 90, 'Lightweight shorts, some signs of wear.'),
    (6, 3006, 'Neoprene Jacket', 4, 'BrandF', 'Orange', 'Used', 2, '2024-06-05', 180, 'Jacket with minor scuffs, still effective.'),

-- Datos para el estado En revisión
    (7, 3007, 'Neoprene Wetsuit', 3, 'BrandG', 'Purple', 'In Review', 3, '2024-07-25', 200, 'Wetsuit in review, minor issues detected.'),
    (8, 3008, 'Neoprene Socks', 2, 'BrandH', 'Pink', 'In Review', 3, '2024-08-10', 40, 'Socks in review, needs some repair.');

	-- Datos para el estado Disponible
INSERT INTO [dbo].[Fins]
    ([Id], [InternNumber], [Brand], [Model], [Color], [SizeId], [Acquired], [Condition], [StateId], [Price], [Notes])
VALUES
    (1, 4001, 'BrandA', 'ModelX', 'Black', 3, '2024-07-10', 'New', 1, 80, 'High-performance fins, excellent grip.'),
    (2, 4002, 'BrandB', 'ModelY', 'Blue', 2, '2024-05-20', 'Like New', 1, 75, 'Comfortable and lightweight fins.'),
    (3, 4003, 'BrandC', 'ModelZ', 'Green', 4, '2024-06-15', 'New', 1, 85, 'Durable fins, suitable for various conditions.'),
    (4, 4004, 'BrandD', 'ModelA', 'Red', 5, '2024-08-01', 'New', 1, 90, 'Advanced fins with adjustable straps.'),

-- Datos para el estado Alquilado
    (5, 4005, 'BrandE', 'ModelB', 'Yellow', 2, '2024-03-15', 'Used', 2, 70, 'Fins with minor wear, still functional.'),
    (6, 4006, 'BrandF', 'ModelC', 'Orange', 3, '2024-06-05', 'Used', 2, 80, 'Good condition, signs of previous use.'),

-- Datos para el estado En revisión
    (7, 4007, 'BrandG', 'ModelD', 'Purple', 4, '2024-07-20', 'In Review', 3, 85, 'In review, needs inspection for damage.'),
    (8, 4008, 'BrandH', 'ModelE', 'Pink', 2, '2024-08-10', 'In Review', 3, 70, 'In review, requires some repairs.');

	-- Datos para el estado Disponible
INSERT INTO [dbo].[Hoods]
    ([Id], [InternNumber], [SizeId], [Brand], [Model], [Color], [Acquired], [Condition], [StateId], [Price], [Notes])
VALUES
    (1, 5001, 3, 'BrandA', 'Con orejitas','Black', '2024-07-01', 'New', 1, 60, 'High-quality hood, perfect for cold water.'),
    (2, 5002, 2, 'BrandB', 'Akatsuki', 'Blue', '2024-06-15', 'Like New', 1, 55, 'Comfortable hood, minimal use.'),
    (3, 5003, 4, 'BrandC', 'Tiburón', 'Green', '2024-05-20', 'New',  1, 65, 'Durable hood, excellent for diving.'),
    (4, 5004, 5, 'BrandD', 'Incómoda', 'Red', '2024-08-01', 'New', 1, 70,  'Advanced hood with enhanced thermal protection.'),

-- Datos para el estado Alquilado
    (5, 5005, 2, 'BrandE', 'Con orejitas','Yellow', '2024-04-10', 'Used', 2, 50, 'Hood with signs of wear, still functional.'),
    (6, 5006, 3, 'BrandF', 'Con orejitas','Orange', '2024-06-01', 'Used', 2, 60, 'Good condition, minor usage marks.'),

-- Datos para el estado En revisión
    (7, 5007, 4, 'BrandG','Con orejitas', 'Purple',  '2024-07-25', 'In Review', 3, 65, 'Hood in review, needs inspection for damage.'),
    (8, 5008, 5, 'BrandH','Con orejitas', 'Pink', '2024-08-10', 'In Review', 3, 70,  'Hood in review, requires some repairs.');

	-- Datos para el estado Disponible
INSERT INTO [dbo].[Masks]
    ([Id], [InternNumber], [Brand], [Model], [SizeId], [Acquired], [Condition], [StateId], [Color], [Price], [Notes])
VALUES
    (1, 6001, 'BrandA', 'ModelX', 3, '2024-07-05', 'New', 1, 'Black', 120, 'High-quality mask with advanced features.'),
    (2, 6002, 'BrandB', 'ModelY', 2, '2024-06-15', 'Like New', 1, 'Blue', 110, 'Comfortable fit, minimal use.'),
    (3, 6003, 'BrandC', 'ModelZ', 4, '2024-05-20', 'New', 1, 'Blue', 130, 'Durable mask with excellent visibility.'),
    (4, 6004, 'BrandD', 'ModelA', 5, '2024-08-01', 'New', 1, 'Gray', 140, 'Advanced mask with superior comfort.'),

-- Datos para el estado Alquilado
    (5, 6005, 'BrandE', 'ModelB', 2, '2024-04-10', 'Used', 2, 'Yellow', 100, 'Mask with some signs of wear, still functional.'),
    (6, 6006, 'BrandF', 'ModelC', 3, '2024-06-01', 'Used', 2, 'Orange', 110, 'Good condition, minor usage marks.'),

-- Datos para el estado En revisión
    (7, 6007, 'BrandG', 'ModelD', 4, '2024-07-25', 'In Review', 3, 'Purple', 120, 'Mask in review, requires inspection for damage.'),
    (8, 6008, 'BrandH', 'ModelE', 5, '2024-08-10', 'In Review', 3, 'Pink', 130, 'Mask in review, needs some repairs.');

	-- Datos para el estado Disponible
INSERT INTO [dbo].[Octopus]
    ([Id], [InternNumber], [Brand], [Model], [Acquired], [SerialNumber], [Condition], [StateId], [Price], [Composition], [Notes])
VALUES
    (1, 7001, 'BrandA', 'ModelX', '2024-07-10', 123456, 'New', 1, 250, 'Stainless steel and rubber', 'High-performance octopus, new condition.'),
    (2, 7002, 'BrandB', 'ModelY', '2024-05-15', 789012, 'Like New', 1, 230, 'Rubber and plastic', 'Minimal use, excellent functionality.'),
    (3, 7003, 'BrandC', 'ModelZ', '2024-06-20', 345678, 'New', 1, 270, 'Titanium and rubber', 'Advanced octopus with superior durability.'),
    (4, 7004, 'BrandD', 'ModelA', '2024-08-01', 901234, 'New', 1, 260, 'High-grade plastic', 'Reliable octopus, excellent for diving.'),

-- Datos para el estado Alquilado
    (5, 7005, 'BrandE', 'ModelB', '2024-03-10', 567890, 'Used', 2, 220, 'Plastic and metal', 'Signs of wear, still functional.'),
    (6, 7006, 'BrandF', 'ModelC', '2024-06-01', 123789, 'Used', 2, 240, 'Metal and rubber', 'Good condition, minor usage marks.'),

-- Datos para el estado En revisión
    (7, 7007, 'BrandG', 'ModelD', '2024-07-25', 456123, 'In Review', 3, 250, 'Mixed materials', 'In review, requires inspection for performance.'),
    (8, 7008, 'BrandH', 'ModelE', '2024-08-10', 789456, 'In Review', 3, 260, 'Rubber and metal', 'In review, needs some repairs.');

	-- Datos para el estado Disponible
INSERT INTO [dbo].[Tanks]
    ([Id], [InternNumber], [Name], [IsAluminium], [SerialNumber], [TankValves], [Color], [Capacity], [Pressure], [HT], [HTCertificate], [Condition], [StateId], [Acquired], [Price], [Notes])
VALUES
    (1, 8001, 'TankA', 1, 1001, 'Standard', 'Black', 12, 200, '2024-07-01', 1, 'New', 1, '2024-06-01', 350, 'High-quality aluminum tank, recent test.'),
    (2, 8002, 'TankB', 0, 1002, 'Deluxe', 'Blue', 15, 250, '2024-05-15', 1, 'Like New', 1, '2024-05-01', 400, 'Durable steel tank, excellent condition.'),
    (3, 8003, 'TankC', 1, 1003, 'Standard', 'Red', 10, 180, '2024-06-20', 1, 'New', 1, '2024-06-01', 320, 'Aluminum tank, recent test passed.'),
    (4, 8004, 'TankD', 0, 1004, 'Advanced', 'Green', 18, 300, '2024-08-01', 1, 'New', 1, '2024-07-01', 450, 'High-pressure steel tank, new condition.'),

-- Datos para el estado Alquilado
    (5, 8005, 'TankE', 1, 1005, 'Standard', 'Yellow', 12, 200, '2024-03-10', 0, 'Used', 2, '2024-02-01', 330, 'Aluminum tank with minor wear.'),
    (6, 8006, 'TankF', 0, 1006, 'Deluxe', 'Orange', 15, 250, '2024-06-01', 0, 'Used', 2, '2024-05-01', 380, 'Steel tank with some usage signs.'),

-- Datos para el estado En revisión
    (7, 8007, 'TankG', 1, 1007, 'Standard', 'Purple', 10, 180, '2024-07-25', 0, 'In Review', 3, '2024-07-01', 340, 'Aluminum tank, requires inspection.'),
    (8, 8008, 'TankH', 0, 1008, 'Advanced', 'Pink', 18, 300, '2024-08-10', 0, 'In Review', 3, '2024-08-01', 460, 'Steel tank, needs review for pressure test.');
