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
    public partial class FormularioClientesFilhos : Form
    {
        private BookidsDBContainer bookidsContainer;
        private Random randNum;

        public FormularioClientesFilhos()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }

        // Ao abrir o Form
        private void FormularioClientesFilhos_Load(object sender, EventArgs e)
        {
            carregaTodosClientes();

            var listaCartoes = (from cliente in bookidsContainer.ClientesSet
                                select cliente.NrCartao).ToList();

            int ultimoCartao = 1000000;
            if (listaCartoes.Count > 0)
            {
                ultimoCartao = listaCartoes.Max();

            }
            randNum = new Random(ultimoCartao);
        }

        
        // Método que ocorre ao fechar um formulário sobreposto
        private void FormularioClientesFilhos_Activated(object sender, EventArgs e)
        {
            carregaComboEscolas();
        }

        /// <summary>
        /// Este Método permite carregar as escolas na combo box
        /// </summary>
        private void carregaComboEscolas()
        {
            cbEscola.DataSource = bookidsContainer.EscolasSet.ToList<Escolas>();
        }




        //    <----------- Clientes ----------->

        /// <summary>
        /// Verifica se os campos do cliente estão todos preenchidos
        /// </summary>
        /// <returns></returns>
        private bool dadosPreenchidosCliente()
        {
            if (tbNomeCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbNomeCliente.Focus();
                return false;
            }
            if (tbMoradaCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbMoradaCliente.Focus();
                return false;
            }
            if (tbLocalidadeCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbLocalidadeCliente.Focus();
                return false;
            }
            if (tbCodPostalCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbCodPostalCliente.Focus();
                return false;
            }
            if (tbTelefoneCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTelefoneCliente.Focus();
                return false;
            }
            if (tbTelemovelCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTelemovelCliente.Focus();
                return false;
            }
            if (tbMailCliente.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbMailCliente.Focus();
                return false;
            }
            if (numericUpDownValorOferta.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownValorOferta.Focus();
                return false;
            }
            if (numericUpDownNumeroCartao.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownNumeroCartao.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Carrega todos os clientes
        /// </summary>
        private void carregaTodosClientes()
        {
            listViewClientes.Items.Clear();
            foreach (Clientes c in bookidsContainer.ClientesSet)
            {
                adicionaCliente(c);
            }
        }

        /// <summary>
        /// Limpa os dados de todos os campos do cliente
        /// </summary>
        private void limparDadosCliente()
        {
            tbNomeCliente.Text = "";
            tbMoradaCliente.Text = "";
            tbLocalidadeCliente.Text = "";
            tbCodPostalCliente.Text = "";
            tbTelefoneCliente.Text = "";
            tbTelemovelCliente.Text = "";
            tbMailCliente.Text = "";
            numericUpDownValorOferta.Value = 0;
            numericUpDownNumeroCartao.Value = 0;
            tbProgenitor.Text = "";
        }

        /// <summary>
        /// Método que permite encher a listView
        /// </summary>
        /// <param name="cliente"></param>
        private void adicionaCliente(Clientes cliente)
        {
            var row = new string[]
            {
                cliente.Nome,
                cliente.Morada,
                cliente.Localidade,
                cliente.CodPostal,
                cliente.Telefone,
                cliente.Telemovel,
                cliente.Mail,
                string.Format("{0:C}",cliente.ValorOferta),
                string.Format("{0}",cliente.NrCartao)
            };

            var lvi = new ListViewItem(row);
            lvi.Tag = cliente;
            listViewClientes.Items.Add(lvi);
        }

        // Adicionar um cliente novo
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dadosPreenchidosCliente())
                {
                    Clientes novo = new Clientes()
                    {
                        Nome = tbNomeCliente.Text,
                        Morada = tbMoradaCliente.Text,
                        Localidade = tbLocalidadeCliente.Text,
                        CodPostal = tbCodPostalCliente.Text,
                        Telefone = tbTelefoneCliente.Text,
                        Telemovel = tbTelemovelCliente.Text,
                        Mail = tbMailCliente.Text,
                        ValorOferta = Convert.ToDouble(numericUpDownValorOferta.Value),
                        NrCartao = Convert.ToInt32(numericUpDownNumeroCartao.Value)
                    };

                    bookidsContainer.ClientesSet.Add(novo);

                    bookidsContainer.SaveChanges();

                    adicionaCliente(novo);

                    MessageBox.Show("Cliente adicionado com sucesso!", "Informação", MessageBoxButtons.OK);

                    limparDadosCliente();
                }

            }
            catch
            {
                MessageBox.Show("Certifique-se de que os dados introduzidos correspondem ao tipo de cada campo! (números/algarismos)", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Apagar o cliente selecionado
        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)listViewClientes.SelectedItems[0].Tag;
                if (clienteSelecionado != null)
                {
                    if (MessageBox.Show("Esta operação puderá não ser possível pois, o cliente pode ser filhos e compras associadas. Se for o caso, terá de apagar essas associações primeiro\n\nMesmo assim quer tentar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        List<Filhos> listaFilhosCliente = clienteSelecionado.Filhos.ToList<Filhos>();
                        List<Compras> listaComprasCliente = clienteSelecionado.Compras.ToList<Compras>();

                        if (listaComprasCliente.Count == 0 && listaFilhosCliente.Count == 0)
                        {
                            bookidsContainer.ClientesSet.Remove(clienteSelecionado);
                            bookidsContainer.SaveChanges();

                            carregaTodosClientes();
                            carregaTodosFilhos(clienteSelecionado.Filhos.ToList<Filhos>());

                            limparDadosCliente();
                            limparDadosFilho();

                            MessageBox.Show("Cliente apagado com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível apagar o cliente!", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o cliente que pretende apagar!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Alterar dados do cliente selecionado
        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)listViewClientes.SelectedItems[0].Tag;
                if (clienteSelecionado != null)
                {
                    clienteSelecionado.Nome = tbNomeCliente.Text;
                    clienteSelecionado.Morada = tbMoradaCliente.Text;
                    clienteSelecionado.Localidade = tbLocalidadeCliente.Text;
                    clienteSelecionado.CodPostal = tbCodPostalCliente.Text;
                    clienteSelecionado.Telefone = tbTelefoneCliente.Text;
                    clienteSelecionado.Telemovel = tbTelemovelCliente.Text;
                    clienteSelecionado.Mail = tbMailCliente.Text;
                    clienteSelecionado.ValorOferta = Convert.ToInt32(numericUpDownValorOferta.Value);
                    clienteSelecionado.NrCartao = Convert.ToInt32(numericUpDownNumeroCartao.Value);

                    bookidsContainer.SaveChanges();

                    carregaTodosClientes();

                    MessageBox.Show("Dados do cliente alterados com sucesso!", "Informação", MessageBoxButtons.OK);

                    limparDadosCliente();
                }
            }
            catch 
            { 
                MessageBox.Show("Selecione primeiro o cliente para alterar os seus dados!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Mostrar dados quando um cliente está selecionado
        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)listViewClientes.SelectedItems[0].Tag;
                if (clienteSelecionado != null)
                {
                    tbNomeCliente.Text = clienteSelecionado.Nome;
                    tbMoradaCliente.Text = clienteSelecionado.Morada;
                    tbLocalidadeCliente.Text = clienteSelecionado.Localidade;
                    tbCodPostalCliente.Text = clienteSelecionado.CodPostal;
                    tbTelefoneCliente.Text = clienteSelecionado.Telefone;
                    tbTelemovelCliente.Text = clienteSelecionado.Telemovel;
                    tbMailCliente.Text = clienteSelecionado.Mail;
                    numericUpDownValorOferta.Value =(Decimal)clienteSelecionado.ValorOferta;
                    numericUpDownNumeroCartao.Value = (Decimal)clienteSelecionado.NrCartao;

                    carregaTodosFilhos(clienteSelecionado.Filhos.ToList<Filhos>());
                    
                    limparDadosFilho();

                    carregaComboEscolas();

                    tbProgenitor.Text = clienteSelecionado.Nome;
                }
            }
            catch
            {
            }
        }

        // Permite Gerar um número de cartão aleatório
        private void buttonGeraCartao_Click(object sender, EventArgs e)
        {
            int numero = randNum.Next(1000000, 99999999);

            List<Clientes> listaClientes = (from cliente in bookidsContainer.ClientesSet
                                            where cliente.NrCartao == numero
                                            select cliente).ToList<Clientes>();
            while (listaClientes.Count > 0)
            {
                numero = randNum.Next(1000000, 99999999);

                listaClientes = (from cliente in bookidsContainer.ClientesSet
                                 where cliente.NrCartao == numero
                                 select cliente).ToList<Clientes>();
            }
            numericUpDownNumeroCartao.Value = numero;
        }




        //    <----------- Filhos ----------->

        /// <summary>
        /// Verifica se os campos do filho estão todos preenchidos
        /// </summary>
        /// <returns></returns>
        private bool dadosPreenchidosFilho()
        {
            if (tbNomeFilho.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbNomeFilho.Focus();
                return false;
            }
            if (cbEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                cbEscola.Focus();
                return false;
            }
            if (tbProgenitor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbProgenitor.Focus();
                return false;
            }
            if (radioButtonF.Checked == false && radioButtonM.Checked == false)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Limpa os dados de todos os campos do filho
        /// </summary>
        private void limparDadosFilho()
        {
            tbNomeFilho.Text = "";
            dateTimePickerDataNascimento.Value = DateTime.Today;
            cbEscola.Text = "";
            tbProgenitor.Text = "";
            if(radioButtonF.Checked == true)
            {
                radioButtonF.Checked = false;
            }
            if (radioButtonM.Checked == true)
            {
                radioButtonM.Checked = false;
            }
        }

        /// <summary>
        /// Permite carregar todos os filhos na listView
        /// </summary>
        /// <param name="listaFilhos"></param>
        private void carregaTodosFilhos(List<Filhos> listaFilhos)
        {
            listViewFilhos.Items.Clear();
            foreach (Filhos f in listaFilhos)
            {
                adicionaFilho(f);
            }
        }

        /// <summary>
        /// Adiciona os dados do filho na list View
        /// </summary>
        /// <param name="filho"></param>
        private void adicionaFilho(Filhos filho)
        {
            var row = new string[]
            {
                filho.Nome,
                (filho.DataNascimento).ToString("dd/mm/yyyy"),
                filho.Sexo,
                filho.Escolas.Nome
            };
            
            var lvi = new ListViewItem(row);
            lvi.Tag = filho;
            listViewFilhos.Items.Add(lvi);
        }

        // Permitir adicionar um filho se o cliente estiver selecionado
        private void buttonAdicionarFilho_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes clienteSelecionado = (Clientes)listViewClientes.SelectedItems[0].Tag;
                if (clienteSelecionado != null)
                {
                    if (dadosPreenchidosFilho())
                    {
                        if (dateTimePickerDataNascimento.Value < DateTime.Today)
                        {
                            Filhos novo = new Filhos()
                            {
                                Nome = tbNomeFilho.Text,
                                Morada = clienteSelecionado.Morada,
                                Localidade = clienteSelecionado.Localidade,
                                CodPostal = clienteSelecionado.CodPostal,
                                Telefone = clienteSelecionado.Telefone,
                                Telemovel = clienteSelecionado.Telemovel,
                                Mail = clienteSelecionado.Mail,
                                DataNascimento = dateTimePickerDataNascimento.Value,
                                Sexo = radioButtonF.Checked ? radioButtonF.Text : radioButtonM.Text,
                                IdEscola = ((Escolas)cbEscola.SelectedItem).IdEscola,
                                IdProgenitor = clienteSelecionado.IdPessoa,
                            };

                            // Adicionar à base de dados
                            bookidsContainer.FilhosSet.Add(novo);

                            // Guardar as alterações feitas               
                            bookidsContainer.SaveChanges();

                            adicionaFilho(novo);
                            carregaTodosFilhos(clienteSelecionado.Filhos.ToList<Filhos>());

                            limparDadosFilho();

                            MessageBox.Show("Filho adicionado com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Certifique-se de selecionar uma data válida!", "Atenção", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar o cliente para adicionar o filho", "Atenção", MessageBoxButtons.OK);
            }
        }

        // Butão que permite apagar o filho selecionado do cliente selecionado
        private void buttonApagarFilho_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = (Clientes)listViewClientes.SelectedItems[0].Tag;
                if (cliente != null)
                {
                    Filhos filhoSelecionado = (Filhos)listViewFilhos.SelectedItems[0].Tag;
                    if (filhoSelecionado != null)
                    {
                        if (MessageBox.Show("Esta operação puderá não ser possível pois, o filho pode estar inscrito em eventos. Se for o caso, terá de apagar as inscrições primeiro.\n\nMesmo assim quer tentar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            List<Inscricoes> listaInscricoes = filhoSelecionado.Inscricoes.ToList<Inscricoes>();

                            if (listaInscricoes.Count == 0)
                            {
                                bookidsContainer.FilhosSet.Remove(filhoSelecionado);
                                bookidsContainer.SaveChanges();

                                carregaTodosFilhos(cliente.Filhos.ToList<Filhos>());

                                limparDadosFilho();

                                MessageBox.Show("Filho apagado com sucesso!", "Informação", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível apagar o filho!", "Aviso", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o filho que pretende apagar!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Alterar dados do filho selecionado
        private void buttonAlterarFilho_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = (Clientes)listViewClientes.SelectedItems[0].Tag;
                if (cliente != null)
                {
                    Filhos filhoSelecionado = (Filhos)listViewFilhos.SelectedItems[0].Tag;
                    if (filhoSelecionado != null)
                    {
                        if (dateTimePickerDataNascimento.Value < DateTime.Today)
                        {
                            filhoSelecionado.Nome = tbNomeFilho.Text;
                            filhoSelecionado.Morada = tbMoradaCliente.Text;
                            filhoSelecionado.Localidade = tbLocalidadeCliente.Text;
                            filhoSelecionado.CodPostal = tbCodPostalCliente.Text;
                            filhoSelecionado.Telefone = tbTelefoneCliente.Text;
                            filhoSelecionado.Telemovel = tbTelemovelCliente.Text;
                            filhoSelecionado.Mail = tbMailCliente.Text;
                            filhoSelecionado.DataNascimento = dateTimePickerDataNascimento.Value;
                            filhoSelecionado.Sexo = radioButtonF.Checked ? radioButtonF.Text : radioButtonM.Text;
                            filhoSelecionado.IdEscola = ((Escolas)cbEscola.SelectedItem).IdEscola;
                            filhoSelecionado.IdProgenitor = cliente.IdPessoa;

                            bookidsContainer.SaveChanges();

                            carregaTodosFilhos(cliente.Filhos.ToList<Filhos>());

                            limparDadosFilho();

                            MessageBox.Show("Dados do filho alterados com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Certifique-se de selecionar uma data válida!", "Atenção", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o filho para alterar os seus dados!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Mostrar dados quando um filho está selecionado
        private void listViewFilhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Filhos filhoSelecionado = (Filhos)listViewFilhos.SelectedItems[0].Tag;
                if (filhoSelecionado != null)
                {
                    tbNomeFilho.Text = filhoSelecionado.Nome;
                    dateTimePickerDataNascimento.Value = filhoSelecionado.DataNascimento;
                    if (filhoSelecionado.Sexo == "Feminino")
                        radioButtonF.Checked = true;
                    else
                        radioButtonM.Checked = true;
                    cbEscola.Text = filhoSelecionado.Escolas.Nome;
                    tbProgenitor.Text = ((Clientes)listViewClientes.SelectedItems[0].Tag).Nome;
                }
            }
            catch
            {
            }
        }

        // Butão que faz abrir o formulário das escolas para adicionar nova escola se não existir nas opções
        private void buttonAdicionarEscola_Click(object sender, EventArgs e)
        {
            FormularioEscolas formEscolas = new FormularioEscolas();
            formEscolas.ShowDialog();
        }


        // <------------------ Menu ------------------>

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosCliente();
        }

        private void filhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosFilho();
        }
    }
}
