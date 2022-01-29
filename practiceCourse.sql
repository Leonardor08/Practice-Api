Use Master 
drop database practiceCurse 
go

Create database practiceCurse
go

Use practiceCurse
go

create table students(
	idSt int primary key not null,
	stname varchar(20) not null,
	stnumber int not null, 
	stmail nvarchar(30) not null
);
go

create table courses(
	idCourse int primary key not null,
	Cname varchar (20) not null,
	Cdescription varchar (50) not null
);
go

create table addres(
	id int identity (1,1) primary key not null,
	Adescription nvarchar (50) not null
);
go

create table stcours(
	idstc int identity (1,1) primary key not null 
);
go

Alter table stcours add idSt int foreign key references students(idSt);
Alter table stcours add idCourse int foreign key references courses(idCourse);
Alter table addres add idSt int foreign key references students(idSt);
go