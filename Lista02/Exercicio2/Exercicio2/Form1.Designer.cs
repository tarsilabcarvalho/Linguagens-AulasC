namespace Exercicio2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myPics = new System.Windows.Forms.ImageList(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // myPics
            // 
            this.myPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myPics.ImageStream")));
            this.myPics.TransparentColor = System.Drawing.Color.Transparent;
            this.myPics.Images.SetKeyName(0, "die1.gif");
            this.myPics.Images.SetKeyName(1, "die2.gif");
            this.myPics.Images.SetKeyName(2, "die3.gif");
            this.myPics.Images.SetKeyName(3, "die4.gif");
            this.myPics.Images.SetKeyName(4, "die5.gif");
            this.myPics.Images.SetKeyName(5, "die6.gif");
            this.myPics.Images.SetKeyName(6, "fabio1.jpg");
            this.myPics.Images.SetKeyName(7, "fabio2.jpg");
            this.myPics.Images.SetKeyName(8, "fabio3.jpg");
            this.myPics.Images.SetKeyName(9, "fabio4.jpg");
            this.myPics.Images.SetKeyName(10, "feliz.JPG");
            this.myPics.Images.SetKeyName(11, "indiferente.JPG");
            this.myPics.Images.SetKeyName(12, "louco.JPG");
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(36, 41);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(217, 183);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList myPics;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

