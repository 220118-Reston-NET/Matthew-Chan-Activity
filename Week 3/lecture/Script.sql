-- Data Definition Language--
--Creating/altering table structures in our DB

--Create statement to create poke table
create table Pokemon(
	pokeName varchar (50),
	pokeLevel int,
	pokeAttack int,
	pokeDefense int,
	pokeHealth int
)

--Alter statement to change existing tables
alter table Pokemon
--add alive bit
drop column alive

--Truncate statement

--Drop statement
drop table Pokemon

-- Data manipulation Language --
--Adding/removing/manipulating the data inside of talbe structures--

--Insert statement
insert into Pokemon
values('Pikachu', 1, 55, 12, 123),
      ('Bulbasaur', 10, 23, 23, 523)
      
--Select statement
select pokeName, pokeLevel from Pokemon

select * from Pokemon

--Update statement
update Pokemon set pokeHealth = 50
where pokeName = 'Bulbasaur'

update Pokemon set pokeHealth = 1
where pokeName = 'Pikachu'

--Delete statement
delete from Pokemon
where pokeName = 'Pikachu'

--Data Query Language ---

select pokeName, pokeLevel from Pokemon

select * from Pokemon

select pokeName, pokeLevel from Pokemon
where pokeName = 'Pikachu'

--Aliasing, basically renaming a column name---
select pokeName as Name, pokeLevel from Pokemon





--Restricts what datatpye can be put in a solumn

--Unique
--Data in this column cannot have replicating values
create table Pokemon(
	pokeName varchar(50) unique,
	pokeLevel int,
	pokeAttack int,
	pokeDefense int,
	pokeHealth int
)
--alter statement to add contraint
alter table Pokemon
add constraint pokeName_unique unique(pokeName)

--Remove contraint
alter table Pokemon
drop constraint pokeName_unique

--Not null
--Data in this column cannot be null

create table Pokemon(
	pokeName varchar(50) unique not null,
	pokeLevel int,
	pokeAttack int,
	pokeDefense int,
	pokeHealth int
)

--alter statement to add nto null (default)
alter table Pokemon
alter column pokeName varchar(50) not null

insert into Pokemon
values ('MissingNo',null,null,null,null)

--Default
--Will provide a default value in case a value was not provided

--Check
--Adds an extra condition on the data
--pokeLevel > 10

--Primary Key
--Data in this Column is both unique and not null
--Acts as a unique identifier for the row in a table


--Foreign Key
--Data in this column references another row from a different column
--Used mainly to estabilsh relationships between 2 tables

--Multiplicity--
--It is a way to describe the numerical relationship betwen 2 tables
--We will use primary keys and foreign keys to establish it

--one to one
--one row in table A is directly related to one row in table B and it goes both ways
create table person(
	SSN int primary key,
	personName varchar(50),
	personAge int
)

create table heart(
	heartId int primary key,
	heartSize int,
	healthy bit,
	personSSN int unique foreign key references person(SSN)
)

insert into person
values (1, 'Brandon',25)

insert into person
values (2, 'Terrance', 23)

insert into person
values (2, 'Vijhan', 21)

insert into heart
values (2,100,0,1)

insert into heart
values (2,100,1,2)

select * from person p from person p
inner join heart h on p.SSN = h.psersonSSN
where person.SSN = 1

--One to Many
--One row in Table A is related to multiple rows in Table B
create table finger(
	fingerId int primary key,
	fingerLength int
)

alter table finger
add personSSN int foreign key references person(SSN)

insert into finger
values (1, 10, 1),
	(2, 5, 1),
	(3, 3, 1)
	
select * from person p
inner join finger f on p.SSN = f.personSSN

--Many to Many
--Many rows in Table A has many rows in Table B

Create table Moves(
	mvId int primary key,
	mvName varchar(50),
	mvPP int,
	mvPower int,
	mvAccuracy int,
)
--many to many does not have a foreign key

select * from Pokemon p

alter table Pokemon
alter column pokeId int not null

alter table Pokemon
add constraint pokeId_primary primary key(pokeId)

create table pokemons_moves(
	mvId int foreign key references Moves(mvId)
	pokeId int foreign key references Pokemon(pokeId)
)
--Insertingv alues to Ability table
insert into Moves
values(1, 'Tackle', 40, 50, 80)
values(2, 'Thunderbolt', 50, 100, 70)

--insertingv values in the
values(1,1) --mvId of 2 is thunderbolt, and pokeId of 3 is pikachu so that means pikachu will have the  
	(1,3) -- ab Id of 1 is tackle and pokeId of 1 is Bulbasaur so that means bulbasaur will have tackle
	(2,3) -- mvId of 1 is tackle and poekId of 3 is pikachu is Pikachu so that means pikachu will have tackle as

--creating select join statements of many to many relationships requires a tlaets2  inner jonis
	--selectinga  starting point (not the join talbe itself) and go from there
	--in thi scsa , i started wit habliti yand jointed join table and then joined the pokemon talbe last

select m.mvName, p.pokeName from Moves m 
inner join moves_pokemons mp on m.mvId  = mp.mvId 
inner join Pokemon p on p.pokeId = mp.pokeId

--Normalizatino---
--It is desing pattern that redcuse/eliminates data redundancy/data duplication
--Must have Referential Integreity and atomic data 
	--referential integrity jutsm eans a foreign key will always point to an existing primary key
	--atomic data jus tmeans the data in yorut able is at its smallest FOR 
	--0NF - Zero Normal Formm --No normalization
	
--1NF - First Normal Form 
--Every table mus htave a primary key
--Must have Atomic data

--2NF - Second Normal Form
--you must be in 1NF 
--Remove any partai dependencies
	-- just don't do coposite primary keys 

--3NF - Third Normal Form 
--You must be in the 2NF 
--Remove any transitive dependencies(make sure every column on table is related to primary key)
	-- Make sure every Column on talbe is actulaly related 
--Ex: Pokemon talbe shouldn't have ability name, power point, accrucay but ability table should be 