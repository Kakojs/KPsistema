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
    public partial class FormDadosClientes : Form
    {
        public FormDadosClientes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza
            this.WindowState = FormWindowState.Normal;
        }


        /// <summary>
        /// botão para salvar os dados do cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Salvar Dados do Cliente"
            };
        }

        /// <summary>
        /// Botão para cancelar a operação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CancelButton = button1; // Define o botão Cancelar como o botão de cancelamento do formulário
        }


        /// <summary>
        /// São os métodos de eventos para os controles do formulário.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        //Nome
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //CPF
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        //CNPJ
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       //telefone
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Endereço
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Numero
        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }

        //nome do cliente
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //CPF do cliente
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //telefone
        private void label3_Click(object sender, EventArgs e)
        {

        }
        //endereço do cliente
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //cnpj do cliente
        private void label5_Click(object sender, EventArgs e)
        {

        }
        //numero da casa do cliente
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
