using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpGame
{
    
    public partial class Form1 : Form
    {
        double money = 1;
        double multy = 1; //print -1
        double rebirth = 1;
        double rebirth2 = 1;
        double rebirth3 = 1;
        double rebirth4 = 1;





        int lvl = 0;
        
        public void labels()
        {
            label1.Text = "Money: " + Math.Round(money, 2).ToString();
            label2.Text = "Multy: " + Math.Round(multy-1, 2).ToString();
            label3.Text = "Rebirth: " + Math.Round(rebirth-1, 2).ToString();
            label4.Text = "Rebirth2: " + Math.Round(rebirth2-1, 2).ToString();
            label5.Text = "Rebirth3: " + Math.Round(rebirth3-1, 2).ToString();
            label6.Text = "Rebirth4: " + Math.Round(rebirth4-1, 2).ToString();
        }
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            labels();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            money = ((money+1*multy)+(rebirth/100*20));
            labels();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (money>= 25)
            {
                money = money -25;
                multy = (multy + 1 * rebirth);
                labels();
            }
            else
            {
                labels();
            }

        }




        private void button11_Click(object sender, EventArgs e)
        {
            if (multy>= 25)
            {
                money = 1;
                multy = 1;
                rebirth = (rebirth + 1 * rebirth2);
                labels();
            }
            else
            {
                labels();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money>= 500)
            {
                money = money -500;
                multy = (multy + 4 * rebirth);
                labels();
            }
            else
            {
                labels();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money>= 100)
            {
                money = money -100;
                multy = (multy + 2 * rebirth);
                labels();
            }
            else
            {
                labels();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money>= 2500)
            {
                money = money -2500;
                multy = (multy + 8 * rebirth);
                labels();
            }
            else
            {
                labels();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (money>= 10000)
            {
                money = money -10000;
                multy = (multy + 15 * rebirth);
                labels();
            }
            else
            {
                labels();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (money>= 50000)
            {
                money = money -50000;
                multy = (multy + 30 * rebirth);
                labels();
            }
            else
            {
                labels();
            }
        }
    }
}
