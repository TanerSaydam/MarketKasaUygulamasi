namespace MarketKasaApp
{
    partial class Form2
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
            this.gBAdet = new System.Windows.Forms.GroupBox();
            this.btnVazgeç = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBAdet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBAdet
            // 
            this.gBAdet.Controls.Add(this.btnVazgeç);
            this.gBAdet.Controls.Add(this.btnKaydet);
            this.gBAdet.Controls.Add(this.txtAdet);
            this.gBAdet.Controls.Add(this.label1);
            this.gBAdet.Location = new System.Drawing.Point(12, 12);
            this.gBAdet.Name = "gBAdet";
            this.gBAdet.Size = new System.Drawing.Size(303, 216);
            this.gBAdet.TabIndex = 11;
            this.gBAdet.TabStop = false;
            // 
            // btnVazgeç
            // 
            this.btnVazgeç.Location = new System.Drawing.Point(26, 161);
            this.btnVazgeç.Name = "btnVazgeç";
            this.btnVazgeç.Size = new System.Drawing.Size(253, 44);
            this.btnVazgeç.TabIndex = 3;
            this.btnVazgeç.Text = "Vazgeç";
            this.btnVazgeç.UseVisualStyleBackColor = true;
            this.btnVazgeç.Click += new System.EventHandler(this.btnVazgeç_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(26, 109);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(253, 46);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(26, 64);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(253, 39);
            this.txtAdet.TabIndex = 1;
            this.txtAdet.Text = "1";
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 237);
            this.Controls.Add(this.gBAdet);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Adedi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gBAdet.ResumeLayout(false);
            this.gBAdet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gBAdet;
        private Button btnVazgeç;
        private Button btnKaydet;
        private TextBox txtAdet;
        private Label label1;
    }
}