create table learningactivities (
	idlearningactivities BIGSERIAL NOT NULL PRIMARY KEY,
	idteacher SMALLINT REFERENCES teacher (idteacher),
	idsubject SMALLINT REFERENCES subject (idsubject),
	idclass SMALLINT REFERENCES class (idclass)
);
insert into learningactivities (idteacher, idsubject, idclass) values (1, 1, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (1, 2, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (1, 3, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (1, 4, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (1, 5, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (2, 1, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (2, 2, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (2, 3, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (2, 4, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (2, 5, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (3, 1, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (3, 2, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (3, 3, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (3, 4, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (3, 5, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (4, 1, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (4, 2, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (4, 3, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (4, 4, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (4, 5, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (5, 5, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (6, 6, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (7, 7, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (8, 8, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (9, 9, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (10, 10, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (11, 11, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 1);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 2);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 3);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 4);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (12, 9, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (13, 1, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (14, 3, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (15, 4, 11);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 5);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 6);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 7);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 8);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 9);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 10);
insert into learningactivities (idteacher, idsubject, idclass) values (16, 5, 11);