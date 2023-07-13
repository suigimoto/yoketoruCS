using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Design;

namespace yoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        static int PlayerMax => 1;
        static int ItemMax = 3;
        static int ObstacleMax => 3;
        static int PlayerIndex => 0;
        static int ObstacleIndex => PlayerIndex + PlayerMax;
        static int ItemIndex => ObstacleIndex + ObstacleMax;
        static int LabelMax => ItemIndex + ItemMax;
        Label[] chrLabels = new Label[LabelMax];
        int itemCount;


        int[] vx = new int[LabelMax];
        int[] vy = new int[LabelMax];
        
        static Random random = new Random();

        static int ScoreMax => 99999;
        static int SpeedMax => 10;
        static int PointRate => 100;

        //列挙子enum
        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }
        State nextState = State.Title;
        State currentState = State.None;

        int timer;
        int score;
        int highscore = 100;
        int StartTimer => 200;
        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < LabelMax; i++)
            {
                chrLabels[i] = new Label();
                chrLabels[i].AutoSize = true; 
                chrLabels[i].Top = i * 24;
                Controls.Add(chrLabels[i]);
                if(i<ObstacleIndex)
                {
                    chrLabels[i].Text = "(*'▽')";
                    chrLabels[i].Font = labelplayer.Font;
                }
                else if (i < ItemIndex)
                {
                    chrLabels[i].Text = labelobstacle.Text;
                    chrLabels[i].Font = labelobstacle.Font;
                }
                else
                {
                    chrLabels[i].Text = labelItem.Text;
                    chrLabels[i].Font = labelItem.Font;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeState();
            UpdateState();
        }

        void UpdateState()
        {
            switch(currentState)
            {
                case State.Game:
            UpdataGame();
            break;
        }
    }

        void UpdataGame()
        {
            if (GetAsyncKeyState((int)Keys.O) < 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
            }
            UpdataPlayer();
            UpdataObstacleAndItem();
            UpdataTimer();

        }

        void UpdataPlayer()
        {
            var mpos = PointToClient(MousePosition);
            chrLabels[PlayerIndex].Left = mpos.X - chrLabels[PlayerIndex].Width/2;
            chrLabels[PlayerIndex].Top = mpos.Y - chrLabels[PlayerIndex].Height / 2;
        }

        void UpdataObstacleAndItem()
        {
            for(int i = ObstacleIndex; i < chrLabels.Length; i++)
            {
                //非表示のやつは処理しない
                if (!chrLabels[i].Visible) continue;
                //if(chrlabels[i].visible == false) continue;
                
                chrLabels[i].Left += vx[i];
                chrLabels[i].Top += vy[i];

                if (chrLabels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (chrLabels[i].Right>ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                else if (chrLabels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (chrLabels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                //当たり判定
                if (IsHit(chrLabels[i]))
                {
                    if (IsObstacle(i))
                    {
                        //障害物に当たった
                        nextState = State.Gameover;
                    }
                    else
                    {
                        //TODOアイテム
                        AddScore(timer * PointRate);
                        itemCount--;
                        chrLabels[i].Visible = false;
                        if (itemCount <= 0)
                        {
                            nextState = State.Clear;
                        }
                    }
                }
            }
        }

        void ChangeState()
        {
            if (nextState == State.None) return;

            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    labeltitle.Visible = true;
                    buttonStart.Visible = true;
                    labelgameover.Visible = false;
                    buttontitle.Visible = false;
                    labelclear.Visible = false;
                    labelscore.Visible = true;
                    labelhighscore.Visible = true;
                    labeltimer.Visible = false;
                    labelplayer.Visible = false;
                    labelItem.Visible = false;
                    labelcopylight.Visible = true;
                    labelobstacle.Visible = false;
                    break;

                case State.Game:
                    labeltitle.Visible = false;
                    buttonStart.Visible = false;
                    labelgameover.Visible = false;
                    buttontitle.Visible = false;
                    labelclear.Visible = false;
                    labelscore.Visible = true;
                    labelhighscore.Visible = false;
                    labeltimer.Visible = true;
                    labelcopylight.Visible = false;
                    score = 0;
                    UpdataScore();
                    itemCount = ItemMax;
                    timer = StartTimer;
                    for (int i = ObstacleIndex; i < vx.Length; i++)
                    {
                        vx[i] = random.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = random.Next(-SpeedMax, SpeedMax + 1);
                        chrLabels[i].Visible = true;
                    }
                    RandomObstacleAndItemPostion();
                    break;

                case State.Gameover:
                    labelgameover.Visible = true;
                    buttontitle.Visible = true;
                    labelhighscore.Visible = true;
                    break;

                case State.Clear:
                    labelclear.Visible = true;
                    buttontitle.Visible = true;
                    labelhighscore.Visible= true;
                    break;
            }
            }
        void RandomObstacleAndItemPostion()
        {
            for(int i = ObstacleIndex; i < chrLabels.Length; i++)
            {
                chrLabels[i].Left = random.Next(ClientSize.Width - chrLabels[i].Width);
                chrLabels[i].Top = random.Next(ClientSize.Height - chrLabels[i].Height);
            }
        }

        void AddScore(int point)
        {
            //TODO 得点加算
            score=Math.Min(score+point,ScoreMax);
            UpdataScore();
        }
        void UpdataScore()
        {
            labelscore.Text=$"{score:00000}";
        }
        void UpdataTimer()
        {
            timer--;
            if (timer <= 0)
            {
                timer = 0;
                nextState = State.Gameover;
            }
            labeltimer.Text = $"{timer:000}";
        }

        bool IsHit(Label Target)
        {
            var mpos = PointToClient(MousePosition);

            return ( (mpos.X >= Target.Left) && (mpos.X < Target.Right)
                && (mpos.Y >= Target.Top) && (mpos.Y < Target.Bottom)) ;
        }

        bool IsObstacle(int index)
        {
            return ((index >= ObstacleIndex) && (index < ItemIndex));
        } 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttontitle_Click(object sender, EventArgs e)
        {
            nextState= State.Title;
        }

        private void labelclear_Click(object sender, EventArgs e)
        {

        }

        private void labelplayer_Click(object sender, EventArgs e)
        {

        }
    }
}
