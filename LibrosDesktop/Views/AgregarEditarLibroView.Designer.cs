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
            label.Location = new Point(41, 56);
            label.Name = "label";
            label.Size = new Size(54, 15);
            label.TabIndex = 0;
            label.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 51);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(434, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(113, 99);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(434, 23);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 99);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(113, 148);
            txtEditorial.Margin = new Padding(3, 2, 3, 2);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(434, 23);
            txtEditorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 148);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Editorial:";
            // 
            // txtPortada
            // 
            txtPortada.Location = new Point(113, 196);
            txtPortada.Margin = new Padding(3, 2, 3, 2);
            txtPortada.Name = "txtPortada";
            txtPortada.Size = new Size(434, 23);
            txtPortada.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 196);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Portada URL:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(113, 345);
            txtSinopsis.Margin = new Padding(3, 2, 3, 2);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(434, 54);
            txtSinopsis.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 345);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "Sinopsis:";
            // 
            // numericPaginas
            // 
            numericPaginas.Location = new Point(113, 415);
            numericPaginas.Margin = new Padding(3, 2, 3, 2);
            numericPaginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericPaginas.Name = "numericPaginas";
            numericPaginas.Size = new Size(131, 23);
            numericPaginas.TabIndex = 10;
            numericPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 415);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Paginas:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(113, 469);
            txtGenero.Margin = new Padding(3, 2, 3, 2);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(434, 23);
            txtGenero.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 474);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Genero:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(80, 547);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(472, 547);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBoxPortada
            // 
            pictureBoxPortada.Location = new Point(227, 220);
            pictureBoxPortada.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPortada.Name = "pictureBoxPortada";
            pictureBoxPortada.Size = new Size(172, 120);
            pictureBoxPortada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPortada.TabIndex = 16;
            pictureBoxPortada.TabStop = false;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 574);
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
            Margin = new Padding(3, 2, 3, 2);
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