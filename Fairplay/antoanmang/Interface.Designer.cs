namespace antoanmang
{
    partial class Interface
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
            this.btnPlayFair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayFair
            // 
            this.btnPlayFair.Location = new System.Drawing.Point(99, 28);
            this.btnPlayFair.Name = "btnPlayFair";
            this.btnPlayFair.Size = new System.Drawing.Size(125, 51);
            this.btnPlayFair.TabIndex = 5;
            this.btnPlayFair.Text = "Playfair";
            this.btnPlayFair.UseVisualStyleBackColor = true;
            this.btnPlayFair.Click += new System.EventHandler(this.btnPlayFair_Click_1);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayFair);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPlayFair;
    }
}