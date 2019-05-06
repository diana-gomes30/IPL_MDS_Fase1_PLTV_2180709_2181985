
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2019 11:07:35
-- Generated from EDMX file: C:\Users\Utilizador\Desktop\Projetos\Projeto\Projeto\BookidsDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MinhaLojaBookidsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoasSet'
CREATE TABLE [dbo].[PessoasSet] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InscricoesSet'
CREATE TABLE [dbo].[InscricoesSet] (
    [Confirmada] nvarchar(max)  NOT NULL,
    [IdFilho] int  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'EscolasSet'
CREATE TABLE [dbo].[EscolasSet] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParticipacoesSet'
CREATE TABLE [dbo].[ParticipacoesSet] (
    [IdEscola] int  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'EventosSet'
CREATE TABLE [dbo].[EventosSet] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] nvarchar(max)  NOT NULL,
    [LimiteParticipacao] nvarchar(max)  NOT NULL,
    [IdadeInferior] nvarchar(max)  NOT NULL,
    [IdadeSuperior] nvarchar(max)  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL,
    [ColaboracoesId] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ColaboracoesSet'
CREATE TABLE [dbo].[ColaboracoesSet] (
    [IdAnimador] int  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'ComprasSet'
CREATE TABLE [dbo].[ComprasSet] (
    [NrCompra] int IDENTITY(1,1) NOT NULL,
    [IdCliente] int  NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetalheComprasSet'
CREATE TABLE [dbo].[DetalheComprasSet] (
    [NrCompra] int  NOT NULL,
    [CodProduto] int  NOT NULL,
    [Quantidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProdutosSet'
CREATE TABLE [dbo].[ProdutosSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] nvarchar(max)  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL,
    [CodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'TipoProdutoSet'
CREATE TABLE [dbo].[TipoProdutoSet] (
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoasSet_Clientes'
CREATE TABLE [dbo].[PessoasSet_Clientes] (
    [ValorOferta] nvarchar(max)  NOT NULL,
    [NrCartao] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Filhos'
CREATE TABLE [dbo].[PessoasSet_Filhos] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [IdProgenitor] int  NOT NULL,
    [IdEscola] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Animadores'
CREATE TABLE [dbo].[PessoasSet_Animadores] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'PessoasSet'
ALTER TABLE [dbo].[PessoasSet]
ADD CONSTRAINT [PK_PessoasSet]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdFilho], [NrEvento] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [PK_InscricoesSet]
    PRIMARY KEY CLUSTERED ([IdFilho], [NrEvento] ASC);
GO

-- Creating primary key on [IdEscola] in table 'EscolasSet'
ALTER TABLE [dbo].[EscolasSet]
ADD CONSTRAINT [PK_EscolasSet]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [IdEscola], [NrEvento] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [PK_ParticipacoesSet]
    PRIMARY KEY CLUSTERED ([IdEscola], [NrEvento] ASC);
GO

-- Creating primary key on [NrEvento] in table 'EventosSet'
ALTER TABLE [dbo].[EventosSet]
ADD CONSTRAINT [PK_EventosSet]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [IdAnimador], [NrEvento] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [PK_ColaboracoesSet]
    PRIMARY KEY CLUSTERED ([IdAnimador], [NrEvento] ASC);
GO

-- Creating primary key on [NrCompra] in table 'ComprasSet'
ALTER TABLE [dbo].[ComprasSet]
ADD CONSTRAINT [PK_ComprasSet]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [CodProduto], [NrCompra] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [PK_DetalheComprasSet]
    PRIMARY KEY CLUSTERED ([CodProduto], [NrCompra] ASC);
GO

-- Creating primary key on [CodProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [PK_ProdutosSet]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutoSet'
ALTER TABLE [dbo].[TipoProdutoSet]
ADD CONSTRAINT [PK_TipoProdutoSet]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Clientes'
ALTER TABLE [dbo].[PessoasSet_Clientes]
ADD CONSTRAINT [PK_PessoasSet_Clientes]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [PK_PessoasSet_Filhos]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Animadores'
ALTER TABLE [dbo].[PessoasSet_Animadores]
ADD CONSTRAINT [PK_PessoasSet_Animadores]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdProgenitor] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_ClientesFilhos]
    FOREIGN KEY ([IdProgenitor])
    REFERENCES [dbo].[PessoasSet_Clientes]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesFilhos'
CREATE INDEX [IX_FK_ClientesFilhos]
ON [dbo].[PessoasSet_Filhos]
    ([IdProgenitor]);
GO

-- Creating foreign key on [IdFilho] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [FK_FilhosInscricoes]
    FOREIGN KEY ([IdFilho])
    REFERENCES [dbo].[PessoasSet_Filhos]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEscola] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_EscolasFilhos]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolasSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolasFilhos'
CREATE INDEX [IX_FK_EscolasFilhos]
ON [dbo].[PessoasSet_Filhos]
    ([IdEscola]);
GO

-- Creating foreign key on [IdEscola] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [FK_EscolasParticipacoes]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolasSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [FK_EventosParticipacoes]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventosParticipacoes'
CREATE INDEX [IX_FK_EventosParticipacoes]
ON [dbo].[ParticipacoesSet]
    ([NrEvento]);
GO

-- Creating foreign key on [NrEvento] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [FK_EventosInscricoes]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventosInscricoes'
CREATE INDEX [IX_FK_EventosInscricoes]
ON [dbo].[InscricoesSet]
    ([NrEvento]);
GO

-- Creating foreign key on [IdAnimador] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [FK_AnimadoresColaboracoes]
    FOREIGN KEY ([IdAnimador])
    REFERENCES [dbo].[PessoasSet_Animadores]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [FK_EventosColaboracoes]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventosColaboracoes'
CREATE INDEX [IX_FK_EventosColaboracoes]
ON [dbo].[ColaboracoesSet]
    ([NrEvento]);
GO

-- Creating foreign key on [IdCliente] in table 'ComprasSet'
ALTER TABLE [dbo].[ComprasSet]
ADD CONSTRAINT [FK_ClientesCompras]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[PessoasSet_Clientes]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesCompras'
CREATE INDEX [IX_FK_ClientesCompras]
ON [dbo].[ComprasSet]
    ([IdCliente]);
GO

-- Creating foreign key on [NrCompra] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [FK_ComprasDetalheCompras]
    FOREIGN KEY ([NrCompra])
    REFERENCES [dbo].[ComprasSet]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComprasDetalheCompras'
CREATE INDEX [IX_FK_ComprasDetalheCompras]
ON [dbo].[DetalheComprasSet]
    ([NrCompra]);
GO

-- Creating foreign key on [CodProduto] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [FK_ProdutosDetalheCompras]
    FOREIGN KEY ([CodProduto])
    REFERENCES [dbo].[ProdutosSet]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CodTipoProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [FK_TipoProdutoProdutos]
    FOREIGN KEY ([CodTipoProduto])
    REFERENCES [dbo].[TipoProdutoSet]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProdutoProdutos'
CREATE INDEX [IX_FK_TipoProdutoProdutos]
ON [dbo].[ProdutosSet]
    ([CodTipoProduto]);
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Clientes'
ALTER TABLE [dbo].[PessoasSet_Clientes]
ADD CONSTRAINT [FK_Clientes_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_Filhos_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Animadores'
ALTER TABLE [dbo].[PessoasSet_Animadores]
ADD CONSTRAINT [FK_Animadores_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------