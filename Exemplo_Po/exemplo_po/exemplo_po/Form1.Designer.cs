namespace exemplo_po
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
            txtnome = new TextBox();
            txtemail = new TextBox();
            txtlogin = new TextBox();
            txtsenha = new TextBox();
            lblnome = new Label();
            lblemail = new Label();
            lbllogin = new Label();
            lblsenha = new Label();
            btnenviar = new Button();
            btnbuscar = new Button();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.Location = new Point(238, 71);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(143, 23);
            txtnome.TabIndex = 0;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(238, 146);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(143, 23);
            txtemail.TabIndex = 1;
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(238, 219);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(143, 23);
            txtlogin.TabIndex = 2;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(238, 294);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(143, 23);
            txtsenha.TabIndex = 3;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(292, 53);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(292, 128);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(41, 15);
            lblemail.TabIndex = 5;
            lblemail.Text = "E-mail";
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(292, 201);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(37, 15);
            lbllogin.TabIndex = 6;
            lbllogin.Text = "Login";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(292, 276);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 7;
            lblsenha.Text = "Senha";
            // 
            // btnenviar
            // 
            btnenviar.Location = new Point(12, 70);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(75, 23);
            btnenviar.TabIndex = 8;
            btnenviar.Text = "Enviar";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.UseWaitCursor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(12, 128);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 9;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.UseWaitCursor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            Controls.Add(btnbuscar);
            Controls.Add(btnenviar);
            Controls.Add(lblsenha);
            Controls.Add(lbllogin);
            Controls.Add(lblemail);
            Controls.Add(lblnome);
            Controls.Add(txtsenha);
            Controls.Add(txtlogin);
            Controls.Add(txtemail);
            Controls.Add(txtnome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtemail;
        private TextBox txtlogin;
        private TextBox txtsenha;
        private Label lblnome;
        private Label lblemail;
        private Label lbllogin;
        private Label lblsenha;
        private Button btnenviar;
        private Button btnbuscar;
    }
}
