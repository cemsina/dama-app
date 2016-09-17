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
    
    public class gamePlatform 
    {
        public Form1 gameForm;
        public int alphaCount = 16;
        public int betaCount = 16;
        private bool p_isFinished = true;
        public bool isFinished {
            get { return p_isFinished; }
            set
            {
                p_isFinished = value;
                if(p_isFinished == true)
                {
                    gameForm.gameButtonGroupVisibility = false;
                }else
                {
                    gameForm.gameButtonGroupVisibility = true;
                }
            }
        }
        public List<string> selectedMemories;
        public List<moves> completedMovesList;
        public Color selectColor;
        public int selectOpacity;
        public Point turnTextLocation;
        public int alphaFails;
        public int betaFails;
        public Color tableTextColor = Color.Black;
        public List<moves> movesList;
        public Color tableColor = Color.LightGray;
        public int tableLineWidth = 1;
        public Color tableLineColor = Color.Black;
        public Color alphaColor = Color.Red;
        public Color betaColor = Color.Blue; 
        public int eachUnit = 50;
        public Point startPosition = new Point(100, 100);
        public List<gameObject> gameObjectList;
        public Graphics panel;
        public enum objTeam
        {
            alpha,
            beta
        }
        public class moves
        {
            public List<move> moveList;
            public objTeam team;
        }
        public class move
        {
            public string from;
            public string to;
            public move(string f,string t)
            {
                from = f;to = t;
            }
        }
        public class gameObject
        {
            public bool isQueen;
            public string position;
            public objTeam team;

        }
       public gamePlatform(Form1 form)
        {
            gameForm = form;
        }
       public void newGraphic()
        {
            Panel p = Application.OpenForms["Form1"].Controls["panel"] as Panel;
            panel = p.CreateGraphics();
        }

        public int verticalAxisToInt(char letter)
        {
            int newAxis;
            switch (letter)
            {
                case 'a':
                    newAxis = 1;
                    break;
                case 'b':
                    newAxis = 2;
                    break;
                case 'c':
                    newAxis = 3;
                    break;
                case 'd':
                    newAxis = 4;
                    break;
                case 'e':
                    newAxis = 5;
                    break;
                case 'f':
                    newAxis = 6;
                    break;
                case 'g':
                    newAxis = 7;
                    break;
                case 'h':
                    newAxis = 8;
                    break;
                default:
                    newAxis = 0;
                    break;
            }
            return newAxis;
        }
        public char verticalAxisToChar(int loc)
        {
            char newAxis;
            switch (loc)
            {
                case 1:
                    newAxis = 'a';
                    break;
                case 2:
                    newAxis = 'b';
                    break;
                case 3:
                    newAxis = 'c';
                    break;
                case 4:
                    newAxis = 'd';
                    break;
                case 5:
                    newAxis = 'e';
                    break;
                case 6:
                    newAxis = 'f';
                    break;
                case 7:
                    newAxis = 'g';
                    break;
                case 8:
                    newAxis = 'h';
                    break;
                default:
                    newAxis = 'x';
                    break;
            }
            return newAxis;
        }
        public void drawPolgon(Point[] points, Color color, float width = 0)
        {
            newGraphic();
            SolidBrush polygonBrush = new SolidBrush(color);
            using (panel)
            {
                panel.FillPolygon(polygonBrush, points);
            }
        }
        public void drawCircle(Point point,int radius,Color color,float width = 0)
        {
            newGraphic();
            Size rectSize = new Size();
            rectSize.Width = radius * 2;
            rectSize.Height = radius * 2;
            point.X -= radius;
            point.Y -= radius;
            Rectangle rect = new Rectangle(point, rectSize);
            SolidBrush ellipseBrush = new SolidBrush(color);
            
            using (panel)
            {
                panel.FillEllipse(ellipseBrush, rect);
                panel.DrawEllipse(new Pen(Color.Black, width), rect);
            }
        }
        public void drawLine(Point point1,Point point2,Color color, float width)
        {
            newGraphic();
            using (panel)
            {
                panel.DrawLine(new Pen(color, width), point1, point2);
            }
        }
        public void eatObjectByPosition(string pos)
        {
            foreach(gameObject gObj in gameObjectList)
            {
                if(gObj.position == pos)
                {
                    gameObjectList.Remove(gObj);
                    return;
                }
            }
        }
        public void newGame()
        {
            isFinished = false;
            alphaCount = 16;
            betaCount = 16;
            alphaFails = 0;betaFails = 0;
            gameObjectList = new List<gameObject>();
            movesList = new List<moves>();
            completedMovesList = new List<moves>();
            selectedMemories = new List<string>();
            turnTextLocation = new Point(600, 200);
            selectColor = Color.Gray;
            selectOpacity = 80;
        string alpha = "a2,a3,b2,b3,c2,c3,d2,d3,e2,e3,f2,f3,g2,g3,h2,h3";
            string beta = "a6,a7,b6,b7,c6,c7,d6,d7,e6,e7,f6,f7,g6,g7,h6,h7";
            //alpha
            List<string> alphaList = project.DataExp(alpha);
            foreach(string p in alphaList)
            {
                gameObject g = new gameObject();
                g.position = p;
                g.team = objTeam.alpha;
                gameObjectList.Add(g);
            }

            //beta
            List<string> betaList = project.DataExp(beta);
            foreach (string p in betaList)
            {
                gameObject g = new gameObject();
                g.position = p;
                g.team = objTeam.beta;
                gameObjectList.Add(g);
            }
        }
        public gameObject findGameObject(string pos)
        {
            foreach(gameObject g in gameObjectList)
            {
                if(g.position == pos) { return g; }
            }
            return new gameObject();
        }
        public int findGameObjectID(string pos)
        {
            int i = 0;
            foreach (gameObject g in gameObjectList)
            {
                if (g.position == pos) { return i; }
                i++;
            }
            return 0;
        }
        
        public Point getLocation(string strLoc)
        {
            Point UnitPos = gameMain.positionToUnit(strLoc);
            Point realLoc = new Point();
            realLoc.X = startPosition.X + ((UnitPos.X - 1) * eachUnit) + (eachUnit / 2);
            realLoc.Y = startPosition.Y + ((8 - UnitPos.Y) * eachUnit) + (eachUnit / 2);
            return realLoc;
        }
        
        public void reDrawObjects()
        {
            if (Form1.gamePlatformObject.isFinished == true) { return; }
            Panel p = Application.OpenForms["Form1"].Controls["panel"] as Panel;
            p.Refresh();
            drawTable();
            objTeam teamTurn = gameMain.turn();

            if (teamTurn == objTeam.alpha)
            {
                drawText(turnTextLocation,"Alpha Team Turn",alphaColor);
            }else
            {
                drawText(turnTextLocation, "Beta Team Turn", betaColor);
            }
            //alpha fails text
            Point textPtAlpha = new Point();
            textPtAlpha.X = startPosition.X;
            textPtAlpha.Y = startPosition.Y + eachUnit * 8 + eachUnit;
            drawText(textPtAlpha, "Alpha Fails : " + alphaFails.ToString() + " / 3", alphaColor);

            //beta fails text
            Point textPtBeta = new Point();
            textPtBeta.X = startPosition.X;
            textPtBeta.Y = startPosition.Y - eachUnit;
            drawText(textPtBeta, "Beta Fails : " + betaFails.ToString() + " / 3", betaColor);

            foreach (gameObject g in gameObjectList)
            {
                Point loc = getLocation(g.position);
                int width = 0;
                if (g.isQueen == true)
                {
                    width = eachUnit/5;
                }
                if(g.team == objTeam.alpha)
                {
                    drawCircle(loc, eachUnit / 3, alphaColor,width);
                }else
                {
                    drawCircle(loc, eachUnit/3, betaColor,width);
                }
                
            }
            Form1.gamePlatformObject.selectedMemories.Clear();
            gameMain.checkWinner();
            gameMain.checkFails();
        }
        public void drawText(Point pt,string text,Color color)
        {
            newGraphic();
            StringFormat drawFormat = new StringFormat();
            Font drawFont = new System.Drawing.Font("Arial", eachUnit/5);
            SolidBrush drawBrush = new SolidBrush(color);
            panel.DrawString(text, drawFont, drawBrush, pt.X, pt.Y, drawFormat);
        }
        public bool checkPosition(string pos)
        {
            foreach(gameObject g in gameObjectList)
            {
                if(g.position == pos)
                {
                    return true;
                }
            }
            return false;
        }
        public void drawTable()
        {
            //vertical
            int maxY = startPosition.Y + (8 * eachUnit);
            for(int i = 0; i < 9; i++)
            {
                //lines
                int ptX = startPosition.X + (i * eachUnit);
                Point pt1 = new Point(ptX, startPosition.Y);
                Point pt2 = new Point(ptX, maxY);
                drawLine(pt1, pt2, tableLineColor, tableLineWidth);
                //texts
                if(i < 8)
                {
                    string text = verticalAxisToChar(i + 1).ToString();
                    drawText(new Point(ptX + eachUnit/2, maxY + eachUnit / 3), text, tableTextColor);

                }
            }
            //horizonal
            int maxX = startPosition.X + (8 * eachUnit);
            for (int i = 0; i < 9; i++)
            {
                //lines
                int ptY = startPosition.Y + (i * eachUnit);
                Point pt1 = new Point(startPosition.X, ptY);
                Point pt2 = new Point(maxX, ptY);
                drawLine(pt1, pt2, tableLineColor, tableLineWidth);
                //texts
                if(i > 0)
                {
                    string text = (8 - i + 1).ToString();
                    drawText(new Point(startPosition.X - (eachUnit / 3), ptY - (eachUnit / 2)), text, tableTextColor);

                }
            }
        }
    }
}
