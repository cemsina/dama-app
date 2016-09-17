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
    public partial class settings : Form
    {

        public Color alphaSettingsColor;        
        public Color betaSettingsColor;
        public Color lineSettingsColor;
        public settings()
        {
            InitializeComponent();
            alphaColorText.Text = Form1.gamePlatformObject.alphaColor.ToString();
            betaColorText.Text = Form1.gamePlatformObject.betaColor.ToString();
            alphaColor.Color = Form1.gamePlatformObject.alphaColor;
            betaColor.Color = Form1.gamePlatformObject.betaColor;
            alphaSettingsColor = Form1.gamePlatformObject.alphaColor;
            betaSettingsColor = Form1.gamePlatformObject.betaColor;
            startLocX.Text = Form1.gamePlatformObject.startPosition.X.ToString();
            startLocY.Text = Form1.gamePlatformObject.startPosition.Y.ToString();
            unitSize.Text = Form1.gamePlatformObject.eachUnit.ToString();
            lineWidth.Text = Form1.gamePlatformObject.tableLineWidth.ToString();
            lineColor.Color = Form1.gamePlatformObject.tableLineColor;
            lineColorText.Text = Form1.gamePlatformObject.tableLineColor.ToString();
            lineSettingsColor = Form1.gamePlatformObject.tableLineColor;
            turnTextX.Text = Form1.gamePlatformObject.turnTextLocation.X.ToString();
            turnTextY.Text = Form1.gamePlatformObject.turnTextLocation.Y.ToString();

        }
        public void convertEmptiesToZero(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                data = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            convertEmptiesToZero(startLocX.Text);
            convertEmptiesToZero(startLocY.Text);
            convertEmptiesToZero(unitSize.Text);
            convertEmptiesToZero(lineWidth.Text);
            convertEmptiesToZero(turnTextX.Text);
            convertEmptiesToZero(turnTextY.Text);
            Form1.gamePlatformObject.startPosition.X = Int32.Parse(startLocX.Text);
            Form1.gamePlatformObject.startPosition.Y = Int32.Parse(startLocY.Text);
            Form1.gamePlatformObject.eachUnit = Int32.Parse(unitSize.Text);
            Panel Form1Panel = Application.OpenForms["Form1"].Controls["panel"] as Panel;
            Form1.gamePlatformObject.alphaColor = alphaSettingsColor;
            Form1.gamePlatformObject.betaColor = betaSettingsColor;
            Form1.gamePlatformObject.tableLineColor = lineSettingsColor;
            Form1.gamePlatformObject.tableLineWidth = Int32.Parse(lineWidth.Text);
            Form1.gamePlatformObject.turnTextLocation.X = Int32.Parse(turnTextX.Text);
            Form1.gamePlatformObject.turnTextLocation.Y = Int32.Parse(turnTextY.Text);
            Form1Panel.Refresh();
            Form1.gamePlatformObject.reDrawObjects();
        }

        private void alphaColorSelect_Click(object sender, EventArgs e)
        {
            DialogResult newColor = alphaColor.ShowDialog();
            if(newColor == DialogResult.OK)
            {
                alphaSettingsColor = alphaColor.Color;
                alphaColorText.Text = alphaSettingsColor.ToString();
            }

        }

        private void betaColorSelect_Click(object sender, EventArgs e)
        {
            DialogResult newColor = betaColor.ShowDialog();
            if (newColor == DialogResult.OK)
            {
                betaSettingsColor = betaColor.Color;
                betaColorText.Text = betaSettingsColor.ToString();
            }
        }

        private void lineColorSelect_Click(object sender, EventArgs e)
        {
            DialogResult newColor = lineColor.ShowDialog();
            if (newColor == DialogResult.OK)
            {
                lineSettingsColor = lineColor.Color;
                lineColorText.Text = lineSettingsColor.ToString();
            }
        }
    }
}
