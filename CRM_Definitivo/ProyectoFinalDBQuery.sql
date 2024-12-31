CREATE DATABASE SistemaProyectosDB;

USE SistemaProyectosDB
GO

CREATE TABLE Users 
(
    idUser INT PRIMARY KEY identity(1,1),
	UserAccount VARCHAR(255),
    nameuser VARCHAR(50),
    lastName VARCHAR(50),
    birthdate DATE,
    numberPhone VARCHAR(15),
    passworduser VARCHAR(100),
    country VARCHAR(50),
    city VARCHAR(50),
    statususer VARCHAR(20),
	idRol int

	CONSTRAINT Fk_Roles  FOREIGN KEY(idRol) REFERENCES roles(idRol)
);

CREATE TABLE Admins (
    idAdmin INT PRIMARY KEY identity(1,1),
    idUser INT,
    FOREIGN KEY (idUser) REFERENCES Users(idUser)
);

CREATE TABLE Clients (
    idCliente INT PRIMARY KEY identity(1,1),
    idUser INT,
    FOREIGN KEY (idUser) REFERENCES Users(idUser) ON DELETE SET NULL
);

CREATE TABLE employee (
    idEmployee INT PRIMARY KEY identity(1,1),
    idUser INT,
    comment VARCHAR(255),
    workStation VARCHAR(50),
	FOREIGN KEY (idUser) REFERENCES Users(idUser) ON DELETE SET NULL
);

CREATE TABLE statusProject (
    idStatusProyect INT PRIMARY KEY identity(1,1),
    statusproyect VARCHAR(50)
);


/* NUEVAS TABLAS */
CREATE TABLE RequestProjectClient
(
	idProject INT PRIMARY KEY IDENTITY(1,1),
	idClient INT,
	codeProject NVARCHAR(6) NOT NULL,
	nameProject NVARCHAR(200) NOT NULL,
	descriptionProject NVARCHAR(200) NOT NULL,
	[file] VARBINARY(MAX),
	idStatusProject INT,
	idRefused INT,
	dateInit DATE,
	dateEnd DATE,
	dateRegistration DATETIME DEFAULT GETDATE()

	FOREIGN KEY (idStatusProject) REFERENCES statusProyect(idStatusProyect),
	FOREIGN KEY (idClient) REFERENCES Clients(idCliente),
	FOREIGN KEY (idRefused) REFERENCES RefusedProject(idRefused)
)


CREATE TABLE RefusedProject
(
	idRefused INT PRIMARY KEY IDENTITY(1,1),
	idProject INT,
	reason NVARCHAR(50) NOT NULL,
	reasonForRejection NVARCHAR(500) NOT NULL

)

DROP TABLE taskProjects
CREATE TABLE taskProjects (
    idTask INT PRIMARY KEY identity(1,1),
	codeProject NVARCHAR(6),
    nameTask VARCHAR(100),
    descriptionTask VARCHAR(255),
    idEmployee INT,
	idStatusTask INT,
	dateEnd DATE,
	fileTask VARBINARY(MAX)
    FOREIGN KEY (idEmployee) REFERENCES employee(idEmployee),
	FOREIGN KEY (idStatusTask) REFERENCES taskEmployeesStatus(idStatusTask)
);


/* Consulta para proyecto de cliente */
SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusproyect, r.dateInit, r.dateEnd, rf.reason, rf.reasonForRejection, r.dateRegistration FROM RequestProjectClient r
LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
LEFT JOIN Clients c on c.idCliente = r.idClient
LEFT JOIN Users u on u.idUser = c.idUser
LEFT JOIN statusProyect st on st.idStatusProyect = r.idStatusProject


/* Consulta para tareas de proyectos */
SELECT tp.idTask, tp.codeProject, TP.idEmployee , u.UserAccount, tp.nameTask, tp.descriptionTask, se.statusTask, tp.dateEnd FROM taskProjects tp
LEFT JOIN employee e on e.idEmployee = tp.idEmployee
LEFT JOIN Users u on u.idUser = e.idEmployee
INNER JOIN taskEmployeesStatus se on se.idStatusTask = tp.idStatusTask

/* Consulta para proyectos rechazados */
SELECT p.codeProject, rp.reason, rp.reasonForRejection, sp.statusproyect FROM RefusedProject rp
LEFT JOIN RequestProjectClient p on p.idProject = rp.idProject
LEFT JOIN statusProyect sp on sp.idStatusProyect = p.idStatusProject

