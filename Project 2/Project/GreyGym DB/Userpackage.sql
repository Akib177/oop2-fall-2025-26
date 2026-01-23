
CREATE TABLE UserPackage (
    id INT PRIMARY KEY,
    Uid INT,
    PackId INT,
    StartDate DATE,
    EndDate DATE,
    IsActive VARCHAR(5)
);


INSERT INTO UserPackage (id, Uid, PackId, StartDate, EndDate, IsActive) VALUES 
(2, 2, 2, '2026-02-02', '2026-02-05', 'No')

INSERT INTO UserPackage (id, Uid, PackId, StartDate, EndDate, IsActive) VALUES 
(3, 4, 1, '2026-03-03', '2026-03-06', 'Yes');

SELECT * from UserPackage