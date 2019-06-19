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
    public partial class FormularioEscolas : Form
    {
        private BookidsDBContainer bookidsContainer;

        public FormularioEscolas()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }

        private void FormularioEscolas_Load(object sender, EventArgs e)
        {
            carregaTodasEscolas();
        }

        //    <----------- Escolas ----------->

        // Verificar se os campos estão todos preenchidos
        private bool dadosPreenchidosEscola()
        {
            if (tbNomeEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbNomeEscola.Focus();
                return false;
            }
            if (tbMoradaEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbMoradaEscola.Focus();
                return false;
            }
            if (tbLocalidadeEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbLocalidadeEscola.Focus();
                return false;
            }
            if (tbCodPostalEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbCodPostalEscola.Focus();
                return false;
            }
            if (tbTelefoneEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTelefoneEscola.Focus();
                return false;
            }
            if (tbMailEscola.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbMailEscola.Focus();
                return false;
            }
            return true;
        }

        // Limpa os dados de todos os campos
        private void limparDadosEscola()
        {
            tbNomeEscola.Text = "";
            tbMoradaEscola.Text = "";
            tbLocalidadeEscola.Text = "";
            tbCodPostalEscola.Text = "";
            tbTelefoneEscola.Text = "";
            tbMailEscola.Text = "";
        }

        // Função que permite encher a listView
        private void adicionaEscola(Escolas escola)
        {
            var row = new string[]
            {
                escola.Nome,
                escola.Morada,
                escola.Localidade,
                escola.CodPostal,
                escola.Telefone,
                escola.Mail
            };

            var lvi = new ListViewItem(row);
            lvi.Tag = escola;
            listViewEscolas.Items.Add(lvi);
        }

        // Carrega todas as Escolas
        private void carregaTodasEscolas()
        {
            listViewEscolas.Items.Clear();
            foreach (Escolas e in bookidsContainer.EscolasSet)
            {
                adicionaEscola(e);
            }
        }

        // Permite adicionar uma escola
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dadosPreenchidosEscola())
                {
                    Escolas novo = new Escolas()
                    {
                        Nome = tbNomeEscola.Text,
                        Morada = tbMoradaEscola.Text,
                        Localidade = tbLocalidadeEscola.Text,
                        CodPostal = tbCodPostalEscola.Text,
                        Telefone = tbTelefoneEscola.Text,
                        Mail = tbMailEscola.Text
                    };

                    bookidsContainer.EscolasSet.Add(novo);

                    bookidsContainer.SaveChanges();
                    
                    adicionaEscola(novo);

                    limparDadosEscola();

                    MessageBox.Show("Escola adicionada com sucesso!", "Informação", MessageBoxButtons.OK);
                }

            }
            catch
            {
                MessageBox.Show("Certifique-se de que os dados introduzidos correspondem ao tipo de cada campo! (números/algarismos)", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para apagar uma escola
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                Escolas escolaSelecionada = (Escolas)listViewEscolas.SelectedItems[0].Tag;
                if (escolaSelecionada != null)
                {
                    if (MessageBox.Show("Se a escola tiver algo relacionado, não é possível ser removida. Mesmo assim quer tentar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        List<Participacoes> listaParticipacoesEscola = escolaSelecionada.Participacoes.ToList<Participacoes>();
                        List<Filhos> listaFilhosEscola = escolaSelecionada.Filhos.ToList<Filhos>();

                        if (listaParticipacoesEscola.Count == 0 && listaFilhosEscola.Count == 0)
                        {
                            bookidsContainer.EscolasSet.Remove(escolaSelecionada);

                            bookidsContainer.SaveChanges();

                            carregaTodasEscolas();

                            limparDadosEscola();

                            MessageBox.Show("Escola apagada com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível apagar a escola!", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro a escola que pretende apagar!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para alterar dados de uma escola selecionada
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Escolas escolaSelecionado = (Escolas)listViewEscolas.SelectedItems[0].Tag;
                if (escolaSelecionado != null)
                {
                    escolaSelecionado.Nome = tbNomeEscola.Text;
                    escolaSelecionado.Morada = tbMoradaEscola.Text;
                    escolaSelecionado.Localidade = tbLocalidadeEscola.Text;
                    escolaSelecionado.CodPostal = tbCodPostalEscola.Text;
                    escolaSelecionado.Telefone = tbTelefoneEscola.Text;
                    escolaSelecionado.Mail = tbMailEscola.Text;

                    bookidsContainer.SaveChanges();

                    carregaTodasEscolas();

                    limparDadosEscola();

                    MessageBox.Show("Dados da Escola alterados com sucesso!", "Informação", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro a Escola para alterar os seus dados!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para mostras os dados da Escola selecionada
        private void listViewEscolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Escolas escolaSelecionada = (Escolas)listViewEscolas.SelectedItems[0].Tag;
                if (escolaSelecionada != null)
                {
                    tbNomeEscola.Text = escolaSelecionada.Nome;
                    tbMoradaEscola.Text = escolaSelecionada.Morada;
                    tbLocalidadeEscola.Text = escolaSelecionada.Localidade;
                    tbCodPostalEscola.Text = escolaSelecionada.CodPostal;
                    tbTelefoneEscola.Text = escolaSelecionada.Telefone;
                    tbMailEscola.Text = escolaSelecionada.Mail;
                }
            }
            catch
            {
            }
        }

        private void novaEscolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosEscola();
        }
    }
}
