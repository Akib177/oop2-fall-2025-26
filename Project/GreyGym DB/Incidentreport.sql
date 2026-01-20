CREATE TABLE IncidentReport (
    id INT PRIMARY KEY,
    ReportedBy VARCHAR(100),
    Date DATE,
    Description TEXT,
    Status VARCHAR(50)
);
INSERT INTO IncidentReport (id, ReportedBy, Date, Description, Status) VALUES 
(1, 'Omi', '2026-01-01', 'dsadasda', 'Resolved')
INSERT INTO IncidentReport (id, ReportedBy, Date, Description, Status) VALUES 
(2, 'Tanzim', '2026-03-05', 'dsadasda', 'Pending')
INSERT INTO IncidentReport (id, ReportedBy, Date, Description, Status) VALUES 
(3, 'sady', '2026-03-03', 'dsadasda', 'InProgress');

SELECT * from IncidentReport