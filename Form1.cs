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

namespace yoketoruCS
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

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

        public Form1()
        {
            InitializeComponent();
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
                labelgameover.Visible = true;
                buttontitle.Visible = true;
                }
            if (GetAsyncKeyState((int)Keys.C) < 0)
            {
                nextState = State.Clear;
                labelclear.Visible = true;
                buttontitle.Visible = true;
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
                    labelcopylight.Visible = true;
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
                    labelplayer.Visible = true;
                    labelcopylight.Visible = false;

                    break;
            }
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
    }
}
