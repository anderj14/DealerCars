-- SQLite
-- Insert sample data into the BodyStyle table
-- INSERT INTO "BodyStyles" ("Id", "BodyTypeName")
-- VALUES
--     (1, 'Sedan'),
--     (2, 'Coupe'),
--     (3, 'Hatchback'),
--     (4, 'SUV'),
--     (5, 'Truck'),
--     (6, 'Convertible');

-- Insert sample data into the Brand table
-- INSERT INTO "Brands" ("Id", "BrandName")
-- VALUES
--     (1, 'Toyota'),
--     (2, 'Honda'),
--     (3, 'Ford'),
--     (4, 'Chevrolet'),
--     (5, 'BMW'),
--     (6, 'Audi');

-- Insert sample data into the DriveTrain table
-- INSERT INTO "DriveTrains" ("Id", "DriveTrainName")
-- VALUES
--     (1, 'Manual Transmission'),
--     (2, 'Automatic Transmission'),
--     (3, 'CVT Transmission'),
--     (4, 'Dual-Clutch Transmission');

-- Insert sample data into the Engines table
-- INSERT INTO "Engines" ("EngineTypeName")
-- VALUES ('V6'),
--        ('V8'),
--        ('Inline-4'),
--        ('Inline-6'),
--        ('Electric');

-- Insert sample data into the Fuel table
-- INSERT INTO "Fuels" ("FuelName")
-- VALUES ('Gasoline'),
--        ('Diesel'),
--        ('Electric'),
--        ('Hybrid'),
--        ('Ethanol');

-- Insert sample data into the Models table
-- Note: The BrandId values should correspond to the IDs from the Brand table
-- INSERT INTO "Models" ("ModelName", "BrandId")
-- VALUES
--     ('Camry', 1),       -- Toyota
--     ('Corolla', 1),     -- Toyota
--     ('Civic', 2),       -- Honda
--     ('Accord', 2),      -- Honda
--     ('Mustang', 3),     -- Ford
--     ('F-150', 3),       -- Ford
--     ('Malibu', 4),      -- Chevrolet
--     ('Impala', 4),      -- Chevrolet
--     ('3 Series', 5),    -- BMW
--     ('X5', 5),          -- BMW
--     ('A4', 6),          -- Audi
--     ('Q7', 6);          -- Audi

-- DELETE FROM "Models";

-- Insert sample data into the Status table
-- INSERT INTO "Statuses" ("StatusName")
-- VALUES
--     ('New'),           -- Brand new vehicle
--     ('Used'),          -- Pre-owned vehicle
--     ('Certified'),     -- Certified pre-owned vehicle
--     ('Salvage'),       -- Salvage title vehicle
--     ('Damaged');       -- Vehicle with damages

-- Insert sample data into the Trim table
-- Note: The ModelId values should correspond to the IDs from the Models table
-- Insert sample data into the Trims table
-- INSERT INTO "Trims" ("TrimName", "ModelsId")
-- VALUES
--     ('LE', 1),        -- Camry
--     ('XLE', 2),       -- Corolla
--     ('Sport', 3),     -- Civic
--     ('Touring', 4),   -- Accord
--     ('GT', 5),        -- Mustang
--     ('Z71', 6),       -- F-150
--     ('LS', 7),        -- Malibu
--     ('Premier', 8),   -- Impala
--     ('Sport', 9),     -- 3 Series
--     ('M Sport', 10),   -- X5
--     ('Premium', 11),   -- A4
--     ('Technik', 12);   -- Q7


