create database dbPetView
GO

use dbPetView
GO

-- TABELAS

create table tbEndereco(
cep char(8) not null,
numero int not null,
rua varchar(50) not null,
bairro varchar(50) not null,
complemento varchar(20),
cidade varchar(50) not null,
uf char(2) not null,
constraint PK_tbEndereco primary key clustered (cep, numero)
);
GO

create table tbFuncionario(
cod_funcionario int identity(1,1) constraint PK_tbFuncionario primary key,
nome_func varchar(70) not null,
cpf_func char(11) not null,
rg_func char(9) not null,
status_func char(8) not null constraint DF_tbFuncionario_status default 'Ativo', -- ativo ou demitido
tel_func char(10),
cel_func char(11),
email_func varchar(100),
cargo_func varchar(30) not null,
salario_func money not null,
cep_func char(8) not null,
numcasa_func int not null,
constraint FK_tbFuncionario_tbEndereco foreign key(cep_func, numcasa_func) references tbEndereco(cep,numero),
constraint CK_tbFuncionario_salario check(salario_func >= 0.00)
);
GO

create table tbMedico(
cod_medico int identity(1,1) constraint PK_tbMedico primary key,
crmv int not null,
nome_med char(70) not null,
funcao_med varchar(30) not null,
cpf_med char(11) not null,
rg_med char(9) not null,
cel_med char(11) not null,
tel_med char(10),
email_med varchar(100) not null,
salario_med money not null,
status_med char(8) not null constraint DF_tbMedico_status default 'Ativo', -- ativo ou demitido
cep_med char(8) not null,
numcasa_med int not null,
constraint FK_tbMedico_tbEndereco foreign key(cep_med, numcasa_med) references tbEndereco(cep,numero),
constraint CK_tbMedico_salario check(salario_med >= 0.00)
);
GO

create table tbUsuario (
cod_usuario int identity(1,1) constraint PK_tbUsuario primary key,
nome_usuario varchar(25) not null,
ativacao_usuario bit not null constraint DF_tbUsuario_ativo default 0,
data_cadastro datetime not null constraint DF_tbUsuario_data default getdate(),
nome_login varchar(25) not null,
senha_login varchar(20) not null,
cod_funcionario int not null,
cod_medico int not null,
constraint FK_tbUsuario_tbFuncionario foreign key(cod_funcionario) references tbFuncionario(cod_funcionario),
constraint FK_tbUsuario_tbMedico foreign key(cod_medico) references tbMedico(cod_medico)
);
GO

create table tbDono(
cod_dono int identity(1,1) constraint PK_tbDono primary key,
nome_dono varchar(70) not null,
cpf_dono char(11) not null,
rg_dono char(9) not null,
cel_dono char(11) not null,
tel_dono char(10),
email_dono varchar(100) not null,
cep_dono char(8) not null,
numcasa_dono int not null,
constraint FK_tbDono_tbEndereco foreign key(cep_dono, numcasa_dono) references tbEndereco(cep,numero)
);
GO

create table tbAnimal(
cod_animal int identity(1,1) constraint PK_tbAnimal primary key,
rga int,
cod_dono int not null,
nome_animal varchar(30) not null,
idade int not null,
raca_animal varchar(30) not null,
especie varchar(30) not null,
descricao varchar(100) not null,
constraint FK_tbAnimal_tbDono foreign key(cod_dono) references tbDono(cod_dono)
);
GO

create table tbConsulta(
cod_consulta int identity(1,1) constraint PK_tbConsulta primary key,
cod_animal int not null,
cod_medico int not null,
sintomas varchar(300) not null,
diagnostico varchar(300) not null,
custo_consulta money not null,
tipo_consulta varchar(15) not null,
data_consulta datetime constraint DF_tbConsulta_data default getdate(),
constraint FK_tbConsulta_tbAnimal foreign key(cod_animal) references tbAnimal(cod_animal),
constraint FK_tbConsulta_tbMedico foreign key(cod_medico) references tbMedico(cod_medico)
);
GO

