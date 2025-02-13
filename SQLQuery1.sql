create table logins(
email varchar(50),
senha varchar(15)
);

select * from logins;

insert into logins values 
('lucas@gmail.com', '123456'),
('wendel@gmailcom', '123456'),
('maria@gmail.com', '123456'),
('ana@gmailcom', '123456');

truncate table logins;