use MGP;
go
insert into dbo.Users
values
('Peter', '447878869', '44787852'),
('Vasiliy', '65487456', '44788746'),
('Jason', '74874875', '216457889'),
('Maria', '456824235', '24123577');
go
select * from dbo.Users;

insert into dbo.SessionMedievalBattles
values
(1),
(0);
go
select * from dbo.SessionMedievalBattles;
go
insert into dbo.UsersSessionsMedievalBattle(UserId, SessionMedievalBattleId)
values
(1, 1),
(2, 1),
(3, 2),
(4, 2);
go
select * from dbo.UsersSessionsMedievalBattle;