create table tbTratamento(
cod_tratamento int identity(1,1) constraint PK_tbTratamento primary key,
cod_animal int not null,
cod_medico int not null,
cod_consulta int not null,
tipo_tratamento varchar(30) not null,
observacao_tratamento varchar(150) not null,
custo_tratamento money not null,
constraint FK_tbTratamento_tbAnimal foreign key(cod_animal) references tbAnimal(cod_animal),
constraint FK_tbTratamento_tbMedico foreign key(cod_medico) references tbMedico(cod_medico),
constraint FK_tbTratamento_tbConsulta foreign key(cod_consulta) references tbConsulta(cod_consulta)
);
GO

create table tbExame(
cod_exame int identity(1,1) constraint PK_tbTratamento primary key,
cod_animal int not null,
cod_medico int not null,
cod_consulta int not null,
tipo_exame varchar(30) not null,
observacao_exame varchar(150) not null,
custo_exame money not null,
data_exame datetime constraint DF_tbExame_data default getdate(),
constraint FK_tbExame_tbAnimal foreign key(cod_animal) references tbAnimal(cod_animal),
constraint FK_tbExame_tbMedico foreign key(cod_medico) references tbMedico(cod_medico),
constraint FK_tbExame_tbConsulta foreign key(cod_consulta) references tbConsulta(cod_consulta)
);
GO

-- PROCEDURES

-- MÉDICO

create proc sp_insert_medico(
@cep char(8),
@numero int,
@rua varchar(50),
@bairro varchar(50),
@complemento varchar(20),
@cidade varchar(50),	
@uf char(2),
@crmv int,
@nome_med char(70),
@funcao_med varchar(30),
@cpf_med char(11),
@rg_med char(9),
@cel_med char(11),
@tel_med char(10),
@email_med varchar(100),
@salario_med money
) 
as 
	begin
		if(@tel_med = '') set @tel_med = null;
		if(@complemento = '')set @complemento = 'Sem complemento';

		insert into tbEndereco (cep, numero, rua, bairro, complemento, cidade, uf)
				values (@cep, @numero, @rua, @bairro, @complemento, @cidade, @uf);
		insert into tbMedico(crmv, nome_med, funcao_med, cpf_med, rg_med, cel_med, tel_med, salario_med, cep_med, numcasa_med)
				values(@crmv, @nome_med, @funcao_med, @cpf_med, @rg_med, @cel_med, @tel_med, @salario_med, @cep, @numero);
	end
 GO

create proc sp_delete_medico(
@cod_medico int
)as
begin
    update tbMedico set status_med = 'Demitido' where cod_medico = @cod_medico;
	--delete from tbUsuario where cod_usuario = @cod_medico;
end
GO

create proc sp_update_medico(
@cod_medico int,
@cep char(8),
@numero int,
@rua varchar(50),
@bairro varchar(50),
@complemento varchar(20),
@cidade varchar(50),	
@uf char(2),
@crmv int,
@nome_med char(70),
@funcao_med varchar(30),
@cpf_med char(11),
@rg_med char(9),
@cel_med char(10),
@tel_med char(10),
@email_med varchar(100),
@status_med char(8),
@salario_med money
)as
begin
	update tbEndereco
	set cep = @cep, numero = @numero, rua = @rua, bairro = @bairro, complemento = @complemento, cidade = @cidade, uf = @uf
	where cep = (select cep from tbEndereco inner join tbMedico on tbMedico.cep_med = tbEndereco.cep where tbMedico.cod_medico = @cod_medico) and numero = (select numero from tbEndereco inner join tbMedico on tbMedico.numcasa_med = tbEndereco.numero where tbMedico.cod_medico = @cod_medico);
	update tbMedico
	set crmv = @crmv, nome_med = @nome_med, funcao_med = @funcao_med, cpf_med = @cpf_med, rg_med = @rg_med, cel_med = @cel_med, tel_med = @tel_med, email_med = @email_med, status_med = @status_med, salario_med = @salario_med, cep_med = @cep, numcasa_med = @numero
	where cod_medico = @cod_medico;
end
GO

