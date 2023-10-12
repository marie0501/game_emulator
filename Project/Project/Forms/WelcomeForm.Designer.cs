namespace Project
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.olympics_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.selectGame_lbl = new System.Windows.Forms.Label();
            this.selectTournament_lbl = new System.Windows.Forms.Label();
            this.selectGame_cmbox = new System.Windows.Forms.ComboBox();
            this.selectTournament_cmbox = new System.Windows.Forms.ComboBox();
            this.matchType_gbox = new System.Windows.Forms.GroupBox();
            this.maxNumberPoints_lbl = new System.Windows.Forms.Label();
            this.maxNumberPoints_nud = new System.Windows.Forms.NumericUpDown();
            this.gamesTypeMatch_chbox = new System.Windows.Forms.CheckBox();
            this.pointsTypeMatch_chbox = new System.Windows.Forms.CheckBox();
            this.singlePlayer_btn = new System.Windows.Forms.Button();
            this.multiPlayer_btn = new System.Windows.Forms.Button();
            this.singlePlayerAdd_btn = new System.Windows.Forms.Button();
            this.multiPlayerAdd_btn = new System.Windows.Forms.Button();
            this.singlePlayerName_tbox = new System.Windows.Forms.TextBox();
            this.multiPlayerName_lbl = new System.Windows.Forms.Label();
            this.multiPlayerTactic_lbl = new System.Windows.Forms.Label();
            this.multiPlayerTeam_lbl = new System.Windows.Forms.Label();
            this.singlePlayerName_lbl = new System.Windows.Forms.Label();
            this.singlePlayerTactic_lbl = new System.Windows.Forms.Label();
            this.singlePlayerTactic_cmbox = new System.Windows.Forms.ComboBox();
            this.multiPlayerName_tbox = new System.Windows.Forms.TextBox();
            this.multiPlayerTactic_cmbox = new System.Windows.Forms.ComboBox();
            this.multiPlayerTeamCount_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.singlePlayerSuccesfulAdd_lbl = new System.Windows.Forms.Label();
            this.multiPlayerSuccesfulAdd_lbl = new System.Windows.Forms.Label();
            this.matchType_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumberPoints_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // olympics_lbl
            // 
            this.olympics_lbl.AutoSize = true;
            this.olympics_lbl.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olympics_lbl.Location = new System.Drawing.Point(470, 38);
            this.olympics_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olympics_lbl.Name = "olympics_lbl";
            this.olympics_lbl.Size = new System.Drawing.Size(233, 38);
            this.olympics_lbl.TabIndex = 0;
            this.olympics_lbl.Text = "THE OLYMPICS";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ok_btn.Location = new System.Drawing.Point(559, 337);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(113, 30);
            this.ok_btn.TabIndex = 1;
            this.ok_btn.Text = " ✔";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // selectGame_lbl
            // 
            this.selectGame_lbl.AutoSize = true;
            this.selectGame_lbl.Location = new System.Drawing.Point(205, 155);
            this.selectGame_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectGame_lbl.Name = "selectGame_lbl";
            this.selectGame_lbl.Size = new System.Drawing.Size(108, 20);
            this.selectGame_lbl.TabIndex = 2;
            this.selectGame_lbl.Text = "Select Game";
            // 
            // selectTournament_lbl
            // 
            this.selectTournament_lbl.AutoSize = true;
            this.selectTournament_lbl.Location = new System.Drawing.Point(153, 235);
            this.selectTournament_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectTournament_lbl.Name = "selectTournament_lbl";
            this.selectTournament_lbl.Size = new System.Drawing.Size(162, 20);
            this.selectTournament_lbl.TabIndex = 3;
            this.selectTournament_lbl.Text = "Select Tournament";
            // 
            // selectGame_cmbox
            // 
            this.selectGame_cmbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectGame_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectGame_cmbox.FormattingEnabled = true;
            this.selectGame_cmbox.Location = new System.Drawing.Point(350, 152);
            this.selectGame_cmbox.Margin = new System.Windows.Forms.Padding(4);
            this.selectGame_cmbox.Name = "selectGame_cmbox";
            this.selectGame_cmbox.Size = new System.Drawing.Size(135, 28);
            this.selectGame_cmbox.TabIndex = 5;
            // 
            // selectTournament_cmbox
            // 
            this.selectTournament_cmbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.selectTournament_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTournament_cmbox.FormattingEnabled = true;
            this.selectTournament_cmbox.Location = new System.Drawing.Point(350, 227);
            this.selectTournament_cmbox.Margin = new System.Windows.Forms.Padding(4);
            this.selectTournament_cmbox.Name = "selectTournament_cmbox";
            this.selectTournament_cmbox.Size = new System.Drawing.Size(135, 28);
            this.selectTournament_cmbox.TabIndex = 6;
            // 
            // matchType_gbox
            // 
            this.matchType_gbox.Controls.Add(this.maxNumberPoints_lbl);
            this.matchType_gbox.Controls.Add(this.maxNumberPoints_nud);
            this.matchType_gbox.Controls.Add(this.gamesTypeMatch_chbox);
            this.matchType_gbox.Controls.Add(this.pointsTypeMatch_chbox);
            this.matchType_gbox.Location = new System.Drawing.Point(616, 125);
            this.matchType_gbox.Margin = new System.Windows.Forms.Padding(4);
            this.matchType_gbox.Name = "matchType_gbox";
            this.matchType_gbox.Padding = new System.Windows.Forms.Padding(4);
            this.matchType_gbox.Size = new System.Drawing.Size(511, 147);
            this.matchType_gbox.TabIndex = 7;
            this.matchType_gbox.TabStop = false;
            this.matchType_gbox.Text = "Type of Match";
            // 
            // maxNumberPoints_lbl
            // 
            this.maxNumberPoints_lbl.AutoSize = true;
            this.maxNumberPoints_lbl.Location = new System.Drawing.Point(147, 57);
            this.maxNumberPoints_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxNumberPoints_lbl.Name = "maxNumberPoints_lbl";
            this.maxNumberPoints_lbl.Size = new System.Drawing.Size(279, 20);
            this.maxNumberPoints_lbl.TabIndex = 3;
            this.maxNumberPoints_lbl.Text = "Max number of points per Match";
            // 
            // maxNumberPoints_nud
            // 
            this.maxNumberPoints_nud.Location = new System.Drawing.Point(434, 57);
            this.maxNumberPoints_nud.Margin = new System.Windows.Forms.Padding(4);
            this.maxNumberPoints_nud.Name = "maxNumberPoints_nud";
            this.maxNumberPoints_nud.Size = new System.Drawing.Size(58, 27);
            this.maxNumberPoints_nud.TabIndex = 2;
            this.maxNumberPoints_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gamesTypeMatch_chbox
            // 
            this.gamesTypeMatch_chbox.AutoSize = true;
            this.gamesTypeMatch_chbox.Location = new System.Drawing.Point(23, 85);
            this.gamesTypeMatch_chbox.Margin = new System.Windows.Forms.Padding(4);
            this.gamesTypeMatch_chbox.Name = "gamesTypeMatch_chbox";
            this.gamesTypeMatch_chbox.Size = new System.Drawing.Size(76, 24);
            this.gamesTypeMatch_chbox.TabIndex = 1;
            this.gamesTypeMatch_chbox.Text = "Games";
            this.gamesTypeMatch_chbox.UseVisualStyleBackColor = true;
            // 
            // pointsTypeMatch_chbox
            // 
            this.pointsTypeMatch_chbox.AutoSize = true;
            this.pointsTypeMatch_chbox.Location = new System.Drawing.Point(23, 40);
            this.pointsTypeMatch_chbox.Margin = new System.Windows.Forms.Padding(4);
            this.pointsTypeMatch_chbox.Name = "pointsTypeMatch_chbox";
            this.pointsTypeMatch_chbox.Size = new System.Drawing.Size(85, 24);
            this.pointsTypeMatch_chbox.TabIndex = 0;
            this.pointsTypeMatch_chbox.Text = "Points";
            this.pointsTypeMatch_chbox.UseVisualStyleBackColor = true;
            // 
            // singlePlayer_btn
            // 
            this.singlePlayer_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.singlePlayer_btn.Location = new System.Drawing.Point(250, 414);
            this.singlePlayer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.singlePlayer_btn.Name = "singlePlayer_btn";
            this.singlePlayer_btn.Size = new System.Drawing.Size(165, 43);
            this.singlePlayer_btn.TabIndex = 8;
            this.singlePlayer_btn.Text = "Single Player";
            this.singlePlayer_btn.UseVisualStyleBackColor = false;
            this.singlePlayer_btn.Click += new System.EventHandler(this.singlePlayer_btn_Click);
            // 
            // multiPlayer_btn
            // 
            this.multiPlayer_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.multiPlayer_btn.Location = new System.Drawing.Point(863, 414);
            this.multiPlayer_btn.Margin = new System.Windows.Forms.Padding(4);
            this.multiPlayer_btn.Name = "multiPlayer_btn";
            this.multiPlayer_btn.Size = new System.Drawing.Size(165, 43);
            this.multiPlayer_btn.TabIndex = 9;
            this.multiPlayer_btn.Text = "Multiplayer";
            this.multiPlayer_btn.UseVisualStyleBackColor = false;
            this.multiPlayer_btn.Click += new System.EventHandler(this.multiPlayer_btn_Click);
            // 
            // singlePlayerAdd_btn
            // 
            this.singlePlayerAdd_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.singlePlayerAdd_btn.Location = new System.Drawing.Point(291, 641);
            this.singlePlayerAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.singlePlayerAdd_btn.Name = "singlePlayerAdd_btn";
            this.singlePlayerAdd_btn.Size = new System.Drawing.Size(85, 58);
            this.singlePlayerAdd_btn.TabIndex = 10;
            this.singlePlayerAdd_btn.Text = "Add";
            this.singlePlayerAdd_btn.UseVisualStyleBackColor = false;
            this.singlePlayerAdd_btn.Click += new System.EventHandler(this.singlePlayerAdd_btn_Click);
            // 
            // multiPlayerAdd_btn
            // 
            this.multiPlayerAdd_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.multiPlayerAdd_btn.Location = new System.Drawing.Point(906, 641);
            this.multiPlayerAdd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.multiPlayerAdd_btn.Name = "multiPlayerAdd_btn";
            this.multiPlayerAdd_btn.Size = new System.Drawing.Size(85, 58);
            this.multiPlayerAdd_btn.TabIndex = 11;
            this.multiPlayerAdd_btn.Text = "Add";
            this.multiPlayerAdd_btn.UseVisualStyleBackColor = false;
            this.multiPlayerAdd_btn.Click += new System.EventHandler(this.multiPlayerAdd_btn_Click);
            // 
            // singlePlayerName_tbox
            // 
            this.singlePlayerName_tbox.Location = new System.Drawing.Point(270, 497);
            this.singlePlayerName_tbox.Margin = new System.Windows.Forms.Padding(4);
            this.singlePlayerName_tbox.Name = "singlePlayerName_tbox";
            this.singlePlayerName_tbox.Size = new System.Drawing.Size(135, 27);
            this.singlePlayerName_tbox.TabIndex = 12;
            // 
            // multiPlayerName_lbl
            // 
            this.multiPlayerName_lbl.AutoSize = true;
            this.multiPlayerName_lbl.Location = new System.Drawing.Point(800, 504);
            this.multiPlayerName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiPlayerName_lbl.Name = "multiPlayerName_lbl";
            this.multiPlayerName_lbl.Size = new System.Drawing.Size(45, 20);
            this.multiPlayerName_lbl.TabIndex = 13;
            this.multiPlayerName_lbl.Text = "Name";
            // 
            // multiPlayerTactic_lbl
            // 
            this.multiPlayerTactic_lbl.AutoSize = true;
            this.multiPlayerTactic_lbl.Location = new System.Drawing.Point(800, 560);
            this.multiPlayerTactic_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiPlayerTactic_lbl.Name = "multiPlayerTactic_lbl";
            this.multiPlayerTactic_lbl.Size = new System.Drawing.Size(63, 20);
            this.multiPlayerTactic_lbl.TabIndex = 14;
            this.multiPlayerTactic_lbl.Text = "Tactic";
            // 
            // multiPlayerTeam_lbl
            // 
            this.multiPlayerTeam_lbl.AutoSize = true;
            this.multiPlayerTeam_lbl.Location = new System.Drawing.Point(818, 603);
            this.multiPlayerTeam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiPlayerTeam_lbl.Name = "multiPlayerTeam_lbl";
            this.multiPlayerTeam_lbl.Size = new System.Drawing.Size(45, 20);
            this.multiPlayerTeam_lbl.TabIndex = 15;
            this.multiPlayerTeam_lbl.Text = "Team";
            // 
            // singlePlayerName_lbl
            // 
            this.singlePlayerName_lbl.AutoSize = true;
            this.singlePlayerName_lbl.Location = new System.Drawing.Point(205, 500);
            this.singlePlayerName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.singlePlayerName_lbl.Name = "singlePlayerName_lbl";
            this.singlePlayerName_lbl.Size = new System.Drawing.Size(45, 20);
            this.singlePlayerName_lbl.TabIndex = 16;
            this.singlePlayerName_lbl.Text = "Name";
            // 
            // singlePlayerTactic_lbl
            // 
            this.singlePlayerTactic_lbl.AutoSize = true;
            this.singlePlayerTactic_lbl.Location = new System.Drawing.Point(187, 560);
            this.singlePlayerTactic_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.singlePlayerTactic_lbl.Name = "singlePlayerTactic_lbl";
            this.singlePlayerTactic_lbl.Size = new System.Drawing.Size(63, 20);
            this.singlePlayerTactic_lbl.TabIndex = 17;
            this.singlePlayerTactic_lbl.Text = "Tactic";
            // 
            // singlePlayerTactic_cmbox
            // 
            this.singlePlayerTactic_cmbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.singlePlayerTactic_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.singlePlayerTactic_cmbox.FormattingEnabled = true;
            this.singlePlayerTactic_cmbox.Location = new System.Drawing.Point(270, 550);
            this.singlePlayerTactic_cmbox.Margin = new System.Windows.Forms.Padding(4);
            this.singlePlayerTactic_cmbox.Name = "singlePlayerTactic_cmbox";
            this.singlePlayerTactic_cmbox.Size = new System.Drawing.Size(135, 28);
            this.singlePlayerTactic_cmbox.TabIndex = 18;
            // 
            // multiPlayerName_tbox
            // 
            this.multiPlayerName_tbox.Location = new System.Drawing.Point(880, 497);
            this.multiPlayerName_tbox.Margin = new System.Windows.Forms.Padding(4);
            this.multiPlayerName_tbox.Name = "multiPlayerName_tbox";
            this.multiPlayerName_tbox.Size = new System.Drawing.Size(135, 27);
            this.multiPlayerName_tbox.TabIndex = 19;
            // 
            // multiPlayerTactic_cmbox
            // 
            this.multiPlayerTactic_cmbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.multiPlayerTactic_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.multiPlayerTactic_cmbox.FormattingEnabled = true;
            this.multiPlayerTactic_cmbox.Location = new System.Drawing.Point(880, 550);
            this.multiPlayerTactic_cmbox.Margin = new System.Windows.Forms.Padding(4);
            this.multiPlayerTactic_cmbox.Name = "multiPlayerTactic_cmbox";
            this.multiPlayerTactic_cmbox.Size = new System.Drawing.Size(135, 28);
            this.multiPlayerTactic_cmbox.TabIndex = 20;
            // 
            // multiPlayerTeamCount_lbl
            // 
            this.multiPlayerTeamCount_lbl.AutoSize = true;
            this.multiPlayerTeamCount_lbl.Location = new System.Drawing.Point(935, 603);
            this.multiPlayerTeamCount_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiPlayerTeamCount_lbl.Name = "multiPlayerTeamCount_lbl";
            this.multiPlayerTeamCount_lbl.Size = new System.Drawing.Size(18, 20);
            this.multiPlayerTeamCount_lbl.TabIndex = 21;
            this.multiPlayerTeamCount_lbl.Text = "1";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start_btn.Location = new System.Drawing.Point(559, 466);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(117, 68);
            this.start_btn.TabIndex = 22;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // singlePlayerSuccesfulAdd_lbl
            // 
            this.singlePlayerSuccesfulAdd_lbl.AutoSize = true;
            this.singlePlayerSuccesfulAdd_lbl.Location = new System.Drawing.Point(384, 663);
            this.singlePlayerSuccesfulAdd_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.singlePlayerSuccesfulAdd_lbl.Name = "singlePlayerSuccesfulAdd_lbl";
            this.singlePlayerSuccesfulAdd_lbl.Size = new System.Drawing.Size(63, 20);
            this.singlePlayerSuccesfulAdd_lbl.TabIndex = 23;
            this.singlePlayerSuccesfulAdd_lbl.Text = "label1";
            // 
            // multiPlayerSuccesfulAdd_lbl
            // 
            this.multiPlayerSuccesfulAdd_lbl.AutoSize = true;
            this.multiPlayerSuccesfulAdd_lbl.Location = new System.Drawing.Point(999, 660);
            this.multiPlayerSuccesfulAdd_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.multiPlayerSuccesfulAdd_lbl.Name = "multiPlayerSuccesfulAdd_lbl";
            this.multiPlayerSuccesfulAdd_lbl.Size = new System.Drawing.Size(63, 20);
            this.multiPlayerSuccesfulAdd_lbl.TabIndex = 24;
            this.multiPlayerSuccesfulAdd_lbl.Text = "label1";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 864);
            this.Controls.Add(this.multiPlayerSuccesfulAdd_lbl);
            this.Controls.Add(this.singlePlayerSuccesfulAdd_lbl);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.multiPlayerTeamCount_lbl);
            this.Controls.Add(this.multiPlayerTactic_cmbox);
            this.Controls.Add(this.multiPlayerName_tbox);
            this.Controls.Add(this.singlePlayerTactic_cmbox);
            this.Controls.Add(this.singlePlayerTactic_lbl);
            this.Controls.Add(this.singlePlayerName_lbl);
            this.Controls.Add(this.multiPlayerTeam_lbl);
            this.Controls.Add(this.multiPlayerTactic_lbl);
            this.Controls.Add(this.multiPlayerName_lbl);
            this.Controls.Add(this.singlePlayerName_tbox);
            this.Controls.Add(this.multiPlayerAdd_btn);
            this.Controls.Add(this.singlePlayerAdd_btn);
            this.Controls.Add(this.multiPlayer_btn);
            this.Controls.Add(this.singlePlayer_btn);
            this.Controls.Add(this.matchType_gbox);
            this.Controls.Add(this.selectTournament_cmbox);
            this.Controls.Add(this.selectGame_cmbox);
            this.Controls.Add(this.selectTournament_lbl);
            this.Controls.Add(this.selectGame_lbl);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.olympics_lbl);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomeForm";
            this.Text = "The Olympics";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.matchType_gbox.ResumeLayout(false);
            this.matchType_gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumberPoints_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label olympics_lbl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label selectGame_lbl;
        private System.Windows.Forms.Label selectTournament_lbl;
        private System.Windows.Forms.ComboBox selectTournament_cmbox;
        private System.Windows.Forms.GroupBox matchType_gbox;
        private System.Windows.Forms.Label maxNumberPoints_lbl;
        private System.Windows.Forms.NumericUpDown maxNumberPoints_nud;
        private System.Windows.Forms.CheckBox gamesTypeMatch_chbox;
        private System.Windows.Forms.CheckBox pointsTypeMatch_chbox;
        private System.Windows.Forms.Button singlePlayer_btn;
        private System.Windows.Forms.Button multiPlayer_btn;
        private System.Windows.Forms.Button singlePlayerAdd_btn;
        private System.Windows.Forms.Button multiPlayerAdd_btn;
        private System.Windows.Forms.TextBox singlePlayerName_tbox;
        private System.Windows.Forms.Label multiPlayerName_lbl;
        private System.Windows.Forms.Label multiPlayerTactic_lbl;
        private System.Windows.Forms.Label multiPlayerTeam_lbl;
        private System.Windows.Forms.Label singlePlayerName_lbl;
        private System.Windows.Forms.Label singlePlayerTactic_lbl;
        private System.Windows.Forms.ComboBox singlePlayerTactic_cmbox;
        private System.Windows.Forms.TextBox multiPlayerName_tbox;
        private System.Windows.Forms.ComboBox multiPlayerTactic_cmbox;
        private System.Windows.Forms.Label multiPlayerTeamCount_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label singlePlayerSuccesfulAdd_lbl;
        private System.Windows.Forms.Label multiPlayerSuccesfulAdd_lbl;
        private System.Windows.Forms.ComboBox selectGame_cmbox;
    }
}

