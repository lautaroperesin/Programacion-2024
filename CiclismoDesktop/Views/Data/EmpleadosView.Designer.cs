namespace CiclismoDesktop.Views
{
    partial class EmpleadosView
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
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dataGridViewEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(688, 390);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 39);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(255, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 39);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "El&iminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(134, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(91, 39);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(12, 390);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 39);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(12, 21);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.ReadOnly = true;
            dataGridViewEmpleados.RowHeadersVisible = false;
            dataGridViewEmpleados.RowHeadersWidth = 51;
            dataGridViewEmpleados.Size = new Size(776, 363);
            dataGridViewEmpleados.TabIndex = 9;
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewEmpleados);
            Name = "EmpleadosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dataGridViewEmpleados;
    }
}