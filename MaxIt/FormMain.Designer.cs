namespace MaxIt
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            timerCountdown = new System.Windows.Forms.Timer(components);
            panelSettings = new Panel();
            btnSettingsBack = new ActiveLabel();
            lblSettingsHint = new ActiveLabel();
            optSettingsLanguage = new ActiveLabel();
            optSettingsTimer = new ActiveLabel();
            optSettingsAiLevel = new ActiveLabel();
            optSettingsPlayers = new ActiveLabel();
            btnSettingsCaptionLanguage = new ActiveLabel();
            lblSettingsCaptionTimer = new ActiveLabel();
            lblSettingsCaptionAiLevel = new ActiveLabel();
            btnSettingsCaptionPlayers = new ActiveLabel();
            lblSettingsTitle = new ActiveLabel();
            panelRules = new Panel();
            btnRulesBack = new ActiveLabel();
            lblRulesText = new ActiveLabel();
            lblRulesTitle = new ActiveLabel();
            panelRecords = new Panel();
            btnRecordsBack = new ActiveLabel();
            lblRecordsTitle = new ActiveLabel();
            panelMenu = new Panel();
            btnQuit = new ActiveLabel();
            btnRecords = new ActiveLabel();
            btnSettings = new ActiveLabel();
            btnRules = new ActiveLabel();
            btnPlay = new ActiveLabel();
            lblMenuTitle = new ActiveLabel();
            panelGame = new Panel();
            btnGameStop = new ActiveLabel();
            lblGameTitle = new ActiveLabel();
            panelIntro = new Panel();
            labelLogo = new Label();
            timerStopwatch = new System.Windows.Forms.Timer(components);
            panelSettings.SuspendLayout();
            panelRules.SuspendLayout();
            panelRecords.SuspendLayout();
            panelMenu.SuspendLayout();
            panelGame.SuspendLayout();
            panelIntro.SuspendLayout();
            SuspendLayout();
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 1000;
            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(btnSettingsBack);
            panelSettings.Controls.Add(lblSettingsHint);
            panelSettings.Controls.Add(optSettingsLanguage);
            panelSettings.Controls.Add(optSettingsTimer);
            panelSettings.Controls.Add(optSettingsAiLevel);
            panelSettings.Controls.Add(optSettingsPlayers);
            panelSettings.Controls.Add(btnSettingsCaptionLanguage);
            panelSettings.Controls.Add(lblSettingsCaptionTimer);
            panelSettings.Controls.Add(lblSettingsCaptionAiLevel);
            panelSettings.Controls.Add(btnSettingsCaptionPlayers);
            panelSettings.Controls.Add(lblSettingsTitle);
            panelSettings.Location = new Point(777, 133);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(395, 416);
            panelSettings.TabIndex = 1;
            // 
            // btnSettingsBack
            // 
            btnSettingsBack.AutoSize = true;
            btnSettingsBack.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettingsBack.ForeColor = Color.Silver;
            btnSettingsBack.Hint = "";
            btnSettingsBack.Id = "btnSettingsBack";
            btnSettingsBack.Location = new Point(126, 486);
            btnSettingsBack.Name = "btnSettingsBack";
            btnSettingsBack.Padding = new Padding(4, 0, 0, 0);
            btnSettingsBack.Role = Enumerations.LabelRole.Button;
            btnSettingsBack.Size = new Size(122, 45);
            btnSettingsBack.TabIndex = 38;
            btnSettingsBack.Text = "?BACK";
            btnSettingsBack.Value = null;
            btnSettingsBack.Values = (List<int>)resources.GetObject("btnSettingsBack.Values");
            btnSettingsBack.Click += ButtonClick;
            btnSettingsBack.MouseDown += ButtonMouseDown;
            btnSettingsBack.MouseEnter += ButtonMouseEnter;
            btnSettingsBack.MouseLeave += ButtonMouseLeave;
            btnSettingsBack.MouseUp += ButtonMouseUp;
            // 
            // lblSettingsHint
            // 
            lblSettingsHint.AutoSize = true;
            lblSettingsHint.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSettingsHint.ForeColor = Color.Silver;
            lblSettingsHint.Hint = "";
            lblSettingsHint.Id = "lblSettingsHint";
            lblSettingsHint.Location = new Point(58, 380);
            lblSettingsHint.Name = "lblSettingsHint";
            lblSettingsHint.Padding = new Padding(4, 0, 0, 0);
            lblSettingsHint.Role = Enumerations.LabelRole.Label;
            lblSettingsHint.Size = new Size(252, 26);
            lblSettingsHint.TabIndex = 37;
            lblSettingsHint.Text = "?CONFIGURE GAME SETTINGS";
            lblSettingsHint.Value = null;
            lblSettingsHint.Values = (List<int>)resources.GetObject("lblSettingsHint.Values");
            // 
            // optSettingsLanguage
            // 
            optSettingsLanguage.AutoSize = true;
            optSettingsLanguage.Captions.Add("?ENGLISH");
            optSettingsLanguage.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            optSettingsLanguage.ForeColor = Color.Silver;
            optSettingsLanguage.Hint = "?SELECT UI LANGUAGE";
            optSettingsLanguage.Id = "optSettingsLanguage";
            optSettingsLanguage.Location = new Point(191, 280);
            optSettingsLanguage.Name = "optSettingsLanguage";
            optSettingsLanguage.Padding = new Padding(4, 0, 0, 0);
            optSettingsLanguage.Role = Enumerations.LabelRole.Option;
            optSettingsLanguage.Size = new Size(121, 34);
            optSettingsLanguage.TabIndex = 36;
            optSettingsLanguage.Tag = "lblSettingsHint";
            optSettingsLanguage.Text = "?ENGLISH";
            optSettingsLanguage.Value = 0;
            optSettingsLanguage.Values = (List<int>)resources.GetObject("optSettingsLanguage.Values");
            optSettingsLanguage.Click += ButtonClick;
            optSettingsLanguage.MouseDown += ButtonMouseDown;
            optSettingsLanguage.MouseEnter += ButtonMouseEnter;
            optSettingsLanguage.MouseLeave += ButtonMouseLeave;
            optSettingsLanguage.MouseUp += ButtonMouseUp;
            // 
            // optSettingsTimer
            // 
            optSettingsTimer.AutoSize = true;
            optSettingsTimer.Captions.Add("?OFF");
            optSettingsTimer.Captions.Add("?ON");
            optSettingsTimer.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            optSettingsTimer.ForeColor = Color.Silver;
            optSettingsTimer.Hint = "?SET COUNTDOWN TIMER: OFF / ON";
            optSettingsTimer.Id = "optSettingsTimer";
            optSettingsTimer.Location = new Point(191, 240);
            optSettingsTimer.Name = "optSettingsTimer";
            optSettingsTimer.Padding = new Padding(4, 0, 0, 0);
            optSettingsTimer.Role = Enumerations.LabelRole.Option;
            optSettingsTimer.Size = new Size(70, 34);
            optSettingsTimer.TabIndex = 35;
            optSettingsTimer.Tag = "lblSettingsHint";
            optSettingsTimer.Text = "?OFF";
            optSettingsTimer.Value = 0;
            optSettingsTimer.Values = (List<int>)resources.GetObject("optSettingsTimer.Values");
            optSettingsTimer.Click += ButtonClick;
            optSettingsTimer.MouseDown += ButtonMouseDown;
            optSettingsTimer.MouseEnter += ButtonMouseEnter;
            optSettingsTimer.MouseLeave += ButtonMouseLeave;
            optSettingsTimer.MouseUp += ButtonMouseUp;
            // 
            // optSettingsAiLevel
            // 
            optSettingsAiLevel.AutoSize = true;
            optSettingsAiLevel.Captions.Add("?EASY");
            optSettingsAiLevel.Captions.Add("?MEDIUM");
            optSettingsAiLevel.Captions.Add("?HARD");
            optSettingsAiLevel.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            optSettingsAiLevel.ForeColor = Color.Silver;
            optSettingsAiLevel.Hint = "?SELECT AI LEVEL: EASY, MEDIUM, HARD";
            optSettingsAiLevel.Id = "optSettingsAiLevel";
            optSettingsAiLevel.Location = new Point(191, 200);
            optSettingsAiLevel.Name = "optSettingsAiLevel";
            optSettingsAiLevel.Padding = new Padding(4, 0, 0, 0);
            optSettingsAiLevel.Role = Enumerations.LabelRole.Option;
            optSettingsAiLevel.Size = new Size(85, 34);
            optSettingsAiLevel.TabIndex = 34;
            optSettingsAiLevel.Tag = "lblSettingsHint";
            optSettingsAiLevel.Text = "?EASY";
            optSettingsAiLevel.Value = 0;
            optSettingsAiLevel.Values = (List<int>)resources.GetObject("optSettingsAiLevel.Values");
            optSettingsAiLevel.Click += ButtonClick;
            optSettingsAiLevel.MouseDown += ButtonMouseDown;
            optSettingsAiLevel.MouseEnter += ButtonMouseEnter;
            optSettingsAiLevel.MouseLeave += ButtonMouseLeave;
            optSettingsAiLevel.MouseUp += ButtonMouseUp;
            // 
            // optSettingsPlayers
            // 
            optSettingsPlayers.AutoSize = true;
            optSettingsPlayers.Captions.Add("?COMPUTER VS. COMPUTER");
            optSettingsPlayers.Captions.Add("?HUMAN VS. COMPUTER");
            optSettingsPlayers.Captions.Add("?HUMAN VS. HUMAN");
            optSettingsPlayers.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            optSettingsPlayers.ForeColor = Color.Silver;
            optSettingsPlayers.Hint = "?SELECT PARTNERS: COMPUTER VS. COMPUTER, HUMAN VS. COMPUTER, HUMAN VS. HUMAN";
            optSettingsPlayers.Id = "optSettingsPlayers";
            optSettingsPlayers.Location = new Point(191, 160);
            optSettingsPlayers.Name = "optSettingsPlayers";
            optSettingsPlayers.Padding = new Padding(4, 0, 0, 0);
            optSettingsPlayers.Role = Enumerations.LabelRole.Option;
            optSettingsPlayers.Size = new Size(270, 34);
            optSettingsPlayers.TabIndex = 33;
            optSettingsPlayers.Tag = "lblSettingsHint";
            optSettingsPlayers.Text = "?HUMAN VS. COMPUTER";
            optSettingsPlayers.Value = 1;
            optSettingsPlayers.Values = (List<int>)resources.GetObject("optSettingsPlayers.Values");
            optSettingsPlayers.Click += ButtonClick;
            optSettingsPlayers.MouseDown += ButtonMouseDown;
            optSettingsPlayers.MouseEnter += ButtonMouseEnter;
            optSettingsPlayers.MouseLeave += ButtonMouseLeave;
            optSettingsPlayers.MouseUp += ButtonMouseUp;
            // 
            // btnSettingsCaptionLanguage
            // 
            btnSettingsCaptionLanguage.AutoSize = true;
            btnSettingsCaptionLanguage.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettingsCaptionLanguage.ForeColor = Color.Silver;
            btnSettingsCaptionLanguage.Hint = "?MANAGE LANGUAGES";
            btnSettingsCaptionLanguage.Id = "btnSettingsCaptionLanguage";
            btnSettingsCaptionLanguage.Location = new Point(37, 280);
            btnSettingsCaptionLanguage.Name = "btnSettingsCaptionLanguage";
            btnSettingsCaptionLanguage.Padding = new Padding(4, 0, 0, 0);
            btnSettingsCaptionLanguage.Role = Enumerations.LabelRole.Button;
            btnSettingsCaptionLanguage.Size = new Size(148, 34);
            btnSettingsCaptionLanguage.TabIndex = 32;
            btnSettingsCaptionLanguage.Tag = "lblSettingsHint";
            btnSettingsCaptionLanguage.Text = "?LANGUAGE:";
            btnSettingsCaptionLanguage.TextAlign = ContentAlignment.TopRight;
            btnSettingsCaptionLanguage.Value = null;
            btnSettingsCaptionLanguage.Values = (List<int>)resources.GetObject("btnSettingsCaptionLanguage.Values");
            btnSettingsCaptionLanguage.Click += ButtonClick;
            btnSettingsCaptionLanguage.MouseDown += ButtonMouseDown;
            btnSettingsCaptionLanguage.MouseEnter += ButtonMouseEnter;
            btnSettingsCaptionLanguage.MouseLeave += ButtonMouseLeave;
            btnSettingsCaptionLanguage.MouseUp += ButtonMouseUp;
            // 
            // lblSettingsCaptionTimer
            // 
            lblSettingsCaptionTimer.AutoSize = true;
            lblSettingsCaptionTimer.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSettingsCaptionTimer.ForeColor = Color.Silver;
            lblSettingsCaptionTimer.Hint = "";
            lblSettingsCaptionTimer.Id = "lblSettingsCaptionTimer";
            lblSettingsCaptionTimer.Location = new Point(82, 240);
            lblSettingsCaptionTimer.Name = "lblSettingsCaptionTimer";
            lblSettingsCaptionTimer.Padding = new Padding(4, 0, 0, 0);
            lblSettingsCaptionTimer.Role = Enumerations.LabelRole.Label;
            lblSettingsCaptionTimer.Size = new Size(103, 34);
            lblSettingsCaptionTimer.TabIndex = 31;
            lblSettingsCaptionTimer.Text = "?TIMER:";
            lblSettingsCaptionTimer.TextAlign = ContentAlignment.TopRight;
            lblSettingsCaptionTimer.Value = null;
            lblSettingsCaptionTimer.Values = (List<int>)resources.GetObject("lblSettingsCaptionTimer.Values");
            // 
            // lblSettingsCaptionAiLevel
            // 
            lblSettingsCaptionAiLevel.AutoSize = true;
            lblSettingsCaptionAiLevel.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSettingsCaptionAiLevel.ForeColor = Color.Silver;
            lblSettingsCaptionAiLevel.Hint = "";
            lblSettingsCaptionAiLevel.Id = "lblSettingsCaptionAiLevel";
            lblSettingsCaptionAiLevel.Location = new Point(64, 200);
            lblSettingsCaptionAiLevel.Name = "lblSettingsCaptionAiLevel";
            lblSettingsCaptionAiLevel.Padding = new Padding(4, 0, 0, 0);
            lblSettingsCaptionAiLevel.Role = Enumerations.LabelRole.Label;
            lblSettingsCaptionAiLevel.Size = new Size(121, 34);
            lblSettingsCaptionAiLevel.TabIndex = 30;
            lblSettingsCaptionAiLevel.Text = "?AI LEVEL:";
            lblSettingsCaptionAiLevel.TextAlign = ContentAlignment.TopRight;
            lblSettingsCaptionAiLevel.Value = null;
            lblSettingsCaptionAiLevel.Values = (List<int>)resources.GetObject("lblSettingsCaptionAiLevel.Values");
            // 
            // btnSettingsCaptionPlayers
            // 
            btnSettingsCaptionPlayers.AutoSize = true;
            btnSettingsCaptionPlayers.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettingsCaptionPlayers.ForeColor = Color.Silver;
            btnSettingsCaptionPlayers.Hint = "?MANAGE PLAYERS";
            btnSettingsCaptionPlayers.Id = "btnSettingsCaptionPlayers";
            btnSettingsCaptionPlayers.Location = new Point(57, 160);
            btnSettingsCaptionPlayers.Name = "btnSettingsCaptionPlayers";
            btnSettingsCaptionPlayers.Padding = new Padding(4, 0, 0, 0);
            btnSettingsCaptionPlayers.Role = Enumerations.LabelRole.Button;
            btnSettingsCaptionPlayers.Size = new Size(128, 34);
            btnSettingsCaptionPlayers.TabIndex = 29;
            btnSettingsCaptionPlayers.Tag = "lblSettingsHint";
            btnSettingsCaptionPlayers.Text = "?PLAYERS:";
            btnSettingsCaptionPlayers.TextAlign = ContentAlignment.TopRight;
            btnSettingsCaptionPlayers.Value = null;
            btnSettingsCaptionPlayers.Values = (List<int>)resources.GetObject("btnSettingsCaptionPlayers.Values");
            btnSettingsCaptionPlayers.Click += ButtonClick;
            btnSettingsCaptionPlayers.MouseDown += ButtonMouseDown;
            btnSettingsCaptionPlayers.MouseEnter += ButtonMouseEnter;
            btnSettingsCaptionPlayers.MouseLeave += ButtonMouseLeave;
            btnSettingsCaptionPlayers.MouseUp += ButtonMouseUp;
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblSettingsTitle.ForeColor = Color.Silver;
            lblSettingsTitle.Hint = "";
            lblSettingsTitle.Id = "lblSettingsTitle";
            lblSettingsTitle.Location = new Point(9, 30);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Padding = new Padding(4, 0, 0, 0);
            lblSettingsTitle.Role = Enumerations.LabelRole.Label;
            lblSettingsTitle.Size = new Size(383, 60);
            lblSettingsTitle.TabIndex = 28;
            lblSettingsTitle.Text = "?MAX IT . SETTINGS";
            lblSettingsTitle.Value = null;
            lblSettingsTitle.Values = (List<int>)resources.GetObject("lblSettingsTitle.Values");
            // 
            // panelRules
            // 
            panelRules.Controls.Add(btnRulesBack);
            panelRules.Controls.Add(lblRulesText);
            panelRules.Controls.Add(lblRulesTitle);
            panelRules.Location = new Point(12, 9);
            panelRules.Name = "panelRules";
            panelRules.Size = new Size(347, 116);
            panelRules.TabIndex = 4;
            // 
            // btnRulesBack
            // 
            btnRulesBack.AutoSize = true;
            btnRulesBack.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRulesBack.ForeColor = Color.Silver;
            btnRulesBack.Hint = "";
            btnRulesBack.Id = "btnRulesBack";
            btnRulesBack.Location = new Point(126, 486);
            btnRulesBack.Name = "btnRulesBack";
            btnRulesBack.Padding = new Padding(4, 0, 0, 0);
            btnRulesBack.Role = Enumerations.LabelRole.Button;
            btnRulesBack.Size = new Size(122, 45);
            btnRulesBack.TabIndex = 41;
            btnRulesBack.Text = "?BACK";
            btnRulesBack.Value = null;
            btnRulesBack.Values = (List<int>)resources.GetObject("btnRulesBack.Values");
            btnRulesBack.Click += ButtonClick;
            btnRulesBack.MouseDown += ButtonMouseDown;
            btnRulesBack.MouseEnter += ButtonMouseEnter;
            btnRulesBack.MouseLeave += ButtonMouseLeave;
            btnRulesBack.MouseUp += ButtonMouseUp;
            // 
            // lblRulesText
            // 
            lblRulesText.AutoSize = true;
            lblRulesText.Captions.Add("?.  The playing field is filled with random numbers from 0 to 9.");
            lblRulesText.Captions.Add("?.  Players can select any non-empty cell on the field in one move.");
            lblRulesText.Captions.Add("?.  One player can select cells only vertically, the other only horizontally.");
            lblRulesText.Captions.Add("?.  After one player moves, the other player can only move in the newly selected row or column.");
            lblRulesText.Captions.Add("?.  An empty cell can no longer be selected.");
            lblRulesText.Captions.Add("?.  The selected number is added to the score of the player who made the move.");
            lblRulesText.Captions.Add("?.  The order, direction of the player's moves and starting position are also random.");
            lblRulesText.Captions.Add("?.  The game ends when no more numbers left on the board.");
            lblRulesText.Captions.Add("?.  The game ends also when one of the players has no opportunity to make a move.");
            lblRulesText.Captions.Add("?.  The player with the most points wins.");
            lblRulesText.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRulesText.ForeColor = Color.Silver;
            lblRulesText.Hint = "";
            lblRulesText.Id = "lblRulesText";
            lblRulesText.Location = new Point(49, 156);
            lblRulesText.Name = "lblRulesText";
            lblRulesText.Padding = new Padding(4, 0, 0, 0);
            lblRulesText.Role = Enumerations.LabelRole.Label;
            lblRulesText.Size = new Size(27, 26);
            lblRulesText.TabIndex = 40;
            lblRulesText.Text = "?";
            lblRulesText.Value = null;
            lblRulesText.Values = (List<int>)resources.GetObject("lblRulesText.Values");
            // 
            // lblRulesTitle
            // 
            lblRulesTitle.AutoSize = true;
            lblRulesTitle.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblRulesTitle.ForeColor = Color.Silver;
            lblRulesTitle.Hint = "";
            lblRulesTitle.Id = "lblRulesTitle";
            lblRulesTitle.Location = new Point(9, 30);
            lblRulesTitle.Name = "lblRulesTitle";
            lblRulesTitle.Padding = new Padding(4, 0, 0, 0);
            lblRulesTitle.Role = Enumerations.LabelRole.Label;
            lblRulesTitle.Size = new Size(319, 60);
            lblRulesTitle.TabIndex = 39;
            lblRulesTitle.Text = "?MAX IT . RULES";
            lblRulesTitle.Value = null;
            lblRulesTitle.Values = (List<int>)resources.GetObject("lblRulesTitle.Values");
            // 
            // panelRecords
            // 
            panelRecords.Controls.Add(btnRecordsBack);
            panelRecords.Controls.Add(lblRecordsTitle);
            panelRecords.Location = new Point(12, 271);
            panelRecords.Name = "panelRecords";
            panelRecords.Size = new Size(395, 118);
            panelRecords.TabIndex = 8;
            // 
            // btnRecordsBack
            // 
            btnRecordsBack.AutoSize = true;
            btnRecordsBack.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecordsBack.ForeColor = Color.Silver;
            btnRecordsBack.Hint = "";
            btnRecordsBack.Id = "btnRecordsBack";
            btnRecordsBack.Location = new Point(126, 486);
            btnRecordsBack.Name = "btnRecordsBack";
            btnRecordsBack.Padding = new Padding(4, 0, 0, 0);
            btnRecordsBack.Role = Enumerations.LabelRole.Button;
            btnRecordsBack.Size = new Size(122, 45);
            btnRecordsBack.TabIndex = 41;
            btnRecordsBack.Text = "?BACK";
            btnRecordsBack.Value = null;
            btnRecordsBack.Values = (List<int>)resources.GetObject("btnRecordsBack.Values");
            btnRecordsBack.Click += ButtonClick;
            btnRecordsBack.MouseDown += ButtonMouseDown;
            btnRecordsBack.MouseEnter += ButtonMouseEnter;
            btnRecordsBack.MouseLeave += ButtonMouseLeave;
            btnRecordsBack.MouseUp += ButtonMouseUp;
            // 
            // lblRecordsTitle
            // 
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecordsTitle.ForeColor = Color.Silver;
            lblRecordsTitle.Hint = "";
            lblRecordsTitle.Id = "lblRecordsTitle";
            lblRecordsTitle.Location = new Point(9, 30);
            lblRecordsTitle.Name = "lblRecordsTitle";
            lblRecordsTitle.Padding = new Padding(4, 0, 0, 0);
            lblRecordsTitle.Role = Enumerations.LabelRole.Label;
            lblRecordsTitle.Size = new Size(381, 60);
            lblRecordsTitle.TabIndex = 39;
            lblRecordsTitle.Text = "?MAX IT . RECORDS";
            lblRecordsTitle.Value = null;
            lblRecordsTitle.Values = (List<int>)resources.GetObject("lblRecordsTitle.Values");
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnQuit);
            panelMenu.Controls.Add(btnRecords);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnRules);
            panelMenu.Controls.Add(btnPlay);
            panelMenu.Controls.Add(lblMenuTitle);
            panelMenu.Location = new Point(12, 131);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(204, 120);
            panelMenu.TabIndex = 5;
            // 
            // btnQuit
            // 
            btnQuit.AutoSize = true;
            btnQuit.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.Silver;
            btnQuit.Hint = "";
            btnQuit.Id = "btnQuit";
            btnQuit.Location = new Point(9, 350);
            btnQuit.Name = "btnQuit";
            btnQuit.Padding = new Padding(4, 0, 0, 0);
            btnQuit.Role = Enumerations.LabelRole.Button;
            btnQuit.Size = new Size(111, 45);
            btnQuit.TabIndex = 44;
            btnQuit.Text = "?QUIT";
            btnQuit.Value = null;
            btnQuit.Values = (List<int>)resources.GetObject("btnQuit.Values");
            btnQuit.Click += ButtonClick;
            btnQuit.MouseDown += ButtonMouseDown;
            btnQuit.MouseEnter += ButtonMouseEnter;
            btnQuit.MouseLeave += ButtonMouseLeave;
            btnQuit.MouseUp += ButtonMouseUp;
            // 
            // btnRecords
            // 
            btnRecords.AutoSize = true;
            btnRecords.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecords.ForeColor = Color.Silver;
            btnRecords.Hint = "";
            btnRecords.Id = "btnRecords";
            btnRecords.Location = new Point(9, 250);
            btnRecords.Name = "btnRecords";
            btnRecords.Padding = new Padding(4, 0, 0, 0);
            btnRecords.Role = Enumerations.LabelRole.Button;
            btnRecords.Size = new Size(177, 45);
            btnRecords.TabIndex = 43;
            btnRecords.Text = "?RECORDS";
            btnRecords.Value = null;
            btnRecords.Values = (List<int>)resources.GetObject("btnRecords.Values");
            btnRecords.Click += ButtonClick;
            btnRecords.MouseDown += ButtonMouseDown;
            btnRecords.MouseEnter += ButtonMouseEnter;
            btnRecords.MouseLeave += ButtonMouseLeave;
            btnRecords.MouseUp += ButtonMouseUp;
            // 
            // btnSettings
            // 
            btnSettings.AutoSize = true;
            btnSettings.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Silver;
            btnSettings.Hint = "";
            btnSettings.Id = "btnSettings";
            btnSettings.Location = new Point(9, 300);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(4, 0, 0, 0);
            btnSettings.Role = Enumerations.LabelRole.Button;
            btnSettings.Size = new Size(181, 45);
            btnSettings.TabIndex = 42;
            btnSettings.Text = "?SETTINGS";
            btnSettings.Value = null;
            btnSettings.Values = (List<int>)resources.GetObject("btnSettings.Values");
            btnSettings.Click += ButtonClick;
            btnSettings.MouseDown += ButtonMouseDown;
            btnSettings.MouseEnter += ButtonMouseEnter;
            btnSettings.MouseLeave += ButtonMouseLeave;
            btnSettings.MouseUp += ButtonMouseUp;
            // 
            // btnRules
            // 
            btnRules.AutoSize = true;
            btnRules.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRules.ForeColor = Color.Silver;
            btnRules.Hint = "";
            btnRules.Id = "btnRules";
            btnRules.Location = new Point(9, 200);
            btnRules.Name = "btnRules";
            btnRules.Padding = new Padding(4, 0, 0, 0);
            btnRules.Role = Enumerations.LabelRole.Button;
            btnRules.Size = new Size(131, 45);
            btnRules.TabIndex = 41;
            btnRules.Text = "?RULES";
            btnRules.Value = null;
            btnRules.Values = (List<int>)resources.GetObject("btnRules.Values");
            btnRules.Click += ButtonClick;
            btnRules.MouseDown += ButtonMouseDown;
            btnRules.MouseEnter += ButtonMouseEnter;
            btnRules.MouseLeave += ButtonMouseLeave;
            btnRules.MouseUp += ButtonMouseUp;
            // 
            // btnPlay
            // 
            btnPlay.AutoSize = true;
            btnPlay.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.Silver;
            btnPlay.Hint = "";
            btnPlay.Id = "btnPlay";
            btnPlay.Location = new Point(9, 150);
            btnPlay.Name = "btnPlay";
            btnPlay.Padding = new Padding(4, 0, 0, 0);
            btnPlay.Role = Enumerations.LabelRole.Button;
            btnPlay.Size = new Size(112, 45);
            btnPlay.TabIndex = 40;
            btnPlay.Text = "?PLAY";
            btnPlay.Value = null;
            btnPlay.Values = (List<int>)resources.GetObject("btnPlay.Values");
            btnPlay.Click += ButtonClick;
            btnPlay.MouseDown += ButtonMouseDown;
            btnPlay.MouseEnter += ButtonMouseEnter;
            btnPlay.MouseLeave += ButtonMouseLeave;
            btnPlay.MouseUp += ButtonMouseUp;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenuTitle.ForeColor = Color.Silver;
            lblMenuTitle.Hint = "";
            lblMenuTitle.Id = "lblMenuTitle";
            lblMenuTitle.Location = new Point(9, 30);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Padding = new Padding(4, 0, 0, 0);
            lblMenuTitle.Role = Enumerations.LabelRole.Label;
            lblMenuTitle.Size = new Size(179, 60);
            lblMenuTitle.TabIndex = 39;
            lblMenuTitle.Text = "?MAX IT";
            lblMenuTitle.Value = null;
            lblMenuTitle.Values = (List<int>)resources.GetObject("lblMenuTitle.Values");
            // 
            // panelGame
            // 
            panelGame.Controls.Add(btnGameStop);
            panelGame.Controls.Add(lblGameTitle);
            panelGame.Location = new Point(777, 12);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(395, 115);
            panelGame.TabIndex = 6;
            // 
            // btnGameStop
            // 
            btnGameStop.AutoSize = true;
            btnGameStop.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGameStop.ForeColor = Color.Silver;
            btnGameStop.Hint = "";
            btnGameStop.Id = "btnGameStop";
            btnGameStop.Location = new Point(126, 486);
            btnGameStop.Name = "btnGameStop";
            btnGameStop.Padding = new Padding(4, 0, 0, 0);
            btnGameStop.Role = Enumerations.LabelRole.Button;
            btnGameStop.Size = new Size(122, 45);
            btnGameStop.TabIndex = 43;
            btnGameStop.Text = "?BACK";
            btnGameStop.Value = null;
            btnGameStop.Values = (List<int>)resources.GetObject("btnGameStop.Values");
            btnGameStop.Click += ButtonClick;
            btnGameStop.MouseDown += ButtonMouseDown;
            btnGameStop.MouseEnter += ButtonMouseEnter;
            btnGameStop.MouseLeave += ButtonMouseLeave;
            btnGameStop.MouseUp += ButtonMouseUp;
            // 
            // lblGameTitle
            // 
            lblGameTitle.AutoSize = true;
            lblGameTitle.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameTitle.ForeColor = Color.Silver;
            lblGameTitle.Hint = "";
            lblGameTitle.Id = "lblGameTitle";
            lblGameTitle.Location = new Point(9, 30);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Padding = new Padding(4, 0, 0, 0);
            lblGameTitle.Role = Enumerations.LabelRole.Label;
            lblGameTitle.Size = new Size(179, 60);
            lblGameTitle.TabIndex = 42;
            lblGameTitle.Text = "?MAX IT";
            lblGameTitle.Value = null;
            lblGameTitle.Values = (List<int>)resources.GetObject("lblGameTitle.Values");
            // 
            // panelIntro
            // 
            panelIntro.Controls.Add(labelLogo);
            panelIntro.Location = new Point(378, 12);
            panelIntro.Name = "panelIntro";
            panelIntro.Size = new Size(226, 141);
            panelIntro.TabIndex = 7;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogo.ForeColor = Color.White;
            labelLogo.Location = new Point(62, 24);
            labelLogo.Name = "labelLogo";
            labelLogo.Padding = new Padding(8, 0, 0, 0);
            labelLogo.Size = new Size(469, 117);
            labelLogo.TabIndex = 4;
            labelLogo.Text = "WEBCHEST";
            // 
            // timerStopwatch
            // 
            timerStopwatch.Interval = 1000;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 561);
            Controls.Add(panelSettings);
            Controls.Add(panelGame);
            Controls.Add(panelRecords);
            Controls.Add(panelMenu);
            Controls.Add(panelRules);
            Controls.Add(panelIntro);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1200, 600);
            MinimumSize = new Size(1200, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MAX IT";
            Load += FormMainLoad;
            Shown += FormMainShown;
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelRules.ResumeLayout(false);
            panelRules.PerformLayout();
            panelRecords.ResumeLayout(false);
            panelRecords.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelIntro.ResumeLayout(false);
            panelIntro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerCountdown;
        private Panel panelSettings;
        private Panel panelRules;
        private Panel panelMenu;
        private Panel panelGame;
        private Panel panelIntro;
        private Label labelLogo;
        private Label buttonSettingsBack;
        private Label captionPlayers;
        private Label captionLanguage;
        private Label captionTimer;
        private Label buttonLanguage;
        private Label buttonPlayers;
        private Label buttonTimer;
        private Label buttonAiLevel;
        private Label captionAiLevel;
        private Label settingsHint;
        private ActiveLabel lblSettingsTitle;
        private ActiveLabel optSettingsLanguage;
        private ActiveLabel optSettingsTimer;
        private ActiveLabel optSettingsAiLevel;
        private ActiveLabel optSettingsPlayers;
        private ActiveLabel btnSettingsCaptionLanguage;
        private ActiveLabel lblSettingsCaptionTimer;
        private ActiveLabel lblSettingsCaptionAiLevel;
        private ActiveLabel btnSettingsCaptionPlayers;
        private ActiveLabel btnSettingsBack;
        private ActiveLabel lblSettingsHint;
        private ActiveLabel btnRulesBack;
        private ActiveLabel lblRulesText;
        private ActiveLabel lblRulesTitle;
        private ActiveLabel btnQuit;
        private ActiveLabel btnRecords;
        private ActiveLabel btnSettings;
        private ActiveLabel btnRules;
        private ActiveLabel btnPlay;
        private ActiveLabel lblMenuTitle;
        private Panel panelRecords;
        private ActiveLabel btnRecordsBack;
        private ActiveLabel lblRecordsTitle;
        private ActiveLabel btnGameStop;
        private ActiveLabel lblGameTitle;
        private System.Windows.Forms.Timer timerStopwatch;
    }
}