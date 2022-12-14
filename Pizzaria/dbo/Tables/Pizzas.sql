CREATE TABLE [dbo].[Pizzas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdTipo] INT NOT NULL,
    [Nome] NVARCHAR(50) NOT NULL, 
    [Descricao] NVARCHAR(1000) NULL, 
    [Valor] DECIMAL(18, 2) NOT NULL, 
    [Ativo] BIT NOT NULL, 
    CONSTRAINT [FK_Pizzas_ToTable] FOREIGN KEY (IdTipo) REFERENCES Tipos(Id), 

)
