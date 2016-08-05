Use MicaDiy ;
INSERT INTO Customer
(CUS_CODE, CUS_LNAME, CUS_FNAME, CUS_INITIAL,CUS_AREACODE, CUS_PHONE, CUS_BALANCE)
VALUES

        (10010, 'Ramas', 'Alfred', 'A', 615, '844-2537', 0.00), 
		(10011, 'Dunne', 'Leona', 'K', 713, '894-1238', 0.00), 
		(10012, 'Smith', 'Kathy', 'W', 615, '894-2285', 345.88),
		(10013, 'Olowski', 'Paul', 'F', 615, '894-2180', 536.75),
		(10014, 'Orlando', 'Myron', '', 615, '222-1672', 0.00),
		(10015, 'O Brian', 'Amy', 'B', 713, '442-3381', 0.00),
		(10016, 'Brown', 'James', 'G', 615, '297-1228', 221.19),
		(10017, 'Williams', 'George', '', 615, '290-2556', 0.00),
		(10018, 'Farriss', 'Anne', 'G', 713, '382-7185', 216.55),
		(10019, 'Smith', 'Olette', 'K', 615, '297-3809', 0.00);

INSERT INTO Invoice
( INV_NUMBER, CUS_CODE, INV_DATE)
VALUES

		(1001, 10014, '1999-08-18'),
		(1002, 10011, '1999-08-18'),
		(1003, 10012, '1999-08-18'),
		(1004, 10011, '1999-08-19'),
		(01005, 10018, '1999-08-19'),
		(1006, 10014, '1999-08-19'),
		(1007, 10015, '1999-08-19'),
		(1008, 10011, '1999-08-19');

INSERT INTO Vendor
(V_CODE,V_NAME,V_CONTACT,V_AREACODE,V_PHONE,V_STATE,V_ORDER)
VALUES

		(21225, 'Bryson, Inc.', 'Smithson', 615, '223-3234', 'TN', 'Y'),
		(21226, 'SuperLoo, Inc.', 'Flushing', 615, '223-3234', 'TN', 'Y'),
		(21231, 'D&E Supply', 'Singh', 615, '223-3234', 'TN', 'Y'),
		(21344, 'Gomez Bros', 'Ortega', 615, '223-3234', 'TN', 'Y'),
		(22567, 'Dome Supply', 'Smith', 615, '223-3234', 'TN', 'Y'),
		(23119, 'Randsets Ltd.', ' ', 615, '223-3234', 'TN', 'Y'),
		(24004, 'Brackman Bros', 'Smithson', 615, '223-3234', 'TN', 'Y'),
		(24228, 'ORDVA, Inc.', 'Smithson', 615, '223-3234', 'TN', 'Y'),
		(25443, 'B&K, Inc.', 'Smithson', 615, '223-3234', 'TN', 'Y'),
		(25501, 'Damal Supplies', 'Smithson', 615, '223-3234', 'TN', 'Y'),
		(25595, 'Rubicon Sis.', 'Smithson', 615, '223-3234', 'TN', 'Y');

INSERT INTO Product
( P_CODE, P_DESCRIPT, P_INDATE, P_ONHAND,P_MIN,P_PRICE,P_DISCOUNT,V_CODE)
VALUES

	('11QER/31', 'Power painter, 15 psi, 3-nozzle', '1999-06-02', 8, 5, 109.99, 0.00, 21225),
	('13-Q2/P2', '7.25-in. pwr. Saw blade', '1999-07-12', 32, 15, 14.99, 0.05, 21226),
	('14-Q1/L3', '9.00-in. pwr. Saw blade', '1999-06-12', 18, 12, 17.49, 0.00, 21231),
	('1546-QQ2', 'Hrd. Cloth, ¼-in., 2x50', '1999-08-14', 15, 8, 39.95, 0.00, 21344),
	('1558-QW1', 'Hrd. Cloth, ½-in., 3x50', '1999-08-14', 23, 5, 43.99, 0.00, 22567),
	('2232/QTY', 'B&D jigsaw, 12-in. blade', '1999-07-29', 8, 5, 109.92, 0.05, 23119),
	('2232/QWE', 'B&D jigsaw, 8-in. blade', '1999-07-23', 6, 5, 99.87, 0.05, 24004),
	('2238/QPD', 'B&D cordless drill, ½-in.', '1999-08-19', 12, 5, 38.95, 0.05, 24004),
	('23109-HB', 'Claw hammer', '1999-08-19', 23, 10, 9.95, 0.10, 24004);

INSERT INTO LINE
( INV_NUMBER, LINE_NUMBER, P_CODE, LINE_UNITS , LINE_PRICE)
VALUES



	(1001, 1, '13-Q2/P2', 1, 14.99),
    (1001, 2, '13-Q2/P2', 1, 9.95),
	(1002, 1, '13-Q2/P2', 2, 4.99),
	(1003, 1, '13-Q2/P2', 1, 38.95),
	(1003,	2,	'1546-QQ2',	1,	$39.95),
(1003,	3,	'13-Q2/P2',	5,	$14.99),
(1004,	2,	'23109-HB',	2,	$9.95),
(1005,	1,	'PVC23DRT',	12,	$5.87),
(1006,	1,	'SM-18277',	3,	$6.99),
(1006,	2,	'2232/QTY',	1,	$109.92),
(1006,	3,	'23109-HB',	1,	$9.95),
(1006,	4,	'89-WRE-Q',	1,	$256.99),
(1007,	1,	'13-Q2/P2',	2,	$14.99),
(1007,	2,	'54778-2T',	1,	$4.99),
(1008,	1,	'PVC23DRT',	5,	$5.87),
(1008,	2,	'WR3/TT3',	3,	$119.95),
(1008,	3,	'23109-HB',	1,	$9.95);
