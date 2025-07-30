using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KPsistema
{

    public partial class FormDadosClientes : Form
    {
        private int clienteId = -1;
        public FormDadosClientes()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza
            this.WindowState = FormWindowState.Normal;

        }

        ///aqui serve para alterar o cliente já existente, passando os dados do cliente para o formulário.
        public FormDadosClientes(int id, string nome, string cpf, string cnpj, string telefone, string endereco, string numero)
            : this()
        {
            clienteId = id;
            textBox1.Text = nome;
            maskedTextBox1.Text = cpf;
            maskedTextBox2.Text = cnpj;
            maskedTextBox3.Text = telefone;
            textBox4.Text = endereco;
            Numero.Text = numero;
        }


        /// <summary>
        /// botão para salvar os dados do cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string cpf = maskedTextBox1.Text.Trim();
            string cnpj = maskedTextBox2.Text.Trim();
            string telefone = maskedTextBox3.Text.Trim();
            string endereco = textBox4.Text.Trim();
            string numero = Numero.Text.Trim();

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=supadm;Database=KPsistema";

            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql;

                    if (clienteId == -1) // Novo cliente, faz INSERT
                    {
                        sql = @"INSERT INTO clientes (nome, cpf, cnpj, telefone, endereco, numero) 
                        VALUES (@nome, @cpf, @cnpj, @telefone, @endereco, @numero)";
                    }
                    else // Cliente existente, faz UPDATE
                    {
                        sql = @"UPDATE clientes SET 
                            nome = @nome,
                            cpf = @cpf,
                            cnpj = @cnpj,
                            telefone = @telefone,
                            endereco = @endereco,
                            numero = @numero
                        WHERE id = @id";
                    }

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@numero", numero);

                        if (clienteId != -1)
                        {
                            cmd.Parameters.AddWithValue("@id", clienteId);
                        }

                        cmd.ExecuteNonQuery();

                        if (clienteId == -1)
                            MessageBox.Show("Cliente cadastrado com sucesso!");
                        else
                            MessageBox.Show("Cliente atualizado com sucesso!");

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Botão para cancelar a operação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário ao clicar em Cancelar
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
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
