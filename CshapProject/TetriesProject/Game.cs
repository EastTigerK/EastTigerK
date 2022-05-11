using System.Drawing;

namespace TetriesProject
{
    internal class Game
    {
        Diagram now;
        Board gboard = Board.GameBoard;
        internal Point NowPosition
        {
            get
            {
                if (now == null)//포인트의 현재위치값이 null이면
                {
                    return new Point(0, 0);
                }
                return new Point(now.x, now.y);
            }
        }

        internal int BlockNum
        {
            get
            {
                return now.BlockNum;
            }
        }
        internal int Turn
        {
            get
            {
                return now.Turn;
            }
        }
        internal static Game Singleton//싱글톤사용
        {
            get;
            private set;
        }
        internal int this[int x, int y]
        {
            get
            {
                return gboard[x, y];
            }
        }
        static Game()
        {
            Singleton = new Game();
        }
        Game()
        {
            now = new Diagram();
        }

        internal bool MoveRight()//마우스가 오른쪽 클릭했을떄
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, Turn, xx, yy] != 0)
                    {
                        if (now.x + xx + 1 >= GameRule.BX)
                        {
                            return false;
                        }
                    }
                }
            }
            if (gboard.MoveEnalbe(now.BlockNum, Turn, now.x + 1, now.y))
            {
                now.MoveRight();
                return true;
            }
            return false;

        }

        internal bool MoveLeft()//마우스가 왼쪽 클릭했을떄
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, Turn, xx, yy] != 0)
                    {
                        if (now.x + xx <= 0)
                        {
                            return false;
                        }
                    }
                }
            }

            if(gboard.MoveEnalbe(now.BlockNum, Turn, now.x - 1, now.y))
            {
                now.MoveLeft();
                return true;
            }
            return false;
        }

        internal bool MoveDown()
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, Turn, xx, yy] != 0)
                    {
                        if (now.y + yy + 1 >= GameRule.BY)
                        {
                            gboard.Store(now.BlockNum, Turn, now.x, now.y);
                            return false;
                        }
                    }
                }
            }
            if (gboard.MoveEnalbe(now.BlockNum, Turn, now.x, now.y + 1))
            {
                now.MoveDown();
                return true;
            }
            gboard.Store(now.BlockNum, Turn, now.x, now.y);
            return false;
        }
        internal bool MoveTurn()
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, (Turn + 1) % 4, xx, yy] != 0)
                    {
                        if (((now.x + xx) < 0) || ((now.x + xx)) >= GameRule.BX || ((now.y + yy) >= GameRule.BY))
                        {
                            return false;
                        }
                    }
                }
            }
            if (gboard.MoveEnalbe(now.BlockNum, (Turn + 1) % 4, now.x, now.y))
            {
                now.MoveTurn();
                return true;
            }
            return false;

        }
        internal bool Next()
        {
            now.Reset();
            return gboard.MoveEnalbe(now.BlockNum, Turn, now.x, now.y);
        }
        internal void Restart()
        {
            gboard.ClearBoard();
        }
    }
}
