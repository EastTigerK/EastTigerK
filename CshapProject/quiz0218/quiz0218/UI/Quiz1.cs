using quiz0218.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz0218
{
    public partial class Quiz1 : Form
    {
        SoundPlayer sndPlayer;
        int remainTime;
        int totalScore;
        String answer;

        public Quiz1()
        {
            InitializeComponent();
        }

        private void quiz1Next_Click(object sender, EventArgs e)
        {
            Close();
            Quiz2 quiz2 = new Quiz2(totalScore);
            quiz2.ShowDialog();
        }

        private void quiz1Main_Click(object sender, EventArgs e)
        {
            quiz1Timer.Stop();
            sndPlayer.Stop();
            Close();
        }

        private void Quiz1_Load(object sender, EventArgs e)
        {
            string[] qna = QuizData.quest[3].Split(':');
            quiz1Q.Text = qna[0];
            answer = qna[1];
            // 폼이 로드될때 다음 버튼을 비활성화 처리
            quiz1Next.Enabled = false;
            quiz1Timer.Start();
            sndPlayer = new SoundPlayer(Properties.Resources.clock);
            sndPlayer.Play();
        }

        private void quiz1_o_Click(object sender, EventArgs e)
        {
            if (answer.Equals("o"))
            {
                doOK();
            }
            else
            {
                doFail();
            }
            
        }

        private void quiz1_x_Click(object sender, EventArgs e)
        {
            if (answer.Equals("x"))
            {
                doOK();
            }
            else
            {
                doFail();
            }
        }

        private void quiz1Timer_Tick(object sender, EventArgs e)
        {
            // 1sec - 1000ms - us - ns
            remainTime = int.Parse(quiz1RT.Text);
            if (remainTime == 0)
            {
                sndPlayer.Stop();
                quiz1Timer.Stop();
                new SoundPlayer(Properties.Resources.timeout).Play();
                MessageBox.Show("시간이 종료되었습니다.");
                quiz1_o.Enabled = false;
                quiz1_x.Enabled = false;
                return;
            }
            quiz1RT.Text = (remainTime - 1).ToString();
        }

        private void Quiz1_FormClosing(object sender, FormClosingEventArgs e)
        {
            quiz1Timer.Stop();
            sndPlayer.Stop();
        }

        private void doOK()
        {
            quiz1Timer.Stop();
            sndPlayer.Stop();
            new SoundPlayer(Properties.Resources.ok).Play();
            MessageBox.Show("정답입니다.\n다음 퀴즈에 도전하세요!");
            quiz1_o.Enabled = false;
            quiz1_x.Enabled = false;
            quiz1Next.Enabled = true;
            int score = ((remainTime - 1) * 10) + 100;
            quiz1Score.Text = score.ToString();
            totalScore = score;
        }
        private void doFail()
        {
            quiz1Timer.Stop();
            sndPlayer.Stop();
            new SoundPlayer(Properties.Resources.error).Play();
            MessageBox.Show("오답입니다.\n퀴즈를 다시 푸세요!");
            quiz1Timer.Start();
            sndPlayer.Play();
        }
    }
}
