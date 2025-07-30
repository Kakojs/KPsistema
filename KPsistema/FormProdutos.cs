using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPsistema
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            // Configurações iniciais do formulário de produtos
            this.WindowState = FormWindowState.Maximized; // Maximiza o formulário ao abrir
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
                FormDadosProdutos formDadosProdutos = new FormDadosProdutos();  
                formDadosProdutos.ShowDialog(); // Exibe o formulário de dados de produtos de forma modal
        }
    }
}
