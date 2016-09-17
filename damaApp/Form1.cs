using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damaApp
{
    public partial class Form1 : Form
    {
        public bool gameButtonGroupVisibility
        {
            get { return gameButtonGroup.Visible; }
            set { gameButtonGroup.Visible = value; }
        }
        public  Graphics panelGraphic;
        
        public static gamePlatform gamePlatformObject;
        public Form1()
        {
            InitializeComponent();
            gamePlatformObject = new gamePlatform(this);
            
        }
        
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            
            base.OnPaint(e);
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            gamePlatformObject.reDrawObjects();

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamePlatformObject.newGame();
            gamePlatformObject.reDrawObjects();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new settings();
            settingsForm.Show();
        }

        
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = Application.OpenForms["Form1"].Controls["panel"] as Panel;
            p.BackColor = gamePlatformObject.tableColor;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(gamePlatformObject.isFinished == true) { return; }
            string moveStr = fromT.Text;
            gameMain.moveWithPos(gamePlatformObject.selectedMemories);
            gamePlatformObject.selectedMemories.Clear();
        }
        
        private void panel_Click(object sender, EventArgs e)
        {
            if(gamePlatformObject.isFinished == true) { return; }
            panelMouseEvents.panelMouseClick();
            fromT.Text = "";
            int i = 0;
            foreach(string t in gamePlatformObject.selectedMemories)
            {
                if(i > 0)
                {
                    fromT.Text += "," + t;
                }else
                {
                    fromT.Text += t;
                }
                i++;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show("hi");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gamePlatformObject.reDrawObjects();
        }
    }
}
