--DROP TABLE Abilities
--DROP TABLE Aerial
--DROP TABLE Attack
--DROP TABLE AttackFramePicture
--DROP TABLE Attributes
--DROP TABLE Fighter
--DROP TABLE Grab
--DROP TABLE Move
--DROP TABLE Roll
--DROP Table Special
--DROP TABLE Throw

CREATE TABLE Attributes (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Weight FLOAT NOT NULL,
	WeightRank INT NOT NULL,
	RunSpeed FLOAT NOT NULL,
	RunSpeedRank INT NOT NULL,
	WalkSpeed FLOAT NOT NULL,
	WalkSpeedRank INT NOT NULL,
	AirSpeed FLOAT NOT NULL,
	AirSpeedRank INT NOT NULL,
	FallSpeed FLOAT NOT NULL,
	FallSpeedRank INT NOT NULL,
	FastFallSpeed FLOAT NOT NULL,
	FastFallSpeedRank INT NOT NULL,
	MaximumJumps INT NOT NULL,
	WallJump BIT NOT NULL,
	WallCling BIT NOT NULL,
	Crawl BIT NOT NULL,
	Tether BIT NOT NULL
)

CREATE TABLE AttackFramePicture (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Url VARCHAR(100) NOT NULL
)

CREATE TABLE Move (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Name VARCHAR(75) NOT NULL,
	AttackFramePictureId INT FOREIGN KEY REFERENCES AttackFramePicture(Id) NOT NULL,
)

CREATE TABLE Attack (
	Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Move(Id),
	HitboxActiveRange VARCHAR(50) NOT NULL,
	FirstActionableFrame INT NOT NULL,
	BaseDamage INT NOT NULL,
	Angle INT NOT NULL,
	BaseKnockBack INT NOT NULL,
	KnockBackGrowth INT NOT NULL,
)

CREATE TABLE Grab (
	Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Move(Id),
	HitboxActiveRange VARCHAR(50) NOT NULL,
	FirstActionableFrame INT NOT NULL
)

CREATE TABLE Throw (
	Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Move(Id),
	BaseDamage INT NOT NULL,
	Angle INT NOT NULL,
	BaseKnockBack INT NOT NULL,
	KnockBackGrowth INT NOT NULL
)

CREATE TABLE Roll (
	Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Move(Id),
	Intangibility INT NOT NULL,
	FirstActionableFrame INT NOT NULL
)

CREATE TABLE Aerial (
	Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Move(Id),
	HitboxActiveRange VARCHAR(50) NOT NULL,
	FirstActionableFrame INT NOT NULL,
	BaseDamage INT NOT NULL,
	Angle INT NOT NULL,
	BaseKnockBack INT NOT NULL,
	KnockBackGrowth INT NOT NULL,
	LandingLag INT NOT NULL,
	AutoCancelFrames VARCHAR(50) NOT NULL
)

CREATE Table Special (
	Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Attack(Id),
)

CREATE TABLE Abilities (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	AttackId INT FOREIGN KEY REFERENCES Attack(Id),
	GrabId INT FOREIGN KEY REFERENCES Grab(Id),
	ThrowId INT FOREIGN KEY REFERENCES Throw(Id),
	RollId INT FOREIGN KEY REFERENCES Roll(Id),
)

CREATE TABLE Fighter (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	PortraitPictureUrl VARCHAR(50) NOT NULL,
	AttributesId INT FOREIGN KEY REFERENCES Attributes(Id),
	AbilitiesId INT FOREIGN KEY REFERENCES Abilities(Id),
)

-- NESS
INSERT INTO Attributes 
VALUES (94, 33, 1.46265, 45, 0.8635, 51, 0.9588, 41, 1.31, 48, 2.096, 48, 2, 0, 0, 0, 0)		

INSERT INTO AttackFramePicture
VALUES ('None')

INSERT INTO Move 
VALUES('Jab 1', 2)

INSERT INTO Attack
VALUES('3-4', 20, 2, 361, 8, 50)

--Id INT IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY REFERENCES Move(Id),
--	HitboxActiveRange VARCHAR(50) NOT NULL,
--	FirstActionableFrame INT NOT NULL,
--	BaseDamage INT NOT NULL,
--	Angle INT NOT NULL,
--	BaseKnockBack INT NOT NULL,
--	KnockBackGrowth INT NOT NULL,
--	LandingLag INT NOT NULL,
--	AutoCancelFrames VARCHAR(50) 

UPDATE Move
SET Name = 'Jab 2'
WHERE Id = 2

SELECT * FROM Move
SELECT * FROM Attack

SELECT M.ID, M.Name, M.AttackFramePictureId, A.HitboxActiveRange, A.FirstActionableFrame, A.BaseDamage, A.Angle, A.BaseKnockBack, A.KnockBackGrowth
FROM Move AS M
JOIN ATTACK AS A ON M.AttackFramePictureId = A.Id