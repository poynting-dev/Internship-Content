namespace TambolaGameDemo
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
            this.hostbutton1 = new System.Windows.Forms.Button();
            this.joinbutton1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hostbutton1
            // 
            this.hostbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hostbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hostbutton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostbutton1.Image = global::TambolaGameDemo.Properties.Resources.icons8_video_message_24__1_;
            this.hostbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hostbutton1.Location = new System.Drawing.Point(133, 241);
            this.hostbutton1.Name = "hostbutton1";
            this.hostbutton1.Size = new System.Drawing.Size(185, 53);
            this.hostbutton1.TabIndex = 1;
            this.hostbutton1.Text = "Host Game";
            this.hostbutton1.UseVisualStyleBackColor = false;
            this.hostbutton1.Click += new System.EventHandler(this.hostbutton1_Click);
            this.hostbutton1.MouseCaptureChanged += new System.EventHandler(this.hostButton1_MouseCaptureChanged);
            this.hostbutton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hostbutton1_MouseDown);
            this.hostbutton1.MouseEnter += new System.EventHandler(this.hostbutton1_MouseEnter);
            this.hostbutton1.MouseLeave += new System.EventHandler(this.hostbutton1_MouseLeave);
            this.hostbutton1.MouseHover += new System.EventHandler(this.hostbutton1_MouseHover);
            // 
            // joinbutton1
            // 
            this.joinbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.joinbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.joinbutton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinbutton1.Image = global::TambolaGameDemo.Properties.Resources.icons8_video_message_24__1_;
            this.joinbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.joinbutton1.Location = new System.Drawing.Point(133, 300);
            this.joinbutton1.Name = "joinbutton1";
            this.joinbutton1.Size = new System.Drawing.Size(185, 53);
            this.joinbutton1.TabIndex = 2;
            this.joinbutton1.Text = "Join Game";
            this.joinbutton1.UseVisualStyleBackColor = false;
            this.joinbutton1.Click += new System.EventHandler(this.joinButton1_Click);
            this.joinbutton1.MouseCaptureChanged += new System.EventHandler(this.hostButton1_MouseCaptureChanged);
            this.joinbutton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hostbutton1_MouseDown);
            this.joinbutton1.MouseEnter += new System.EventHandler(this.hostbutton1_MouseEnter);
            this.joinbutton1.MouseLeave += new System.EventHandler(this.hostbutton1_MouseLeave);
            this.joinbutton1.MouseHover += new System.EventHandler(this.hostbutton1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TambolaGameDemo.Properties.Resources.ab916e3a_f0f4_4b94_9a12_95f915292fef___Copy;
            this.pictureBox2.Location = new System.Drawing.Point(121, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(463, 494);
            this.Controls.Add(this.joinbutton1);
            this.Controls.Add(this.hostbutton1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button hostbutton1;
        public System.Windows.Forms.Button joinbutton1;
    }
}

