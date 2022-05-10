using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace TetriesProject
{
    public partial class form1 : Form
    {
        Game game;
        int bx;
        int by;
        int bwidth;
        int bheight;
        public form1()
        {
            InitializeComponent();
            playSimpleSound();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = Game.Singleton;
            bx = GameRule.BX;
            by = GameRule.BY;
            bwidth = GameRule.B_WIDTH;
            bheight = GameRule.B_HEIGHT;
            this.SetClientSizeCore(bx * bwidth, by * bheight);//폼의 넓이,높이를 x y에 맞게자동조정
        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\feel6\source\repos\TetriesProject\BGM\ive.wav");
            simpleSound.Play();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawGarduation(e.Graphics);
            DrawDiagram(e.Graphics);
            //깜빡임 현상 막기위해 고속복사기능 사용
            DoubleBuffered = true;
            DrawBoard(e.Graphics);
        }

        private void DrawBoard(Graphics graphics)
        {
            for(int xx = 0; xx < bx; xx++)
            {
                for(int yy=0; yy < by; yy++)
                {
                    if (game[xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle(xx * bwidth + 2,yy * bheight + 2, bwidth - 4, bheight - 4);
                        graphics.DrawRectangle(Pens.Green, now_rt);
                        graphics.FillRectangle(Brushes.Red, now_rt); ;
                    }
                }
            }
        }

        private void DrawDiagram(Graphics graphics)//도형모양
        {
            Pen dpen = new Pen(Color.Red, 4);
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Trun;
            for(int xx=0; xx < 4; xx++)
            {
                for(int yy=0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle((now.X+xx) * bwidth + 2, (now.Y+yy) * bheight + 2, bwidth - 4, bheight - 4);
                        graphics.DrawRectangle(dpen, now_rt);
                    }
                }
            }
        }

        private void DrawGarduation(Graphics graphics)
        {
            DrawHorizons(graphics);//수평선 그리기
            DrawVerticals(graphics);//수직선 그리기
             
        }

        private void DrawVerticals(Graphics graphics)//수직설정
        {
            Point st = new Point();
            Point et = new Point();
            for(int cx = 0; cx < bx; cx++)
            {
                st.X = cx*bwidth;
                st.Y = 0;
                et.X = st.X;
                et.Y = by * bheight;
                graphics.DrawLine(Pens.Gray, st, et);
            }
        }

        private void DrawHorizons(Graphics graphics)//수평설정
        {
            Point st = new Point();
            Point et = new Point();
            for (int cy = 0; cy < by; cy++)
            {
                st.X = 0;
                st.Y = cy*bheight;
                et.X = bx*bwidth;
                et.Y = st.Y;
                graphics.DrawLine(Pens.Gray, st, et);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: MoveRight(); return;
                case Keys.Left: MoveLeft(); return;
                case Keys.Space: MoveDown(); return;
                case Keys.Up:MoveTrun(); return;
            }
        }

        private void MoveTrun()
        {
            if (game.MoveTrun())
            {
                Region rg = MakeRegion();
                Invalidate(rg);
            }
        }

        private void MoveDown()
        {
            if (game.MoveDown())
            {
                Region rg = MakeRegion(0, -1);
                Invalidate(rg);
            }
            else
            {
                game.Next();
                Invalidate();
            }
        }



        private void MoveLeft()
        {
            if (game.MoveLeft())
            {
                Region rg = MakeRegion(1, 0);
                Invalidate(rg);
            }
        }

        private void MoveRight()
        {
            if (game.MoveRight())
            {
                Region rg = MakeRegion(-1, 0);
                Invalidate(rg);
            }
        }
        private Region MakeRegion(int cx, int cy)
        {
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Trun;

            Region region = new Region();
            for(int xx=0; xx < 4; xx++)
            {
                for(int yy=0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X+xx) * bwidth, (now.Y+yy) * bheight, bwidth, bheight);
                        Rectangle rect2 = new Rectangle((now.X + cx+xx) * bwidth, (now.Y + cy+yy) * bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        Region rg2 = new Region(rect2);
                        region.Union(rg1);
                        region.Union(rg2);
                    }
                }
            }
            return region;
        }

        private Region MakeRegion()
        {
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Trun;
            int oldtn = (tn + 3) % 4;

            Region region = new Region();
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth, (now.Y + yy) * bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        region.Union(rg1);
                    }
                    if (BlockValue.bvals[bn, oldtn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth, (now.Y + yy) * bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        region.Union(rg1);
                    }
                }
            }
            return region;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveDown();
        }
    }
}