create proc sp_select_medico(
@cod_medico int,
@crmv int,
@nome_med char(70),
@funcao_med varchar(30),
@cpf_med char(11),
@rg_med char(9),
@cel_med char(10),
@tel_med char(10),
@email_med  varchar(100),
@status_med char(8),
@salario_med money 
)
as
begin
select M.cod_medico [ID], M.crmv [CRMV], M.nome_med [Nome], M.funcao_med [Função], M.cpf_med [CPF], M.rg_med [RG], M.cel_med [Celular], M.tel_med [Telefone], M.email_med [Email], M.status_med [Status], M.salario_med [Salário], E.cep [CEP], E.rua [Rua], E.numero [Número], E.complemento [Complemento], E.bairro [Bairro], E.cidade [Cidade], E.uf [UF] from tbMedico M
inner join tbEndereco E on M.cep_med = E.cep and M.numcasa_med = E.numero
where M.cod_medico = @cod_medico or M.crmv = @crmv or M.nome_med = @nome_med or M.funcao_med = @funcao_med or M.cpf_med = @cpf_med or M.rg_med = @rg_med or M.cel_med = @cel_med or M.tel_med = @tel_med or M.email_med = @email_med or M.status_med = @status_med or M.salario_med = @salario_med;
end
GO

-- FUNCIONÁRIO

create proc sp_insert_func(
@cep char(8),
@numero int,
@rua varchar(50),
@bairro varchar(50),
@complemento varchar(20),
@cidade varchar(50),	
@uf char(2),
@nome_func varchar(70),
@cpf_func char(11),
@rg_func char(9),
@status_func char(8),
@tel_func char(10),
@cel_func char(11),
@email_func varchar(100),
@cargo_func varchar(30),
@salario_func money
) 
as 
	begin
		if(@tel_func = '') set @tel_func = null;
		if(@complemento = '')set @complemento = 'Sem complemento';

		insert into tbEndereco (cep, numero, rua, bairro, complemento, cidade, uf)
				values (@cep, @numero, @rua, @bairro, @complemento, @cidade, @uf);
		insert into tbFuncionario(nome_func, cpf_func, rg_func, status_func, tel_func, cel_func, email_func, cargo_func, salario_func, cep_func, numcasa_func)
			values(@nome_func, @cpf_func, @rg_func, @status_func, @tel_func, @cel_func, @email_func, @cargo_func, @salario_func, @cep, @numero)
	end
 GO

create proc sp_delete_func(
@cod_func int
)as
begin
    update tbFuncionario set status_func = 'Demitido' where cod_funcionario = @cod_func;
	--delete from tbUsuario where cod_usuario = @cod_medico;
end
GO

create proc sp_update_func(
@cod_funcionario int,
@cep char(8),
@numero int,
@rua varchar(50),
@bairro varchar(50),
@complemento varchar(20),
@cidade varchar(50),	
@uf char(2),
@nome_func varchar(70),
@cpf_func char(11),
@rg_func char(9),
@status_func char(8),
@tel_func char(10),
@cel_func char(11),
@email_func varchar(100),
@cargo_func varchar(30),
@salario_func money
)as
begin
	update tbEndereco
	set cep = @cep, numero = @numero, rua = @rua, bairro = @bairro, complemento = @complemento, cidade = @cidade, uf = @uf
	where cep = (select cep from tbEndereco inner join tbFuncionario on tbFuncionario.cep_func = tbEndereco.cep where tbFuncionario.cod_funcionario = @cod_funcionario) and numero = (select numero from tbEndereco inner join tbFuncionario on tbFuncionario.numcasa_func = tbEndereco.numero where tbFuncionario.cod_funcionario = @cod_funcionario);
	update tbFuncionario
	set nome_func = @nome_func, cpf_func = @cpf_func, rg_func = @rg_func, status_func = @status_func, tel_func = @tel_func, cel_func = @cel_func, email_func = @email_func, cargo_func = @cargo_func, salario_func = @salario_func, cep_func = @cep, numcasa_func = @numero
	where cod_funcionario = @cod_funcionario;
end
GO

