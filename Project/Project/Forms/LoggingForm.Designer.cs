namespace Project
{
    partial class LoggingForm
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
            this.components = new System.ComponentModel.Container();
            this.playTournament_btn = new System.Windows.Forms.Button();
            this.playMatch_btn = new System.Windows.Forms.Button();
            this.playGame_btn = new System.Windows.Forms.Button();
            this.nextMove_btn = new System.Windows.Forms.Button();
            this.playAuto_btn = new System.Windows.Forms.Button();
            this.options_gbox = new System.Windows.Forms.GroupBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.logMoves_chbox = new System.Windows.Forms.CheckBox();
            this.logGame_chbox = new System.Windows.Forms.CheckBox();
            this.logMatch_chbox = new System.Windows.Forms.CheckBox();
            this.screen_flpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.screen_lbl = new System.Windows.Forms.Label();
            this.playAuto_timer = new System.Windows.Forms.Timer(this.components);
            this.timer_nud = new System.Windows.Forms.NumericUpDown();
            this.options_gbox.SuspendLayout();
            this.screen_flpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // playTournament_btn
            // 
            this.playTournament_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.playTournament_btn.Location = new System.Drawing.Point(45, 143);
            this.playTournament_btn.Name = "playTournament_btn";
            this.playTournament_btn.Size = new System.Drawing.Size(182, 34);
            this.playTournament_btn.TabIndex = 0;
            this.playTournament_btn.Text = "Play Tournament";
            this.playTournament_btn.UseVisualStyleBackColor = false;
            this.playTournament_btn.Click += new System.EventHandler(this.playChamp_btn_Click);
            // 
            // playMatch_btn
            // 
            this.playMatch_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.playMatch_btn.Location = new System.Drawing.Point(45, 207);
            this.playMatch_btn.Name = "playMatch_btn";
            this.playMatch_btn.Size = new System.Drawing.Size(182, 34);
            this.playMatch_btn.TabIndex = 1;
            this.playMatch_btn.Text = "Play Match";
            this.playMatch_btn.UseVisualStyleBackColor = false;
            this.playMatch_btn.Click += new System.EventHandler(this.playMatch_btn_Click);
            // 
            // playGame_btn
            // 
            this.playGame_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.playGame_btn.Location = new System.Drawing.Point(45, 272);
            this.playGame_btn.Name = "playGame_btn";
            this.playGame_btn.Size = new System.Drawing.Size(182, 34);
            this.playGame_btn.TabIndex = 2;
            this.playGame_btn.Text = "Play Game";
            this.playGame_btn.UseVisualStyleBackColor = false;
            this.playGame_btn.Click += new System.EventHandler(this.playGame_btn_Click);
            // 
            // nextMove_btn
            // 
            this.nextMove_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nextMove_btn.Location = new System.Drawing.Point(45, 338);
            this.nextMove_btn.Name = "nextMove_btn";
            this.nextMove_btn.Size = new System.Drawing.Size(182, 34);
            this.nextMove_btn.TabIndex = 3;
            this.nextMove_btn.Text = "Next Move";
            this.nextMove_btn.UseVisualStyleBackColor = false;
            this.nextMove_btn.Click += new System.EventHandler(this.nextMove_btn_Click);
            // 
            // playAuto_btn
            // 
            this.playAuto_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.playAuto_btn.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAuto_btn.Location = new System.Drawing.Point(63, 26);
            this.playAuto_btn.Name = "playAuto_btn";
            this.playAuto_btn.Size = new System.Drawing.Size(147, 67);
            this.playAuto_btn.TabIndex = 4;
            this.playAuto_btn.Text = "Play Automatically";
            this.playAuto_btn.UseVisualStyleBackColor = false;
            this.playAuto_btn.Click += new System.EventHandler(this.playAuto_btn_Click);
            // 
            // options_gbox
            // 
            this.options_gbox.Controls.Add(this.start_btn);
            this.options_gbox.Controls.Add(this.logMoves_chbox);
            this.options_gbox.Controls.Add(this.logGame_chbox);
            this.options_gbox.Controls.Add(this.logMatch_chbox);
            this.options_gbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.options_gbox.ForeColor = System.Drawing.Color.Black;
            this.options_gbox.Location = new System.Drawing.Point(45, 476);
            this.options_gbox.Name = "options_gbox";
            this.options_gbox.Size = new System.Drawing.Size(149, 181);
            this.options_gbox.TabIndex = 5;
            this.options_gbox.TabStop = false;
            this.options_gbox.Text = "Options";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start_btn.Location = new System.Drawing.Point(18, 129);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(88, 30);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // logMoves_chbox
            // 
            this.logMoves_chbox.AutoSize = true;
            this.logMoves_chbox.Location = new System.Drawing.Point(18, 82);
            this.logMoves_chbox.Name = "logMoves_chbox";
            this.logMoves_chbox.Size = new System.Drawing.Size(112, 24);
            this.logMoves_chbox.TabIndex = 2;
            this.logMoves_chbox.Text = "Log Moves";
            this.logMoves_chbox.UseVisualStyleBackColor = true;
            // 
            // logGame_chbox
            // 
            this.logGame_chbox.AutoSize = true;
            this.logGame_chbox.Location = new System.Drawing.Point(18, 56);
            this.logGame_chbox.Name = "logGame_chbox";
            this.logGame_chbox.Size = new System.Drawing.Size(112, 24);
            this.logGame_chbox.TabIndex = 1;
            this.logGame_chbox.Text = "Log Games";
            this.logGame_chbox.UseVisualStyleBackColor = true;
            // 
            // logMatch_chbox
            // 
            this.logMatch_chbox.AutoSize = true;
            this.logMatch_chbox.Location = new System.Drawing.Point(18, 31);
            this.logMatch_chbox.Name = "logMatch_chbox";
            this.logMatch_chbox.Size = new System.Drawing.Size(130, 24);
            this.logMatch_chbox.TabIndex = 0;
            this.logMatch_chbox.Text = "Log Matches";
            this.logMatch_chbox.UseVisualStyleBackColor = true;
            // 
            // screen_flpanel
            // 
            this.screen_flpanel.AutoScroll = true;
            this.screen_flpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screen_flpanel.Controls.Add(this.screen_lbl);
            this.screen_flpanel.Location = new System.Drawing.Point(402, 23);
            this.screen_flpanel.Name = "screen_flpanel";
            this.screen_flpanel.Size = new System.Drawing.Size(758, 634);
            this.screen_flpanel.TabIndex = 6;
            // 
            // screen_lbl
            // 
            this.screen_lbl.AutoSize = true;
            this.screen_lbl.Location = new System.Drawing.Point(3, 0);
            this.screen_lbl.Name = "screen_lbl";
            this.screen_lbl.Size = new System.Drawing.Size(63, 20);
            this.screen_lbl.TabIndex = 0;
            this.screen_lbl.Text = "label1";
            // 
            // playAuto_timer
            // 
            this.playAuto_timer.Tick += new System.EventHandler(this.playAuto_timer_Tick);
            // 
            // timer_nud
            // 
            this.timer_nud.AllowDrop = true;
            this.timer_nud.Location = new System.Drawing.Point(243, 47);
            this.timer_nud.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.timer_nud.Name = "timer_nud";
            this.timer_nud.Size = new System.Drawing.Size(51, 27);
            this.timer_nud.TabIndex = 7;
            this.timer_nud.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // LoggingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1250, 716);
            this.Controls.Add(this.timer_nud);
            this.Controls.Add(this.screen_flpanel);
            this.Controls.Add(this.options_gbox);
            this.Controls.Add(this.playAuto_btn);
            this.Controls.Add(this.nextMove_btn);
            this.Controls.Add(this.playGame_btn);
            this.Controls.Add(this.playMatch_btn);
            this.Controls.Add(this.playTournament_btn);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoggingForm";
            this.ShowIcon = false;
            this.Text = "The Olympics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggingForm_FormClosing);
            this.Load += new System.EventHandler(this.LoggingForm_Load);
            this.options_gbox.ResumeLayout(false);
            this.options_gbox.PerformLayout();
            this.screen_flpanel.ResumeLayout(false);
            this.screen_flpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer_nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playTournament_btn;
        private System.Windows.Forms.Button playMatch_btn;
        private System.Windows.Forms.Button playGame_btn;
        private System.Windows.Forms.Button nextMove_btn;
        private System.Windows.Forms.Button playAuto_btn;
        private System.Windows.Forms.GroupBox options_gbox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.CheckBox logMoves_chbox;
        private System.Windows.Forms.CheckBox logGame_chbox;
        private System.Windows.Forms.CheckBox logMatch_chbox;
        private System.Windows.Forms.FlowLayoutPanel screen_flpanel;
        private System.Windows.Forms.Label screen_lbl;
        private System.Windows.Forms.Timer playAuto_timer;
        private System.Windows.Forms.NumericUpDown timer_nud;
    }
}