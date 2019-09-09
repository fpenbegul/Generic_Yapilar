namespace Generic_Interface_Form3
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
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(12, 12);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(276, 59);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "INTEGER";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.BtnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(12, 89);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(276, 59);
            this.btnDouble.TabIndex = 0;
            this.btnDouble.Text = "DOUBLE";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(12, 166);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(276, 59);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "STRING";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.BtnString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 273);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnString;
    }
}