create proc sp_select_func(
@cod_funcionario int,
@nome_func varchar(70),
@cpf_func char(11),
@rg_func char(9),
@status_func char(8),
@tel_func char(10),
@cel_func char(11),
@email_func varchar(100),
@cargo_func varchar(30),
@salario_func money
)
as
begin
	select F.cod_funcionario [ID], F.nome_func [Nome], F.cargo_func [Cargo], F.cpf_func [CPF], F.rg_func [RG], F.cel_func [Celular], F.tel_func [Telefone], F.salario_func [Salário], E.cep [CEP], E.rua [Rua], E.numero [Número], E.complemento [Complemento], E.bairro [Bairro], E.cidade [Cidade], E.uf [UF] from tbFuncionario F
	inner join tbEndereco E on F.cep_func = E.cep and F.numcasa_func = E.numero
	where F.cod_funcionario = @cod_funcionario or F.nome_func = @nome_func or F.cargo_func = @cargo_func or F.cpf_func = @cpf_func or F.rg_func = @rg_func or F.cel_func = @cel_func or F.tel_func = @tel_func or F.email_func = @email_func or F.salario_func = @salario_func;
end
GO

-- DONO

create proc sp_insert_dono(
@cep char(8),
@numero int,
@rua varchar(50),
@bairro varchar(50),
@complemento varchar(20),
@cidade varchar(50),	
@uf char(2),
@nome_dono varchar(70),
@cpf_dono char(11),
@rg_dono char(9),
@tel_dono char(10),
@cel_dono char(11),
@email_dono varchar(100)
) 
as 
	begin
		if(@tel_dono = '') set @tel_dono = null;
		if(@complemento = '')set @complemento = 'Sem complemento';

		insert into tbEndereco (cep, numero, rua, bairro, complemento, cidade, uf)
				values (@cep, @numero, @rua, @bairro, @complemento, @cidade, @uf);
		insert into tbDono (nome_dono, cpf_dono, rg_dono, tel_dono, cel_dono, email_dono, cep_dono, numcasa_dono)
			values(@nome_dono, @cpf_dono, @rg_dono, @tel_dono, @cel_dono, @email_dono, @cep, @numero)
	end
 GO

create proc sp_update_dono(
@cod_dono int,
@cep char(8),
@numero int,
@rua varchar(50),
@bairro varchar(50),
@complemento varchar(20),
@cidade varchar(50),	
@uf char(2),
@nome_dono varchar(70),
@cpf_dono char(11),
@rg_dono char(9),
@tel_dono char(10),
@cel_dono char(11),
@email_dono varchar(100)
)as
begin
	update tbEndereco
	set cep = @cep, numero = @numero, rua = @rua, bairro = @bairro, complemento = @complemento, cidade = @cidade, uf = @uf
	where cep = (select cep from tbEndereco inner join tbDono on tbDono.cep_dono = tbEndereco.cep where tbDono.cod_dono = @cod_dono) and numero = (select numero from tbEndereco inner join tbDono on tbDono.numcasa_dono = tbEndereco.numero where tbDono.cod_dono = @cod_dono);
	update tbDono
	set nome_dono = @nome_dono, cpf_dono = @cpf_dono, rg_dono = @rg_dono, tel_dono = @tel_dono, cel_dono = @cel_dono, email_dono = @email_dono, cep_dono = @cep, numcasa_dono = @numero
	where cod_dono = @cod_dono;
end
GO

create proc sp_select_dono(
@cod_dono int,
@nome_dono varchar(70),
@cpf_dono char(11),
@rg_dono char(9),
@tel_dono char(10),
@cel_dono char(11),
@email_dono varchar(100)
)
as
begin
	select D.cod_dono [ID], D.nome_dono [Nome], D.cpf_dono [CPF], D.rg_dono [RG], D.cel_dono [Celular], D.tel_dono [Telefone], E.cep [CEP], E.rua [Rua], E.numero [Número], E.complemento [Complemento], E.bairro [Bairro], E.cidade [Cidade], E.uf [UF] from tbDono D
	inner join tbEndereco E on D.cep_dono = E.cep and D.numcasa_dono = E.numero
	where D.cod_dono = @cod_dono or D.nome_dono = @nome_dono or D.cpf_dono = @cpf_dono or D.rg_dono = @rg_dono or D.cel_dono = @cel_dono or D.tel_dono = @tel_dono or D.email_dono = @email_dono;
