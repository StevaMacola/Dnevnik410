namespace Dnevnik410A
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upisnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poOdeljenjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poNastavnikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poUcenikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekeToolStripMenuItem,
            this.dokumentiToolStripMenuItem,
            this.izvestajiToolStripMenuItem,
            this.administracijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekeToolStripMenuItem
            // 
            this.datotekeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem,
            this.odeljenjeToolStripMenuItem,
            this.skolskaGodinaToolStripMenuItem,
            this.predmetToolStripMenuItem});
            this.datotekeToolStripMenuItem.Name = "datotekeToolStripMenuItem";
            this.datotekeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.datotekeToolStripMenuItem.Text = "datoteke";
            // 
            // dokumentiToolStripMenuItem
            // 
            this.dokumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upisnicaToolStripMenuItem,
            this.raspodelaToolStripMenuItem,
            this.ocenaToolStripMenuItem});
            this.dokumentiToolStripMenuItem.Name = "dokumentiToolStripMenuItem";
            this.dokumentiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.dokumentiToolStripMenuItem.Text = "dokumenti";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poOdeljenjuToolStripMenuItem,
            this.poNastavnikuToolStripMenuItem,
            this.poUcenikuToolStripMenuItem});
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "izvestaji";
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.administracijaToolStripMenuItem.Text = "administracija";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobaToolStripMenuItem.Text = "osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click_1);
            // 
            // odeljenjeToolStripMenuItem
            // 
            this.odeljenjeToolStripMenuItem.Name = "odeljenjeToolStripMenuItem";
            this.odeljenjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odeljenjeToolStripMenuItem.Text = "odeljenje";
            this.odeljenjeToolStripMenuItem.Click += new System.EventHandler(this.odeljenjeToolStripMenuItem_Click);
            // 
            // skolskaGodinaToolStripMenuItem
            // 
            this.skolskaGodinaToolStripMenuItem.Name = "skolskaGodinaToolStripMenuItem";
            this.skolskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skolskaGodinaToolStripMenuItem.Text = "skolska godina";
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.predmetToolStripMenuItem.Text = "predmet";
            // 
            // upisnicaToolStripMenuItem
            // 
            this.upisnicaToolStripMenuItem.Name = "upisnicaToolStripMenuItem";
            this.upisnicaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upisnicaToolStripMenuItem.Text = "upisnica";
            this.upisnicaToolStripMenuItem.Click += new System.EventHandler(this.upisnicaToolStripMenuItem_Click_1);
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // ocenaToolStripMenuItem
            // 
            this.ocenaToolStripMenuItem.Name = "ocenaToolStripMenuItem";
            this.ocenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ocenaToolStripMenuItem.Text = "ocena";
            // 
            // poOdeljenjuToolStripMenuItem
            // 
            this.poOdeljenjuToolStripMenuItem.Name = "poOdeljenjuToolStripMenuItem";
            this.poOdeljenjuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poOdeljenjuToolStripMenuItem.Text = "po odeljenju";
            // 
            // poNastavnikuToolStripMenuItem
            // 
            this.poNastavnikuToolStripMenuItem.Name = "poNastavnikuToolStripMenuItem";
            this.poNastavnikuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poNastavnikuToolStripMenuItem.Text = "po nastavniku";
            // 
            // poUcenikuToolStripMenuItem
            // 
            this.poUcenikuToolStripMenuItem.Name = "poUcenikuToolStripMenuItem";
            this.poUcenikuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poUcenikuToolStripMenuItem.Text = "po uceniku";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odeljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upisnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poOdeljenjuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poNastavnikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poUcenikuToolStripMenuItem;
    }
}