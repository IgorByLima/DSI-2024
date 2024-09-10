namespace conversorMoedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            cbbpara = new ComboBox();
            cbbde = new ComboBox();
            txtconvertido = new TextBox();
            txtvalor = new TextBox();
            lblde = new Label();
            lblconvertido = new Label();
            lblpara = new Label();
            lblvalor = new Label();
            lbltitle = new Label();
            btnsair = new Button();
            btnnovo = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DarkBlue;
            splitContainer1.Panel1.Controls.Add(cbbpara);
            splitContainer1.Panel1.Controls.Add(cbbde);
            splitContainer1.Panel1.Controls.Add(txtconvertido);
            splitContainer1.Panel1.Controls.Add(txtvalor);
            splitContainer1.Panel1.Controls.Add(lblde);
            splitContainer1.Panel1.Controls.Add(lblconvertido);
            splitContainer1.Panel1.Controls.Add(lblpara);
            splitContainer1.Panel1.Controls.Add(lblvalor);
            splitContainer1.Panel1.Controls.Add(lbltitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnsair);
            splitContainer1.Panel2.Controls.Add(btnnovo);
            splitContainer1.Size = new Size(371, 316);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 0;
            // 
            // cbbpara
            // 
            cbbpara.FormattingEnabled = true;
            cbbpara.Items.AddRange(new object[] { "EURO", "DOLAR", "REAL ", "PESO", "SELECIONE" });
            cbbpara.Location = new Point(54, 167);
            cbbpara.Name = "cbbpara";
            cbbpara.Size = new Size(109, 23);
            cbbpara.TabIndex = 7;
            cbbpara.SelectedIndexChanged += cbbpara_SelectedIndexChanged;
            // 
            // cbbde
            // 
            cbbde.FormattingEnabled = true;
            cbbde.Items.AddRange(new object[] { "EURO", "DOLAR", "REAL ", "PESO", "SELECIONE" });
            cbbde.Location = new Point(203, 91);
            cbbde.Name = "cbbde";
            cbbde.Size = new Size(109, 23);
            cbbde.TabIndex = 6;
            // 
            // txtconvertido
            // 
            txtconvertido.Location = new Point(203, 167);
            txtconvertido.Name = "txtconvertido";
            txtconvertido.Size = new Size(109, 23);
            txtconvertido.TabIndex = 5;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(54, 91);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(112, 23);
            txtvalor.TabIndex = 0;
            // 
            // lblde
            // 
            lblde.AutoSize = true;
            lblde.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblde.ForeColor = SystemColors.ControlLightLight;
            lblde.Location = new Point(203, 71);
            lblde.Name = "lblde";
            lblde.Size = new Size(25, 17);
            lblde.TabIndex = 4;
            lblde.Text = "De";
            // 
            // lblconvertido
            // 
            lblconvertido.AutoSize = true;
            lblconvertido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblconvertido.ForeColor = SystemColors.ControlLightLight;
            lblconvertido.Location = new Point(203, 147);
            lblconvertido.Name = "lblconvertido";
            lblconvertido.Size = new Size(112, 17);
            lblconvertido.TabIndex = 3;
            lblconvertido.Text = "Valor Converitdo";
            // 
            // lblpara
            // 
            lblpara.AutoSize = true;
            lblpara.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblpara.ForeColor = SystemColors.ControlLightLight;
            lblpara.Location = new Point(54, 147);
            lblpara.Name = "lblpara";
            lblpara.Size = new Size(35, 17);
            lblpara.TabIndex = 2;
            lblpara.Text = "Para";
            // 
            // lblvalor
            // 
            lblvalor.AutoSize = true;
            lblvalor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblvalor.ForeColor = SystemColors.ControlLightLight;
            lblvalor.ImageAlign = ContentAlignment.BottomLeft;
            lblvalor.Location = new Point(54, 71);
            lblvalor.Name = "lblvalor";
            lblvalor.Size = new Size(40, 17);
            lblvalor.TabIndex = 1;
            lblvalor.Text = "Valor";
            lblvalor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.BackColor = Color.White;
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(44, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(268, 32);
            lbltitle.TabIndex = 0;
            lbltitle.Text = ":.Conversor de Moedas.:";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnsair
            // 
            btnsair.Image = (Image)resources.GetObject("btnsair.Image");
            btnsair.Location = new Point(104, 5);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(75, 56);
            btnsair.TabIndex = 9;
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // btnnovo
            // 
            btnnovo.Image = (Image)resources.GetObject("btnnovo.Image");
            btnnovo.Location = new Point(12, 5);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(75, 56);
            btnnovo.TabIndex = 8;
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 316);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblde;
        private Label lblconvertido;
        private Label lblpara;
        private Label lblvalor;
        private Label lbltitle;
        private TextBox txtconvertido;
        private TextBox txtvalor;
        private ComboBox cbbpara;
        private ComboBox cbbde;
        private Button btnsair;
        private Button btnnovo;
    }
}
