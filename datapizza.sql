create table public.tbl_Customer(c_id serial primary key,
								name varchar(30),
								f_name varchar(30),
								phone_no bigint,
								email varchar(40))							
create table public.tbl_Product(p_id serial primary key,
							   name varchar(30),
							   unti_price decimal(18,3),
							   pt_id int)
							   
alter table public.tbl_Product add constraint pt_id foreign key(pt_id) references public.tbl_Product_type(pt_id)

create table public.tbl_Product_type(pt_id serial primary key,
									name varchar(30))
									
create table public.tbl_take_order(o_id serial primary key,
								  c_id int,
								  p_id int,
								  quantity int,
								  date date,
								  amount decimal(18,3),
								  total_amount decimal(18,3))

alter table public.tbl_take_order add constraint c_id foreign key(c_id) references public.tbl_Customer(c_id)
alter table public.tbl_take_order add constraint p_id foreign key(p_id) references public.tbl_Product(p_id)

create table public.tbl_payment(pa_id serial primary key,
							   o_id int,
							   date date,
							   total amount decimal(18,3))
alter table public.tbl_payment add constraint o_id foreign key(o_id) references public.tbl_take_order(o_id)