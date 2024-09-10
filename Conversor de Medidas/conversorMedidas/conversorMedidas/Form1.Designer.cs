namespace conversorMedidas
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
            lblmedida = new Label();
            lblde = new Label();
            lblpara = new Label();
            lblmedidaconvertida = new Label();
            txtmedida = new TextBox();
            txtconvertida = new TextBox();
            cbbde = new ComboBox();
            cbbpara = new ComboBox();
            btnnovo = new Button();
            btnfechar = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lblmedida
            // 
            lblmedida.AutoSize = true;
            lblmedida.Location = new Point(12, 20);
            lblmedida.Name = "lblmedida";
            lblmedida.Size = new Size(50, 15);
            lblmedida.TabIndex = 0;
            lblmedida.Text = "Medida:";
            // 
            // lblde
            // 
            lblde.AutoSize = true;
            lblde.Location = new Point(288, 20);
            lblde.Name = "lblde";
            lblde.Size = new Size(24, 15);
            lblde.TabIndex = 1;
            lblde.Text = "De:";
            // 
            // lblpara
            // 
            lblpara.AutoSize = true;
            lblpara.Location = new Point(12, 133);
            lblpara.Name = "lblpara";
            lblpara.Size = new Size(33, 15);
            lblpara.TabIndex = 2;
            lblpara.Text = "Para:";
            // 
            // lblmedidaconvertida
            // 
            lblmedidaconvertida.AutoSize = true;
            lblmedidaconvertida.Location = new Point(204, 133);
            lblmedidaconvertida.Name = "lblmedidaconvertida";
            lblmedidaconvertida.Size = new Size(111, 15);
            lblmedidaconvertida.TabIndex = 3;
            lblmedidaconvertida.Text = "Medida Convertida:";
            // 
            // txtmedida
            // 
            txtmedida.Location = new Point(68, 20);
            txtmedida.Name = "txtmedida";
            txtmedida.Size = new Size(100, 23);
            txtmedida.TabIndex = 4;
            // 
            // txtconvertida
            // 
            txtconvertida.Location = new Point(321, 130);
            txtconvertida.Name = "txtconvertida";
            txtconvertida.Size = new Size(100, 23);
            txtconvertida.TabIndex = 5;
            // 
            // cbbde
            // 
            cbbde.FormattingEnabled = true;
            cbbde.Items.AddRange(new object[] { "CM", "M", "KM" });
            cbbde.Location = new Point(318, 17);
            cbbde.Name = "cbbde";
            cbbde.Size = new Size(103, 23);
            cbbde.TabIndex = 6;
            // 
            // cbbpara
            // 
            cbbpara.FormattingEnabled = true;
            cbbpara.Items.AddRange(new object[] { "CM", "M", "KM" });
            cbbpara.Location = new Point(66, 130);
            cbbpara.Name = "cbbpara";
            cbbpara.Size = new Size(103, 23);
            cbbpara.TabIndex = 7;
            cbbpara.SelectedIndexChanged += cbbpara_SelectedIndexChanged;
            // 
            // btnnovo
            // 
            btnnovo.Location = new Point(66, 46);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(103, 23);
            btnnovo.TabIndex = 8;
            btnnovo.Text = "Novo Cálculo";
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // btnfechar
            // 
            btnfechar.Location = new Point(318, 249);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(103, 23);
            btnfechar.TabIndex = 9;
            btnfechar.Text = "Fechar";
            btnfechar.UseVisualStyleBackColor = true;
            btnfechar.Click += btnfechar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-1, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.None;
            splitContainer1.Panel1.Controls.Add(cbbpara);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnnovo);
            splitContainer1.Size = new Size(441, 283);
            splitContainer1.SplitterDistance = 199;
            splitContainer1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 284);
            Controls.Add(btnfechar);
            Controls.Add(cbbde);
            Controls.Add(txtconvertida);
            Controls.Add(txtmedida);
            Controls.Add(lblmedidaconvertida);
            Controls.Add(lblpara);
            Controls.Add(lblde);
            Controls.Add(lblmedida);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmedida;
        private Label lblde;
        private Label lblpara;
        private Label lblmedidaconvertida;
        private TextBox txtmedida;
        private TextBox txtconvertida;
        private ComboBox cbbde;
        private ComboBox cbbpara;
        private Button btnnovo;
        private Button btnfechar;
        private SplitContainer splitContainer1;
    }
}
