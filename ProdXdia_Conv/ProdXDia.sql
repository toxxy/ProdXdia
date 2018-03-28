use ProdXdia;
create table prodxdia
(
Item_ID int primary key not null,
Work_Order varchar(50) not null,
Serie_De_Papel varchar(50) not null,
MSF_Inicial float,
MSF_Consumido float not null,
Tamano_Bolsa varchar(50) not null,
Nombre_Bolsa varchar(50) not null,
Bag_Style varchar(50) not null,
Packing_Group varchar(50) not null,
REP_Del_Modelo float not null,
Num_Tarima int not null,
Num_Rollo varchar(50) not null,
Cantidad int not null,
Contador int not null,
Bolsas_Buenas int not null,
Varianza_Acumulada float not null,
Varianza_Rollo float,
Scrap int not null,
)