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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto
{
    public partial class FormularioEventos : Form
    {
        private BookidsDBContainer bookidsContainer;
        private int eventoSelecionado;

        public FormularioEventos()
        {
            InitializeComponent();
            bookidsContainer = new BookidsDBContainer();
        }

        private void FormularioEventos_Load(object sender, EventArgs e)
        {
            carregaTodosEventos();
        }

        private void FormularioEventos_Activated(object sender, EventArgs e)
        {
            carregaComboEscolas();
            carregaComboAnimadores();
            carregaComboFilhos();
            
        }

        // Carrega todas as Escolas
        private void carregaComboEscolas()
        {
            cbEscolas.DataSource = bookidsContainer.EscolasSet.ToList<Escolas>();
        }

        // Carrega todos os Animadores 
        private void carregaComboAnimadores()
        {
            cbAnimadores.DataSource = bookidsContainer.AnimadoresSet.ToList<Animadores>();
        }

        // Carrega todos os Filhos
        private void carregaComboFilhos()
        {
            cbFilhos.DataSource = bookidsContainer.FilhosSet.ToList<Filhos>();
        }




        //   <---------------- Eventos ---------------->

        // Verificação dos dados preenchidos
        private bool dadosPreenchidosEvento()
        {
            if (tbTipoEvento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbTipoEvento.Focus();
                return false;
            }
            if (tbDescricaoEvento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbDescricaoEvento.Focus();
                return false;
            }
            if (tbLocalEvento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbLocalEvento.Focus();
                return false;
            }
            if (dateTimePickerDataEvento.Value == null)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                dateTimePickerDataEvento.Focus();
                return false;
            }
            if (tbHoraEvento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                tbHoraEvento.Focus();
                return false;
            }
            if (numericUpDownLimite.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownLimite.Focus();
                return false;
            }
            if (numericUpDownIdadeInferior.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownIdadeInferior.Focus();
                return false;
            }
            if (numericUpDownIdadeSuperior.Value == 0)
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK);
                numericUpDownIdadeSuperior.Focus();
                return false;
            }
            return true;
        }

        // Carrega todos os Eventos
        private void carregaTodosEventos()
        {
            listViewEventos.Items.Clear();
            foreach (Eventos e in bookidsContainer.EventosSet)
            {
                adicionaEvento(e);
            }
        }

        // Adiciona o Evento à listView
        private void adicionaEvento(Eventos evento)
        {
            var row = new string[]
            {
                evento.TipoEvento,
                evento.Descricao,
                evento.Local,
                Convert.ToString(evento.DataHora),
                Convert.ToString(evento.LimiteParticipacao),
                Convert.ToString(evento.IdadeInferior),
                Convert.ToString(evento.IdadeSuperior)
            };

            var lvi = new ListViewItem(row);
            lvi.Tag = evento;
            listViewEventos.Items.Add(lvi);
        }

        // Limpa todos os dados dos campos
        private void limparDadosEvento()
        {
            tbTipoEvento.Text = "";
            tbDescricaoEvento.Text = "";
            tbLocalEvento.Text = "";
            dateTimePickerDataEvento.Value = DateTime.Now;
            tbHoraEvento.Text = "";
            numericUpDownLimite.Value = 0;
            numericUpDownIdadeInferior.Value = 0;
            numericUpDownIdadeSuperior.Value = 0;
        }

        // Para adicionar um Evento
        private void buttonAdicionarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (dadosPreenchidosEvento())
                {
                    // Para ir buscar a formatação dataHora
                    DateTime data = dateTimePickerDataEvento.Value;
                    String horaEvento = tbHoraEvento.Text;

                    int hora = Convert.ToInt32(horaEvento.Substring(0, 2));
                    int minutos = Convert.ToInt32(horaEvento.Substring(7, 2));

                    DateTime dataHora = new DateTime(
                        data.Year,
                        data.Month,
                        data.Day,
                        hora,
                        minutos,
                        0,
                        0
                        );
            
                    Eventos novo = new Eventos()
                    {
                        TipoEvento = tbTipoEvento.Text,
                        Descricao = tbDescricaoEvento.Text,
                        Local = tbLocalEvento.Text,
                        DataHora = dataHora,
                        LimiteParticipacao = Convert.ToInt32(numericUpDownLimite.Value),
                        IdadeInferior = Convert.ToInt32(numericUpDownIdadeInferior.Value),
                        IdadeSuperior = Convert.ToInt32(numericUpDownIdadeSuperior.Value)
                    };

                    bookidsContainer.EventosSet.Add(novo);

                    bookidsContainer.SaveChanges();

                    adicionaEvento(novo);

                    limparDadosEvento();

                    MessageBox.Show("Evento adicionado com sucesso!", "Informação", MessageBoxButtons.OK);
                }

            }
            catch
            {
                MessageBox.Show("Certifique-se de que os dados introduzidos correspondem ao tipo de cada campo! (números/algarismos)", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para alterar os dados de um Evento selecionado
        private void buttonAlterarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                // Para ir buscar a formatação dataHora
                DateTime data = dateTimePickerDataEvento.Value;
                String horaEvento = tbHoraEvento.Text;

                int hora = Convert.ToInt32(horaEvento.Substring(0, 2));
                int minutos = Convert.ToInt32(horaEvento.Substring(7, 2));

                DateTime dataHora = new DateTime(
                    data.Year,
                    data.Month,
                    data.Day,
                    hora,
                    minutos,
                    0,
                    0
                    );

                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    eventoSelecionado.TipoEvento = tbTipoEvento.Text;
                    eventoSelecionado.Descricao = tbDescricaoEvento.Text;
                    eventoSelecionado.Local = tbLocalEvento.Text;
                    eventoSelecionado.DataHora = dataHora;
                    eventoSelecionado.LimiteParticipacao = (Int32)numericUpDownLimite.Value;
                    eventoSelecionado.IdadeInferior = (Int32)numericUpDownIdadeInferior.Value;
                    eventoSelecionado.IdadeSuperior = (Int32)numericUpDownIdadeSuperior.Value;

                    bookidsContainer.SaveChanges();

                    carregaTodosEventos();

                    limparDadosEvento();

                    if (contaConfirmacoes(eventoSelecionado) < eventoSelecionado.LimiteParticipacao)
                    {
                        checkedListBoxFilhos.Enabled = true;
                    }
                    else
                    {
                        checkedListBoxFilhos.Enabled = false;
                    }

                    MessageBox.Show("Dados do Evento alterados com sucesso!", "Informação", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o Evento para alterar os seus dados!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para apagar um Evento
        private void buttonApagarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    if (MessageBox.Show("Este evento puderá conter algo associado. Para apagar terá que remover tudo o que está associado.\nMesmo assim quer tentar apagar o evento?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bookidsContainer.EventosSet.Remove(eventoSelecionado);

                        bookidsContainer.SaveChanges();

                        carregaTodosEventos();

                        limparDadosEvento();

                        MessageBox.Show("Evento apagado com sucesso!", "Informação", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível apagar o evento!", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Selecione primeiro o Evento que pretende apagar!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Mostrar dados de um Evento selecionado
        private void listViewEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    tbTipoEvento.Text = eventoSelecionado.TipoEvento;
                    tbDescricaoEvento.Text = eventoSelecionado.Descricao;
                    tbLocalEvento.Text = eventoSelecionado.Local;
                    dateTimePickerDataEvento.Value = eventoSelecionado.DataHora;
                    tbHoraEvento.Text = Convert.ToDateTime(Convert.ToString(eventoSelecionado.DataHora)).ToString("hh:mm");
                    numericUpDownLimite.Value = eventoSelecionado.LimiteParticipacao;
                    numericUpDownIdadeInferior.Value = eventoSelecionado.IdadeInferior;
                    numericUpDownIdadeSuperior.Value = eventoSelecionado.IdadeSuperior;

                    listBoxEscolas.DataSource = eventoSelecionado.Participacoes.ToList<Participacoes>();
                    listBoxAnimadores.DataSource = eventoSelecionado.Colaboracoes.ToList<Colaboracoes>();

                    carregaListaInscricoes(eventoSelecionado);
                    
                    labelTotalConfirmacoes.Text = "Número de confirmações: " + contaConfirmacoes(eventoSelecionado);

                    if (contaConfirmacoes(eventoSelecionado) < eventoSelecionado.LimiteParticipacao)
                    {
                        checkedListBoxFilhos.Enabled = true;
                    }
                    else
                    {
                        checkedListBoxFilhos.Enabled = false;
                    }
                }
            }
            catch
            {
            }
        }

        private void carregaListaInscricoes(Eventos eventoSelecionado)
        {
            List<Inscricoes> listaInscricoes = eventoSelecionado.Inscricoes.ToList<Inscricoes>();
            checkedListBoxFilhos.Items.Clear();
            foreach (Inscricoes i in listaInscricoes)
            {
                checkedListBoxFilhos.Items.Add(i, i.Confirmada);
                
            }
        }



        // <------------ Participações ------------>

        // Para adicionar a participação de uma escola
        private void buttonAdicionarEscola_Click(object sender, EventArgs e)
        {
            try
            {
                
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    if (!participa(eventoSelecionado, ((Escolas)cbEscolas.SelectedItem)))
                    {
                        Participacoes nova = new Participacoes()
                        {
                            IdEscola = ((Escolas)cbEscolas.SelectedItem).IdEscola,
                            NrEvento = eventoSelecionado.NrEvento
                        };
                    
                        if (cbEscolas.Text == "")
                        {
                            cbEscolas.Focus();
                            return;
                        }
                        else
                        {
                            bookidsContainer.ParticipacoesSet.Add(nova);
                            bookidsContainer.SaveChanges();
                            listBoxEscolas.DataSource = eventoSelecionado.Participacoes.ToList<Participacoes>();
                            MessageBox.Show("Participação adicionada com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Essa Participação já foi adicionada!", "Informação", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar o Evento que pretende fazer modificações!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Função que permite verificar se já existe essa participação
        private bool participa(Eventos eventoSelecionado, Escolas escola)
        {
            var participacao = (from p in bookidsContainer.ParticipacoesSet
                                where p.IdEscola == escola.IdEscola && p.NrEvento == eventoSelecionado.NrEvento
                                select p).ToList();
            if (participacao.Count == 0)
            {
                return false;
            }

            return true;
        }

        // Para eliminar a participação de uma escola
        private void buttonApagarEscola_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    Participacoes participacaoSelecionada = (Participacoes)listBoxEscolas.SelectedItem;
                    if (participacaoSelecionada != null)
                    {
                        bookidsContainer.ParticipacoesSet.Remove(participacaoSelecionada);

                        bookidsContainer.SaveChanges();

                        listBoxEscolas.DataSource = eventoSelecionado.Participacoes.ToList<Participacoes>();

                        MessageBox.Show("Participação apagada com sucesso!", "Informação", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar a Participação que pretende apagar!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para abrir o formulário das escolas e adicionar uma nova
        private void buttonMaisEscolas_Click(object sender, EventArgs e)
        {
            FormularioEscolas formEscolas = new FormularioEscolas();
            formEscolas.ShowDialog();
        }



        // <--------------- Colaborações --------------->

        // Para adicionar uma colaboração de um Animador
        private void buttonAdicionarAnimador_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    if (!colabora(eventoSelecionado, ((Animadores)cbAnimadores.SelectedItem)))
                    {
                        if (cbAnimadores.Text == "")
                        {
                            cbAnimadores.Focus();
                            return;
                        }
                        else
                        {
                            Colaboracoes nova = new Colaboracoes()
                            {
                                IdAnimador = ((Animadores)cbAnimadores.SelectedItem).IdPessoa,
                                NrEvento = eventoSelecionado.NrEvento
                            };

                            bookidsContainer.ColaboracoesSet.Add(nova);
                            bookidsContainer.SaveChanges();
                            listBoxAnimadores.DataSource = eventoSelecionado.Colaboracoes.ToList<Colaboracoes>();
                            MessageBox.Show("Colaboração adicionada com sucesso!", "Informação", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Essa Colaboração já foi adicionada!", "Informação", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar o Evento que pretende fazer modificações!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Função que permite verificar se já existe essa colaboração
        private bool colabora(Eventos eventoSelecionado, Animadores animador)
        {
            var colaboracao = (from p in bookidsContainer.ColaboracoesSet
                                where p.IdAnimador == animador.IdPessoa && p.NrEvento == eventoSelecionado.NrEvento
                                select p).ToList();
            if (colaboracao.Count == 0)
            {
                return false;
            }

            return true;
        }

        // Para eliminar a colaboração de um Animador
        private void buttonApagarAnimador_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    Colaboracoes colaboracaoSelecionada = (Colaboracoes)listBoxAnimadores.SelectedItem;
                    if (colaboracaoSelecionada != null)
                    {
                        bookidsContainer.ColaboracoesSet.Remove(colaboracaoSelecionada);

                        bookidsContainer.SaveChanges();

                        listBoxAnimadores.DataSource = eventoSelecionado.Colaboracoes.ToList<Colaboracoes>();

                        MessageBox.Show("Colaboração apagada com sucesso!", "Informação", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar a Colaboração que pretende fazer modificações!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Para abrir o formulário dos Animadores, caso queira registar um novo
        private void buttonMaisAnimadores_Click(object sender, EventArgs e)
        {
            FormularioAnimadores formAnimadores = new FormularioAnimadores();
            formAnimadores.ShowDialog();
        }



        // <--------------- Inscrições --------------->
        
        // Para increver um filho num Evento
        private void buttonInscrever_Click(object sender, EventArgs e)
        {
            try
            { 
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                if (eventoSelecionado != null)
                {
                    Filhos filhoSelecionado = (Filhos)cbFilhos.SelectedItem;
                    if (filhoSelecionado.Idade() > eventoSelecionado.IdadeInferior && filhoSelecionado.Idade() < eventoSelecionado.IdadeSuperior)
                    {
                        if (!inscrito(eventoSelecionado, ((Filhos)cbFilhos.SelectedItem)))
                        {
                            if (cbFilhos.Text == "")
                            {
                                cbFilhos.Focus();
                                return;
                            }
                            else
                            {
                                Inscricoes nova = new Inscricoes()
                                {
                                    Confirmada = false,
                                    IdFilho = ((Filhos)cbFilhos.SelectedItem).IdPessoa,
                                    NrEvento = eventoSelecionado.NrEvento
                                };

                                bookidsContainer.InscricoesSet.Add(nova);
                                bookidsContainer.SaveChanges();
                                checkedListBoxFilhos.DataSource = eventoSelecionado.Inscricoes.ToList<Inscricoes>();
                                MessageBox.Show("Inscrição adicionada com sucesso!", "Informação", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esse Filho já foi inscrito!", "Informação", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esse Filho não tem idade para o evento!", "Informação", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Certifique-se de selecionar o Evento que pretende fazer modificações, ou, verifique se esse Filho já foi inscrito!", "Aviso", MessageBoxButtons.OK);
            }
        }

        // Função que permite verificar se já existe essa inscrição
        private bool inscrito(Eventos eventoSelecionado, Filhos filho)
        {
            var inscrito = (from p in bookidsContainer.InscricoesSet
                               where p.IdFilho == filho.IdPessoa && p.NrEvento == eventoSelecionado.NrEvento
                               select p).ToList();
            if (inscrito.Count == 0)
            {
                return false;
            }

            return true;
        }

        // Para registar um filho caso nao o tenho feito
        private void buttonMaisFilhos_Click(object sender, EventArgs e)
        {
            FormularioClientesFilhos formularioClientesFilhos = new FormularioClientesFilhos();
            formularioClientesFilhos.ShowDialog();
        }

        private void checkedListBoxFilhos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;
                checkedListBoxFilhos.Enabled = true;
                Inscricoes inscricaoSelecionada = (Inscricoes)checkedListBoxFilhos.SelectedItem;
                if (inscricaoSelecionada != null)
                {
                    inscricaoSelecionada.Confirmada = !inscricaoSelecionada.Confirmada;

                    bookidsContainer.SaveChanges();

                    labelTotalConfirmacoes.Text = "Numero de confirmações: " + contaConfirmacoes(eventoSelecionado);
                    
                    if (contaConfirmacoes(eventoSelecionado) >= eventoSelecionado.LimiteParticipacao)
                    {
                        MessageBox.Show("As confirmações chegaram ao limite!", "Informação", MessageBoxButtons.OK);
                        checkedListBoxFilhos.Enabled = false;
                    }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Permite fazer a contagem do número de inscrições do evento selecionado
        /// </summary>
        /// <returns></returns>
        private int contaConfirmacoes(Eventos eventoSelecionado)
        {
            List<Inscricoes> listaInscricoes = new List<Inscricoes>();
            listaInscricoes = eventoSelecionado.Inscricoes.ToList<Inscricoes>();

            int contagem = 0;

            foreach (Inscricoes i in listaInscricoes)
            {
                if (i.Confirmada == true)
                {
                    contagem++;
                }
            }

            return contagem;
        }

        private void buttonRetirarInscricao_Click(object sender, EventArgs e)
        {
            checkedListBoxFilhos.Enabled = true;
        }


        // <---------------------- Menu ---------------------->

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparDadosEvento();
        }

        private void listaDeInscriçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;

                saveFileDialog_Save.FileName = "ListaInscricoes_" + eventoSelecionado.Descricao + ".pdf";
                saveFileDialog_Save.Filter = "All files (*.*)|*.*";
                saveFileDialog_Save.FilterIndex = 0;

                if (saveFileDialog_Save.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    doc.SetMargins(60, 60, 30, 30);

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog_Save.FileName, FileMode.Create));

                    doc.Open();

                    //Font fontH1 = new Font(Currier, 16, Font.Bold);

                    // <---------------- Título ---------------->

                    Paragraph titulo = new Paragraph("Lista de Inscrições\n");
                    titulo.Alignment = Element.TITLE;


                    // <---------------- Informações sobre o Evento ---------------->

                    Paragraph evento = new Paragraph("\n\nEvento: " + eventoSelecionado.Descricao);
                    Paragraph local = new Paragraph("Local: " + eventoSelecionado.Local);
                    Paragraph data = new Paragraph(string.Format("Data: {0:dd} de {0:MMMM} de {0:yyyy}", eventoSelecionado.DataHora));
                    Paragraph hora = new Paragraph(string.Format("Hora: {0:HH:mm:ss}", eventoSelecionado.DataHora));
                    Paragraph limite = new Paragraph("Limite de Participação: " + eventoSelecionado.LimiteParticipacao + " crianças");
                    Paragraph idadeInf = new Paragraph("Idade Mínima: " + eventoSelecionado.IdadeInferior + " anos");
                    Paragraph idadeSup = new Paragraph("Idade Máxima: " + eventoSelecionado.IdadeSuperior + " anos\n\n\n\n");

                    evento.Alignment = Element.ALIGN_JUSTIFIED;
                    local.Alignment = Element.ALIGN_JUSTIFIED;
                    data.Alignment = Element.ALIGN_JUSTIFIED;
                    hora.Alignment = Element.ALIGN_JUSTIFIED;
                    limite.Alignment = Element.ALIGN_JUSTIFIED;
                    idadeInf.Alignment = Element.ALIGN_JUSTIFIED;
                    idadeSup.Alignment = Element.ALIGN_JUSTIFIED;


                    // <---------------- Tabela ---------------->

                    PdfPTable table = new PdfPTable(5);


                    Paragraph coluna1 = new Paragraph("Nome");
                    Paragraph coluna2 = new Paragraph("Idade");
                    Paragraph coluna3 = new Paragraph("Responsável");
                    Paragraph coluna4 = new Paragraph("Telefone");
                    Paragraph coluna5 = new Paragraph("Telemóvel");

                    coluna1.Alignment = Element.ALIGN_CENTER;
                    coluna2.Alignment = Element.ALIGN_CENTER;
                    coluna3.Alignment = Element.ALIGN_CENTER;
                    coluna4.Alignment = Element.ALIGN_CENTER;
                    coluna5.Alignment = Element.ALIGN_CENTER;


                    var cell1 = new PdfPCell();
                    var cell2 = new PdfPCell();
                    var cell3 = new PdfPCell();
                    var cell4 = new PdfPCell();
                    var cell5 = new PdfPCell();

                    cell1.AddElement(coluna1);
                    cell2.AddElement(coluna2);
                    cell3.AddElement(coluna3);
                    cell4.AddElement(coluna4);
                    cell5.AddElement(coluna5);

                    table.AddCell(cell1);
                    table.AddCell(cell2);
                    table.AddCell(cell3);
                    table.AddCell(cell4);
                    table.AddCell(cell5);

                    foreach (Inscricoes i in eventoSelecionado.Inscricoes.ToList<Inscricoes>())
                    {
                        Phrase nome = new Phrase(i.Filhos.Nome);
                        var cell = new PdfPCell(nome);
                        table.AddCell(cell);

                        Phrase idade = new Phrase(Convert.ToString(i.Filhos.Idade()));
                        cell = new PdfPCell(idade);
                        table.AddCell(cell);

                        Phrase responsavel = new Phrase(i.Filhos.Clientes.Nome);
                        cell = new PdfPCell(responsavel);
                        table.AddCell(cell);

                        Phrase telefone = new Phrase(i.Filhos.Telefone);
                        cell = new PdfPCell(telefone);
                        table.AddCell(cell);

                        Phrase telemovel = new Phrase(i.Filhos.Telemovel);
                        cell = new PdfPCell(telemovel);
                        table.AddCell(cell);
                    }


                    // <---------------- Adicionar os dados todos ao documento ---------------->

                    doc.Add(titulo);
                    doc.Add(evento);
                    doc.Add(local);
                    doc.Add(data);
                    doc.Add(hora);
                    doc.Add(limite);
                    doc.Add(idadeInf);
                    doc.Add(idadeSup);
                    doc.Add(table);

                    doc.Close();

                    MessageBox.Show("Lista de Inscrições guardada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Selecione o evento primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fichaDeInscriçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Eventos eventoSelecionado = (Eventos)listViewEventos.SelectedItems[0].Tag;

                saveFileDialog_FichaInscricao.FileName = "FichaInscricoes_" + eventoSelecionado.Descricao + ".pdf";
                saveFileDialog_FichaInscricao.Filter = "All files (*.*)|*.*";
                saveFileDialog_FichaInscricao.FilterIndex = 0;

                if (saveFileDialog_FichaInscricao.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    doc.SetMargins(60, 60, 30, 30);

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog_FichaInscricao.FileName, FileMode.Create));

                    doc.Open();


                    // <---------------- Título ---------------->

                    Paragraph titulo = new Paragraph("Ficha de Inscrição\n");
                    titulo.Alignment = Element.TITLE;


                    // <---------------- Informações sobre o Evento ---------------->

                    Paragraph evento = new Paragraph("\n\nEvento: " + eventoSelecionado.Descricao);
                    Paragraph local = new Paragraph("Local: " + eventoSelecionado.Local);
                    Paragraph data = new Paragraph(string.Format("Data: {0:dd} de {0:MMMM} de {0:yyyy}", eventoSelecionado.DataHora));
                    Paragraph hora = new Paragraph(string.Format("Hora: {0:HH:mm:ss}", eventoSelecionado.DataHora));
                    Paragraph limite = new Paragraph("Limite de Participação: " + eventoSelecionado.LimiteParticipacao + " crianças");
                    Paragraph idadeInf = new Paragraph("Idade Mínima: " + eventoSelecionado.IdadeInferior + " anos");
                    Paragraph idadeSup = new Paragraph("Idade Máxima: " + eventoSelecionado.IdadeSuperior + " anos\n\n\n\n");

                    evento.Alignment = Element.ALIGN_JUSTIFIED;
                    local.Alignment = Element.ALIGN_JUSTIFIED;
                    data.Alignment = Element.ALIGN_JUSTIFIED;
                    hora.Alignment = Element.ALIGN_JUSTIFIED;
                    limite.Alignment = Element.ALIGN_JUSTIFIED;
                    idadeInf.Alignment = Element.ALIGN_JUSTIFIED;
                    idadeSup.Alignment = Element.ALIGN_JUSTIFIED;

                    Paragraph paragrafo1 = new Paragraph("Aceita que  o seu filho participe neste evento\n");
                    Paragraph paragrafo2 = new Paragraph("   Sim\n   Não\n");
                    Paragraph paragrafo3 = new Paragraph("Se responder sim preencha as inofrmações do filho que se seguem.\n\n\n");

                    Paragraph paragrafofilho = new Paragraph("Informação do filho");
                    Paragraph paragrafonomefilho = new Paragraph("Nome:_________________________________________________________\n");
                    Paragraph paragrafodatanascmentofilho = new Paragraph("Data Nascimento:____/____/______\n");
                    Paragraph paragrafoescolafilho = new Paragraph("Escola:_________________________________________________________\n\n\n\n");


                    Paragraph paragrafo4 = new Paragraph("Se ainda não for cliente da loja, por favor, preencha os dados que se seguem.\n\n");
                    
                    Paragraph paragrafocliente = new Paragraph("Informação do cliente");
                    Paragraph paragrafonomecliente = new Paragraph("Nome:________________________________________________________\n");
                    Paragraph paragrafomoradacliente = new Paragraph("Morada:_______________________________________________________\n");
                    Paragraph paragrafolocalidadecliente = new Paragraph("Localidade:________________________________  Codigo Postal: ____-___\n");
                    Paragraph paragrafotelefonecliente = new Paragraph("Telefone: ___ ___ ___\n");
                    Paragraph paragrafotelemovelcliente = new Paragraph("Telemóvel: ___ ___ ___\n");
                    Paragraph paragrafomailcliente = new Paragraph("Mail:__________________________________________________________\n");
                    


                    // <---------------- Adicionar os dados todos ao documento ---------------->

                    doc.Add(titulo);
                    doc.Add(evento);
                    doc.Add(local);
                    doc.Add(data);
                    doc.Add(hora);
                    doc.Add(limite);
                    doc.Add(idadeInf);
                    doc.Add(idadeSup);
                    doc.Add(paragrafo1);
                    doc.Add(paragrafo2);
                    doc.Add(paragrafo3);
                    doc.Add(paragrafofilho);
                    doc.Add(paragrafonomefilho);
                    doc.Add(paragrafodatanascmentofilho);
                    doc.Add(paragrafoescolafilho);
                    doc.Add(paragrafo4);
                    doc.Add(paragrafocliente);
                    doc.Add(paragrafonomecliente);
                    doc.Add(paragrafomoradacliente);
                    doc.Add(paragrafolocalidadecliente);

                    doc.Add(paragrafotelefonecliente);
                    doc.Add(paragrafotelemovelcliente);
                    doc.Add(paragrafomailcliente);

                    doc.Close();

                    MessageBox.Show("Lista de Inscrições guardada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("Selecione o evento primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}





