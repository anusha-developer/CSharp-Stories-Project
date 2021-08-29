Create  database Stories;
Create table Tbl_Student(
Id int Identity Primary key,
FirstName varchar(100),
LastName varchar(100),
EmailId  Varchar(150),
Branch varchar(50),
Phoneno BigInt,
S_Address  Varchar(200),
Dob date
);
 insert into Tbl_Student values('Anusha','Anu','Anu@gmail.com','CSE',8387874334,
                                'Karimnagar','1998-1-03');
insert into Tbl_Student values('Fruity','Sanvi','Sanvi@gmail.com','EEE',9574874334,
                                'Hyderabad','2008-5-08');
insert into Tbl_Student values('Binnu','varshith','varshith@gmail.com','ECE',7843874334,
                                'Husnabad','2006-8-01');

select * from  Tbl_Student;
