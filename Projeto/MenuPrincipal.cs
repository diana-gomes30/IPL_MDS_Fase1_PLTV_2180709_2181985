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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonClientesFilhos_Click(object sender, EventArgs e)
        {
            FormularioClientesFilhos formClientesFilhos = new FormularioClientesFilhos();
            formClientesFilhos.Show();
        }

        private void buttonVendasProdutos_Click(object sender, EventArgs e)
        {
            FormularioVendaProdutos formVendaProdutos = new FormularioVendaProdutos();
            formVendaProdutos.Show();
        }

        private void buttonEventos_Click(object sender, EventArgs e)
        {
            FormularioEventos formEventos = new FormularioEventos();
            formEventos.Show();
        }

        private void buttonProdutosVendidosLoja_Click(object sender, EventArgs e)
        {
            FormularioProdutosVendidosLoja formProdutosVendidosLoja = new FormularioProdutosVendidosLoja();
            formProdutosVendidosLoja.Show();
        }

        private void buttonEscolas_Click(object sender, EventArgs e)
        {
            FormularioEscolas formEscolas = new FormularioEscolas();
            formEscolas.Show();
        }

        private void buttonAnimadores_Click(object sender, EventArgs e)
        {
            FormularioAnimadores formAnimadores = new FormularioAnimadores();
            formAnimadores.Show();
        }
    }
}
