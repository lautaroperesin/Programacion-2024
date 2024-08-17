namespace CiclismoDesktop.Views.StoredProcedure.ProductosSP
{
    partial class NuevoEditarProductoSPView
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownPrecioProducto = new NumericUpDown();
            txtClaseProducto = new TextBox();
            txtColorProducto = new TextBox();
            txtTallaProducto = new TextBox();
            txtMFProducto = new TextBox();
            txtNombreProducto = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioProducto).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 326);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 27;
            label6.Text = "Clase:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 275);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 26;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 226);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 25;
            label4.Text = "M - F";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 166);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 24;
            label3.Text = "Talla:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 102);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 23;
            label2.Text = "Color:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre:";
            // 
            // numericUpDownPrecioProducto
            // 
            numericUpDownPrecioProducto.Location = new Point(317, 268);
            numericUpDownPrecioProducto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrecioProducto.Name = "numericUpDownPrecioProducto";
            numericUpDownPrecioProducto.Size = new Size(89, 27);
            numericUpDownPrecioProducto.TabIndex = 21;
            // 
            // txtClaseProducto
            // 
            txtClaseProducto.Location = new Point(317, 319);
            txtClaseProducto.Name = "txtClaseProducto";
            txtClaseProducto.Size = new Size(172, 27);
            txtClaseProducto.TabIndex = 20;
            // 
            // txtColorProducto
            // 
            txtColorProducto.Location = new Point(317, 95);
            txtColorProducto.Name = "txtColorProducto";
            txtColorProducto.Size = new Size(172, 27);
            txtColorProducto.TabIndex = 19;
            // 
            // txtTallaProducto
            // 
            txtTallaProducto.Location = new Point(317, 159);
            txtTallaProducto.Name = "txtTallaProducto";
            txtTallaProducto.Size = new Size(172, 27);
            txtTallaProducto.TabIndex = 18;
            // 
            // txtMFProducto
            // 
            txtMFProducto.Location = new Point(317, 219);
            txtMFProducto.Name = "txtMFProducto";
            txtMFProducto.Size = new Size(172, 27);
            txtMFProducto.TabIndex = 17;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(317, 34);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(172, 27);
            txtNombreProducto.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(455, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 48);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(255, 370);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 46);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // NuevoEditarProductoSPView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownPrecioProducto);
            Controls.Add(txtClaseProducto);
            Controls.Add(txtColorProducto);
            Controls.Add(txtTallaProducto);
            Controls.Add(txtMFProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "NuevoEditarProductoSPView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar Producto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownPrecioProducto;
        private TextBox txtClaseProducto;
        private TextBox txtColorProducto;
        private TextBox txtTallaProducto;
        private TextBox txtMFProducto;
        private TextBox txtNombreProducto;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}