-- -- Insert sample data into the Vehicle table
-- INSERT INTO "Vehicles" (
--     "Name", "DateAdded", "Owner", "Year", "Price", "Mileage", "VIN", 
--     "FuelEfficiency", "Color", "NumberOfDoors", "ExteriorFeatures", 
--     "InteriorFeatures", "HasABS", "HasAirbags", "HasStabilityControl", 
--     "HasTractionControl", "HasRearviewCamera", "HasBlindSpotMonitoring", 
--     "HasLaneDepartureWarning", "HasAutomaticEmergencyBraking", 
--     "BrandId", "ModelsId", "StatusId", "BodyStyleId", "EngineId", 
--     "DriveTrainId", "FuelId")
-- VALUES
--     -- Camry LE
--     ('Toyota Camry LE', '2024-08-01', '1', 2024, 25000, 5000, '1HGBH41JXMN109186', 
--      28.5, 'Blue', 4, 'Sunroof, Alloy Wheels', 'Leather Seats, Navigation System',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, 
--      1, 1, 1, 1, 1, 2, 1),

--     -- Corolla XLE
--     ('Toyota Corolla XLE', '2023-07-12', '2', 2023, 23000, 2000, '2HGBH41JXMN109187',
--      31.0, 'Silver', 4, 'Sunroof', 'Leather Interior, Heated Seats',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      1, 2, 1, 1, 3, 2, 1),

--     -- Civic Sport
--     ('Honda Civic Sport', '2022-06-10', '2', 2022, 22000, 3000, '3HGBH41JXMN109188',
--      30.0, 'Red', 4, 'Sporty Design', 'Premium Sound System, Heated Seats',
--      TRUE, TRUE, TRUE, TRUE, TRUE, FALSE, TRUE, FALSE,
--      2, 3, 1, 3, 1, 2, 1),

--     -- Accord Touring
--     ('Honda Accord Touring', '2021-05-15', '1', 2021, 27000, 1200, '4HGBH41JXMN109189',
--      29.0, 'Green', 4, 'LED Headlights', 'Leather Seats, Sunroof',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      2, 4, 1, 1, 3, 2, 1),

--     -- Mustang GT
--     ('Ford Mustang GT', '2020-04-20', '2', 2020, 35000, 2000, '5HGBH41JXMN109190',
--      25.0, 'Black', 2, 'Sporty Exhaust', 'Leather Seats, Advanced Infotainment',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      3, 5, 1, 2, 2, 2, 1),

--     -- F-150 Z71
--     ('Ford F-150 Z71', '2019-03-25', '3', 2019, 40000, 3000, '6HGBH41JXMN109191',
--      20.0, 'Black', 4, 'Off-Road Package', 'Leather Seats, Navigation',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      3, 6, 1, 5, 2, 1, 1),

--     -- Malibu Premier
--     ('Chevrolet Malibu Premier', '2018-02-18', '2', 2018, 28000, 1000, '7HGBH41JXMN109192',
--      27.0, 'White', 4, 'Chrome Trim', 'Luxury Leather, Sunroof',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      4, 7, 1, 1, 3, 2, 1),

--     -- Impala LS
--     ('Chevrolet Impala LS', '2017-01-12', '1', 2017, 29000, 800, '8HGBH41JXMN109193',
--      26.0, 'Grey', 4, 'LED Lights', 'Heated Seats, Premium Audio',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      4, 8, 1, 1, 3, 2, 1),

--     -- 3 Series Sport
--     ('BMW 3 Series Sport', '2016-12-05', '2', 2016, 32000, 1500, '9HGBH41JXMN109194',
--      25.0, 'Blue', 4, 'Sport Package', 'Leather Interior, Navigation',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      5, 9, 1, 1, 1, 2, 1),

--     -- X5 M Sport
--     ('BMW X5 M Sport', '2015-11-10', '3', 2015, 45000, 2500, '0HGBH41JXMN109195',
--      22.0, 'Black', 4, 'M Sport Package', 'Advanced Infotainment, Leather Seats',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      5, 10, 1, 4, 2, 2, 1),

--     -- A4 Premium
--     ('Audi A4 Premium', '2014-10-22', '1', 2014, 34000, 3000, '1HGBH41JXMN109196',
--      24.0, 'Red', 4, 'Premium Package', 'Leather Seats, Sunroof',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      6, 11, 1, 1, 1, 2, 1),