/* Consulta para seleccionar tareas relacionadas al codigo de un proyecto solicitiado */
SELECT t.idEmployee, t.nameTask, t.descriptionTask, t.idStatusTask , te.statusTask FROM taskProjects t
INNER JOIN taskEmployeesStatus te ON te.idStatusTask = t.idStatusTask
INNER JOIN employee e ON e.idEmployee = t.idEmployee
WHERE t.codeProject = 'U24590'




CREATE TABLE roles (
    idRol INT PRIMARY KEY identity(1,1),
    Rol VARCHAR(50),
);

CREATE TABLE permission (
    idPermission INT PRIMARY KEY identity(1,1),
    idMenu INT,
    FOREIGN KEY (idMenu) REFERENCES menu(idMenu)
);

CREATE TABLE rolPermission (
    idRolPermission INT PRIMARY KEY identity(1,1),
    idRoles INT,
    idPermission INT,
    FOREIGN KEY (idRoles) REFERENCES roles(idRoles),
    FOREIGN KEY (idPermission) REFERENCES permission(idPermission)
);

CREATE TABLE menu (
    idMenu INT PRIMARY KEY identity(1,1),
    name VARCHAR(50),
    nameForm VARCHAR(50)
);



CREATE TRIGGER InsertRoleInSpecificTable
ON Users
AFTER INSERT
AS
BEGIN
    DECLARE @idUser INT;
    DECLARE @idRol INT;
    DECLARE @adminRoleId INT;
    DECLARE @clientRoleId INT;
    DECLARE @employeeRoleId INT;

    SELECT @adminRoleId = idRol FROM roles WHERE Rol = 'Admin';
    SELECT @clientRoleId = idRol FROM roles WHERE Rol = 'Cliente';
    SELECT @employeeRoleId = idRol FROM roles WHERE Rol = 'Empleado';

    DECLARE user_cursor CURSOR FOR SELECT idUser, idRol FROM inserted;
    OPEN user_cursor;
    FETCH NEXT FROM user_cursor INTO @idUser, @idRol;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        IF @idRol = @adminRoleId
        BEGIN
            INSERT INTO Admins (idUser) VALUES (@idUser);
        END
        ELSE IF @idRol = @clientRoleId
        BEGIN
            INSERT INTO Clients (idUser) VALUES (@idUser);
        END
        ELSE IF @idRol = @employeeRoleId
        BEGIN
            INSERT INTO Employee (idUser) VALUES (@idUser);
        END

        FETCH NEXT FROM user_cursor INTO @idUser, @idRol;
    END;

    CLOSE user_cursor;
    DEALLOCATE user_cursor;
END;


CREATE TRIGGER UpdateRoleInSpecificTable
ON Users
AFTER UPDATE
AS
BEGIN
    DECLARE @idUser INT;
    DECLARE @oldRoleId INT;
    DECLARE @newRoleId INT;
    DECLARE @adminRoleId INT;
    DECLARE @clientRoleId INT;
    DECLARE @employeeRoleId INT;

    SELECT @adminRoleId = idRol FROM roles WHERE Rol = 'Admin';
    SELECT @clientRoleId = idRol FROM roles WHERE Rol = 'Cliente';
    SELECT @employeeRoleId = idRol FROM roles WHERE Rol = 'Empleado';

    DECLARE user_cursor CURSOR FOR 
        SELECT idUser, idRol FROM inserted;
    OPEN user_cursor;
    FETCH NEXT FROM user_cursor INTO @idUser, @newRoleId;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @oldRoleId = idRol FROM deleted WHERE idUser = @idUser;

        IF @oldRoleId != @newRoleId
        BEGIN
            IF @oldRoleId = @adminRoleId
            BEGIN
                DELETE FROM Admins WHERE idUser = @idUser;
            END
            ELSE IF @oldRoleId = @clientRoleId
            BEGIN
                DELETE FROM Clients WHERE idUser = @idUser;
            END
            ELSE IF @oldRoleId = @employeeRoleId
            BEGIN
                DELETE FROM Employee WHERE idUser = @idUser;
            END

            IF @newRoleId = @adminRoleId
            BEGIN
                INSERT INTO Admins (idUser) VALUES (@idUser);
            END
            ELSE IF @newRoleId = @clientRoleId
            BEGIN
                INSERT INTO Clients (idUser) VALUES (@idUser);
            END
            ELSE IF @newRoleId = @employeeRoleId
            BEGIN
                INSERT INTO Employee (idUser) VALUES (@idUser);
            END
        END

        FETCH NEXT FROM user_cursor INTO @idUser, @newRoleId;
    END;

    CLOSE user_cursor;
    DEALLOCATE user_cursor;
END;


	






