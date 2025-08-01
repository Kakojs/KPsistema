using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace KPsistema

{

    public partial class FormClientes : Form
    {
        public FormDadosClientes FormDadosClientes { get; private set; }
        public Button ExitButton { get; private set; }

        public FormClientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CarregarClientes();
        }


        #region Tabela onde exibe os clientes
        private void CarregarClientes()
        {
            // String de conexão com o PostgreSQL — lembre-se de trocar os dados para os seus
            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=supadm;Database=KPsistema";
            using (var conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM clientes";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;

                        // Oculta a coluna "id"
                        if (dataGridView1.Columns.Contains("id"))
                        {
                            dataGridView1.Columns["id"].Visible = false;
                        }

                        
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Remove a linha em branco no final (linha de novo registro)
                        dataGridView1.AllowUserToAddRows = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }
        }
        #endregion

        #region Botoes de açoes da tela de clientes 


        // botao de inclusão de clientes
        private void Incluir_Click(object sender, EventArgs e)
        {
            
            // Cria uma nova instância do DadosClientes
            FormDadosClientes = new FormDadosClientes();

            // Exibe o DadosClientes
            FormDadosClientes.ShowDialog(); // ShowDialog() abre o form de forma modal
            CarregarClientes(); // Recarrega a lista de clientes após fechar o formulário
        }


        //botao de alteração de clientes
        private void Alterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["id"].Value);
                string nome = row.Cells["nome"].Value.ToString();
                string cpf = row.Cells["cpf"].Value.ToString();
                string cnpj = row.Cells["cnpj"].Value.ToString();
                string telefone = row.Cells["telefone"].Value.ToString();
                string endereco = row.Cells["endereco"].Value.ToString();
                string numero = row.Cells["numero"].Value.ToString();

                FormDadosClientes form = new FormDadosClientes(id, nome, cpf, cnpj, telefone, endereco, numero);
                form.ShowDialog();
                CarregarClientes(); // Atualiza a grade após edição
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }

        }
        //botao de remoção de clientes
        private void Remover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o ID do cliente selecionado
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int idCliente = Convert.ToInt32(row.Cells["id"].Value);

                DialogResult confirm = MessageBox.Show("Tem certeza que deseja remover este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    string connStr = "Host=localhost;Port=5432;Username=postgres;Password=supadm;Database=KPsistema";
                    using (var conn = new NpgsqlConnection(connStr))
                    {
                        try
                        {
                            conn.Open();
                            string sql = "DELETE FROM clientes WHERE id = @id";
                            using (var cmd = new NpgsqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("id", idCliente);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Cliente removido com sucesso!");
                            CarregarClientes(); // Atualiza a lista
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao remover cliente: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.");
            }
        }
        //Botao de sair da tela de clientes
        private void button4_Click(object sender, EventArgs e)
        {
            CancelButton = button4;
        }
        #endregion


        //Seria minha "tabela" que exibe os clientes consumindo os dados do banco de dados;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    

}
