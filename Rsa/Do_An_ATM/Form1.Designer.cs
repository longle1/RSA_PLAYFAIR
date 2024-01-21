namespace Do_An_ATM
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
            this.tbCiphertext = new System.Windows.Forms.TextBox();
            this.tbPlaintextDecryption = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCipherUploaded = new System.Windows.Forms.TextBox();
            this.btnUploadFilePlaintext = new System.Windows.Forms.Button();
            this.btnUploadFileCipher = new System.Windows.Forms.Button();
            this.btnDownloadCiphertext = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCiphertext
            // 
            this.tbCiphertext.Location = new System.Drawing.Point(15, 479);
            this.tbCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.tbCiphertext.Multiline = true;
            this.tbCiphertext.Name = "tbCiphertext";
            this.tbCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCiphertext.Size = new System.Drawing.Size(345, 188);
            this.tbCiphertext.TabIndex = 6;
            // 
            // tbPlaintextDecryption
            // 
            this.tbPlaintextDecryption.Location = new System.Drawing.Point(414, 479);
            this.tbPlaintextDecryption.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaintextDecryption.Multiline = true;
            this.tbPlaintextDecryption.Name = "tbPlaintextDecryption";
            this.tbPlaintextDecryption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlaintextDecryption.Size = new System.Drawing.Size(345, 188);
            this.tbPlaintextDecryption.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ciphertext";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.Location = new System.Drawing.Point(15, 128);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(162, 54);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.Location = new System.Drawing.Point(200, 128);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(146, 54);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Location = new System.Drawing.Point(15, 243);
            this.tbPlaintext.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlaintext.Size = new System.Drawing.Size(345, 177);
            this.tbPlaintext.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Plaintext";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.BackColor = System.Drawing.Color.White;
            this.btnGenerateKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerateKeys.Location = new System.Drawing.Point(388, 128);
            this.btnGenerateKeys.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(157, 54);
            this.btnGenerateKeys.TabIndex = 16;
            this.btnGenerateKeys.Text = "Random Key";
            this.btnGenerateKeys.UseVisualStyleBackColor = false;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbPublicKey.Location = new System.Drawing.Point(147, 84);
            this.tbPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(183, 22);
            this.tbPublicKey.TabIndex = 17;
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbPrivateKey.Location = new System.Drawing.Point(378, 84);
            this.tbPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(193, 22);
            this.tbPrivateKey.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(411, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Plaintext after using decryption";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(145, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Public Key:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(375, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Private Key:";
            // 
            // txtQ
            // 
            this.txtQ.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQ.Location = new System.Drawing.Point(185, 21);
            this.txtQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(145, 22);
            this.txtQ.TabIndex = 28;
            // 
            // txtP
            // 
            this.txtP.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtP.Location = new System.Drawing.Point(34, 21);
            this.txtP.Margin = new System.Windows.Forms.Padding(4);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(130, 22);
            this.txtP.TabIndex = 29;
            // 
            // txtPhi
            // 
            this.txtPhi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPhi.Location = new System.Drawing.Point(348, 21);
            this.txtPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(150, 22);
            this.txtPhi.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "P:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(182, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Q:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(345, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Φ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(518, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtN.Location = new System.Drawing.Point(521, 21);
            this.txtN.Margin = new System.Windows.Forms.Padding(4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(238, 22);
            this.txtN.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(410, 205);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "Upload File";
            // 
            // tbCipherUploaded
            // 
            this.tbCipherUploaded.Location = new System.Drawing.Point(414, 243);
            this.tbCipherUploaded.Margin = new System.Windows.Forms.Padding(4);
            this.tbCipherUploaded.Multiline = true;
            this.tbCipherUploaded.Name = "tbCipherUploaded";
            this.tbCipherUploaded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCipherUploaded.Size = new System.Drawing.Size(345, 177);
            this.tbCipherUploaded.TabIndex = 36;
            // 
            // btnUploadFilePlaintext
            // 
            this.btnUploadFilePlaintext.BackColor = System.Drawing.Color.White;
            this.btnUploadFilePlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFilePlaintext.Location = new System.Drawing.Point(123, 190);
            this.btnUploadFilePlaintext.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadFilePlaintext.Name = "btnUploadFilePlaintext";
            this.btnUploadFilePlaintext.Size = new System.Drawing.Size(161, 49);
            this.btnUploadFilePlaintext.TabIndex = 38;
            this.btnUploadFilePlaintext.Text = "Upload File";
            this.btnUploadFilePlaintext.UseVisualStyleBackColor = false;
            this.btnUploadFilePlaintext.Click += new System.EventHandler(this.btnUploadFilePlaintext_Click);
            // 
            // btnUploadFileCipher
            // 
            this.btnUploadFileCipher.BackColor = System.Drawing.Color.White;
            this.btnUploadFileCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUploadFileCipher.Location = new System.Drawing.Point(540, 190);
            this.btnUploadFileCipher.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadFileCipher.Name = "btnUploadFileCipher";
            this.btnUploadFileCipher.Size = new System.Drawing.Size(174, 49);
            this.btnUploadFileCipher.TabIndex = 39;
            this.btnUploadFileCipher.Text = "Upload File";
            this.btnUploadFileCipher.UseVisualStyleBackColor = false;
            this.btnUploadFileCipher.Click += new System.EventHandler(this.btnUploadFileCipher_Click);
            // 
            // btnDownloadCiphertext
            // 
            this.btnDownloadCiphertext.BackColor = System.Drawing.Color.White;
            this.btnDownloadCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDownloadCiphertext.Location = new System.Drawing.Point(123, 433);
            this.btnDownloadCiphertext.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadCiphertext.Name = "btnDownloadCiphertext";
            this.btnDownloadCiphertext.Size = new System.Drawing.Size(132, 43);
            this.btnDownloadCiphertext.TabIndex = 40;
            this.btnDownloadCiphertext.Text = "Download";
            this.btnDownloadCiphertext.UseVisualStyleBackColor = false;
            this.btnDownloadCiphertext.Click += new System.EventHandler(this.btnDownloadCiphertext_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.Location = new System.Drawing.Point(593, 128);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(157, 54);
            this.btnClearAll.TabIndex = 41;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(790, 680);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnDownloadCiphertext);
            this.Controls.Add(this.btnUploadFileCipher);
            this.Controls.Add(this.btnUploadFilePlaintext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbCipherUploaded);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhi);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrivateKey);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPlaintext);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlaintextDecryption);
            this.Controls.Add(this.tbCiphertext);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCiphertext;
        private System.Windows.Forms.TextBox tbPlaintextDecryption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCipherUploaded;
        private System.Windows.Forms.Button btnUploadFilePlaintext;
        private System.Windows.Forms.Button btnUploadFileCipher;
        private System.Windows.Forms.Button btnDownloadCiphertext;
        private System.Windows.Forms.Button btnClearAll;
    }
}

