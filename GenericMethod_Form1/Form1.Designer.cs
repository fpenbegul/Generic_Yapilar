namespace GenericMethod_Form1
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
            this.btnChar = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnBool = new System.Windows.Forms.Button();
            this.btnDatetime = new System.Windows.Forms.Button();
            this.btnAraba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(50, 51);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(118, 51);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "INT";
            this.btnInt.UseVisualStyleBackColor = true;
            // 
            // btnChar
            // 
            this.btnChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar.Location = new System.Drawing.Point(200, 51);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(118, 51);
            this.btnChar.TabIndex = 0;
            this.btnChar.Text = "CHAR";
            this.btnChar.UseVisualStyleBackColor = true;
            // 
            // btnString
            // 
            this.btnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnString.Location = new System.Drawing.Point(50, 122);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(118, 51);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "STRING";
            this.btnString.UseVisualStyleBackColor = true;
            // 
            // btnBool
            // 
            this.btnBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBool.Location = new System.Drawing.Point(200, 122);
            this.btnBool.Name = "btnBool";
            this.btnBool.Size = new System.Drawing.Size(118, 51);
            this.btnBool.TabIndex = 0;
            this.btnBool.Text = "BOOL";
            this.btnBool.UseVisualStyleBackColor = true;
            // 
            // btnDatetime
            // 
            this.btnDatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatetime.Location = new System.Drawing.Point(50, 188);
            this.btnDatetime.Name = "btnDatetime";
            this.btnDatetime.Size = new System.Drawing.Size(118, 51);
            this.btnDatetime.TabIndex = 0;
            this.btnDatetime.Text = "DATETIME";
            this.btnDatetime.UseVisualStyleBackColor = true;
            // 
            // btnAraba
            // 
            this.btnAraba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAraba.Location = new System.Drawing.Point(200, 188);
            this.btnAraba.Name = "btnAraba";
            this.btnAraba.Size = new System.Drawing.Size(118, 51);
            this.btnAraba.TabIndex = 0;
            this.btnAraba.Text = "ARABA";
            this.btnAraba.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 443);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnAraba);
            this.Controls.Add(this.btnDatetime);
            this.Controls.Add(this.btnBool);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnBool;
        private System.Windows.Forms.Button btnDatetime;
        private System.Windows.Forms.Button btnAraba;
    }
}

