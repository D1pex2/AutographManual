namespace AuthographManual
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manualButton = new System.Windows.Forms.Button();
            this.videoButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AuthographManual.Properties.Resources.autograph;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // manualButton
            // 
            this.manualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.manualButton.FlatAppearance.BorderSize = 0;
            this.manualButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manualButton.ForeColor = System.Drawing.Color.White;
            this.manualButton.Location = new System.Drawing.Point(12, 168);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(360, 23);
            this.manualButton.TabIndex = 1;
            this.manualButton.Text = "Руководство пользователя";
            this.manualButton.UseVisualStyleBackColor = false;
            this.manualButton.Click += new System.EventHandler(this.ManualButton_Click);
            // 
            // videoButton
            // 
            this.videoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.videoButton.FlatAppearance.BorderSize = 0;
            this.videoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.videoButton.ForeColor = System.Drawing.Color.White;
            this.videoButton.Location = new System.Drawing.Point(12, 197);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(360, 23);
            this.videoButton.TabIndex = 2;
            this.videoButton.Text = "Видеоролик по руководству";
            this.videoButton.UseVisualStyleBackColor = false;
            this.videoButton.Click += new System.EventHandler(this.VideoButton_Click);
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(240)))));
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.Location = new System.Drawing.Point(12, 226);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(360, 23);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "Тестирование";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.videoButton);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Основы работы в Автограф";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button videoButton;
        private System.Windows.Forms.Button testButton;
    }
}