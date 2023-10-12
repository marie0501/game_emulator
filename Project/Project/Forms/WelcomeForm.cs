using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class WelcomeForm : Form
    {
        IGame Game;
        public static ITournament Tournament;
        Logger logger;
        Form loggingForm;
        Player[] players;
        int countTeam;
        int numberTeam;
        int countPlayers;
        Dictionary<string, object> Dicc;
        bool singlePlayer;
        List<string> PlayersNames;

        public WelcomeForm()
        {
            InitializeComponent();
            countTeam = 0;
            countPlayers = 0;
            Dicc = new Dictionary<string, object>();
            singlePlayer = false;
            numberTeam = 1;
            loggingForm = new LoggingForm();
            PlayersNames = new List<string>();

            #region AddNewObjects
            Dicc.Add("Tic-Tac-Toe", new TicTacToe());
            Dicc.Add("Title", new TitleTournament());
            Dicc.Add("Two To Two", new TwoToTwoTournament());
            Dicc.Add("Random", new RandomPlayer());
            Dicc.Add("Greedy", new GreedyPlayer());
            #endregion

            AddGamesAndChamps();
        }

        private void AddGamesAndChamps() //register the new types(IGames, ITournament) implemented
        {
            foreach (var item in Dicc.Keys)
            {
                if (Dicc[item] as IGame != null)
                    selectGame_cmbox.Items.Add(item);
                if (Dicc[item] as ITournament != null)
                    selectTournament_cmbox.Items.Add(item);
            }
        }
        private void AddPlayers()//it only filters games that implement a certain interface
        {
            foreach (var item in Dicc.Keys)
            {
                if (Dicc[item].GetType().GetInterface(Game.GetInterface) != null)
                    if (singlePlayer) singlePlayerTactic_cmbox.Items.Add(item); else multiPlayerTactic_cmbox.Items.Add(item);
            }
        }

        #region buttonsClickEvent
        private void singlePlayer_btn_Click(object sender, EventArgs e)
        {
            singlePlayer = true;
            multiPlayer_btn.Visible = false;
            AddPlayers();

            #region Visible
            singlePlayerAdd_btn.Visible = true;
            singlePlayerName_tbox.Visible = true;
            singlePlayerName_lbl.Visible = true;
            singlePlayerTactic_cmbox.Visible = true;
            singlePlayerTactic_lbl.Visible = true;
            start_btn.Visible = true;
            #endregion
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            logger = new Logger((LoggingForm)loggingForm);

            if (gamesTypeMatch_chbox.Checked == pointsTypeMatch_chbox.Checked || (selectTournament_cmbox.Text == "" || selectGame_cmbox.Text == "" || (int)maxNumberPoints_nud.Value == 0))
            {
                logger.Log("error", "Match", "There is something you did not select"); return;
            }

            Game = Factory.GamesFactory(selectGame_cmbox.Text, logger);
            Tournament = Factory.TournamentFactory(selectTournament_cmbox.Text, logger, Game, (int)maxNumberPoints_nud.Value, gamesTypeMatch_chbox.Checked);


            #region EnableControls
            selectGame_cmbox.Enabled = false;
            selectTournament_cmbox.Enabled = false;
            ok_btn.Enabled = false;
            matchType_gbox.Enabled = false;
            #endregion


            if (!Game.Teams || !Tournament.Teams) singlePlayer_btn.Visible = true;
            else { singlePlayer_btn.Visible = true; multiPlayer_btn.Visible = true; }

        }

        private void multiPlayer_btn_Click(object sender, EventArgs e)
        {
            singlePlayer_btn.Visible = false;
            AddPlayers();
            #region Visible
            multiPlayerAdd_btn.Visible = true;
            multiPlayerName_tbox.Visible = true;
            multiPlayerName_lbl.Visible = true;
            multiPlayerTactic_cmbox.Visible = true;
            multiPlayerTactic_lbl.Visible = true;
            multiPlayerTeamCount_lbl.Visible = true;
            multiPlayerTeam_lbl.Visible = true;
            start_btn.Visible = true;
            #endregion
        }

        private void multiPlayerAdd_btn_Click(object sender, EventArgs e)
        {

            if (PlayersNames.Contains(multiPlayerName_tbox.Text))
            {
                logger.Log("error", "Championship", "Player name already exists. You have to choose another."); return;
            }


            if (multiPlayerName_tbox.Text == "" || multiPlayerTactic_cmbox.Text == "")
            {
                logger.Log("warning", "Championship", "The name and tactic of the player/s cannot be blank");
                return;
            }

            if (players == null) { players = new Player[Game.NumberOfPlayersPerTeam]; }

            players[countTeam] = Factory.PlayersFactory(multiPlayerName_tbox.Text, multiPlayerTactic_cmbox.Text);
            PlayersNames.Add(multiPlayerName_tbox.Text);
            countTeam++;

            if (countTeam == Game.NumberOfPlayersPerTeam)
            {
                if (Tournament.AddPlayer(players))
                {
                    multiPlayerSuccesfulAdd_lbl.Text = $"Team {numberTeam} was successfully added";
                    countTeam = 0;
                    numberTeam++;

                }
                else
                {
                    multiPlayerSuccesfulAdd_lbl.Text = $"Team {numberTeam} could not be added";
                }

                players = new Player[Game.NumberOfPlayersPerTeam];
            }

            multiPlayerName_tbox.Text = "";
            multiPlayerTeamCount_lbl.Text = $"{numberTeam}";

        }

        private void singlePlayerAdd_btn_Click(object sender, EventArgs e)
        {
            if (PlayersNames.Contains(singlePlayerName_tbox.Text))
            {
                logger.Log("error", "Championship", "Player name already exists. You have to choose another.");
                return;
            }
            if (singlePlayerName_tbox.Text == "" || singlePlayerTactic_cmbox.Text == "")
            {
                logger.Log("warning", "Championship", "The name and tactic of the player/s cannot be blank");
                return;
            }
            Player[] p = { Factory.PlayersFactory(singlePlayerName_tbox.Text, singlePlayerTactic_cmbox.Text) };
            if (Tournament.AddPlayer(p))
            {
                singlePlayerSuccesfulAdd_lbl.Text = $" {singlePlayerName_tbox.Text} was successfully added"; countPlayers++;
                PlayersNames.Add(singlePlayerName_tbox.Text);
                singlePlayerName_tbox.Text = "";
            }
            else singlePlayerSuccesfulAdd_lbl.Text = $"{singlePlayerName_tbox.Text} could not be added. You cannot add more players";

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (singlePlayer && countPlayers < Game.NumberPlayers)
            {
                logger.Log("error", "Championship", "The number of players needed it is not enough. You have to add more players");
                return;
            }
            else if (Game.Teams)
                if (!singlePlayer && countTeam < Game.NumberTeams)
                {
                    logger.Log("error", "Championship", "The number of teams needed it is not enough. You have to add more teams");
                    return;
                }
            this.Hide();
            loggingForm.ShowDialog();

        }

        #endregion
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            #region InvisibleControls
            singlePlayerSuccesfulAdd_lbl.Text = "";
            singlePlayerAdd_btn.Visible = false;
            singlePlayerName_tbox.Visible = false;
            singlePlayerName_lbl.Visible = false;
            singlePlayerTactic_cmbox.Visible = false;
            singlePlayerTactic_lbl.Visible = false;
            singlePlayer_btn.Visible = false;
            multiPlayer_btn.Visible = false;
            multiPlayerSuccesfulAdd_lbl.Text = "";
            multiPlayerTeam_lbl.Visible = false;
            multiPlayerTeamCount_lbl.Visible = false;
            multiPlayerAdd_btn.Visible = false;
            multiPlayerName_tbox.Visible = false;
            multiPlayerName_lbl.Visible = false;
            multiPlayerTactic_cmbox.Visible = false;
            multiPlayerTactic_lbl.Visible = false;
            start_btn.Visible = false;

            #endregion
        }
    }
}
