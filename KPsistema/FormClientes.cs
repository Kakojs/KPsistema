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
    public partial class FormClientes : Form
    {
        public FormDadosClientes FormDadosClientes { get; private set; }

        public FormClientes()
        {
            InitializeComponent();
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do DadosClientes
            FormDadosClientes = new FormDadosClientes();

            // Exibe o DadosClientes
            FormDadosClientes.ShowDialog(); // ShowDialog() abre o form de forma modal
        }

        private void Alterar_Click(object sender, EventArgs e)
        {

        }

        private void Remover_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CancelButton = button4; // Define o botão Cancelar como o botão de cancelamento do formulário
        }
    }
}
