namespace Navegador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Ir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "https://www.umes.edu.gt",
            "https://www.youtube.com",
            "https://www.google.com"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(755, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ir
            // 
            this.Ir.Location = new System.Drawing.Point(752, 0);
            this.Ir.Name = "Ir";
            this.Ir.Size = new System.Drawing.Size(52, 27);
            this.Ir.TabIndex = 1;
            this.Ir.Text = "Ir";
            this.Ir.UseVisualStyleBackColor = true;
            this.Ir.Click += new System.EventHandler(this.Ir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.siguienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "Menu";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.navegarToolStripMenuItem.Text = "Home";
            this.navegarToolStripMenuItem.Click += new System.EventHandler(this.navegarToolStripMenuItem_Click);
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.anteriorToolStripMenuItem_Click);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.siguienteToolStripMenuItem.Text = "Siguiente";
            this.siguienteToolStripMenuItem.Click += new System.EventHandler(this.siguienteToolStripMenuItem_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 59);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(948, 559);
            this.webView21.TabIndex = 3;
            this.webView21.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Ir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 29);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 618);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Ir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel panel1;
    }
}

