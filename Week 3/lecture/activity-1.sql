create table Salesman(	
	id int primary key not null,
	salesName varchar(50),
	salesPNumber varchar(12)
)


create table Routes(
	uniqueRouteNumber  int primary key not null,
	route varchar(50),
	--uniqueOrderNumber int foreign key references Salesman(id)
)

create table Supplies(
	uniqueSupplyNumber int primary key not null,	
	products varchar(50),
	--supplyToSalesmanNumber int foreign key references Salesman(id)
)

create table Salesman_Routes(
	uniqueRouteNumber int foreign key references Routes(uniqueRouteNumber),
	id int foreign key references Salesman(id)
)

create table Salesman_Orders(
	uniqueSupplyNumber  int foreign key references Supplies(uniqueSupplyNumber),
	id int foreign key references Salesman(id)
)

insert into Salesman 
values(1, 'Bob the Builder', '510-BUI-LDIT'),
      (2, 'Fred Belotte', '415-HEY-FRED'),
      (3, 'Nick Enscalada', '888-GET-COMFI'),
      (4, 'Pushpinder Kaur', '213-TRA-INER'),
      (5, 'Mark "Less is" Moore', '635-SLI-DES!'),
      (6, 'Jacob Davis', '415-SEA-HAWK'),
      (7, 'Marielle The Martian','510-FLY-MARS')

insert into Routes 
values(1,'SFO'),
	(2,'LAX'),
    (3,'DFW'),
    (4,'IAH'),
    (5,'SAT'),
    (6,'DAL'),
    (7,'AUS'),
    (8,'TPA'),
    (9,'SEA'),
    (10,'STL'),
    (11,'OAK'),
    (12, 'MNL')

INSERT INTO Salesman_Routes 
values (1,1),
	(1,7),
	(2,1),
	(3,2),
	(3,4),
	(3,5),
	(4,2),
	(4,3),
	(4,6),
	(5,2),
	(6,3),
	(6,4),
	(6,7),
	(7,3),
	(8,4),
	(9,6),
	(10,6),
	(11,7),
	(12,7)
		

insert into Supplies
values(1,'hammer'),
	(2,'nails'),
	(3,'screws'),
	(4,'pizza'),
	(5,'coffee'),
	(6,'espresso'),
	(7,'latte'),
	(8,'cookies'),
	(9,'cakes'),
	(10,'books'),
	(11,'tea'),
	(12,'hot chocolate')

INSERT INTO Salesman_Orders 
values (1,1),
	(2,1),
	(3,1),
	(4,2),
	(5,3),
	(5,6),
	(5,7),
	(6,3),
	(7,3),
	(8,4),
	(9,4),
	(10,5),
	(11,7),
	(12,7)
	



SELECT r.route as Routes 
FROM Salesman s 
INNER JOIN Salesman_Routes sr ON s.id  = sr.uniqueRouteNumber 
INNER JOIN Routes r ON sr.uniqueRouteNumber  = r.route  	
where s.salesName  = 'Marielle The Martian'





DROP Routes 
DROP Supplies 
DROP Salesman 