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
    public partial class FormDadosProdutos : Form
    {
        public FormDadosProdutos()
        {
            InitializeComponent();
        }

        public AutoCompleteMode AutoCompleteMode { get; private set; }

        private void FormDadosProdutos_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void Salvar_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário ao clicar em Cancelar
        }

        //Aqui em diante sera inserido em ordem, label e abaixo seu devido campo separado por linha

        private void label1Codigo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1Codigo_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        //-------------------------------------------------------------
        private void Descricao_Click(object sender, EventArgs e)
        {

        }

        private void CampoDescricao_TextChanged(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------
        private void PrecoVenda_Click(object sender, EventArgs e)
        {

        }

        private void CampoPrecoVenda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        //-------------------------------------------------------------
    }
}
