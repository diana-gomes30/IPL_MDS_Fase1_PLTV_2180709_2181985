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
    public partial class FormularioAnimadores : Form
    {
        private BookidsDBContainer bookidsContainer;

        public FormularioAnimadores()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }
        
        private void FormularioAnimadores_Load(object sender, EventArgs e)
        {
            carregaTodosAnimadores();
        }



        //    <----------- Animadores ----------->

        /// <summary>
        /// Verifica se os campos estão todos preenchidos
        /// </summary>
        /// <returns></returns>
        private bool dadosPreenchidosAnimador()
        {
            if (tbNomeAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbNomeAnimadores.Focus();
                return false;
            }
            if (tbMoradaAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbMoradaAnimadores.Focus();
                return false;
            }
            if (tbLocalidadeAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbLocalidadeAnimadores.Focus();
                return false;
            }
            if (tbCodPostalAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbCodPostalAnimadores.Focus();
                return false;
            }
            if (tbTelefoneAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTelefoneAnimadores.Focus();
                return false;
            }
            if (tbTelemovelAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTelemovelAnimadores.Focus();
                return false;
            }
            if (tbMailAnimadores.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbMailAnimadores.Focus();
                return false;
            }
            if (tbEspecialidade.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbEspecialidade.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Limpa os dados de todos os campos
        /// </summary>
        private void limparDadosAnimador()
        {
            tbNomeAnimadores.Text = "";
            tbMoradaAnimadores.Text = "";
            tbLocalidadeAnimadores.Text = "";
            tbCodPostalAnimadores.Text = "";
            tbTelefoneAnimadores.Text = "";
            tbTelemovelAnimadores.Text = "";
            tbMailAnimadores.Text = "";
            tbEspecialidade.Text = "";
        }

        /// <summary>
        /// Método que permite encher a listView
        /// </summary>
        /// <param name="animador"></param>
        private void adicionaAnimador(Animadores animador)
        {
            var row = new string[]
            {
                animador.Nome,
                animador.Morada,
                animador.Localidade,
                animador.CodPostal,
                animador.Telefone,
                animador.Telemovel,
                animador.Mail,
                animador.Especialidade
            };

            var lvi = new ListViewItem(row);
            lvi.Tag = animador;
            listViewAnimadores.Items.Add(lvi);
        }

        /// <summary>
        /// Método que carrega todos os Animadores na listView
        /// </summary>
        private void carregaTodosAnimadores()
        {
            listViewAnimadores.Items.Clear();
            foreach (Animadores a in bookidsContainer.AnimadoresSet)
            {
                adicionaAnimador(a);
            }
        }

        // Permite adicionar um Animador
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dadosPreenchidosAnimador())
                {
                    Animadores novo = new Animadores()
                    {
                        Nome = tbNomeAnimadores.Text,
                        Morada = tbMoradaAnimadores.Text,
                        Localidade = tbLocalidadeAnimadores.Text,
                        CodPostal = tbCodPostalAnimadores.Text,
                        Telefone = tbTelefoneAnimadores.Text,
                        Telemovel = tbTelemovelAnimadores.Text,
                        Mail = tbMailAnimadores.Text,
                        Especialidade = tbEspecialidade.Text
                    };

                    bookidsContainer.AnimadoresSet.Add(novo);

                    bookidsContainer.SaveChanges();

                    adicionaAnimador(novo);

                    limparDadosAnimador();

                    MessageBox.Show("Animador adicionado com sucesso!", "Informação", MessageBoxButtons.OK);
                }

            }
            catch
            {
                MessageBox.Show("Certifique-se de que os dados introduzidos correspondem ao tipo de cada campo! (números/algarismos)", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para apagar um Animador selecionado
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Animadores animadorSelecionado = (Animadores)listViewAnimadores.SelectedItems[0].Tag;
            if (animadorSelecionado != null)
            {
                if (MessageBox.Show("Se o Animador tiver algo relacionado, não é possível ser removido. Mesmo assim quer tentar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<Colaboracoes> listaColaboracoesAnimador = animadorSelecionado.Colaboracoes.ToList<Colaboracoes>();
                    if (listaColaboracoesAnimador.Count == 0)
                    {
                        bookidsContainer.AnimadoresSet.Remove(animadorSelecionado);
                        bookidsContainer.SaveChanges();

                        carregaTodosAnimadores();

                        limparDadosAnimador();

                        MessageBox.Show("Animador apagado com sucesso!", "Informação", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Impossível remover o Animador!", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
        }
                
        // Para alterar os dados de um Animador selecionado
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Animadores animadorSelecionado = (Animadores)listViewAnimadores.SelectedItems[0].Tag;
                if (animadorSelecionado != null)
                {
                    animadorSelecionado.Nome = tbNomeAnimadores.Text;
                    animadorSelecionado.Morada = tbMoradaAnimadores.Text;
                    animadorSelecionado.Localidade = tbLocalidadeAnimadores.Text;
                    animadorSelecionado.CodPostal = tbCodPostalAnimadores.Text;
                    animadorSelecionado.Telefone = tbTelefoneAnimadores.Text;
                    animadorSelecionado.Telemovel = tbTelemovelAnimadores.Text;
                    animadorSelecionado.Mail = tbMailAnimadores.Text;
                    animadorSelecionado.Especialidade = tbEspecialidade.Text;

                    bookidsContainer.SaveChanges();

                    carregaTodosAnimadores();

                    limparDadosAnimador();

                    MessageBox.Show("Dados do Animador alterados com sucesso!", "Informação", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o Animador para alterar os seus dados!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Mostrar dados do Animador selecionado
        private void listViewAnimadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Animadores animadorSelecionado = (Animadores)listViewAnimadores.SelectedItems[0].Tag;
                if (animadorSelecionado != null)
                {
                    tbNomeAnimadores.Text = animadorSelecionado.Nome;
                    tbMoradaAnimadores.Text = animadorSelecionado.Morada;
                    tbLocalidadeAnimadores.Text = animadorSelecionado.Localidade;
                    tbCodPostalAnimadores.Text = animadorSelecionado.CodPostal;
                    tbTelefoneAnimadores.Text = animadorSelecionado.Telefone;
                    tbTelemovelAnimadores.Text = animadorSelecionado.Telemovel;
                    tbMailAnimadores.Text = animadorSelecionado.Mail;
                    tbEspecialidade.Text = animadorSelecionado.Especialidade;
                }
            }
            catch
            {
            }
        }

        private void novoAnimadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosAnimador();
        }
    }
}
