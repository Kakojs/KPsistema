namespace KPsistema
{
    partial class FormDadosClientes
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            Numero = new TextBox();
            label6Numero = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 33);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 94);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Endereço";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(725, 426);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(644, 426);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(240, 51);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(145, 23);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 33);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "CNPJ";
            label5.Click += label5_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(404, 51);
            maskedTextBox2.Mask = "00.000.000/0000-00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(145, 23);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // Numero
            // 
            Numero.Location = new Point(240, 112);
            Numero.Name = "Numero";
            Numero.Size = new Size(201, 23);
            Numero.TabIndex = 14;
            Numero.TextChanged += Numero_TextChanged;
            // 
            // label6Numero
            // 
            label6Numero.AutoSize = true;
            label6Numero.Location = new Point(240, 94);
            label6Numero.Name = "label6Numero";
            label6Numero.Size = new Size(51, 15);
            label6Numero.TabIndex = 13;
            label6Numero.Text = "Numero";
            label6Numero.Click += label6_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(586, 51);
            maskedTextBox3.Mask = "(000)0000-00000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(202, 23);
            maskedTextBox3.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(586, 33);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 16;
            label9.Text = "Telefone";
            label9.Click += label9_Click;
            // 
            // FormDadosClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(maskedTextBox3);
            Controls.Add(Numero);
            Controls.Add(label6Numero);
            Controls.Add(maskedTextBox2);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDadosClientes";
            Text = "FormDadosClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private TextBox Numero;
        private Label label6Numero;
        private MaskedTextBox maskedTextBox3;
        private Label label9;
    }
}