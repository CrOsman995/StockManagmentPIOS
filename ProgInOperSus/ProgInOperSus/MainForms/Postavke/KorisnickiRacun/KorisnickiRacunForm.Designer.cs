namespace ProgInOperSus.MainForm
{
    partial class KorisnickiRacunForm
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
            this.korisnickiRacuniDGW = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnIzbrisiRacun = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisnickiRacuniDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // korisnickiRacuniDGW
            // 
            this.korisnickiRacuniDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisnickiRacuniDGW.Location = new System.Drawing.Point(12, 14);
            this.korisnickiRacuniDGW.Name = "korisnickiRacuniDGW";
            this.korisnickiRacuniDGW.Size = new System.Drawing.Size(583, 308);
            this.korisnickiRacuniDGW.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj / Uredi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnIzbrisiRacun
            // 
            this.btnIzbrisiRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiRacun.Location = new System.Drawing.Point(217, 343);
            this.btnIzbrisiRacun.Name = "btnIzbrisiRacun";
            this.btnIzbrisiRacun.Size = new System.Drawing.Size(163, 48);
            this.btnIzbrisiRacun.TabIndex = 2;
            this.btnIzbrisiRacun.Text = "Izbriši račun";
            this.btnIzbrisiRacun.UseVisualStyleBackColor = true;
            this.btnIzbrisiRacun.Click += new System.EventHandler(this.btnIzbrisiRacun_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.Location = new System.Drawing.Point(432, 343);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(163, 48);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // KorisnickiRacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 410);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzbrisiRacun);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.korisnickiRacuniDGW);
            this.Name = "KorisnickiRacunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija računima";
            ((System.ComponentModel.ISupportInitialize)(this.korisnickiRacuniDGW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView korisnickiRacuniDGW;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnIzbrisiRacun;
        private System.Windows.Forms.Button btnIzlaz;
    }
}