end
GO

-- ANIMAL

create proc sp_insert_animal(
@rga int,
@cod_dono int,
@nome_animal varchar(70),
@idade int,
@raca_animal varchar(30),
@especie varchar(30),
@descricao varchar(100)
) 
as 
	begin
		insert into tbAnimal (rga, cod_dono, nome_animal, idade, raca_animal, especie, descricao)
			values(@rga, @cod_dono, @nome_animal, @idade, @raca_animal, @especie, @descricao)
	end
 GO

create proc sp_update_animal(
@cod_animal int,
@rga int,
@nome_animal varchar(70),
@idade int,
@raca_animal varchar(30),
@especie varchar(30),
@descricao varchar(100)
)as
begin
	update tbAnimal
	set rga = @rga, nome_animal = @nome_animal, idade = @idade, raca_animal = @raca_animal, especie = @especie, descricao = @descricao
	where cod_animal = @cod_animal;
end
GO

create proc sp_select_animal(
@cod_animal int,
@rga int,
@nome_dono varchar(70),
@nome_animal varchar(70),
@idade int,
@raca_animal varchar(30),
@especie varchar(30),
@descricao varchar(100)
)
as
begin
	select A.cod_animal [ID], A.rga [RGA], A.nome_animal [Nome], A.idade [Idade], A.raca_animal [Raça], A.especie [Espécie], A.descricao [Descrição], D.nome_dono [Dono], D.cel_dono [Celular], D.tel_dono [Telefone] from tbAnimal A
	inner join tbDono D on A.cod_dono = D.cod_dono
	where A.cod_animal = @cod_animal or A.nome_animal = @nome_animal or A.cod_dono = (select nome_dono from tbDono inner join tbAnimal on tbAnimal.cod_dono = tbDono.cod_dono where D.nome_dono = @nome_dono) or A.idade = @idade or A.raca_animal = @raca_animal or A.especie = @especie or A.descricao = @descricao;
end
GO

-- CONSULTA

-- Quando for cadastrar coloca 2 combo box, ai seleciona o dono e na segunda mostra os animais desse dono, então vai selecionar o código certo do animal
create proc sp_insert_consulta(
@cod_animal int,
@cod_medico int,
@sintomas varchar(300),
@diagnostico varchar(300),
@custo_consulta money,
@tipo_consulta varchar(15),
@data_consulta datetime
) 
as 
	begin
		insert into tbConsulta (cod_animal, cod_medico, sintomas, diagnostico, custo_consulta, tipo_consulta, data_consulta)
			values(@cod_animal, @cod_medico, @sintomas, @diagnostico, @custo_consulta, @tipo_consulta, @data_consulta)
	end
 GO

create proc sp_select_consulta(
@cod_animal int,
@nome_animal varchar(70),
@cod_medico int,
@nome_medico varchar(70),
@nome_dono varchar(70),
@custo_consulta money,
@tipo_consulta varchar(15),
@data_consulta datetime
)
as
begin
	select M.nome_med [Médico], A.nome_animal [Nome], D.nome_dono [Dono], C.data_consulta [Data], C.tipo_consulta [Tipo], C.sintomas [Sintomas], C.diagnostico [Diagnóstico], C.custo_consulta [Custo] from tbConsulta C
	inner join tbAnimal A on A.cod_animal = C.cod_animal
	inner join tbMedico M on M.cod_medico = C.cod_medico
	inner join tbDono D on D.cod_dono = A.cod_dono
	where A.cod_animal = @cod_animal or D.nome_dono = (select D.nome_dono from tbDono /*não tenho certeza se funciona*/ where D.nome_dono = @nome_dono) or A.nome_animal = (select A.nome_animal from tbAnimal where A.nome_animal = @nome_animal);
	-- PRECISO TER CERTEZA DO QUE TA ACONTECENDO AQUI
end
GO