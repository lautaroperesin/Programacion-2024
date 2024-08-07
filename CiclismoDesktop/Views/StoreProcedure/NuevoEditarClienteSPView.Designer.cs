namespace CiclismoDesktop.Views.StoreProcedure
{
    partial class NuevoEditarClienteSPView
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtApellidoContacto = new TextBox();
            label3 = new Label();
            txtNombreContacto = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(506, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(352, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellidoContacto
            // 
            txtApellidoContacto.Location = new Point(352, 243);
            txtApellidoContacto.Name = "txtApellidoContacto";
            txtApellidoContacto.Size = new Size(248, 27);
            txtApellidoContacto.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 243);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 12;
            label3.Text = "Apellido Contacto:";
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(352, 149);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(248, 27);
            txtNombreContacto.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 156);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 10;
            label2.Text = "Nombre Contacto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(352, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 27);
            txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 69);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // NuevoEditarClienteSPView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidoContacto);
            Controls.Add(label3);
            Controls.Add(txtNombreContacto);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "NuevoEditarClienteSPView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NuevoEditarClienteSPView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtApellidoContacto;
        private Label label3;
        private TextBox txtNombreContacto;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}