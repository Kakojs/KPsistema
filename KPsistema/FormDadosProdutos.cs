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

        private void FormDadosProdutos_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}
