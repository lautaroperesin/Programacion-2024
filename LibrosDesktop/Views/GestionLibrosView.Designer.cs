namespace LibrosDesktop.Views
{
    partial class GestionLibrosView
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
            dataGridLibros = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLibros).BeginInit();
            SuspendLayout();
            // 
            // dataGridLibros
            // 
            dataGridLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLibros.BackgroundColor = SystemColors.Desktop;
            dataGridLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibros.Location = new Point(37, 43);
            dataGridLibros.Name = "dataGridLibros";
            dataGridLibros.ReadOnly = true;
            dataGridLibros.RowHeadersVisible = false;
            dataGridLibros.RowHeadersWidth = 51;
            dataGridLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridLibros.Size = new Size(972, 557);
            dataGridLibros.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(37, 619);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 39);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(177, 619);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 39);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(319, 619);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "El&iminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(909, 619);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 39);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // GestionLibrosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1062, 670);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridLibros);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionLibrosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de libros";
            ((System.ComponentModel.ISupportInitialize)dataGridLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridLibros;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}