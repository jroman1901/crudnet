namespace pacientes
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
            groupBox1 = new GroupBox();
            txtversion = new TextBox();
            txtnonbre = new TextBox();
            txttipo = new TextBox();
            txtserie = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnguardar = new Button();
            button2 = new Button();
            vista = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vista).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtversion);
            groupBox1.Controls.Add(txtnonbre);
            groupBox1.Controls.Add(txttipo);
            groupBox1.Controls.Add(txtserie);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del equipo";
            // 
            // txtversion
            // 
            txtversion.Location = new Point(92, 126);
            txtversion.Name = "txtversion";
            txtversion.Size = new Size(289, 23);
            txtversion.TabIndex = 7;
            // 
            // txtnonbre
            // 
            txtnonbre.Location = new Point(92, 97);
            txtnonbre.Name = "txtnonbre";
            txtnonbre.Size = new Size(289, 23);
            txtnonbre.TabIndex = 6;
            // 
            // txttipo
            // 
            txttipo.Location = new Point(92, 63);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(289, 23);
            txttipo.TabIndex = 5;
            // 
            // txtserie
            // 
            txtserie.Location = new Point(92, 29);
            txtserie.Name = "txtserie";
            txtserie.Size = new Size(289, 23);
            txtserie.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 127);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Version";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 97);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 66);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Serie";
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(29, 179);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 1;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // vista
            // 
            vista.AllowUserToAddRows = false;
            vista.AllowUserToDeleteRows = false;
            vista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vista.Columns.AddRange(new DataGridViewColumn[] { Codigo, Column2, Column3, Column4 });
            vista.Location = new Point(25, 208);
            vista.Name = "vista";
            vista.ReadOnly = true;
            vista.RowTemplate.Height = 25;
            vista.Size = new Size(453, 170);
            vista.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "serie";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "tipo";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "nombre";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 388);
            Controls.Add(vista);
            Controls.Add(button2);
            Controls.Add(btnguardar);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtversion;
        private TextBox txtnonbre;
        private TextBox txttipo;
        private TextBox txtserie;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnguardar;
        private Button button2;
        private DataGridView vista;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}