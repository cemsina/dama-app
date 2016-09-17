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
    public static class gameMain
    {
        public static bool checkMove(gamePlatform.move m)
        {
            if(Form1.gamePlatformObject.isFinished == true) { return false; }
            //checking turn
            gamePlatform.gameObject obj = Form1.gamePlatformObject.findGameObject(m.from);
            gamePlatform.objTeam teamTurn = turn();
            if (teamTurn != obj.team) { return false; }
            //checking to position
            bool toCheck = Form1.gamePlatformObject.checkPosition(m.to);
            if (toCheck == true)
            {
                return false;
            }
            Point toPos = positionToUnit(m.to);
            if (toPos.X > 8 || toPos.X < 1) { return false; }
            if (toPos.Y > 8 || toPos.Y < 1) { return false; }
            Point fromPos = positionToUnit(m.from);
            if (fromPos.X > 8 || fromPos.X < 1) { return false; }
            if (fromPos.Y > 8 || fromPos.Y < 1) { return false; }
            //checking From-To
            Point diff = new Point(Math.Abs(toPos.X - fromPos.X), Math.Abs(toPos.Y - fromPos.Y));
            if (diff.X > 0 && diff.Y > 0) { addFail(obj.team); return false; }
            if (diff.X == 0 && diff.Y == 0) { return false; }
            
            //check for back
            if(obj.isQueen == false)
            {
                if((obj.team == gamePlatform.objTeam.alpha) && (toPos.Y < fromPos.Y))
                {
                    addFail(obj.team);
                    return false;
                }
                if ((obj.team == gamePlatform.objTeam.beta) && (toPos.Y > fromPos.Y))
                {
                    addFail(obj.team);
                    return false;
                }
            }
            return true;
        }
        public static List<gamePlatform.gameObject> findObjectsBetweenTwoPositions(string pos1,string pos2)
        {
            if (Form1.gamePlatformObject.isFinished == true) { return new List<gamePlatform.gameObject>(); }
            List<gamePlatform.gameObject> list = new List<gamePlatform.gameObject>();
            Point from = positionToUnit(pos1);
            Point to = positionToUnit(pos2);
            Point diff = new Point(Math.Abs(from.X - to.X), Math.Abs(from.Y - to.Y));
            if((diff.X + diff.Y) < 2) { return list; }else
            {
                List<string> betweenPosList = new List<string>();
                if(diff.X > 0)
                {
                    //X direction
                    if(from.X > to.X)
                    {
                        // - direction
                        for(int i = 1; i < diff.X; i++)
                        {
                            string thisX = Form1.gamePlatformObject.verticalAxisToChar(from.X - i).ToString();
                            betweenPosList.Add(thisX + from.Y.ToString());
                        }
                    }else
                    {
                        // + diretion
                        for (int i = 1; i < diff.X; i++)
                        {
                            string thisX = Form1.gamePlatformObject.verticalAxisToChar(from.X + i).ToString();
                            betweenPosList.Add(thisX + from.Y.ToString());
                        }
                    }
                }
                if(diff.Y > 0)
                {
                    //Y direction
                    if(from.Y < to.Y)
                    {
                        // + direction
                        for (int i = 1; i < diff.Y; i++)
                        {
                            string thisX = Form1.gamePlatformObject.verticalAxisToChar(from.X).ToString();
                            int thisY = from.Y + i;
                            betweenPosList.Add(thisX + thisY);
                        }
                    }
                    else
                    {
                        // - direction
                        for (int i = 1; i < diff.Y; i++)
                        {
                            string thisX = Form1.gamePlatformObject.verticalAxisToChar(from.X).ToString();
                            int thisY = from.Y - i;
                            betweenPosList.Add(thisX + thisY);
                        }
                    }

                }
                foreach (string p in betweenPosList)
                {
                    bool check = Form1.gamePlatformObject.checkPosition(p);
                    if (check == true)
                    {
                        gamePlatform.gameObject g = Form1.gamePlatformObject.findGameObject(p);
                        list.Add(g);
                    }
                }
                return list;
            }
            
        }
        public static void move(gamePlatform.moves moves)
        {
            if (Form1.gamePlatformObject.isFinished == true) { return; }
            gamePlatform.moves completedMoves = new gamePlatform.moves();
            List<gamePlatform.move> completedMoveList = new List<gamePlatform.move>();
            List<gamePlatform.move> moveList = moves.moveList;
            bool shouldEat = false;
            if (checkMove(moveList[0]) == false) { return; }
            gamePlatform.gameObject obj = Form1.gamePlatformObject.findGameObject(moveList[0].from);
            completedMoves.team = obj.team;
            foreach (gamePlatform.move m in moveList)
            {
                if(checkMove(m) == false) { break; }
                Point toPos = positionToUnit(m.to);
                Point fromPos = positionToUnit(m.from);
                Point diff = new Point(Math.Abs(toPos.X - fromPos.X), Math.Abs(toPos.Y - fromPos.Y));
                List<gamePlatform.gameObject> between = findObjectsBetweenTwoPositions(m.from, m.to);
                if(between.Count > 1) {
                    addFail(obj.team);
                    Form1.gamePlatformObject.movesList.Add(moves);
                    break;
                }else if(between.Count == 1)
                {
                    //eat
                    if(obj.isQueen == false)
                    {
                        if(diff.X > 2 || diff.Y > 2)
                        {
                            addFail(obj.team);
                            Form1.gamePlatformObject.movesList.Add(moves);
                            break;
                        }
                        string ateObjPos = between[0].position;
                        Form1.gamePlatformObject.eatObjectByPosition(ateObjPos);
                        obj.position = m.to;
                        gamePlatform.move cm = new gamePlatform.move(m.from,m.to);
                        completedMoveList.Add(cm);
                    }
                    else
                    {
                        string ateObjPos = between[0].position;
                        Form1.gamePlatformObject.eatObjectByPosition(ateObjPos);
                        obj.position = m.to;
                        gamePlatform.move cm = new gamePlatform.move(m.from, m.to);
                        completedMoveList.Add(cm);
                    }
                }else
                {
                    if(shouldEat == true)
                    {
                        addFail(obj.team);
                        Form1.gamePlatformObject.movesList.Add(moves);
                        break;
                    }
                    if(obj.isQueen == false)
                    {
                        if(diff.X > 1 || diff.Y > 1)
                        {
                            addFail(obj.team);
                            Form1.gamePlatformObject.movesList.Add(moves);
                            break;
                        }
                    }
                    
                    obj.position = m.to;
                    gamePlatform.move cm = new gamePlatform.move(m.from, m.to);
                    completedMoveList.Add(cm);
                }
                shouldEat = true;
                if(obj.team == gamePlatform.objTeam.alpha)
                {
                    Point objPosPoint = positionToUnit(obj.position);
                    if (objPosPoint.Y == 8)
                    {
                        obj.isQueen = true;
                    }
                }else
                {
                    Point objPosPoint = positionToUnit(obj.position);
                    if (objPosPoint.Y == 1)
                    {
                        obj.isQueen = true;
                    }
                }
            }
            Form1.gamePlatformObject.movesList.Add(moves);
            completedMoves.moveList = completedMoveList;
            if(completedMoves.moveList.Count() > 0)
            {
                Form1.gamePlatformObject.completedMovesList.Add(completedMoves);
            }
            //last
            last();
        }
        public static void winner(gamePlatform.objTeam team)
        {
            MessageBox.Show("Winner : " + team.ToString(), "Game Over");
            Form1.gamePlatformObject.isFinished = true;
        }
        public static void checkFails()
        {
            if (Form1.gamePlatformObject.alphaFails >= 3)
            {
                winner(gamePlatform.objTeam.beta);
            }
            if(Form1.gamePlatformObject.betaFails >= 3)
            {
                winner(gamePlatform.objTeam.alpha);
            }
        }
        public static void last()
        {
            bool alphaDama = false;
            bool betaDama = false;
            int alphaCount = stoneCount(gamePlatform.objTeam.alpha);
            int betaCount = stoneCount(gamePlatform.objTeam.beta);
            Form1.gamePlatformObject.alphaCount = alphaCount;
            Form1.gamePlatformObject.betaCount = betaCount;
           
            if (alphaCount == 1)
            {
                alphaDama = true;
            }
            if (betaCount == 1)
            {
                betaDama = true;
            }
            foreach (gamePlatform.gameObject g in Form1.gamePlatformObject.gameObjectList)
            {
                if (alphaDama == true && g.team == gamePlatform.objTeam.alpha)
                {
                    g.isQueen = true;
                }
                if (betaDama == true && g.team == gamePlatform.objTeam.beta)
                {
                    g.isQueen = true;
                }
            }
        }
        public static void checkWinner()
        {
            if (Form1.gamePlatformObject.alphaCount == 0)
            {
                Form1.gamePlatformObject.isFinished = true;
                winner(gamePlatform.objTeam.beta);
            }
            if (Form1.gamePlatformObject.betaCount == 0)
            {
                Form1.gamePlatformObject.isFinished = true;
                winner(gamePlatform.objTeam.alpha);
            }
        }
        public static int stoneCount(gamePlatform.objTeam team)
        {
            int c = 0;
            foreach(gamePlatform.gameObject g in Form1.gamePlatformObject.gameObjectList)
            {
                if(g.team == team)
                {
                    c++;
                }
            }
            return c;
        }
        public static void moveWithPos(List<string> posList)
        {
            if(Form1.gamePlatformObject.isFinished == true) { return; }
            if (posList.Count() < 1) { return; }
            List<gamePlatform.move> moveL = new List<gamePlatform.move>();
            gamePlatform.moves moves = new gamePlatform.moves();
            gamePlatform.gameObject selectedGameObj = Form1.gamePlatformObject.findGameObject(posList[0]);
            moves.team = selectedGameObj.team;
            for (int i = 1; i < posList.Count(); i++)
            {
                gamePlatform.move newMove = new gamePlatform.move(posList[i - 1], posList[i]);
                moveL.Add(newMove);
            }
            moves.moveList = moveL;
            gameMain.move(moves);
            Form1.gamePlatformObject.reDrawObjects();
        }
        public static void addFail(gamePlatform.objTeam team)
        {
            if (Form1.gamePlatformObject.isFinished == true) { return; }
            if (team == gamePlatform.objTeam.alpha)
            {
                Form1.gamePlatformObject.alphaFails += 1;
            }
            else
            {
                Form1.gamePlatformObject.betaFails += 1;
            }
            
        }
        public static Point positionToUnit(string pos)
        {
            char[] posArr = pos.ToCharArray();
            return new Point(Form1.gamePlatformObject.verticalAxisToInt(posArr[0]),Int32.Parse(posArr[1].ToString()));
        }
       
        public static gamePlatform.objTeam turn()
        {
            if (Form1.gamePlatformObject.isFinished == true) { return gamePlatform.objTeam.alpha; }
            if (Form1.gamePlatformObject.completedMovesList.Count() > 0)
            {
                gamePlatform.objTeam lastPlay = Form1.gamePlatformObject.movesList[Form1.gamePlatformObject.movesList.Count() - 1].team;
                if (lastPlay == gamePlatform.objTeam.alpha)
                {
                    return gamePlatform.objTeam.beta;
                }
                else
                {
                    return gamePlatform.objTeam.alpha;
                }
            }else
            {
                return gamePlatform.objTeam.alpha;
            }
        }
    }
}
