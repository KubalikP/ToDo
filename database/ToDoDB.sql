create database todo;
use todo;

create table users (
    id int primary key auto_increment,
    username varchar(50) unique not null,
    password varchar(255) not null
);

create table tasks (
    id int primary key auto_increment,
    user_id int,
    foreign key (user_id) references users(id),
    taskName varchar(100),
    start_date date,
    end_date date,
    end_time datetime,
    completed boolean default false
);

insert into users (username, password) values ('user', 'password');
create user 'user'@'%' identified by 'password';
grant select, insert, update on todo.users to 'user'@'%';
grant select, insert, update, delete on todo.tasks to 'user'@'%';
flush privileges;