using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto
{
    
    public partial class FormularioVendaProdutos : Form
    {
        private BookidsDBContainer bookidsContainer;
        public FormularioVendaProdutos()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }

        private void FormularioVendaProdutos_Load(object sender, EventArgs e)
        {
        }

        private void FormularioVendaProdutos_Activated(object sender, EventArgs e)
        {
            carregaComboClientes();
            carregaComboProdutos();
        }

        private void carregaComboClientes()
        {
            cbCliente.DataSource = bookidsContainer.ClientesSet.ToList<Clientes>();
        }

        private void carregaComboProdutos()
        {
            cbProduto.DataSource = bookidsContainer.ProdutosSet.ToList<Produtos>();
        }

        private void buttonMaisCliente_Click(object sender, EventArgs e)
        {
            FormularioClientesFilhos formClientesFilhos = new FormularioClientesFilhos();
            formClientesFilhos.ShowDialog();
        }

        private void buttonMaisProdutos_Click(object sender, EventArgs e)
        {
            FormularioProdutosVendidosLoja formProdutosVendidosLoja = new FormularioProdutosVendidosLoja();
            formProdutosVendidosLoja.ShowDialog();
        }

        // Verificação dos dados preenchidos
        private bool dadosPreenchidosCompra()
        {
            if (radioButtonS.Checked == false && radioButtonN.Checked == false)
            {
                MessageBox.Show("Selecione se o cliente usou cartão ou não!", "Atenção", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
                
        // Para adicionar uma compra
        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)cbCliente.SelectedItem;
                if (clienteSelecionado != null && dadosPreenchidosCompra())
                {
                    Compras nova = new Compras()
                    {
                        IdCliente = clienteSelecionado.IdPessoa,
                        Data = DateTime.Now,
                        UtilizouCartao = radioButtonS.Checked ? radioButtonS.Text : radioButtonN.Text
                    };

                    bookidsContainer.ComprasSet.Add(nova);
                    bookidsContainer.SaveChanges();

                    carregaCompras(clienteSelecionado);

                    MessageBox.Show("Compra adicionada com sucesso!", "Informação", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar o cliente para adicionar uma compra", "Informação", MessageBoxButtons.OK);
            }
        }

        // Carrega a lista de compras de um cliente
        private void carregaCompras(Clientes clienteSelecionado)
        {
            listBoxCompra.DataSource = clienteSelecionado.Compras.ToList<Compras>();
        }

        // Carrega a lista de compras do cliente selecionado
        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)cbCliente.SelectedItem;
                if (clienteSelecionado != null)
                {
                    carregaCompras(clienteSelecionado);
                    labelTotalCliente.Text = string.Format("{0:C}", clienteSelecionado.getTotalCliente());
                }
            }
            catch
            {
            }
        }

        private void listBoxCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)cbCliente.SelectedItem;
                if (clienteSelecionado != null)
                {
                    Compras compraSelecionada = (Compras)listBoxCompra.SelectedItem;
                    if (compraSelecionada != null)
                    {
                        carregaDetalhesCompra(compraSelecionada);
                        labelTotalDetalhesCompra.Text = string.Format("{0:C}", compraSelecionada.getTotalCompra());
                    }
                }
            }
            catch
            {
            }
        }

        // Para apagar uma compra
        private void buttonApagarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                Compras compraSelecionada = (Compras)listBoxCompra.SelectedItem;
                if (compraSelecionada != null)
                {
                    if (MessageBox.Show("Esta operação implica remover todos os detalhes da compra. Tem a certeza que pretende apagá-la?", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bookidsContainer.ComprasSet.Remove(compraSelecionada);
                        bookidsContainer.SaveChanges();

                        Clientes clienteSelecionado = (Clientes)cbCliente.SelectedItem;
                        carregaCompras(clienteSelecionado);

                        MessageBox.Show("Compra apagada com sucesso!", "Informação", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar a compra!", "Aviso", MessageBoxButtons.OK);
            }
        }



        // <------------------- Detalhe de Compras ------------------->

        // Verificar se os campos estão todos preenchidos para adicionar um novo produto
        private bool dadosPreenchidosProdutos()
        {
            if (numericUpDownQuantidade.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownQuantidade.Focus();
                return false;
            }
            //Verificar se designaçao esta selecionado
            if (cbProduto.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                cbProduto.Focus();
                return false;
            }
            return true;
        }

        // Para adicionar um detalhe da compra
        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                bool produtoExiste = false;

                Compras compraSelecionada = (Compras)listBoxCompra.SelectedItem;
                if (compraSelecionada != null)
                {

                    foreach (DetalheCompras dc in compraSelecionada.DetalheCompras.ToList<DetalheCompras>())
                    {
                        if (dc.CodProduto == ((Produtos)cbProduto.SelectedItem).CodProduto)
                        {
                            produtoExiste = true;
                        }
                    }

                    if (produtoExiste == false)
                    {
                        if (numericUpDownQuantidade.Value < ((Produtos)cbProduto.SelectedItem).StockExistente)
                        {
                            Produtos produto = (Produtos)cbProduto.SelectedItem;
                            DetalheCompras novo = new DetalheCompras()
                            {
                                NrCompra = compraSelecionada.NrCompra,
                                CodProduto = ((Produtos)cbProduto.SelectedItem).CodProduto,
                                Quantidade = (int)numericUpDownQuantidade.Value
                            };

                            produto.StockExistente = produto.StockExistente - (int)numericUpDownQuantidade.Value;

                            bookidsContainer.DetalheComprasSet.Add(novo);
                            bookidsContainer.SaveChanges();

                            limparDados();

                            carregaDetalhesCompra(compraSelecionada);

                            MessageBox.Show("Detalhe de compra adicionada com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Stock Insuficiente!", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este detalhe já foi adicionado à compra. Se quiser fazer alguma alteração, apague o detalhe da compra e adicione novamente!", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não se esqueça de selecionar a compra que pretende adicionar o detalhe!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Permite carregar a listBox dos detalhes de Compra
        private void carregaDetalhesCompra(Compras compraSelecionada)
        {
            listBoxProdutos.DataSource = null;
            listBoxProdutos.DataSource = compraSelecionada.DetalheCompras.ToList<DetalheCompras>();
        }

        private void limparDados()
        {
            numericUpDownQuantidade.Value = 0;
        }

        // Para apagar um detalhe de compra
        private void buttonApagarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                DetalheCompras detalheCompraSelecionado = (DetalheCompras)listBoxProdutos.SelectedItem;
                if (detalheCompraSelecionado != null)
                {
                    detalheCompraSelecionado.Produtos.StockExistente = detalheCompraSelecionado.Produtos.StockExistente + detalheCompraSelecionado.Quantidade;

                    bookidsContainer.DetalheComprasSet.Remove(detalheCompraSelecionado);
                    bookidsContainer.SaveChanges();


                    MessageBox.Show("Detalhe de Compra apagado com sucesso!", "Informação", MessageBoxButtons.OK);
                }
               
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o detalhe a ser eliminado!", "Aviso", MessageBoxButtons.OK);
            }
        }



        // <------------------- Fatura ------------------->

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                Clientes clienteSelecionado = (Clientes)cbCliente.SelectedItem;
                if (clienteSelecionado != null)
                {
                    Compras compraSelecionada = (Compras)listBoxCompra.SelectedItem;
                    if (compraSelecionada != null)
                    {
                        string fatura = "";

                        saveFileDialog_Save.FileName = clienteSelecionado.Nome + "_" + compraSelecionada.NrCompra + ".txt";
                        saveFileDialog_Save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        saveFileDialog_Save.FilterIndex = 1;

                        if (saveFileDialog_Save.ShowDialog() == DialogResult.OK)
                        {
                            FileStream fs = new FileStream(saveFileDialog_Save.FileName, FileMode.Create, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);

                            fatura += "Fatura-Recibo\n\nData: " + compraSelecionada.Data + "\nNome: " + clienteSelecionado.Nome + "\n";
                            if (compraSelecionada.UtilizouCartao == "Sim")
                            {
                                fatura += "Número do Cartão: " + clienteSelecionado.NrCartao + "\n";
                            }
                            fatura += "\n\nProduto          Quantidade           Preço\n";
                            fatura += "_______________________________________________\n";
                            foreach (DetalheCompras dc in compraSelecionada.DetalheCompras.ToList<DetalheCompras>())
                            {
                                fatura += "\n" + dc.Produtos.Designacao + "              " + dc.Quantidade + "                  " + (dc.Quantidade * dc.Produtos.Preco) + " €";
                            }
                            fatura += "\n_______________________________________________\n";
                            fatura += "\nIVA: " + (Compras.iva) * 100 + "%\n"; fatura += "Total (IVA incluído): " + compraSelecionada.getTotalCompra() + " €";

                            sw.WriteLine(fatura);

                            sw.Close();
                            MessageBox.Show("Fatura da compra exportada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fs.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o cliente e a compra que pretende fazer fatura!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // <------------------- Guardar Compras do cliente ------------------->

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                Clientes clienteSelecionado = (Clientes)cbCliente.SelectedItem;
                List<Compras> listaCompras = clienteSelecionado.Compras.ToList<Compras>();
                if (clienteSelecionado != null)
                {
                    string ficheiro = "";

                    saveFileDialog_Save.FileName = clienteSelecionado.Nome + ".txt";
                    saveFileDialog_Save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog_Save.FilterIndex = 1;

                    if (saveFileDialog_Save.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = new FileStream(saveFileDialog_Save.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);

                        ficheiro += "                             Compras                             \n\n";
                        ficheiro += "Cliente: " + clienteSelecionado.Nome + string.Format("\nData: {0:dd/MM/yyyy}\nHora: {0:hh:mm:ss}", DateTime.Now);

                        double totalCliente = 0;
                        foreach (Compras c in listaCompras)
                        {
                            double totalCompra = 0;
                            ficheiro += "\n________________________________________________________\n";
                            ficheiro += "Efetuada a: " + string.Format("{0:dd} de {0:MMMM} de {0:yyyy} às {0:HH:mm:ss}", c.Data);

                            foreach (DetalheCompras dc in c.DetalheCompras.ToList<DetalheCompras>())
                            {
                                ficheiro += "\n\n -" + (dc.Quantidade * dc.Produtos.Preco) + "€  " + dc.Produtos.Designacao + " (" + dc.Produtos.TipoProduto.Tipo + ")";
                                totalCompra += dc.Quantidade * dc.Produtos.Preco;
                            }

                            ficheiro += "\n\n Total: " + totalCompra + "€";

                            if (c.UtilizouCartao == "Sim")
                            {
                                ficheiro += "\n\n Número do cartão: " + clienteSelecionado.NrCartao;
                            }

                            totalCliente += totalCompra;
                        }
                        ficheiro += "\n________________________________________________________" +
                            "\n Total do Cliente: " + totalCliente + "€";


                        sw.WriteLine(ficheiro);

                        sw.Close();
                        MessageBox.Show("Compras do cliente guardadas com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fs.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o cliente que pretende guardar os dados!", "Aviso", MessageBoxButtons.OK);
            }
        }
    }
}
