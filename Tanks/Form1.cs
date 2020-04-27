using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }
        int DMG = 0;
        PCVehicle T54 = new PCVehicle("T54", 120, 55, "HEAT", 40);
        PCVehicle M48 = new PCVehicle("M48", 100, 75, "HEAT", 40);
        PCVehicle Player = new PCVehicle();
        EnemyVehicle T54B = new EnemyVehicle("T54", 120, 55);
        EnemyVehicle M48B = new EnemyVehicle("M48", 100, 75);
        EnemyVehicle Enemy = new EnemyVehicle();
       
        private void button4_Click(object sender, EventArgs e)
        {
            
            Player = T54;
            Player.stats(richTextBoxEvent);
            richTextBoxEvent.Text+= PCVehicle.Welcome();
            groupBoxTankSelect.Visible = false;
            groupBoxAmmo.Visible = true;
            groupBox2PCinfo.Visible = true;
            groupBoxEinfo.Visible = true;
            textBoxPCHP.Text = Convert.ToString(Player.getArmorThickness);
            textBoxPCModel.Text = Player.getModel;
            Random rand = new Random();
            int random = rand.Next(1, 3);
            if (random == 1) { Enemy = T54B; }
            else if (random == 2) { Enemy = M48B; }
            textBoxEHP.Text = Convert.ToString(Enemy.getArmorThickness);
            textBoxEModel.Text = Enemy.getModel;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Player = M48;
            Player.stats(richTextBoxEvent);
            richTextBoxEvent.Text += PCVehicle.Welcome();
            groupBoxTankSelect.Visible = false;
            groupBoxAmmo.Visible = true;
            groupBox2PCinfo.Visible = true;
            groupBoxEinfo.Visible = true;
            textBoxPCHP.Text = Convert.ToString(Player.getArmorThickness);
            textBoxPCModel.Text = Player.getModel;
            Random rand = new Random();
            int random = rand.Next(1, 3);
            if (random == 1) { Enemy = T54B; }
            else if (random == 2) { Enemy = M48B; }
            textBoxEHP.Text = Convert.ToString(Enemy.getArmorThickness);
            textBoxEModel.Text = Enemy.getModel;
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHEAT_Click(object sender, EventArgs e)
        {
            DMG = Player.getGun_dmg + Player.getAmmo.getPen;
            Random rand = new Random();

            int random = rand.Next(0, 2);
            
            int Erandom = rand.Next(0, 3);
            if (Erandom == 0) 
            {
                Player.getArmorThickness -= Enemy.getGun_dmg;
                textBoxPCHP.Text = Player.getArmorThickness.ToString();
                richTextBoxEvent.Text += "Enemy "+Enemy.getModel+" hit you for " +Enemy.getGun_dmg+"\n";
            }

            if (random == 0) { richTextBoxEvent.Text += "You Missed Enemy" + Enemy.getModel + " with " + Player.getAmmo.getType + "\n"; }
            else if (random == 1)
            {
                richTextBoxEvent.Text += "You Hit Enemy " + Enemy.getModel + " for " + DMG + " with " + Player.getAmmo.getType + "\n";
                Enemy.getArmorThickness = Enemy.getArmorThickness - DMG;
                textBoxEHP.Text = Convert.ToString(Enemy.getArmorThickness);
            }
                if (Enemy.getArmorThickness <= 0)
                {
                    richTextBoxEvent.Text += "You Won ! " + "\n";
                    Enemy.getArmorThickness = 0;
                    textBoxEHP.Text = Convert.ToString(Enemy.getArmorThickness);
                    groupBoxAmmo.Visible = false;
                }
            
            if (Player.getArmorThickness <= 0)
            {
                richTextBoxEvent.Text += "You Lost ! " + "\n";
                Player.getArmorThickness = 0;
                textBoxPCHP.Text = Player.getArmorThickness.ToString();
                groupBoxAmmo.Visible = false;
            }


        }

        private void buttonAPCBC_Click(object sender, EventArgs e)
        {
            DMG = Player.getGun_dmg;
            Random rand = new Random();

            
            int Erandom = rand.Next(0, 3);
            if (Erandom == 0)
            {
                Player.getArmorThickness -= Enemy.getGun_dmg;
                textBoxPCHP.Text = Player.getArmorThickness.ToString();
                richTextBoxEvent.Text += "Enemy " + Enemy.getModel + " hit you for " + Enemy.getGun_dmg + "\n";
            }
            
            int random = rand.Next(0, 2);
            if (random == 0) { richTextBoxEvent.Text += "You Missed Enemy" + Enemy.getModel + " with " + "APCBC" + "\n"; }
            else if (random == 1)
            {
                richTextBoxEvent.Text += "You Hit Enemy " + Enemy.getModel + " for " + DMG + " with " + "APCBC" + "\n";
                Enemy.getArmorThickness = Enemy.getArmorThickness - DMG;
                textBoxEHP.Text = Convert.ToString(Enemy.getArmorThickness);
            }
                if (Player.getArmorThickness <= 0)
                {
                    richTextBoxEvent.Text += "You Lost ! " + "\n";
                    Player.getArmorThickness = 0;
                    textBoxPCHP.Text = Player.getArmorThickness.ToString();
                    groupBoxAmmo.Visible = false;
                }
                if (Enemy.getArmorThickness <= 0)
                {
                    richTextBoxEvent.Text += "You Won" + "\n";
                    Enemy.getArmorThickness = 0;
                    textBoxEHP.Text = Convert.ToString(Enemy.getArmorThickness);
                    groupBoxAmmo.Visible = false;
                }
            
        }

        private void richTextBoxEvent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
