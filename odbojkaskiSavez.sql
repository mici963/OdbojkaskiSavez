CREATE TABLE korisnici (
    korisnikid INT PRIMARY KEY IDENTITY,
    email NVARCHAR(100) NOT NULL UNIQUE,
    sifra NVARCHAR(255) NOT NULL,
    ime NVARCHAR(50),
    prezime NVARCHAR(50),
    uloga INT NOT NULL
);
CREATE TABLE timovi (
    timid INT PRIMARY KEY IDENTITY,
    nazivtima NVARCHAR(100) NOT NULL
);
CREATE TABLE igraci (
    igracid INT PRIMARY KEY IDENTITY,
    korisnikid INT UNIQUE,
    timid INT,
    pozicija NVARCHAR(50),

    FOREIGN KEY (korisnikid) REFERENCES korisnici(korisnikid),
    FOREIGN KEY (timid) REFERENCES timovi(timid)
);
CREATE TABLE treneri (
    trenerid INT PRIMARY KEY IDENTITY,
    korisnikid INT UNIQUE,
    timid INT,

    FOREIGN KEY (korisnikid) REFERENCES korisnici(korisnikid),
    FOREIGN KEY (timid) REFERENCES timovi(timid)
);
CREATE TABLE sudije (
    sudijaid INT PRIMARY KEY IDENTITY,
    korisnikid INT UNIQUE,

    FOREIGN KEY (korisnikid) REFERENCES korisnici(korisnikid)
);
CREATE TABLE utakmice (
    utakmicaid INT PRIMARY KEY IDENTITY,

    domacitimid INT,
    gostujucitimid INT,

    datum DATE,
    vreme TIME,

    lokacija NVARCHAR(200),

    sudijaid INT,

    FOREIGN KEY (domacitimid) REFERENCES timovi(timid),
    FOREIGN KEY (gostujucitimid) REFERENCES timovi(timid),
    FOREIGN KEY (sudijaid) REFERENCES sudije(sudijaid)
);