using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        bool moveleft, moveright,attack,stop;
        int speed = 10;
        int enemyspeed1 = 3;
        int enemyspeed2 = 3;
        int score = 0;
        int hp = 3;
        int bowserhp = 2;
        
        private void maintimer(object sender, EventArgs e)
        {
            scorebox.Text = "Energy" + score;
            HPbox.Text = "HP" + hp;
            
            //win event

            if(player.Bounds.IntersectsWith(princesspeach.Bounds))
            {
                this.player.Location = new System.Drawing.Point(585, 40);
                this.player.BackgroundImage = Properties.Resources.super_mario_world_super_mario_bros_luigi_pixel_art_86c2534a019e603d4db83b92b443f78f;
                gametimer.Stop();
                stop = true;
                wintext.Visible = true;
                
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "Energy")
                    {
                        if(player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if ((string)x.Tag == "turtle")
                    {
                        //hurt

                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            hp--;
                            this.player.Location = new System.Drawing.Point(1, 326);
                            HPbox.Text = "HP" + hp;
                            if (hp == 0)
                            {
                                gametimer.Stop();
                                stop = true;
                                player.Visible = false;
                                gameovertext.Visible = true;
                            }
                        }

                        //attack

                        int Length3 = Math.Abs(bowser.Left - player.Left);
                        int Length1 = Math.Abs(enemy1.Left - player.Left);
                        int Length2 = Math.Abs(enemy2.Left - player.Left);
                        if (score != 0 && attack == true)
                        {
                            if (Length1 < 80 && player.Location.Y == 326)
                            {
                                enemy1.Visible = false;
                            }
                            if (Length2 < 80 && player.Location.Y == 181) 
                            {
                                enemy2.Visible = false;
                            }
                            if (Length3 < 80 && player.Location.Y == 47)
                            {
                                
                                if(bowserhp == 0)
                                {
                                    bowser.Visible = false;
                                }
                                bowserhp--;
                            }
                        }
                        
                        

                    }

                }
            }

            
            
            //enemy1

            {
                enemy1.Left -= enemyspeed1;

                if (enemy1.Left < 250 || enemy1.Left + enemy1.Width > 654)
                {
                    enemyspeed1 = -enemyspeed1;
                }
                if (enemy1.Left > 600)
                {
                    this.enemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy1.BackgroundImage")));
                }
                if (enemy1.Left < 255)
                {
                    this.enemy1.BackgroundImage = Properties.Resources.InShot_20250109_020405086;
                }
            }

            //enemy2

            {
                enemy2.Left -= enemyspeed2;

                if (enemy2.Left < 180 || enemy2.Left + enemy2.Width > 654)
                {
                    enemyspeed2 = -enemyspeed2;
                }
                if (enemy2.Left > 600)
                {
                    this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
                }
                if (enemy2.Left < 185)
                {
                    this.enemy2.BackgroundImage = Properties.Resources.InShot_20250109_020405086;
                }
            }

            //player

            {
                if (moveright == true && player.Left < 672)
                {
                    player.Left += speed;
                }
                if (moveleft == true && player.Left > 0)
                {
                    player.Left -= speed;
                }
                if (player.Location.X > 654 && player.Location.Y > 300)
                {
                    this.player.Location = new System.Drawing.Point(1, 181);
                }
                else if (player.Location.X > 654 && player.Location.Y > 160 && player.Location.Y < 299)
                {
                    this.player.Location = new System.Drawing.Point(1, 47);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && stop == false)
            {
                moveleft = true;
                this.player.BackgroundImage = Properties.Resources.InShot_20250108_195744311;

            }
            if (e.KeyCode == Keys.Right && stop == false)
            {
                moveright = true;
                this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
                this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if(e.KeyCode == Keys.B && stop == false)
            {
                attack = true;
                score--;
            }
        }
        
        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = false;
            }
            if (e.KeyCode == Keys.B)
            {
                attack = false;
            }
        }
        
    }
}
