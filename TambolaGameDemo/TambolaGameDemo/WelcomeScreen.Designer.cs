namespace TambolaGameDemo
{
    partial class WelcomeScreen
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
            this.hostButton = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TambolaGameDemo.Properties.Resources.ab916e3a_f0f4_4b94_9a12_95f915292fef___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hostButton
            // 
            this.hostButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hostButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostButton.Image = global::TambolaGameDemo.Properties.Resources.icons8_video_message_24__1_;
            this.hostButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hostButton.Location = new System.Drawing.Point(123, 233);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(186, 58);
            this.hostButton.TabIndex = 1;
            this.hostButton.Text = "Host Game";
            this.hostButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hostButton.UseVisualStyleBackColor = false;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.joinButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinButton.Image = global::TambolaGameDemo.Properties.Resources.icons8_video_message_24__1_;
            this.joinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.joinButton.Location = new System.Drawing.Point(123, 300);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(184, 58);
            this.joinButton.TabIndex = 2;
            this.joinButton.Text = "Join Game";
            this.joinButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            this.joinButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.joinButton_MouseClick);
            this.joinButton.MouseEnter += new System.EventHandler(this.joinButton_MouseEnter);
            this.joinButton.MouseLeave += new System.EventHandler(this.joinButton_MouseLeave);
            this.joinButton.MouseHover += new System.EventHandler(this.joinButton_MouseHover);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 541);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Button joinButton;
    }
}