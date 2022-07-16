drop table if exists dbo.todos
go
create table dbo.todos
(
	id varchar(100) not null,
	title varchar(1000) not null,
	completed bit,
	constraint pk_todos primary key(id)
)
