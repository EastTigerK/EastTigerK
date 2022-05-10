using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetriesProject
{
    internal class Diagram
    {
        internal int x
        {
            get; 
            private set;
        }
        internal int y
        {
            get;
            private set;
        }
        
        internal int Trun
        {
            get;
            private set;
        }

        internal int BlockNum
        {
            get;
            private set;
        }
        internal Diagram()
        {
            Reset();
        }
        internal void Reset()
        {
            Random random = new Random();
            x = GameRule.SX;
            y = GameRule.SY;
            Trun = random.Next() % 4;
            BlockNum = random.Next()%7;
        }
        internal void MoveLeft()
        {
            x--;
        }
        internal void MoveRight()
        {
            x++;
        }
        internal void MoveDown()
        {
            y++;
        }
        internal void MoveTrun()
        {
            Trun = (Trun + 1) % 4;//현재턴+1 4까지 0,1,2,3반복
        }
    }
}
