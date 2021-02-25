namespace ChooseGameSummative2222
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heartBox = new System.Windows.Forms.PictureBox();
            this.starBox = new System.Windows.Forms.PictureBox();
            this.diamondBox = new System.Windows.Forms.PictureBox();
            this.diamondLabel = new System.Windows.Forms.Label();
            this.starLabel = new System.Windows.Forms.Label();
            this.heartLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamondBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // heartBox
            // 
            this.heartBox.BackColor = System.Drawing.Color.Transparent;
            this.heartBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heartBox.BackgroundImage")));
            this.heartBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.heartBox.Location = new System.Drawing.Point(311, 271);
            this.heartBox.Name = "heartBox";
            this.heartBox.Size = new System.Drawing.Size(60, 33);
            this.heartBox.TabIndex = 18;
            this.heartBox.TabStop = false;
            // 
            // starBox
            // 
            this.starBox.BackColor = System.Drawing.Color.Transparent;
            this.starBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("starBox.BackgroundImage")));
            this.starBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.starBox.Location = new System.Drawing.Point(311, 324);
            this.starBox.Name = "starBox";
            this.starBox.Size = new System.Drawing.Size(60, 33);
            this.starBox.TabIndex = 17;
            this.starBox.TabStop = false;
            // 
            // diamondBox
            // 
            this.diamondBox.BackColor = System.Drawing.Color.Transparent;
            this.diamondBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamondBox.BackgroundImage")));
            this.diamondBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamondBox.Location = new System.Drawing.Point(311, 387);
            this.diamondBox.Name = "diamondBox";
            this.diamondBox.Size = new System.Drawing.Size(60, 33);
            this.diamondBox.TabIndex = 16;
            this.diamondBox.TabStop = false;
            // 
            // diamondLabel
            // 
            this.diamondLabel.ForeColor = System.Drawing.Color.Black;
            this.diamondLabel.Location = new System.Drawing.Point(380, 397);
            this.diamondLabel.Name = "diamondLabel";
            this.diamondLabel.Size = new System.Drawing.Size(194, 23);
            this.diamondLabel.TabIndex = 15;
            this.diamondLabel.Text = "Space Key";
            // 
            // starLabel
            // 
            this.starLabel.ForeColor = System.Drawing.Color.Black;
            this.starLabel.Location = new System.Drawing.Point(377, 334);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(194, 23);
            this.starLabel.TabIndex = 14;
            this.starLabel.Text = "N key";
            // 
            // heartLabel
            // 
            this.heartLabel.BackColor = System.Drawing.Color.Transparent;
            this.heartLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heartLabel.Location = new System.Drawing.Point(377, 281);
            this.heartLabel.Name = "heartLabel";
            this.heartLabel.Size = new System.Drawing.Size(197, 23);
            this.heartLabel.TabIndex = 13;
            this.heartLabel.Text = "M key";
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(308, 12);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(253, 200);
            this.textLabel.TabIndex = 12;
            // 
            // sceneImage
            // 
            this.sceneImage.BackColor = System.Drawing.Color.White;
            this.sceneImage.Location = new System.Drawing.Point(12, 12);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(273, 426);
            this.sceneImage.TabIndex = 11;
            this.sceneImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.heartBox);
            this.Controls.Add(this.starBox);
            this.Controls.Add(this.diamondBox);
            this.Controls.Add(this.diamondLabel);
            this.Controls.Add(this.starLabel);
            this.Controls.Add(this.heartLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.sceneImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.heartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamondBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox heartBox;
        private System.Windows.Forms.PictureBox starBox;
        private System.Windows.Forms.PictureBox diamondBox;
        private System.Windows.Forms.Label diamondLabel;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Label heartLabel;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox sceneImage;
    }
}

