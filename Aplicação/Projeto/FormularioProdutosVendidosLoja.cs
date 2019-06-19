using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormularioProdutosVendidosLoja : Form
    {
        private BookidsDBContainer bookidsContainer;
        public FormularioProdutosVendidosLoja()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }

        private void FormularioProdutosVendidosLoja_Load(object sender, EventArgs e)
        {
            carregaTodosProdutos();
            listBoxTipoProduto.DataSource = bookidsContainer.TipoProdutoSet.ToList<TipoProduto>();
        }

        private void FormularioProdutosVendidosLoja_Activated(object sender, EventArgs e)
        {
            carregaComboTiposProduto();
        }

        private void carregaComboTiposProduto()
        {
            cbTiposProduto.DataSource = bookidsContainer.TipoProdutoSet.ToList<TipoProduto>();
        }


        //  <----------- Tipo de Produto ----------->


        // Verificar se os campos estão todos preenchidos
        private bool dadosPreenchidosTipoProduto()
        {
            if (tbTipo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTipo.Focus();
                return false;
            }
            return true;
        }

        // Limpa os dados de todos os campos
        private void limparDadosTipoProduto()
        {
            tbTipo.Text = "";
        }

        // Adicionar um tipo de produto novo
        private void buttonAdicionarTipo_Click(object sender, EventArgs e)
        {

            try
            {
                if (dadosPreenchidosTipoProduto())
                {
                    TipoProduto novo = new TipoProduto()
                    {
                        Tipo = tbTipo.Text,
                    };

                    bookidsContainer.TipoProdutoSet.Add(novo);

                    bookidsContainer.SaveChanges();

                    listBoxTipoProduto.DataSource = bookidsContainer.TipoProdutoSet.ToList<TipoProduto>();
                    
                    MessageBox.Show("Tipo de Produto adicionado com sucesso!", "Informação", MessageBoxButtons.OK);

                    limparDadosTipoProduto();
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de que os dados introduzidos correspondem ao tipo de cada campo! (números/algarismos)", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonApagarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProduto tipoSel = (TipoProduto)listBoxTipoProduto.SelectedItem;
                if (tipoSel != null)
                {
                    if (MessageBox.Show("Esta operação puderá não ser possível pois, o Tipo de produto pode pode conter produtos associados. Se for o caso, terá de apagar esses produtos primeiro.\n\nMesmo assim quer tentar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bookidsContainer.TipoProdutoSet.Remove(tipoSel);

                        bookidsContainer.SaveChanges();

                        listBoxTipoProduto.DataSource = bookidsContainer.TipoProdutoSet.ToList<TipoProduto>();

                        MessageBox.Show("Tipo de Produto apagado com sucesso!", "Informação", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível apagar o Tipo de produto!", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Existem produtos associados a este tipo de produto!\n\nPara apagar este tipo de produto, terá que apagar primeiro os produtos.", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProduto tipoSelecionado = (TipoProduto)listBoxTipoProduto.SelectedItem;
                if (tipoSelecionado != null)
                {
                    if (dadosPreenchidosTipoProduto())
                    {
                        tipoSelecionado.Tipo = tbTipo.Text;

                        bookidsContainer.SaveChanges();

                        listBoxTipoProduto.DataSource = bookidsContainer.TipoProdutoSet.ToList<TipoProduto>();

                        MessageBox.Show("Dados do tipo de produto alterados com sucesso!", "Informação", MessageBoxButtons.OK);

                        limparDadosTipoProduto();

                        carregaTodosProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar o tipo de produto!", "Atenção", MessageBoxButtons.OK);
            }
        }



        //  <----------- Produto ----------->


        //o stock ainda nao atualiza sozinho
        //quando a uma compra do produto o stock tem que diminuir

        // Verificar se os campos estão todos preenchidos
        private bool dadosPreenchidoProduto()
        {
            if (tbDesignacao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbDesignacao.Focus();
                return false;
            }

            if (cbTiposProduto.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                cbTiposProduto.Focus();
                return false;
            }

            if (numericUpDownPreco.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownPreco.Focus();
                return false;
            }

            if (numericUpDownStock.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownStock.Focus();
                return false;
            }
            return true;
        }

        // Limpa os dados de todos os campos
        private void limparDadosProduto()
        {
            tbDesignacao.Text = "";
            cbTiposProduto.Text = "";
            numericUpDownPreco.Value = 0;
            numericUpDownStock.Value = 0;
        }

        // Carrega todos os produtos
        private void carregaTodosProdutos()
        {
            listViewProdutos.Items.Clear();
            foreach (Produtos c in bookidsContainer.ProdutosSet)
            {
                adicionaProduto(c);
            }
        }

        private void adicionaProduto(Produtos novo)
        {
            var row = new string[]
            {
                novo.Designacao,
                string.Format("{0}",novo.TipoProduto),
                string.Format("{0:C}",novo.Preco),
                string.Format("{0}",novo.StockExistente)
            };

            var lvi = new ListViewItem(row);
            lvi.Tag = novo;
            listViewProdutos.Items.Add(lvi);
        }

        // Adicionar um produto novo
        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dadosPreenchidoProduto())
                {
                    Produtos novo = new Produtos()
                    {
                        Designacao = tbDesignacao.Text,
                        CodTipoProduto = ((TipoProduto)cbTiposProduto.SelectedItem).CodTipoProduto,
                        Preco = (double)numericUpDownPreco.Value,
                        StockExistente = (int)numericUpDownStock.Value,
                    };

                    bookidsContainer.ProdutosSet.Add(novo);

                    bookidsContainer.SaveChanges();

                    adicionaProduto(novo);

                    MessageBox.Show("Produto adicionado com sucesso!", "Informação", MessageBoxButtons.OK);

                    limparDadosProduto();
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de que os dados introduzidos correspondem ao tipo de cada campo! (números/algarismos)", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Apagar o tipo de produto selecionado
        private void buttonApagarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtoSelecionado = (Produtos)listViewProdutos.SelectedItems[0].Tag;
                if (produtoSelecionado != null)
                {
                    bookidsContainer.ProdutosSet.Remove(produtoSelecionado);

                    bookidsContainer.SaveChanges();

                    carregaTodosProdutos();

                    MessageBox.Show("Produto apagado com sucesso!", "Informação", MessageBoxButtons.OK);

                    limparDadosProduto();
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o produto que pretende apagar!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonAlterarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtoSelecionado = (Produtos)listViewProdutos.SelectedItems[0].Tag;
                if (produtoSelecionado != null)
                {
                    produtoSelecionado.Designacao = tbDesignacao.Text;
                    produtoSelecionado.Preco = (double)numericUpDownPreco.Value;
                    produtoSelecionado.StockExistente = (int)numericUpDownStock.Value;
                    produtoSelecionado.CodTipoProduto = ((TipoProduto)cbTiposProduto.SelectedItem).CodTipoProduto;

                    bookidsContainer.SaveChanges();

                    carregaTodosProdutos();

                    MessageBox.Show("Dados do produto alterados com sucesso!", "Informação", MessageBoxButtons.OK);

                    limparDadosProduto();
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o produto para alterar os seus dados!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void listViewProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Produtos produtoSelecionado = (Produtos)listViewProdutos.SelectedItems[0].Tag;
                if (produtoSelecionado != null)
                {
                    tbDesignacao.Text = produtoSelecionado.Designacao;
                    cbTiposProduto.Text = produtoSelecionado.TipoProduto.Tipo;
                    numericUpDownPreco.Value = (Decimal)produtoSelecionado.Preco;
                    numericUpDownStock.Value = (Decimal)produtoSelecionado.StockExistente;
                }
            }
            catch
            {
            }
        }


        // <--------------- Menu --------------->

        private void tipoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosTipoProduto();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosProduto();
        }
    }
}
