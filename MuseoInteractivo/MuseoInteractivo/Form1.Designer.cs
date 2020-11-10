namespace MuseoInteractivo
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnStartMuseum = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMic = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCamara = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAux = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerCamara = new System.Windows.Forms.Timer(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartMuseum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1920, 1080);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnStartMuseum
            // 
            this.btnStartMuseum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.btnStartMuseum.Image = ((System.Drawing.Image)(resources.GetObject("btnStartMuseum.Image")));
            this.btnStartMuseum.ImageActive = null;
            this.btnStartMuseum.Location = new System.Drawing.Point(0, 910);
            this.btnStartMuseum.Name = "btnStartMuseum";
            this.btnStartMuseum.Size = new System.Drawing.Size(1920, 170);
            this.btnStartMuseum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStartMuseum.TabIndex = 1;
            this.btnStartMuseum.TabStop = false;
            this.btnStartMuseum.Zoom = 10;
            this.btnStartMuseum.Click += new System.EventHandler(this.btnStartMuseum_Click);
            // 
            // btnMic
            // 
            this.btnMic.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMic.Image = ((System.Drawing.Image)(resources.GetObject("btnMic.Image")));
            this.btnMic.ImageActive = null;
            this.btnMic.Location = new System.Drawing.Point(0, 910);
            this.btnMic.Name = "btnMic";
            this.btnMic.Size = new System.Drawing.Size(350, 170);
            this.btnMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMic.TabIndex = 5;
            this.btnMic.TabStop = false;
            this.btnMic.Zoom = 10;
            this.btnMic.Click += new System.EventHandler(this.btnMic_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCamara.Image = ((System.Drawing.Image)(resources.GetObject("btnCamara.Image")));
            this.btnCamara.ImageActive = null;
            this.btnCamara.Location = new System.Drawing.Point(1570, 910);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(350, 170);
            this.btnCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCamara.TabIndex = 6;
            this.btnCamara.TabStop = false;
            this.btnCamara.Zoom = 10;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1000);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelAux
            // 
            this.panelAux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(46)))));
            this.panelAux.Controls.Add(this.bunifuImageButton1);
            this.panelAux.Controls.Add(this.pictureBox2);
            this.panelAux.Location = new System.Drawing.Point(0, 910);
            this.panelAux.Name = "panelAux";
            this.panelAux.Size = new System.Drawing.Size(1927, 170);
            this.panelAux.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1446, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timerCamara
            // 
            this.timerCamara.Interval = 3000;
            this.timerCamara.Tick += new System.EventHandler(this.timerCamara_Tick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(921, 61);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.btnMic);
            this.Controls.Add(this.panelAux);
            this.Controls.Add(this.btnStartMuseum);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartMuseum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnStartMuseum;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuImageButton btnCamara;
        private Bunifu.Framework.UI.BunifuImageButton btnMic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAux;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerCamara;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

