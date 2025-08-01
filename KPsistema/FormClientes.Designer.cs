namespace KPsistema
{
    partial class FormClientes
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(8, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Incluir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 49);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 1;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Alterar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 82);
            button3.Name = "button3";
            button3.Size = new Size(75, 29);
            button3.TabIndex = 2;
            button3.Text = "Remover";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Remover_Click;
            // 
            // button4
            // 
            button4.Location = new Point(8, 117);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Sair";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 437);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormClientes";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}