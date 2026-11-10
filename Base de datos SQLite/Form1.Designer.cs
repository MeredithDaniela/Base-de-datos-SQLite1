namespace Base_de_datos_SQLite
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
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            datagv = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 26);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 0;
            label1.Text = "Base de datos en SQLite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 92);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 188);
            label3.Name = "label3";
            label3.Size = new Size(28, 19);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 184);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(67, 269);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(183, 39);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(67, 340);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(183, 39);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(67, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(183, 39);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // datagv
            // 
            datagv.BackgroundColor = Color.White;
            datagv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagv.Columns.AddRange(new DataGridViewColumn[] { Nombre, Id });
            datagv.Location = new Point(282, 77);
            datagv.Name = "datagv";
            datagv.Size = new Size(397, 411);
            datagv.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 514);
            Controls.Add(datagv);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtId;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView datagv;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Id;
    }
}
