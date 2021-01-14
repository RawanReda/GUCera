use GUCera;
insert into Promocode ( code , isuueDate , expiryDate , discount , adminId ) values ( '123' , '2020-12-12' , '2020-12-30' , 22.22,27);
insert into Promocode ( code , isuueDate , expiryDate , discount , adminId ) values ( '456' , '2020-12-12' , '2020-12-30' , 22.22,27);
insert into Promocode ( code , isuueDate , expiryDate , discount , adminId ) values ( '678' , '12-12-2027' , '2020-12-30' , 22.22,27);


insert into StudentHasPromocode(sid, code) values(14, '123');
insert into StudentHasPromocode(sid, code) values(14, '456');