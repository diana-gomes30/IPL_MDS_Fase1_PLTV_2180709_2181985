
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/17/2019 22:01:23
-- Generated from EDMX file: C:\Users\Utilizador\Desktop\Projetos\CidaliaPinto2180709_DianaGomes2181985\Projeto\Projeto\BookidsDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BookidsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientesFilhos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Filhos] DROP CONSTRAINT [FK_ClientesFilhos];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhosInscricoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricoesSet] DROP CONSTRAINT [FK_FilhosInscricoes];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolasFilhos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Filhos] DROP CONSTRAINT [FK_EscolasFilhos];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolasParticipacoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacoesSet] DROP CONSTRAINT [FK_EscolasParticipacoes];
GO
IF OBJECT_ID(N'[dbo].[FK_EventosParticipacoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacoesSet] DROP CONSTRAINT [FK_EventosParticipacoes];
GO
IF OBJECT_ID(N'[dbo].[FK_EventosInscricoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricoesSet] DROP CONSTRAINT [FK_EventosInscricoes];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimadoresColaboracoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracoesSet] DROP CONSTRAINT [FK_AnimadoresColaboracoes];
GO
IF OBJECT_ID(N'[dbo].[FK_EventosColaboracoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracoesSet] DROP CONSTRAINT [FK_EventosColaboracoes];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientesCompras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComprasSet] DROP CONSTRAINT [FK_ClientesCompras];
GO
IF OBJECT_ID(N'[dbo].[FK_ComprasDetalheCompras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheComprasSet] DROP CONSTRAINT [FK_ComprasDetalheCompras];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutosDetalheCompras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheComprasSet] DROP CONSTRAINT [FK_ProdutosDetalheCompras];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProdutoProdutos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutosSet] DROP CONSTRAINT [FK_TipoProdutoProdutos];
GO
IF OBJECT_ID(N'[dbo].[FK_Clientes_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Clientes] DROP CONSTRAINT [FK_Clientes_inherits_Pessoas];
GO
IF OBJECT_ID(N'[dbo].[FK_Filhos_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Filhos] DROP CONSTRAINT [FK_Filhos_inherits_Pessoas];
GO
IF OBJECT_ID(N'[dbo].[FK_Animadores_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Animadores] DROP CONSTRAINT [FK_Animadores_inherits_Pessoas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PessoasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet];
GO
IF OBJECT_ID(N'[dbo].[InscricoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricoesSet];
GO
IF OBJECT_ID(N'[dbo].[EscolasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscolasSet];
GO
IF OBJECT_ID(N'[dbo].[ParticipacoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParticipacoesSet];
GO
IF OBJECT_ID(N'[dbo].[EventosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventosSet];
GO
IF OBJECT_ID(N'[dbo].[ColaboracoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ColaboracoesSet];
GO
IF OBJECT_ID(N'[dbo].[ComprasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComprasSet];
GO
IF OBJECT_ID(N'[dbo].[DetalheComprasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalheComprasSet];
GO
IF OBJECT_ID(N'[dbo].[ProdutosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutosSet];
GO
IF OBJECT_ID(N'[dbo].[TipoProdutoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProdutoSet];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Clientes];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Filhos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Filhos];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Animadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Animadores];
GO

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
    [Confirmada] bit  NOT NULL,
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
    [DataHora] datetime  NOT NULL,
    [LimiteParticipacao] int  NOT NULL,
    [IdadeInferior] int  NOT NULL,
    [IdadeSuperior] int  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
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
    [Data] datetime  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetalheComprasSet'
CREATE TABLE [dbo].[DetalheComprasSet] (
    [NrCompra] int  NOT NULL,
    [CodProduto] int  NOT NULL,
    [Quantidade] int  NOT NULL
);
GO

-- Creating table 'ProdutosSet'
CREATE TABLE [dbo].[ProdutosSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [StockExistente] int  NOT NULL,
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
    [ValorOferta] float  NOT NULL,
    [NrCartao] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Filhos'
CREATE TABLE [dbo].[PessoasSet_Filhos] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
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