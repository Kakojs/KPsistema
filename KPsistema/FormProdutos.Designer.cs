﻿namespace KPsistema
{
    partial class FormProdutos
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
            Incluir = new Button();
            SuspendLayout();
            // 
            // Incluir
            // 
            Incluir.Location = new Point(5, 39);
            Incluir.Name = "Incluir";
            Incluir.Size = new Size(70, 25);
            Incluir.TabIndex = 0;
            Incluir.Text = "Incluir";
            Incluir.UseVisualStyleBackColor = true;
            Incluir.Click += Incluir_Click;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Incluir);
            Name = "FormProdutos";
            Text = "FormProdutos";
            Load += FormProdutos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Incluir;
    }
}