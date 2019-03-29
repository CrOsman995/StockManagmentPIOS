namespace ProgInOperSus.MainForms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.skladišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.primkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otpremnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.poslovniPartneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.šifrarnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.djelatniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adreseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenakorisničkogRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skladišteToolStripMenuItem,
            this.toolStripSeparator1,
            this.primkaToolStripMenuItem,
            this.otpremnicaToolStripMenuItem,
            this.toolStripSeparator2,
            this.poslovniPartneriToolStripMenuItem,
            this.toolStripSeparator3,
            this.šifrarnikToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(65, 20);
            this.fileMenu.Text = "&Skladiste";
            // 
            // skladišteToolStripMenuItem
            // 
            this.skladišteToolStripMenuItem.Name = "skladišteToolStripMenuItem";
            this.skladišteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.skladišteToolStripMenuItem.Text = "&Skladište";
            this.skladišteToolStripMenuItem.Click += new System.EventHandler(this.skladišteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // primkaToolStripMenuItem
            // 
            this.primkaToolStripMenuItem.Name = "primkaToolStripMenuItem";
            this.primkaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.primkaToolStripMenuItem.Text = "Pri&mka";
            this.primkaToolStripMenuItem.Click += new System.EventHandler(this.primkaToolStripMenuItem_Click);
            // 
            // otpremnicaToolStripMenuItem
            // 
            this.otpremnicaToolStripMenuItem.Name = "otpremnicaToolStripMenuItem";
            this.otpremnicaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.otpremnicaToolStripMenuItem.Text = "&Otpremnica";
            this.otpremnicaToolStripMenuItem.Click += new System.EventHandler(this.otpremnicaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // poslovniPartneriToolStripMenuItem
            // 
            this.poslovniPartneriToolStripMenuItem.Name = "poslovniPartneriToolStripMenuItem";
            this.poslovniPartneriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.poslovniPartneriToolStripMenuItem.Text = "&Poslovni partneri";
            this.poslovniPartneriToolStripMenuItem.Click += new System.EventHandler(this.poslovniPartneriToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // šifrarnikToolStripMenuItem
            // 
            this.šifrarnikToolStripMenuItem.Name = "šifrarnikToolStripMenuItem";
            this.šifrarnikToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.šifrarnikToolStripMenuItem.Text = "&Šifrarnik";
            this.šifrarnikToolStripMenuItem.Click += new System.EventHandler(this.šifrarnikToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redoToolStripMenuItem,
            this.djelatniciToolStripMenuItem,
            this.adreseToolStripMenuItem,
            this.promjenakorisničkogRačunaToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(66, 20);
            this.editMenu.Text = "&Postavke";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.redoToolStripMenuItem.Text = "D&odaj skladište";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // djelatniciToolStripMenuItem
            // 
            this.djelatniciToolStripMenuItem.Name = "djelatniciToolStripMenuItem";
            this.djelatniciToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.djelatniciToolStripMenuItem.Text = "&Djelatnici";
            this.djelatniciToolStripMenuItem.Click += new System.EventHandler(this.djelatniciToolStripMenuItem_Click);
            // 
            // adreseToolStripMenuItem
            // 
            this.adreseToolStripMenuItem.Name = "adreseToolStripMenuItem";
            this.adreseToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.adreseToolStripMenuItem.Text = "&Adrese";
            this.adreseToolStripMenuItem.Click += new System.EventHandler(this.adreseToolStripMenuItem_Click);
            // 
            // promjenakorisničkogRačunaToolStripMenuItem
            // 
            this.promjenakorisničkogRačunaToolStripMenuItem.Name = "promjenakorisničkogRačunaToolStripMenuItem";
            this.promjenakorisničkogRačunaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.promjenakorisničkogRačunaToolStripMenuItem.Text = "Promjena &korisničkog računa";
            this.promjenakorisničkogRačunaToolStripMenuItem.Click += new System.EventHandler(this.promjenakorisničkogRačunaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.izlazToolStripMenuItem.Text = "&Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Managment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem skladišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem primkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otpremnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem poslovniPartneriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem šifrarnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem djelatniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenakorisničkogRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adreseToolStripMenuItem;
    }
}



