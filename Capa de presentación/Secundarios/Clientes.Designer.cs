namespace Capa_de_presentación.Secundarios
{
    partial class Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            label2 = new Label();
            txtedad = new TextBox();
            label3 = new Label();
            txttelefono = new TextBox();
            label4 = new Label();
            txtcorreo = new TextBox();
            label5 = new Label();
            txtdireccion = new TextBox();
            label6 = new Label();
            txtcedula = new TextBox();
            label7 = new Label();
            btnguardar = new Button();
            txtid = new TextBox();
            label8 = new Label();
            btneditar = new Button();
            btneliminar = new Button();
            txtbuscarID = new TextBox();
            Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(34, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(872, 339);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1043, 202);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(1122, 199);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(231, 31);
            txtnombre.TabIndex = 2;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(1122, 236);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(231, 31);
            txtapellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1043, 239);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(1122, 284);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(231, 31);
            txtedad.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1043, 287);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 5;
            label3.Text = "Edad";
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(1122, 330);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(231, 31);
            txttelefono.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1043, 333);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 7;
            label4.Text = "Telefono";
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(1122, 387);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(231, 31);
            txtcorreo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1043, 390);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 9;
            label5.Text = "Correo";
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(1122, 443);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(231, 31);
            txtdireccion.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1043, 446);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 11;
            label6.Text = "Dirección";
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(1122, 498);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(231, 31);
            txtcedula.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1043, 501);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 13;
            label7.Text = "Cédula";
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(1153, 560);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(168, 49);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(1122, 162);
            txtid.Name = "txtid";
            txtid.Size = new Size(231, 31);
            txtid.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1043, 165);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 16;
            label8.Text = "ID";
            // 
            // btneditar
            // 
            btneditar.Location = new Point(34, 561);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(168, 49);
            btneditar.TabIndex = 18;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(230, 561);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(168, 49);
            btneliminar.TabIndex = 19;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
         
            
            
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 684);
           
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(txtid);
            Controls.Add(label8);
            Controls.Add(btnguardar);
            Controls.Add(txtcedula);
            Controls.Add(label7);
            Controls.Add(txtdireccion);
            Controls.Add(label6);
            Controls.Add(txtcorreo);
            Controls.Add(label5);
            Controls.Add(txttelefono);
            Controls.Add(label4);
            Controls.Add(txtedad);
            Controls.Add(label3);
            Controls.Add(txtapellido);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private Label label2;
        private TextBox txtedad;
        private Label label3;
        private TextBox txttelefono;
        private Label label4;
        private TextBox txtcorreo;
        private Label label5;
        private TextBox txtdireccion;
        private Label label6;
        private TextBox txtcedula;
        private Label label7;
        private Button btnguardar;
        private TextBox txtid;
        private Label label8;
        private Button btneditar;
        private Button btneliminar;
        private TextBox txtbuscarID;
        private Button Buscar;
    }
}