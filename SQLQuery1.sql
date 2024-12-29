-- Populate People Table
INSERT INTO People (FirstName, LastName, EmailAddress, CellphoneNumber)
VALUES 
('John', 'Doe', 'john.doe@example.com', '123-456-7890'),
('Jane', 'Smith', 'jane.smith@example.com', '234-567-8901'),
('Emily', 'Johnson', 'emily.johnson@example.com', '345-678-9012'),
('Michael', 'Brown', 'michael.brown@example.com', '456-789-0123'),
('Sarah', 'Davis', 'sarah.davis@example.com', '567-890-1234'),
('Chris', 'Miller', 'chris.miller@example.com', '678-901-2345'),
('Jessica', 'Wilson', 'jessica.wilson@example.com', '789-012-3456'),
('David', 'Moore', 'david.moore@example.com', '890-123-4567'),
('Sophia', 'Taylor', 'sophia.taylor@example.com', '901-234-5678'),
('James', 'Anderson', 'james.anderson@example.com', '012-345-6789');

-- Populate Teams Table
INSERT INTO Teams (TeamName)
VALUES 
('The Titans'),
('Warriors'),
('Eagle Squad'),
('Storm Chasers'),
('Thunderbolts'),
('Shadow Hunters'),
('Phoenix Force'),
('Blaze Runners'),
('Iron Wolves'),
('Silver Hawks');

-- Populate TeamMembers Table
INSERT INTO TeamMembers (TeamId, PersonId)
VALUES 
(1, 1), (1, 2),
(2, 3), (2, 4),
(3, 5), (3, 6),
(4, 7), (4, 8),
(5, 9), (5, 10),
(6, 1), (6, 3),
(7, 5), (7, 7),
(8, 9), (8, 2),
(9, 4), (9, 6),
(10, 8), (10, 10);

-- Populate Prizes Table
INSERT INTO Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
VALUES 
(1, 'First Place', 1000.00, 50.00),
(2, 'Second Place', 500.00, 30.00),
(3, 'Third Place', 250.00, 20.00);

-- Populate Tournaments Table
INSERT INTO Tournaments (TournamentName, EntryFee)
VALUES 
('Summer Showdown', 100.00),
('Winter Clash', 150.00);

-- Populate TournamentPrizes Table
INSERT INTO TournamentPrizes (TournamentId, PrizeId)
VALUES 
(1, 1), (1, 2), (1, 3),
(2, 1), (2, 2);

-- Populate TournamentEntries Table
INSERT INTO TournamentEntries (TournamentId, TeamId)
VALUES 
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5),
(2, 6), (2, 7), (2, 8), (2, 9), (2, 10);

-- Populate Matchups Table
INSERT INTO Matchups (WinnerId, MatchupRound)
VALUES 
(1, 1), (2, 1),
(3, 2), (4, 2),
(1, 3), (3, 3);

-- Populate MatchupEntries Table
INSERT INTO MatchupEntries (MatchupId, ParentMatchupId, TeamCompetingId, Score)
VALUES 
(1, NULL, 1, 30.0),
(1, NULL, 2, 20.0),
(2, NULL, 3, 25.0),
(2, NULL, 4, 15.0),
(3, 1, 1, 35.0),
(3, 2, 3, 28.0);
