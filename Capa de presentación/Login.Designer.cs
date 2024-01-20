namespace Capa_de_presentación
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            txtingrsar = new Button();
            linkcontra = new LinkLabel();
            lblerror = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 389);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // txtusuario
            // 
            txtusuario.BorderStyle = BorderStyle.None;
            txtusuario.Location = new Point(468, 111);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(393, 24);
            txtusuario.TabIndex = 2;
            txtusuario.Text = "Usuario";
            txtusuario.Enter += txtusuario_Enter;
            txtusuario.Leave += txtusuario_Leave;
            // 
            // txtcontraseña
            // 
            txtcontraseña.BorderStyle = BorderStyle.None;
            txtcontraseña.Location = new Point(468, 166);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(393, 24);
            txtcontraseña.TabIndex = 3;
            txtcontraseña.Text = "Contraseña";
            txtcontraseña.Enter += txtcontraseña_Enter;
            txtcontraseña.Leave += txtcontraseña_Leave;
            // 
            // txtingrsar
            // 
            txtingrsar.Location = new Point(571, 280);
            txtingrsar.Name = "txtingrsar";
            txtingrsar.Size = new Size(112, 34);
            txtingrsar.TabIndex = 4;
            txtingrsar.Text = "Ingresar";
            txtingrsar.UseVisualStyleBackColor = true;
            txtingrsar.Click += txtingrsar_Click;
            // 
            // linkcontra
            // 
            linkcontra.AutoSize = true;
            linkcontra.Location = new Point(506, 344);
            linkcontra.Name = "linkcontra";
            linkcontra.Size = new Size(234, 25);
            linkcontra.TabIndex = 5;
            linkcontra.TabStop = true;
            linkcontra.Text = "¿Ha olvidado la contraseña?";
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(465, 217);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(55, 25);
            lblerror.TabIndex = 6;
            lblerror.Text = "Error ";
            lblerror.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(928, 389);
            Controls.Add(lblerror);
            Controls.Add(linkcontra);
            Controls.Add(txtingrsar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private Button txtingrsar;
        private LinkLabel linkcontra;
        private Label lblerror;
    }
}