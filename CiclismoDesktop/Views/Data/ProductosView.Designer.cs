namespace CiclismoDesktop.Views
{
    partial class ProductosView
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
            dataGridViewProductos = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 12);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(776, 371);
            dataGridViewProductos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 395);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 43);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(163, 395);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 43);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(316, 395);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 43);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(659, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 43);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewProductos);
            Name = "ProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductosView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}