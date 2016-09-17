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
    public static class panelMouseEvents
    {
        public static Point mouseLocation()
        {
            Panel p = Application.OpenForms["Form1"].Controls["panel"] as Panel;
            return p.PointToClient(Cursor.Position);
        }
        public static string locationToStrPosition(Point pt)
        {
            string tablePosX = Form1.gamePlatformObject.verticalAxisToChar(((pt.X - Form1.gamePlatformObject.startPosition.X)/Form1.gamePlatformObject.eachUnit)+1).ToString();
            string tablePosY = (8 - ((pt.Y - Form1.gamePlatformObject.startPosition.Y)/ Form1.gamePlatformObject.eachUnit)).ToString();
            return tablePosX + tablePosY;
        }
        public static Point locationToUnit(Point pt)
        {
            Point unitPt = new Point();
            unitPt.X = ((pt.X - Form1.gamePlatformObject.startPosition.X) / Form1.gamePlatformObject.eachUnit) + 1;
            unitPt.Y = (8 - ((pt.Y - Form1.gamePlatformObject.startPosition.Y) / Form1.gamePlatformObject.eachUnit));
            return unitPt;
        }
        public static void selectPosition(string pos)
        {
            int unit = Form1.gamePlatformObject.eachUnit/2;
            Point location = Form1.gamePlatformObject.getLocation(pos);
            Point[] rect = new Point[4];
            rect[0] = new Point(location.X - unit, location.Y - unit);
            rect[1] = new Point(location.X + unit, location.Y - unit);
            rect[2] = new Point(location.X + unit, location.Y + unit);
            rect[3] = new Point(location.X - unit, location.Y + unit);
            Color col = Color.FromArgb(Form1.gamePlatformObject.selectOpacity, Form1.gamePlatformObject.selectColor);
            Form1.gamePlatformObject.drawPolgon(rect, col);
        }
        public static void panelMouseClick()
        {
            if(Form1.gamePlatformObject.isFinished == true){
                return;
            }
            Point mouseLoc = mouseLocation();
            Point unitLoc = locationToUnit(mouseLoc);
            if(unitLoc.X < 1 || unitLoc.X > 8 || unitLoc.Y < 1 || unitLoc.Y > 8)
            {
                return;
            }
            string pos = locationToStrPosition(mouseLoc);
            if(Form1.gamePlatformObject.selectedMemories.Count() == 0)
            {
                if (Form1.gamePlatformObject.checkPosition(pos) == false)
                {
                    return;
                }
                gamePlatform.gameObject obj = Form1.gamePlatformObject.findGameObject(pos);
                gamePlatform.objTeam teamTurn = gameMain.turn();
                if(obj.team != teamTurn) { return; }
            }
            Form1.gamePlatformObject.selectedMemories.Add(pos);
            selectPosition(pos);

        }
    }
}
