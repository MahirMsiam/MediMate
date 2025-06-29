CREATE TABLE Admins (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL, -- For secure, hashed passwords
    FullName NVARCHAR(100),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Table for Patients
CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    Address NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Table for Pharmacists
CREATE TABLE Pharmacists (
    PharmacistID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    PharmacyName NVARCHAR(100),
    Address NVARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Table for Patient's medicine routine, linked to the Patients table
CREATE TABLE MedicineDoseRoutine (
    RoutineID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT NOT NULL,
    MedicineName VARCHAR(100),
    DosageTime VARCHAR(100),
    DurationDays INT,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE
);

-- Table for Pharmacist's medicine inventory, linked to the Pharmacists table
CREATE TABLE MedicineInventory (
    InventoryID INT PRIMARY KEY IDENTITY(1,1),
    PharmacistID INT NOT NULL,
    MedicineName VARCHAR(100),
    StockQuantity INT,
    ExpiryDate DATE,
    FOREIGN KEY (PharmacistID) REFERENCES Pharmacists(PharmacistID) ON DELETE CASCADE
);
