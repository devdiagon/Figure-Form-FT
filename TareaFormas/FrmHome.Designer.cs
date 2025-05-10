namespace TareaFormas
{
    partial class FrmHome
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
            this.mnsNav = new System.Windows.Forms.MenuStrip();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadranguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.mnsNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsNav
            // 
            this.mnsNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.mnsNav.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloToolStripMenuItem,
            this.cuadranguloToolStripMenuItem,
            this.curvasToolStripMenuItem,
            this.poligonosToolStripMenuItem});
            this.mnsNav.Location = new System.Drawing.Point(914, 0);
            this.mnsNav.Name = "mnsNav";
            this.mnsNav.Padding = new System.Windows.Forms.Padding(8, 12, 0, 2);
            this.mnsNav.Size = new System.Drawing.Size(127, 527);
            this.mnsNav.TabIndex = 0;
            this.mnsNav.Text = "menuStrip1";
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.trianguloToolStripMenuItem.Text = "Triángulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.trianguloToolStripMenuItem_Click);
            // 
            // cuadranguloToolStripMenuItem
            // 
            this.cuadranguloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadradoToolStripMenuItem,
            this.rectanguloToolStripMenuItem});
            this.cuadranguloToolStripMenuItem.Name = "cuadranguloToolStripMenuItem";
            this.cuadranguloToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cuadranguloToolStripMenuItem.Text = "Cuadrángulo";
            // 
            // curvasToolStripMenuItem
            // 
            this.curvasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem,
            this.elipseToolStripMenuItem});
            this.curvasToolStripMenuItem.Name = "curvasToolStripMenuItem";
            this.curvasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.curvasToolStripMenuItem.Text = "Curvas";
            // 
            // poligonosToolStripMenuItem
            // 
            this.poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            this.poligonosToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.poligonosToolStripMenuItem.Text = "Polígonos";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circuloToolStripMenuItem.Text = "Circulo";
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.elipseToolStripMenuItem.Text = "Elipse";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rectanguloToolStripMenuItem.Text = "Rectangulo";
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 0);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(914, 527);
            this.pnlWrapper.TabIndex = 2;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 527);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.mnsNav);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsNav;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.mnsNav.ResumeLayout(false);
            this.mnsNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsNav;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadranguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWrapper;
    }
}