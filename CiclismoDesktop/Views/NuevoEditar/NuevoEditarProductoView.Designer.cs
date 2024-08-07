namespace CiclismoDesktop.Views
{
    partial class NuevoEditarProductoView
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombreProducto = new TextBox();
            txtMFProducto = new TextBox();
            txtTallaProducto = new TextBox();
            txtColorProducto = new TextBox();
            txtClaseProducto = new TextBox();
            numericUpDownPrecioProducto = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioProducto).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(245, 373);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 46);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(445, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 48);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(307, 37);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(172, 27);
            txtNombreProducto.TabIndex = 2;
            // 
            // txtMFProducto
            // 
            txtMFProducto.Location = new Point(307, 222);
            txtMFProducto.Name = "txtMFProducto";
            txtMFProducto.Size = new Size(172, 27);
            txtMFProducto.TabIndex = 3;
            // 
            // txtTallaProducto
            // 
            txtTallaProducto.Location = new Point(307, 162);
            txtTallaProducto.Name = "txtTallaProducto";
            txtTallaProducto.Size = new Size(172, 27);
            txtTallaProducto.TabIndex = 4;
            // 
            // txtColorProducto
            // 
            txtColorProducto.Location = new Point(307, 98);
            txtColorProducto.Name = "txtColorProducto";
            txtColorProducto.Size = new Size(172, 27);
            txtColorProducto.TabIndex = 5;
            // 
            // txtClaseProducto
            // 
            txtClaseProducto.Location = new Point(307, 322);
            txtClaseProducto.Name = "txtClaseProducto";
            txtClaseProducto.Size = new Size(172, 27);
            txtClaseProducto.TabIndex = 6;
            // 
            // numericUpDownPrecioProducto
            // 
            numericUpDownPrecioProducto.Location = new Point(307, 271);
            numericUpDownPrecioProducto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrecioProducto.Name = "numericUpDownPrecioProducto";
            numericUpDownPrecioProducto.Size = new Size(89, 27);
            numericUpDownPrecioProducto.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 105);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 9;
            label2.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 169);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 10;
            label3.Text = "Talla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 229);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 11;
            label4.Text = "M - F";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 278);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 12;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 329);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 13;
            label6.Text = "Clase:";
            // 
            // NuevoEditarProductosView
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
            Name = "NuevoEditarProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NuevoEditarProductosView";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecioProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombreProducto;
        private TextBox txtMFProducto;
        private TextBox txtTallaProducto;
        private TextBox txtColorProducto;
        private TextBox txtClaseProducto;
        private NumericUpDown numericUpDownPrecioProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}