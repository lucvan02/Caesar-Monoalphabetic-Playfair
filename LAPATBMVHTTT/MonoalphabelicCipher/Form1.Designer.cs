
namespace MonoalphabelicCipher
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDe = new System.Windows.Forms.Button();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.btnEn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlaintext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ciphertext";
            // 
            // btnDe
            // 
            this.btnDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDe.Location = new System.Drawing.Point(305, 150);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(77, 23);
            this.btnDe.TabIndex = 21;
            this.btnDe.Text = "Decrypt";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(185, 189);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(120, 24);
            this.txtCipher.TabIndex = 20;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(185, 104);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(120, 20);
            this.txtKey.TabIndex = 19;
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(185, 63);
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.Size = new System.Drawing.Size(120, 20);
            this.txtPlaintext.TabIndex = 18;
            // 
            // btnEn
            // 
            this.btnEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEn.Location = new System.Drawing.Point(108, 150);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(75, 23);
            this.btnEn.TabIndex = 17;
            this.btnEn.Text = "Encrypt";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Key";
            // 
            // lbPlaintext
            // 
            this.lbPlaintext.AutoSize = true;
            this.lbPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaintext.Location = new System.Drawing.Point(105, 70);
            this.lbPlaintext.Name = "lbPlaintext";
            this.lbPlaintext.Size = new System.Drawing.Size(56, 13);
            this.lbPlaintext.TabIndex = 15;
            this.lbPlaintext.Text = "Plaintext";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPlaintext);
            this.Name = "Form1";
            this.Text = "Monoalphabelic Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlaintext;
    }
}