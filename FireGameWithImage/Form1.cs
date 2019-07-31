using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGameWithImage
{

  
    public partial class Form1 : Form
    {
        //global variable that are used in the whole task to perform different functionality 
        private int load = 0,spin=0,fire=0,chk=0;
        private int strt = 1, end = 3;
        //global object of  the different class that are used to call the method of that class with the help of refrenece 
        Gun_Shot gun_Shot_Object = new Gun_Shot();
        Random Random_Object = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Lad_Bullet_Click(object sender, EventArgs e)
        {
            //this condition is used to check  the value of no of bullet  the no of bullet value must be greater than 0 and less than 6
            pictureBox1.ImageLocation = "fire.jpg";
            if (No_Of_Bullet.Value > 0 && No_Of_Bullet.Value < 7)
            {
                load++;
            }
            else {
                MessageBox.Show("Bullet value must be greater than 0 and less than 6");
            }
        }

        private void Fire_Gun_Click(object sender, EventArgs e)
        {
            //this method is used to fire the gun and count the fire with the help  of the fire 
            fire++;

            //this condition is used to check the load button or spin button if the user first clk on that button then it will work otheriwise generate an error message
            if (load == 1 && spin == 1)
            {
                chk = gun_Shot_Object.fire(fire, strt, end);

                
               //this condition is used to find the winner or looser from the game if the player is winnner then the spot image will be dispaly other wise the next function will be execute 
                if (chk > 0 && chk == Random_Object.Next(1, 3))
                {
                    pictureBox1.ImageLocation = "spot.jpg";
                    //this method is used to reset the count variable so the game will be execute again 
                    MessageBox.Show("you are the Winner of this game");
                    
                    load = 0;
                    spin = 0;
                }

              else if (chk == 2)
                {
                    //this block execute  when the game is over and display the looser message 
                    MessageBox.Show("your Game is over and you  not win the game");
                    //this method is used to reset the count variable so the game will be execute again 
                    gun_Shot_Object.reset();
                    load = 0;
                    spin = 0;
                }
              //  MessageBox.Show("" + chk);
                strt = 3; end = 6;
            }
           //if the game is over and the player click on the fire button again and again then this error message will be genreated
            if (load==0 && spin==0) {
                MessageBox.Show("Gun is Empty fist load the gun with bullet to fire and also spin");
                load = 0;
                spin = 0;
                fire = 0;
                chk = 0;
                strt = 1; end = 2;
                gun_Shot_Object.reset();
            }
            if (fire==6) {
                fire = 0;
                strt = 1; end = 2;
                MessageBox.Show("Game is Over Reload it Again");

                load = 0;
                spin = 0;
                fire = 0;
                chk = 0;
                strt = 1; end = 2;

                //System.Windows.Forms.Application.Exit();
            }
        }
        
        private void No_Of_Bullet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Spin_Gun_Click(object sender, EventArgs e)
        {
            // this  condition is used to verfiy the spin button
            //if the user directly click on the fire button or without click on the load buttonthen it will generate an error messsage 
            if (load > 0)
            {
                //this counter is used to check the click on spin button 
                spin++;
            }
            else {
                MessageBox.Show("Gun is Empty fist load the bullet to fire");
            }
            
        }
    }
}
