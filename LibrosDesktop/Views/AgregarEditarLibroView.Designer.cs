namespace LibrosDesktop.Views
{
    partial class AgregarEditarLibroView
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
            label = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            label2 = new Label();
            txtEditorial = new TextBox();
            label3 = new Label();
            txtPortada = new TextBox();
            label4 = new Label();
            txtSinopsis = new TextBox();
            label5 = new Label();
            numericPaginas = new NumericUpDown();
            label6 = new Label();
            txtGenero = new TextBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pictureBoxPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(47, 75);
            label.Name = "label";
            label.Size = new Size(67, 20);
            label.TabIndex = 0;
            label.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(495, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(129, 132);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(495, 27);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 132);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(129, 198);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(495, 27);
            txtEditorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 198);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Editorial:";
            // 
            // txtPortada
            // 
            txtPortada.Location = new Point(129, 261);
            txtPortada.Name = "txtPortada";
            txtPortada.Size = new Size(495, 27);
            txtPortada.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 261);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 6;
            label4.Text = "Portada URL:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(129, 460);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(495, 70);
            txtSinopsis.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 460);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 8;
            label5.Text = "Sinopsis:";
            // 
            // numericPaginas
            // 
            numericPaginas.Location = new Point(129, 553);
            numericPaginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericPaginas.Name = "numericPaginas";
            numericPaginas.Size = new Size(150, 27);
            numericPaginas.TabIndex = 10;
            numericPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 553);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 11;
            label6.Text = "Paginas:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(129, 625);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(495, 27);
            txtGenero.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 632);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 12;
            label7.Text = "Genero:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(92, 729);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(539, 729);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBoxPortada
            // 
            pictureBoxPortada.Location = new Point(259, 294);
            pictureBoxPortada.Name = "pictureBoxPortada";
            pictureBoxPortada.Size = new Size(196, 160);
            pictureBoxPortada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPortada.TabIndex = 16;
            pictureBoxPortada.TabStop = false;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 770);
            Controls.Add(pictureBoxPortada);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtGenero);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericPaginas);
            Controls.Add(txtSinopsis);
            Controls.Add(label5);
            Controls.Add(txtPortada);
            Controls.Add(label4);
            Controls.Add(txtEditorial);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label);
            Name = "AgregarEditarLibroView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar libro";
            ((System.ComponentModel.ISupportInitialize)numericPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private Label label2;
        private TextBox txtEditorial;
        private Label label3;
        private TextBox txtPortada;
        private Label label4;
        private TextBox txtSinopsis;
        private Label label5;
        private NumericUpDown numericPaginas;
        private Label label6;
        private TextBox txtGenero;
        private Label label7;
        private Button btnGuardar;
        private Button btnCancelar;
        private PictureBox pictureBoxPortada;
    }
}