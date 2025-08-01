namespace KPsistema
{
    partial class FormDadosProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1Codigo = new Label();
            textBox1Codigo = new TextBox();
            Salvar = new Button();
            Cancelar = new Button();
            Descricao = new Label();
            CampoDescricao = new TextBox();
            PrecoVenda = new Label();
            CampoPrecoVenda = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1Codigo
            // 
            label1Codigo.AutoSize = true;
            label1Codigo.Location = new Point(47, 38);
            label1Codigo.Name = "label1Codigo";
            label1Codigo.Size = new Size(46, 15);
            label1Codigo.TabIndex = 0;
            label1Codigo.Text = "Código";
            label1Codigo.Click += label1Codigo_Click;
            // 
            // textBox1Codigo
            // 
            textBox1Codigo.Location = new Point(47, 56);
            textBox1Codigo.Name = "textBox1Codigo";
            textBox1Codigo.ReadOnly = true;
            textBox1Codigo.Size = new Size(100, 23);
            textBox1Codigo.TabIndex = 1;
            textBox1Codigo.TextChanged += textBox1Codigo_TextChanged;
            // 
            // Salvar
            // 
            Salvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Salvar.Location = new Point(632, 415);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(75, 23);
            Salvar.TabIndex = 11;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancelar.Location = new Point(713, 415);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 10;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Location = new Point(204, 38);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(58, 15);
            Descricao.TabIndex = 12;
            Descricao.Text = "Descriçao";
            Descricao.Click += Descricao_Click;
            // 
            // CampoDescricao
            // 
            CampoDescricao.Location = new Point(204, 56);
            CampoDescricao.Name = "CampoDescricao";
            CampoDescricao.Size = new Size(100, 23);
            CampoDescricao.TabIndex = 13;
            CampoDescricao.TextChanged += CampoDescricao_TextChanged;
            // 
            // PrecoVenda
            // 
            PrecoVenda.AutoSize = true;
            PrecoVenda.Location = new Point(378, 38);
            PrecoVenda.Name = "PrecoVenda";
            PrecoVenda.Size = new Size(88, 15);
            PrecoVenda.TabIndex = 14;
            PrecoVenda.Text = "Preco de Venda";
            PrecoVenda.Click += PrecoVenda_Click;
            // 
            // CampoPrecoVenda
            // 
            CampoPrecoVenda.Location = new Point(378, 56);
            CampoPrecoVenda.Name = "CampoPrecoVenda";
            CampoPrecoVenda.Size = new Size(100, 23);
            CampoPrecoVenda.TabIndex = 15;
            CampoPrecoVenda.MaskInputRejected += CampoPrecoVenda_MaskInputRejected;
            // 
            // FormDadosProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CampoPrecoVenda);
            Controls.Add(PrecoVenda);
            Controls.Add(CampoDescricao);
            Controls.Add(Descricao);
            Controls.Add(Salvar);
            Controls.Add(Cancelar);
            Controls.Add(textBox1Codigo);
            Controls.Add(label1Codigo);
            Name = "FormDadosProdutos";
            Text = "FormDadosProdutos";
            Load += FormDadosProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1Codigo;
        private TextBox textBox1Codigo;
        private Button Salvar;
        private Button Cancelar;
        private Label Descricao;
        private TextBox CampoDescricao;
        private Label PrecoVenda;
        private MaskedTextBox CampoPrecoVenda;
    }
}