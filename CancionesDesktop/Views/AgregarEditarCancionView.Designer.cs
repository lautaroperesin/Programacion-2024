﻿namespace CancionesDesktop.Views
{
    partial class AgregarEditarCancionView
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
            label1 = new Label();
            txtCancion = new TextBox();
            label2 = new Label();
            txtArtista = new TextBox();
            txtPortada = new TextBox();
            label3 = new Label();
            pictureBoxPortada = new PictureBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 33);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 0;
            label1.Text = "Cancion:";
            // 
            // txtCancion
            // 
            txtCancion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCancion.Location = new Point(261, 28);
            txtCancion.Name = "txtCancion";
            txtCancion.Size = new Size(312, 35);
            txtCancion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 30);
            label2.TabIndex = 2;
            label2.Text = "Artista:";
            // 
            // txtArtista
            // 
            txtArtista.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArtista.Location = new Point(261, 98);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(312, 35);
            txtArtista.TabIndex = 3;
            // 
            // txtPortada
            // 
            txtPortada.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPortada.Location = new Point(261, 167);
            txtPortada.Name = "txtPortada";
            txtPortada.Size = new Size(312, 35);
            txtPortada.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 172);
            label3.Name = "label3";
            label3.Size = new Size(132, 30);
            label3.TabIndex = 5;
            label3.Text = "Portada URL:";
            // 
            // pictureBoxPortada
            // 
            pictureBoxPortada.Location = new Point(272, 228);
            pictureBoxPortada.Name = "pictureBoxPortada";
            pictureBoxPortada.Size = new Size(289, 137);
            pictureBoxPortada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPortada.TabIndex = 6;
            pictureBoxPortada.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(272, 395);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 36);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(447, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AgregarEditarCancion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 461);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(pictureBoxPortada);
            Controls.Add(label3);
            Controls.Add(txtPortada);
            Controls.Add(txtArtista);
            Controls.Add(label2);
            Controls.Add(txtCancion);
            Controls.Add(label1);
            Name = "AgregarEditarCancion";
            Text = "Agregar/Editar cancion";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCancion;
        private Label label2;
        private TextBox txtArtista;
        private TextBox txtPortada;
        private Label label3;
        private PictureBox pictureBoxPortada;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}