namespace WindowsFormsApplication5
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pipe4 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pipe3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.scorebox = new System.Windows.Forms.Label();
            this.HPbox = new System.Windows.Forms.Label();
            this.gameovertext = new System.Windows.Forms.Label();
            this.bowser = new System.Windows.Forms.PictureBox();
            this.princesspeach = new System.Windows.Forms.PictureBox();
            this.wintext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.princesspeach)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.maintimer);
            // 
            // coin3
            // 
            this.coin3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin3.BackgroundImage")));
            this.coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin3.Location = new System.Drawing.Point(179, 187);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(39, 32);
            this.coin3.TabIndex = 11;
            this.coin3.TabStop = false;
            this.coin3.Tag = "Energy";
            // 
            // coin4
            // 
            this.coin4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin4.BackgroundImage")));
            this.coin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin4.Location = new System.Drawing.Point(250, 187);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(39, 32);
            this.coin4.TabIndex = 11;
            this.coin4.TabStop = false;
            this.coin4.Tag = "Energy";
            // 
            // coin5
            // 
            this.coin5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin5.BackgroundImage")));
            this.coin5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin5.Location = new System.Drawing.Point(317, 187);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(39, 32);
            this.coin5.TabIndex = 11;
            this.coin5.TabStop = false;
            this.coin5.Tag = "Energy";
            // 
            // coin1
            // 
            this.coin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin1.BackgroundImage")));
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin1.Location = new System.Drawing.Point(179, 330);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(39, 32);
            this.coin1.TabIndex = 11;
            this.coin1.TabStop = false;
            this.coin1.Tag = "Energy";
            // 
            // coin2
            // 
            this.coin2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coin2.BackgroundImage")));
            this.coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin2.Location = new System.Drawing.Point(250, 330);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(39, 32);
            this.coin2.TabIndex = 11;
            this.coin2.TabStop = false;
            this.coin2.Tag = "Energy";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(734, 31);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(734, 31);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pipe4
            // 
            this.pipe4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipe4.BackgroundImage")));
            this.pipe4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipe4.Location = new System.Drawing.Point(1, 63);
            this.pipe4.Name = "pipe4";
            this.pipe4.Size = new System.Drawing.Size(81, 50);
            this.pipe4.TabIndex = 7;
            this.pipe4.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipe2.BackgroundImage")));
            this.pipe2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipe2.Location = new System.Drawing.Point(1, 204);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(81, 50);
            this.pipe2.TabIndex = 5;
            this.pipe2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipe1
            // 
            this.pipe1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipe1.BackgroundImage")));
            this.pipe1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipe1.Location = new System.Drawing.Point(654, 348);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(81, 50);
            this.pipe1.TabIndex = 4;
            this.pipe1.TabStop = false;
            // 
            // player
            // 
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(1, 326);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(55, 63);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pipe3
            // 
            this.pipe3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipe3.BackgroundImage")));
            this.pipe3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipe3.Location = new System.Drawing.Point(654, 204);
            this.pipe3.Name = "pipe3";
            this.pipe3.Size = new System.Drawing.Size(81, 50);
            this.pipe3.TabIndex = 6;
            this.pipe3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(564, 187);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(51, 50);
            this.enemy2.TabIndex = 9;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "turtle";
            // 
            // enemy1
            // 
            this.enemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy1.BackgroundImage")));
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Location = new System.Drawing.Point(564, 330);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(51, 50);
            this.enemy1.TabIndex = 9;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "turtle";
            // 
            // scorebox
            // 
            this.scorebox.AutoSize = true;
            this.scorebox.Location = new System.Drawing.Point(685, 2);
            this.scorebox.Name = "scorebox";
            this.scorebox.Size = new System.Drawing.Size(0, 13);
            this.scorebox.TabIndex = 12;
            // 
            // HPbox
            // 
            this.HPbox.AutoSize = true;
            this.HPbox.Location = new System.Drawing.Point(12, 2);
            this.HPbox.Name = "HPbox";
            this.HPbox.Size = new System.Drawing.Size(0, 13);
            this.HPbox.TabIndex = 13;
            // 
            // gameovertext
            // 
            this.gameovertext.AutoSize = true;
            this.gameovertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gameovertext.Location = new System.Drawing.Point(212, 9);
            this.gameovertext.Name = "gameovertext";
            this.gameovertext.Size = new System.Drawing.Size(314, 55);
            this.gameovertext.TabIndex = 14;
            this.gameovertext.Text = "GAME OVER";
            this.gameovertext.Visible = false;
            // 
            // bowser
            // 
            this.bowser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bowser.BackgroundImage")));
            this.bowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bowser.Location = new System.Drawing.Point(543, 20);
            this.bowser.Name = "bowser";
            this.bowser.Size = new System.Drawing.Size(109, 83);
            this.bowser.TabIndex = 15;
            this.bowser.TabStop = false;
            // 
            // princesspeach
            // 
            this.princesspeach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("princesspeach.BackgroundImage")));
            this.princesspeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.princesspeach.Location = new System.Drawing.Point(658, 43);
            this.princesspeach.Name = "princesspeach";
            this.princesspeach.Size = new System.Drawing.Size(75, 60);
            this.princesspeach.TabIndex = 16;
            this.princesspeach.TabStop = false;
            // 
            // wintext
            // 
            this.wintext.AutoSize = true;
            this.wintext.Font = new System.Drawing.Font("NSimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wintext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(34)))));
            this.wintext.Location = new System.Drawing.Point(259, 12);
            this.wintext.Name = "wintext";
            this.wintext.Size = new System.Drawing.Size(220, 48);
            this.wintext.TabIndex = 17;
            this.wintext.Text = "YOU WON!";
            this.wintext.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(138)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(732, 401);
            this.Controls.Add(this.wintext);
            this.Controls.Add(this.princesspeach);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bowser);
            this.Controls.Add(this.gameovertext);
            this.Controls.Add(this.HPbox);
            this.Controls.Add(this.scorebox);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pipe3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.princesspeach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.PictureBox pipe3;
        private System.Windows.Forms.PictureBox pipe4;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.Label scorebox;
        private System.Windows.Forms.Label HPbox;
        private System.Windows.Forms.Label gameovertext;
        private System.Windows.Forms.PictureBox bowser;
        private System.Windows.Forms.PictureBox princesspeach;
        private System.Windows.Forms.Label wintext;
    }
}

