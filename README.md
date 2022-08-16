# Topicos2

#PT-BR
1 - Para que você consiga utilizar o SQL Server integrado no visual studio é necesseario realizar alguns ajustes.
2 - Entre no projeto SQLDatabase.
3 - Clique no botão Edit.
4 - Clique em browse.
5 - Clique em Local.
6 - Selecione MSSQLLocalDB e clique em OK.
7 - No campo Database name digite o nome da sua data base.
8 - Clique no botão Save Profile As...
9 - Selecione a pasta PublishLocations, caso ela não esteja criada, crie uma e salve o arquivo dentre da pasta.
10 - Sempre que for feita alguma alteração no desing do banco, é necessario entrar no arquivo da pasta PublishLocations (pelo visual studio) e clicar em publish
para que as alterações sejam feitas.

// Apos isso abra a janela SQL Server Object Explorer, clique com o botão direito em sua database e selecione properties, em properties tem um campo
chamado Connection string, com ele você se conectará com esta database integrada.

// Uma segunda alternativa, caso você não queira utilizar esta database integrada, você simplesmente pode criar uma pelo SQL Server.


#EN-US
1 - In order to use SQL Server in visual studio, you need to make some adjustments.
2 - Go to SQLDatabase project.
3 - Select the Edit button.
4 - Select browse.
5 - Select MSSQLocalDB and select OK.
7 - In the Database name field, type your database name.
8 - Select Save Profile As... button.
9 - Select the PublishLocations folder, if there's none, create a new one and save the file in the folder.
10 - Everyime that you make a alteration in the SQLServer, you have to go in the PublishLocations folder (in visual studio) and select publish locations so
you can save the changes.

// After done all these steps, open the SQL Server Object Explorer Window, right-click your database and go to properties so you can find the connectionStrings
field when you need to connect to the database.

// A second alternative, if you don't want use SQL Server in visual studio, you can create a database in SQLServer Program too.
