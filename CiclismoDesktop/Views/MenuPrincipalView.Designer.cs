namespace CiclismoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesStoredProcedureToolStripMenuItem = new ToolStripMenuItem();
            gestionarClientesORMToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            productosStoredProcedureToolStripMenuItem = new ToolStripMenuItem();
            gestionarEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarClientesToolStripMenuItem, gestionarClientesStoredProcedureToolStripMenuItem, gestionarClientesORMToolStripMenuItem, productosToolStripMenuItem, productosStoredProcedureToolStripMenuItem, gestionarEmpleadosToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(80, 24);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // gestionarClientesToolStripMenuItem
            // 
            gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            gestionarClientesToolStripMenuItem.Size = new Size(288, 26);
            gestionarClientesToolStripMenuItem.Text = "Clientes - Code";
            gestionarClientesToolStripMenuItem.Click += gestionarClientesToolStripMenuItem_Click;
            // 
            // gestionarClientesStoredProcedureToolStripMenuItem
            // 
            gestionarClientesStoredProcedureToolStripMenuItem.Name = "gestionarClientesStoredProcedureToolStripMenuItem";
            gestionarClientesStoredProcedureToolStripMenuItem.Size = new Size(288, 26);
            gestionarClientesStoredProcedureToolStripMenuItem.Text = "Clientes - Stored procedure";
            gestionarClientesStoredProcedureToolStripMenuItem.Click += gestionarClientesStoredProcedureToolStripMenuItem_Click;
            // 
            // gestionarClientesORMToolStripMenuItem
            // 
            gestionarClientesORMToolStripMenuItem.Name = "gestionarClientesORMToolStripMenuItem";
            gestionarClientesORMToolStripMenuItem.Size = new Size(288, 26);
            gestionarClientesORMToolStripMenuItem.Text = "Clientes - ORM";
            gestionarClientesORMToolStripMenuItem.Click += gestionarClientesORMToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(288, 26);
            productosToolStripMenuItem.Text = "Productos - Code";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // productosStoredProcedureToolStripMenuItem
            // 
            productosStoredProcedureToolStripMenuItem.Name = "productosStoredProcedureToolStripMenuItem";
            productosStoredProcedureToolStripMenuItem.Size = new Size(288, 26);
            productosStoredProcedureToolStripMenuItem.Text = "Productos - Stored procedure";
            productosStoredProcedureToolStripMenuItem.Click += productosStoredProcedureToolStripMenuItem_Click;
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            gestionarEmpleadosToolStripMenuItem.Size = new Size(288, 26);
            gestionarEmpleadosToolStripMenuItem.Text = "Empleados - Code";
            gestionarEmpleadosToolStripMenuItem.Click += gestionarEmpleadosToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(200, 26);
            salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ciclismo Desktop por Codigo";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesStoredProcedureToolStripMenuItem;
        private ToolStripMenuItem gestionarClientesORMToolStripMenuItem;
        private ToolStripMenuItem productosStoredProcedureToolStripMenuItem;
    }
}
