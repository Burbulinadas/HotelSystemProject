CREATE DATABASE HotelDB
ON
(
	NAME = 'HotelDB',
	FILENAME = 'D:\SQLDataBases\HotelDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogHotelDB',				 
	FILENAME = 'D:\SQLDataBases\HotelDB.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS

CREATE TABLE Customers                 
(                                     
	CustomerNo int IDENTITY PRIMARY KEY NOT NULL,  
	CustomerName varchar(20) NOT NULL,
	CustomerSurname varchar(20) NOT NULL,
	CustomerMiddleName varchar(20) NOT NULL,
	DateOfBirth date NOT NULL,
	VIP bit NOT NULL, -- 2 options: "1" for VIP status, "0" for no VIP status  
	Gender bit NOT NULL, -- 2 options: "1" for MALE, "0" for FEMALE  
	Address1 varchar(25) NOT NULL,
	Address2 varchar(25) NULL,
	City varchar(15) NOT NULL,
	[Region] char(2) NOT NULL,
	Country varchar(25) NOT NULL,
	PostalCode varchar(10) NOT NULL,
	CustomerIDType bit NOT NULL, -- 2 options: "1" for passport, "0" for driving license
	CustomerIDNo varchar(25) NOT NULL,	
	Phone char(20) UNIQUE NOT NULL,
	Email  varchar(40) UNIQUE NOT NULL,
	PreferedLang varchar(10) NULL,
	DateInSystem smalldatetime NOT NULL 
)
GO

CREATE TABLE GuestCard
(
	GuestCardNo int IDENTITY PRIMARY KEY FOREIGN KEY REFERENCES Customers(CustomerNo) NOT NULL,
	TravelAgency varchar(10) NULL,
	CheckInDateTime datetime NOT NULL,
	CheckOutDateTime datetime NOT NULL,
	[RoomNo] smallint FOREIGN KEY REFERENCES [HouseKeeping]([RoomNo]) NOT NULL,
	SpecialRequirements varchar(100) NULL
)
GO

CREATE TABLE Payments
(
	PaymentsCard int IDENTITY FOREIGN KEY REFERENCES GuestCard(GuestCardNo) NOT NULL,
	RoomPrice smallmoney NOT NULL,
	DiscountCash smallmoney NULL,
	DiscountPercens tinyint NULL,
	Paid smallmoney NUll
)
GO

CREATE TABLE [HouseKeeping]
(
	[RoomNo] smallint PRIMARY KEY NOT NULL,
	RoomStatus char(3) NOT NULL,
	StopSaleBegin datetime NULL,
	StopSaleEnd datetime NULL,
	StopSaleNote varchar(100) NULL
)
GO

--The most commonly
--used room status codes are Occupied, Vacant, Dirty, Clean, Ready, and
--Out of Order.
--State of Occupancy
-- Occupied—applies to a room that has been assigned to a guest and
--that guest has checked in
-- Vacant—the guest has checked out of the room
-- Ready—room is available for new occupancy
--State of Cleanliness
-- Dirty—room has not been cleaned by housekeeping
-- Clean—room has been cleaned but not yet verified as clean

--Room Status Codes
--Status Code                                        Meaning
--Vacant/Ready                               Available for sale. A “V/R” room status is the only
--                                                   status a room can be sold in.
--Vacant/Clean                               Cleaned room, not yet inspected. All sleeping
--                                                  rooms are cleaned by a housekeeper and then
--                                                   inspected by a supervisor or manager to ensure it
--                                                  is ready for sale. These inspectors then change the
--                                                   code from “V/C” to “V/R.”
--Vacant/Maintenance                     A “V/M” room has been taken out of inventory for
--                                                  some reason. This is the code assigned to out-oforder
--                                                  rooms.
--Vacant/Dirty                                 Guest checked out, not serviced by housekeeping
--                                                   yet. “V/D” codes take top priority in housekeeping,
--                                                  as they must be readied for resale.
--Occupied/Dirty                               Guest currently occupies the room, the night has
--                                                  passed, but room has not yet been serviced by
--                                                  housekeeping.
--Occupied/Clean                          Guest currently occupies the room, and room has
--                                                 been serviced by housekeeping. Typically, there is
--                                                 no inspection for rooms cleaned during the length
--                                                of an individual guest’s stay. The expectation is that
--                                                 all rooms are cleaned well, but an occupied room is
--                                                  generally easier to clean than one from which the
--                                                 guest has checked out.