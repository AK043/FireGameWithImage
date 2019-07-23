using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGameWithImage
{
    public class Gun_Shot
    {
       private int count = 0;
       static Random Random_Object = new Random();
        
        public int fire(int fire,int strt,int end)
        {
            int fire_Object = Random_Object.Next(strt, end);    
            if (fire == fire_Object)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("fire.wav");
                player.Play();
                count++;
                return count;
            }
            else {
                return 0;
            }
        }
        public void reset() {           
                count = 0;
            
        }

    }
    }

