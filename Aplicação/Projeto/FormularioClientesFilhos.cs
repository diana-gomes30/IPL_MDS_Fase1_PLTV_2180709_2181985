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
        public FormularioClientesFilhos()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }

        private void FormularioClientesFilhos_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = bookidsContainer.ClientesSet.ToList<Clientes>();
        }

        //    <----------- Clientes ----------->

        // Verificar se os campos estão todos preenchidos
        private bool dadosPreenchidosCliente()
        {
            if (tbNomeCliente.Text == "")
            {
                tbNomeCliente.Focus();
                return false;
            }
            if (tbMoradaCliente.Text == "")
            {
                tbMoradaCliente.Focus();
                return false;
            }
            if (tbLocalidadeCliente.Text == "")
            {
                tbLocalidadeCliente.Focus();
                return false;
            }
            if (tbCodPostalCliente.Text == "")
            {
                tbCodPostalCliente.Focus();
                return false;
            }
            if (tbTelefoneCliente.Text == "")
            {
                tbTelefoneCliente.Focus();
                return false;
            }
            if (tbTelemovelCliente.Text == "")
            {
                tbTelemovelCliente.Focus();
                return false;
            }
            if (tbMailCliente.Text == "")
            {
                tbMailCliente.Focus();
                return false;
            }
            if (tbValorOferta.Text == "")
            {
                tbValorOferta.Focus();
                return false;
            }
            if (tbNumeroCartao.Text == "")
            {
                tbNumeroCartao.Focus();
                return false;
            }
            return true;
        }

        // Para limpar dados das text box
        private void limparDadosCliente()
        {
            tbNomeCliente.Text = "";
            tbMoradaCliente.Text = "";
            tbLocalidadeCliente.Text = "";
            tbCodPostalCliente.Text = "";
            tbTelefoneCliente.Text = "";
            tbTelemovelCliente.Text = "";
            tbMailCliente.Text = "";
            tbValorOferta.Text = "";
            tbNumeroCartao.Text = "";
        }

        // Adicionar um cliente novo
        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
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
                    ValorOferta = tbValorOferta.Text,
                    NrCartao = tbNumeroCartao.Text,
                };

                bookidsContainer.ClientesSet.Add(novo);

                bookidsContainer.SaveChanges();

                listBoxClientes.DataSource = bookidsContainer.ClientesSet.ToList<Clientes>();

                limparDadosCliente();
            }
        }

        // Apagar o cliente selecionado
        private void buttonApagarCliente_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)listBoxClientes.SelectedItem;
            if (clienteSelecionado != null)
            {
                bookidsContainer.ClientesSet.Remove(clienteSelecionado);
                bookidsContainer.PessoasSet.Remove(clienteSelecionado);

                bookidsContainer.SaveChanges();

                listBoxClientes.DataSource = bookidsContainer.ClientesSet.ToList<Clientes>();
                limparDadosCliente();
            }
        }

        // Alterar dados do cliente selecionado
        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)listBoxClientes.SelectedItem;
            if (clienteSelecionado != null)
            {
                clienteSelecionado.Nome = tbNomeCliente.Text;
                clienteSelecionado.Morada = tbMoradaCliente.Text;
                clienteSelecionado.Localidade = tbLocalidadeCliente.Text;
                clienteSelecionado.CodPostal = tbCodPostalCliente.Text;
                clienteSelecionado.Telefone = tbTelefoneCliente.Text;
                clienteSelecionado.Telemovel = tbTelemovelCliente.Text;
                clienteSelecionado.Mail = tbMailCliente.Text;
                clienteSelecionado.ValorOferta = tbValorOferta.Text;
                clienteSelecionado.NrCartao = tbNumeroCartao.Text;

                bookidsContainer.SaveChanges();

                listBoxClientes.DataSource = bookidsContainer.ClientesSet.ToList<Clientes>();
            }
        }

        // Mostrar dados quando um cliente está selecionado
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clientes clienteSelecionado = (Clientes)listBoxClientes.SelectedItem;
            if (clienteSelecionado != null)
            {
                tbNomeCliente.Text = clienteSelecionado.Nome;
                tbMoradaCliente.Text = clienteSelecionado.Morada;
                tbLocalidadeCliente.Text = clienteSelecionado.Localidade;
                tbCodPostalCliente.Text = clienteSelecionado.CodPostal;
                tbTelefoneCliente.Text = clienteSelecionado.Telefone;
                tbTelemovelCliente.Text = clienteSelecionado.Telemovel;
                tbMailCliente.Text = clienteSelecionado.Mail;
                tbValorOferta.Text = clienteSelecionado.ValorOferta;
                tbNumeroCartao.Text = clienteSelecionado.NrCartao;
            }

        }
    }
}
