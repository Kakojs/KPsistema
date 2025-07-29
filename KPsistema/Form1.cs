namespace KPsistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do FormClientes
            FormClientes formClientes = new FormClientes();

            // Exibe o FormClientes
            formClientes.ShowDialog(); // ShowDialog() abre o form de forma modal
        }
    }
}
