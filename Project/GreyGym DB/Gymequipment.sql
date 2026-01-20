CREATE TABLE GymEquipment (
    id INT PRIMARY KEY,
    Ename VARCHAR(100),
    Category VARCHAR(50),
    Quantity INT,
    PurchaseDate DATE,
    Status VARCHAR(50)
);


INSERT INTO GymEquipment (id, Ename, Category, Quantity, PurchaseDate, Status) VALUES 
(1, 'Dumbells', 'Weight', 10, '2026-01-01', 'Available')


INSERT INTO GymEquipment (id, Ename, Category, Quantity, PurchaseDate, Status) VALUES 
(2, 'Treadmill', 'Cardio', 1, '2026-02-03', 'UnderMaintanance')


INSERT INTO GymEquipment (id, Ename, Category, Quantity, PurchaseDate, Status) VALUES 
(3, 'BenchPress', 'Weight', 2, '2026-03-04', 'Available');

SELECT * from GymEquipment