namespace OgrenciKayit_ETF
{
    partial class OgrenciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciListesi));
            this.dgwOgrenciListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOgrenciListele
            // 
            this.dgwOgrenciListele.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgwOgrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciListele.Location = new System.Drawing.Point(13, 77);
            this.dgwOgrenciListele.Name = "dgwOgrenciListele";
            this.dgwOgrenciListele.RowHeadersWidth = 51;
            this.dgwOgrenciListele.RowTemplate.Height = 24;
            this.dgwOgrenciListele.Size = new System.Drawing.Size(540, 329);
            this.dgwOgrenciListele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ ARA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 2;
            // 
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwOgrenciListele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRENCİ LİSTESİ";
            this.Load += new System.EventHandler(this.OgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOgrenciListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}