--     -- Q7 Technik
--     ('Audi Q7 Technik', '2013-09-15', '2', 2013, 50000, 3500, '2HGBH41JXMN109197',
--      20.0, 'Silver', 4, 'Technology Package', 'Leather Seats, Navigation System',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      6, 12, 1, 6, 2, 2, 1),

--     -- Camry XLE
--     ('Toyota Camry XLE', '2022-08-20', '1', 2022, 24000, 1200, '3HGBH41JXMN109198',
--      28.0, 'White', 4, 'Navigation System', 'Leather Seats, Heated Seats',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      1, 1, 1, 1, 1, 2, 1),

--     -- Corolla LE
--     ('Toyota Corolla LE', '2021-07-18', '3', 2021, 21000, 1500, '4HGBH41JXMN109199',
--      30.0, 'Silver', 4, 'Backup Camera', 'Cloth Seats, Air Conditioning',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      1, 2, 1, 1, 3, 2, 1),

--     -- Civic Touring
--     ('Honda Civic Touring', '2020-06-22', '2', 2020, 25000, 2000, '5HGBH41JXMN109200',
--      29.0, 'Blue', 4, 'Leather Seats', 'Navigation, Sunroof',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      2, 3, 1, 3, 1, 2, 1),

--     -- Accord Sport
--     ('Honda Accord Sport', '2019-05-15', '1', 2019, 26000, 3000, '6HGBH41JXMN109201',
--      27.0, 'Black', 4, 'Sport Package', 'Heated Seats, Infotainment System',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      2, 4, 1, 1, 3, 2, 1),

--     -- Mustang Shelby
--     ('Ford Mustang Shelby', '2018-04-10', '3', 2018, 45000, 1200, '7HGBH41JXMN109202',
--      23.0, 'Green', 2, 'Shelby Package', 'Leather Seats, Performance Exhaust',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      3, 5, 1, 2, 2, 2, 1),

--     -- F-150 Lariat
--     ('Ford F-150 Lariat', '2017-03-25', '1', 2017, 42000, 2000, '8HGBH41JXMN109203',
--      21.0, 'White', 4, 'Chrome Trim', 'Leather Seats, Navigation',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      3, 6, 1, 5, 2, 1, 1),

--     -- Malibu LS
--     ('Chevrolet Malibu LS', '2016-02-18', '2', 2016, 27000, 1500, '9HGBH41JXMN109204',
--      28.0, 'Silver', 4, 'Backup Camera', 'Leather Seats, Sunroof',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      4, 7, 1, 1, 3, 2, 1),

--     -- Impala LT
--     ('Chevrolet Impala LT', '2015-01-12', '1', 2015, 29000, 1000, '0HGBH41JXMN109205',
--      26.0, 'Blue', 4, 'Leather Seats', 'Navigation System, Premium Audio',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      4, 8, 1, 1, 3, 2, 1),

--     -- 3 Series Premium
--     ('BMW 3 Series Premium', '2014-12-05', '2', 2014, 32000, 2500, '1HGBH41JXMN109206',
--      25.0, 'Red', 4, 'Premium Package', 'Leather Seats, Navigation',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      5, 9, 1, 1, 1, 2, 1),

--     -- X5 Premium
--     ('BMW X5 Premium', '2013-11-10', '3', 2013, 45000, 3000, '2HGBH41JXMN109207',
--      22.0, 'Black', 4, 'Premium Package', 'Leather Seats, Advanced Infotainment',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      5, 10, 1, 4, 2, 2, 1),

--     -- A4 Technik
--     ('Audi A4 Technik', '2012-10-22', '2', 2012, 34000, 3500, '3HGBH41JXMN109208',
--      24.0, 'Silver', 4, 'Technology Package', 'Leather Seats, Navigation System',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      6, 11, 1, 1, 1, 2, 1),

--     -- Q7 Premium
--     ('Audi Q7 Premium', '2011-09-15', '3', 2011, 50000, 4000, '4HGBH41JXMN109209',
--      20.0, 'Gray', 4, 'Premium Package', 'Leather Seats, Advanced Navigation',
--      TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE,
--      6, 12, 1, 6, 2, 2, 1);
