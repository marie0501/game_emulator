using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project
{
    public partial class LoggingForm : Form
    {
        bool Start;
        bool End;
        bool Match;
        bool Game;
        bool Move;

        public LoggingForm()
        {
            InitializeComponent();
            Start = false;
        }

        public void Logging(string info, string category)//sends logs to a label
        {
            if (LogCategory(category)) screen_lbl.Text += info + "\n";
            else return;
        }
        private bool LogCategory(string category)//filters logs depending on their category, returns true if the category can be log, false otherwise
        {
            switch (category)
            {
                case "Match": return Match;
                case "Game": return Game;
                case "Move": return Move;
            }
            return true;
        }

        #region PlayMethods
        private static void PlayTournament(ITournament t)//plays the entire championship
        {
            while (t.MoveNext())
            {
                PlayMatch(t.Current);
            }

        }
        private static void PlayMatch(Match match)//plays just the current match
        {
            while (match.MoveNext())
            {
                PlayGame(match.Current);
            }

        }
        private static void PlayGame(IGame game)//plays just the current game
        {
            while (game.MoveNext()) { }
        }
        #endregion

        #region buttonsClickEvent

        private void playAuto_btn_Click(object sender, EventArgs e)// Play Automatically button click event
        {
            playAuto_timer.Interval = (int)timer_nud.Value;
            playAuto_timer.Start();

            #region DisableButtons
            playTournament_btn.Enabled = false;
            playGame_btn.Enabled = false;
            playMatch_btn.Enabled = false;
            nextMove_btn.Enabled = false;
            #endregion
        }
        private void playChamp_btn_Click(object sender, EventArgs e)// Play Championship button click event
        {
            playAuto_btn.Enabled = false;
            timer_nud.Enabled = false;

            if (End) return;
            if (!Start)
            {
                Start = true;
                PlayTournament(WelcomeForm.Tournament);
                return;
            }
            if (!WelcomeForm.Tournament.Current.MatchOver) playMatch_btn_Click(sender, e);
            PlayTournament(WelcomeForm.Tournament);
        }

        private void playMatch_btn_Click(object sender, EventArgs e)// Play Match button click event
        {
            playAuto_btn.Enabled = false;
            timer_nud.Enabled = false;

            if (End) return;
            if (!Start)
            {
                Start = true;
                WelcomeForm.Tournament.MoveNext();
                PlayMatch(WelcomeForm.Tournament.Current);
                if (!WelcomeForm.Tournament.MoveNext()) { End = true; return; }
                else { WelcomeForm.Tournament.Current.MoveNext(); return; }
            }
            if (!WelcomeForm.Tournament.Current.Current.GameOver) { PlayGame(WelcomeForm.Tournament.Current.Current); }
            PlayMatch(WelcomeForm.Tournament.Current);
            if (!WelcomeForm.Tournament.MoveNext()) { End = true; return; }
            else WelcomeForm.Tournament.Current.MoveNext();

        }

        private void playGame_btn_Click(object sender, EventArgs e)// Play Game button click event
        {
            playAuto_btn.Enabled = false;
            timer_nud.Enabled = false;

            if (End) return;
            if (!Start)
            {
                Start = true;
                WelcomeForm.Tournament.MoveNext();
                WelcomeForm.Tournament.Current.MoveNext();
                PlayGame(WelcomeForm.Tournament.Current.Current);
                if (!WelcomeForm.Tournament.Current.MoveNext()) if (!WelcomeForm.Tournament.MoveNext()) { End = true; return; }
                return;
            }

            PlayGame(WelcomeForm.Tournament.Current.Current);
            if (!WelcomeForm.Tournament.Current.MoveNext()) if (!WelcomeForm.Tournament.MoveNext()) { End = true; return; }
            return;


        }

        private void nextMove_btn_Click(object sender, EventArgs e)// Next Move button click event
        {
            playAuto_btn.Enabled = false;
            timer_nud.Enabled = false;

            if (End) return;
            if (!Start)
            {
                Start = true;
                WelcomeForm.Tournament.MoveNext();
                WelcomeForm.Tournament.Current.MoveNext();
                WelcomeForm.Tournament.Current.Current.MoveNext();
                return;

            }

            if (!WelcomeForm.Tournament.Current.Current.MoveNext())
            {
                if (!WelcomeForm.Tournament.Current.MoveNext())
                {
                    if (!WelcomeForm.Tournament.MoveNext()) { End = true; return; }
                    else WelcomeForm.Tournament.Current.MoveNext();
                }
                WelcomeForm.Tournament.Current.Current.MoveNext(); return;
            }


        }

        private void LoggingForm_Load(object sender, EventArgs e)
        {
            screen_lbl.Text = "";

            #region InvisibleButtons
            timer_nud.Visible = false;
            playMatch_btn.Visible = false;
            playTournament_btn.Visible = false;
            playGame_btn.Visible = false;
            nextMove_btn.Visible = false;
            playAuto_btn.Visible = false;
            #endregion
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Match = logMatch_chbox.Checked;
            Game = logGame_chbox.Checked;
            Move = logMoves_chbox.Checked;

            #region VisibleButtons
            timer_nud.Visible = true;
            playTournament_btn.Visible = true;
            playMatch_btn.Visible = true;
            playGame_btn.Visible = true;
            playAuto_btn.Visible = true;
            nextMove_btn.Visible = true;
            #endregion

            options_gbox.Enabled = false;
        }

        #endregion
        private void playAuto_timer_Tick(object sender, EventArgs e)
        {
            if (End) playAuto_timer.Stop();
            else nextMove_btn_Click(sender, e);
        }

        private void LoggingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            playAuto_timer.Stop();
            this.Close();
        }
    }
}
