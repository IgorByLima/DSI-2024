namespace BDEXEMPLO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtGridAluno = new DataGridView();
            btnIncluir = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnConsultar = new Button();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridAluno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 38);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(232, 146);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(152, 45);
            txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(232, 234);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(533, 45);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 234);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(59, 24);
            label3.Name = "label3";
            label3.Size = new Size(706, 63);
            label3.TabIndex = 4;
            label3.Text = "Exemplo CRUD(Create, Read, Update, Delete)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtGridAluno
            // 
            dtGridAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridAluno.Location = new Point(88, 410);
            dtGridAluno.Name = "dtGridAluno";
            dtGridAluno.RowHeadersWidth = 62;
            dtGridAluno.Size = new Size(626, 225);
            dtGridAluno.TabIndex = 5;
            dtGridAluno.DoubleClick += dtGridAluno_DoubleClick;
            // 
            // btnIncluir
            // 
            btnIncluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIncluir.BackColor = SystemColors.ActiveCaption;
            btnIncluir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnIncluir.Location = new Point(88, 328);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(139, 54);
            btnIncluir.TabIndex = 6;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.BackColor = SystemColors.ActiveCaption;
            btnExcluir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnExcluir.Location = new Point(575, 328);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(139, 54);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAlterar.BackColor = SystemColors.ActiveCaption;
            btnAlterar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAlterar.Location = new Point(421, 328);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(139, 54);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConsultar.BackColor = SystemColors.ActiveCaption;
            btnConsultar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConsultar.Location = new Point(246, 328);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(153, 54);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPesquisar.BackColor = SystemColors.ActiveCaption;
            btnPesquisar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPesquisar.Location = new Point(421, 137);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(153, 54);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 647);
            Controls.Add(btnPesquisar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(dtGridAluno);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = ":. EXEMPLO CRUD.:";
            ((System.ComponentModel.ISupportInitialize)dtGridAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridAluno;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

