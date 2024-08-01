namespace CiclismoDesktop.Views
{
    partial class NuevoEditarEmpleadoView
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
            txtTelEmpleado = new TextBox();
            label3 = new Label();
            txtCargoEmpleado = new TextBox();
            label2 = new Label();
            txtNombreEmpleado = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtApellidoEmpleado = new TextBox();
            label6 = new Label();
            dateTimeFechaNacimiento = new DateTimePicker();
            label7 = new Label();
            dateTimeFechaIngreso = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(468, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(314, 355);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelEmpleado
            // 
            txtTelEmpleado.Location = new Point(314, 272);
            txtTelEmpleado.Name = "txtTelEmpleado";
            txtTelEmpleado.Size = new Size(248, 27);
            txtTelEmpleado.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 279);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Teléfono:";
            // 
            // txtCargoEmpleado
            // 
            txtCargoEmpleado.Location = new Point(314, 135);
            txtCargoEmpleado.Name = "txtCargoEmpleado";
            txtCargoEmpleado.Size = new Size(248, 27);
            txtCargoEmpleado.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 138);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Cargo:";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(314, 52);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(248, 27);
            txtNombreEmpleado.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 52);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 91);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 16;
            label4.Text = "Apellido:";
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(314, 91);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(248, 27);
            txtApellidoEmpleado.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 184);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 20;
            label6.Text = "Fecha de nacimiento:";
            // 
            // dateTimeFechaNacimiento
            // 
            dateTimeFechaNacimiento.CustomFormat = "YYYY-MM-DD hh:mm:ss";
            dateTimeFechaNacimiento.Location = new Point(314, 184);
            dateTimeFechaNacimiento.MaxDate = new DateTime(2024, 7, 26, 16, 22, 34, 0);
            dateTimeFechaNacimiento.MinDate = new DateTime(1755, 12, 26, 0, 0, 0, 0);
            dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            dateTimeFechaNacimiento.Size = new Size(250, 27);
            dateTimeFechaNacimiento.TabIndex = 21;
            dateTimeFechaNacimiento.Value = new DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 234);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 22;
            label7.Text = "Fecha de ingreso:";
            // 
            // dateTimeFechaIngreso
            // 
            dateTimeFechaIngreso.CustomFormat = "YYYY-MM-DD hh:mm:ss";
            dateTimeFechaIngreso.Location = new Point(314, 229);
            dateTimeFechaIngreso.MaxDate = new DateTime(2024, 7, 26, 16, 22, 46, 0);
            dateTimeFechaIngreso.Name = "dateTimeFechaIngreso";
            dateTimeFechaIngreso.Size = new Size(250, 27);
            dateTimeFechaIngreso.TabIndex = 23;
            dateTimeFechaIngreso.Value = new DateTime(2024, 7, 26, 0, 0, 0, 0);
            // 
            // NuevoEditarEmpleadoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimeFechaIngreso);
            Controls.Add(label7);
            Controls.Add(dateTimeFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(txtApellidoEmpleado);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelEmpleado);
            Controls.Add(label3);
            Controls.Add(txtCargoEmpleado);
            Controls.Add(label2);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(label1);
            Name = "NuevoEditarEmpleadoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo/Editar Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelEmpleado;
        private Label label3;
        private TextBox txtCargoEmpleado;
        private Label label2;
        private TextBox txtNombreEmpleado;
        private Label label1;
        private Label label4;
        private TextBox txtApellidoEmpleado;
        private Label label6;
        private DateTimePicker dateTimeFechaNacimiento;
        private Label label7;
        private DateTimePicker dateTimeFechaIngreso;
    }
}