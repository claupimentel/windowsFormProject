# windowsFormProject
Projeto para iniciar o desenvolvimento de C# com interface gráfica

## Para este projeto eu criei o seguinte banco de dados:

* Criação do banco de dados
`CREATE DATABASE db_agenda;`

* Seleciona o banco para uso
`USE db_agenda;`

* Cria tabela
`CREATE TABLE contato (
    id        INT AUTO_INCREMENT,
    nome      VARCHAR(150) NOT NULL,
    email     VARCHAR(150),
    telefone  VARCHAR(20),
    PRIMARY KEY (id)
);`
