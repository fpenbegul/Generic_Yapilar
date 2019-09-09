namespace GenericMethod_Form2
{
    partial class Form1
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
            this.lbxSonuc = new System.Windows.Forms.ListBox();
            this.btnIntArrayOlustur = new System.Windows.Forms.Button();
            this.btnBoyutlandir = new System.Windows.Forms.Button();
            this.btnStringArrayOlustur = new System.Windows.Forms.Button();
            this.btnStringBoyutlandir = new System.Windows.Forms.Button();
            this.btnKisiOlustur = new System.Windows.Forms.Button();
            this.btnKisiBoyutlandir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSonuc
            // 
            this.lbxSonuc.FormattingEnabled = true;
            this.lbxSonuc.Location = new System.Drawing.Point(12, 12);
            this.lbxSonuc.Name = "lbxSonuc";
            this.lbxSonuc.Size = new System.Drawing.Size(323, 303);
            this.lbxSonuc.TabIndex = 0;
            // 
            // btnIntArrayOlustur
            // 
            this.btnIntArrayOlustur.Location = new System.Drawing.Point(342, 13);
            this.btnIntArrayOlustur.Name = "btnIntArrayOlustur";
            this.btnIntArrayOlustur.Size = new System.Drawing.Size(343, 23);
            this.btnIntArrayOlustur.TabIndex = 1;
            this.btnIntArrayOlustur.Text = "Int Array Oluştur";
            this.btnIntArrayOlustur.UseVisualStyleBackColor = true;
            this.btnIntArrayOlustur.Click += new System.EventHandler(this.BtnIntArrayOlustur_Click);
            // 
            // btnBoyutlandir
            // 
            this.btnBoyutlandir.Location = new System.Drawing.Point(341, 42);
            this.btnBoyutlandir.Name = "btnBoyutlandir";
            this.btnBoyutlandir.Size = new System.Drawing.Size(343, 23);
            this.btnBoyutlandir.TabIndex = 1;
            this.btnBoyutlandir.Text = "Int Array Boyutlandır";
            this.btnBoyutlandir.UseVisualStyleBackColor = true;
            this.btnBoyutlandir.Click += new System.EventHandler(this.BtnBoyutlandir_Click);
            // 
            // btnStringArrayOlustur
            // 
            this.btnStringArrayOlustur.Location = new System.Drawing.Point(342, 123);
            this.btnStringArrayOlustur.Name = "btnStringArrayOlustur";
            this.btnStringArrayOlustur.Size = new System.Drawing.Size(343, 23);
            this.btnStringArrayOlustur.TabIndex = 1;
            this.btnStringArrayOlustur.Text = "String Array Oluştur";
            this.btnStringArrayOlustur.UseVisualStyleBackColor = true;
            this.btnStringArrayOlustur.Click += new System.EventHandler(this.BtnStringArrayOlustur_Click);
            // 
            // btnStringBoyutlandir
            // 
            this.btnStringBoyutlandir.Location = new System.Drawing.Point(341, 152);
            this.btnStringBoyutlandir.Name = "btnStringBoyutlandir";
            this.btnStringBoyutlandir.Size = new System.Drawing.Size(343, 23);
            this.btnStringBoyutlandir.TabIndex = 1;
            this.btnStringBoyutlandir.Text = "String Array Boyutlandır";
            this.btnStringBoyutlandir.UseVisualStyleBackColor = true;
            this.btnStringBoyutlandir.Click += new System.EventHandler(this.BtnStringBoyutlandir_Click);
            // 
            // btnKisiOlustur
            // 
            this.btnKisiOlustur.Location = new System.Drawing.Point(342, 259);
            this.btnKisiOlustur.Name = "btnKisiOlustur";
            this.btnKisiOlustur.Size = new System.Drawing.Size(343, 23);
            this.btnKisiOlustur.TabIndex = 1;
            this.btnKisiOlustur.Text = "Kisi Array Oluştur";
            this.btnKisiOlustur.UseVisualStyleBackColor = true;
            this.btnKisiOlustur.Click += new System.EventHandler(this.BtnKisiOlustur_Click);
            // 
            // btnKisiBoyutlandir
            // 
            this.btnKisiBoyutlandir.Location = new System.Drawing.Point(342, 288);
            this.btnKisiBoyutlandir.Name = "btnKisiBoyutlandir";
            this.btnKisiBoyutlandir.Size = new System.Drawing.Size(343, 23);
            this.btnKisiBoyutlandir.TabIndex = 1;
            this.btnKisiBoyutlandir.Text = "Kisi Array Boyutlandır";
            this.btnKisiBoyutlandir.UseVisualStyleBackColor = true;
            this.btnKisiBoyutlandir.Click += new System.EventHandler(this.BtnKisiBoyutlandir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 327);
            this.Controls.Add(this.btnKisiBoyutlandir);
            this.Controls.Add(this.btnStringBoyutlandir);
            this.Controls.Add(this.btnBoyutlandir);
            this.Controls.Add(this.btnKisiOlustur);
            this.Controls.Add(this.btnStringArrayOlustur);
            this.Controls.Add(this.btnIntArrayOlustur);
            this.Controls.Add(this.lbxSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSonuc;
        private System.Windows.Forms.Button btnIntArrayOlustur;
        private System.Windows.Forms.Button btnBoyutlandir;
        private System.Windows.Forms.Button btnStringArrayOlustur;
        private System.Windows.Forms.Button btnStringBoyutlandir;
        private System.Windows.Forms.Button btnKisiOlustur;
        private System.Windows.Forms.Button btnKisiBoyutlandir;
    }
}

