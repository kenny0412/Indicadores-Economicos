use IndicadoresEconomicos;

CREATE TABLE SUBSCRIPTION(
idUser int identity(1,1) primary key  not null,
fullname	nvarchar(50) not null,
identificationCard nvarchar(50) not null,
age	int	not null,
email nvarchar(50) not null,
profesion nvarchar(50) not null,
idProvince	int not null,
canton	nvarchar(50) not null,
district nvarchar(50) not null
);

CREATE TABLE PROVINCE (
idProvince int identity(1,1) primary key not null,
province nvarchar(50)
);

-- Foreign keys
ALTER TABLE SUBSCRIPTION ADD CONSTRAINT FK_SUBSCRIPTION_PROVINCE  FOREIGN KEY(idProvince) references PROVINCE(idProvince);
-- Inserts

-- Table province
insert into PROVINCE values('San José');
insert into PROVINCE values('Alajuela');
insert into PROVINCE values('Limón');
insert into PROVINCE values('Puntarenas');
insert into PROVINCE values('Heredia');
insert into PROVINCE values('Cartago');
insert into PROVINCE values('Guanacaste');


CREATE TABLE QUESTION(
idQuestion int identity(1,1) primary key not null,
author nvarchar(100) not null,
startdate date not null,
content text not null
);

CREATE TABLE ANSWER (
idAnswer int identity(1,1) primary key not null,
author nvarchar(100) not null,
startdate date not null,
content nvarchar not null,
idQuestion int not null
);

ALTER TABLE ANSWER ADD CONSTRAINT  FK_USER_DIRECTION FOREIGN KEY (idQuestion) references QUESTION(idQuestion);