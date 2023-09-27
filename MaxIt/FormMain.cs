using MaxIt.Properties;
using static MaxIt.Tools;
using static MaxIt.Enumerations;
using System.Drawing.Imaging;
using System.Security.Policy;
using System;

namespace MaxIt
{
    public partial class FormMain : Form
    {
        private Settings _settings;
        private Players _players;
        private bool _loading;
        private bool _showIntro;
        private string _fontName = "Impact";
        private Color _menuItemNormalColor = FlatColors.Silver;
        private Color _menuItemHoverColor = FlatColors.GreenSea;

        private GameMode _gameMode;

        #region FormMain
        public FormMain()
        {
            InitializeComponent();
            _players = new Players();
            //InitializeGame();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            _loading = true;
            _showIntro = false;
            InitializeGame();
        }

        private void FormMainShown(object sender, EventArgs e)
        {
            if (_showIntro)
            {
                panelIntro.BringToFront();
                panelIntro.Dock = DockStyle.Fill;
                panelIntro.Visible = true;
                ShowIntro();
            }
            else
            {
                SetLabelCentered(labelLogo, "MAX IT", labelLogo.Font.Name, 36, 20, Color.White);
            }
            _loading = false;
            ShowPage(GameMode.Menu);
        }

        #endregion FormMain

        private void InitializeGame()
        {
            _gameMode = GameMode.None;

            HideAllPanels();
            //_settings.Load();

            InitMenu();
            InitPlay();
            InitRules();
            InitSettings();
            InitRecords();
        }

        private void InitMenu()
        {
            InitializePanel(panelMenu, ClientSize);
            LabelAlignCenter(lblMenuTitle);
            LabelAlignCenter(btnPlay);
            LabelAlignCenter(btnRules);
            LabelAlignCenter(btnSettings);
            LabelAlignCenter(btnRecords);
            LabelAlignCenter(btnQuit);
        }

        private void InitRules()
        {
            InitializePanel(panelRules, ClientSize);
            LabelAlignCenter(lblRulesTitle);
            LabelAlignCenter(lblRulesText);
            LabelAlignCenter(btnRulesBack);
        }

        private void InitRecords()
        {
            InitializePanel(panelRecords, ClientSize);
            LabelAlignCenter(lblRecordsTitle);
            LabelAlignCenter(btnRecordsBack);
        }

        private void InitSettings()
        {
            InitializePanel(panelSettings, ClientSize);
            LabelAlignCenter(lblSettingsTitle);
            LabelAlignCenter(btnSettingsBack);
            TwoLabelsAlignCenter(btnSettingsCaptionPlayers, optSettingsPlayers);
            TwoLabelsAlignCenter(lblSettingsCaptionAiLevel, optSettingsAiLevel);
            TwoLabelsAlignCenter(lblSettingsCaptionTimer, optSettingsTimer);
            TwoLabelsAlignCenter(btnSettingsCaptionLanguage, optSettingsLanguage);
            lblSettingsHint.Text = string.Empty;
            lblSettingsHint.Visible = false;
        }

        private void InitPlay()
        {
            InitializePanel(panelGame, ClientSize);
            LabelAlignCenter(lblGameTitle);
            LabelAlignCenter(btnGameStop);
        }

        private void HideAllPanels()
        {
            foreach (var panel in Controls.OfType<Panel>())
            {
                panel.Visible = false;
                panel.Dock = DockStyle.None;
            }
        }

        private void ShowPage(GameMode gameMode)
        {
            if (_gameMode == gameMode) return;
            HideAllPanels();
            Panel? panel = null;

            switch (gameMode)
            {
                case GameMode.None: panel = panelIntro; break;
                case GameMode.Intro: panel = panelIntro; break;
                case GameMode.Menu: panel = panelMenu; break;
                case GameMode.Play: panel = panelGame; break;
                case GameMode.Rules: panel = panelRules; break;
                case GameMode.Settings: panel = panelSettings; break;
                case GameMode.Records: panel = panelRecords; break;
                default: _gameMode = GameMode.None; break;
            }

            if (panel is null) return;

            panel.BringToFront();
            panel.Dock = DockStyle.Fill;
            panel.Visible = true;
            _gameMode = gameMode;
        }

        #region Rules

        

        #endregion Rules

        #region Menu

        private void ButtonMouseEnter(object sender, EventArgs e)
        {
            var button = (ActiveLabel)sender;
            if (button is null) return;
            button.ForeColor = _menuItemHoverColor;

            if (button.Role > LabelRole.Label && button.Tag is not null && !string.IsNullOrWhiteSpace(button.Hint))
            {
                var hintLabel = button.Parent.Controls.Find(button.Tag.ToString(), true).FirstOrDefault() as ActiveLabel;
                if (hintLabel is not null)
                {
                    hintLabel.Text = button.Hint;
                    LabelAlignCenter(lblSettingsHint);
                    hintLabel.Visible = true;
                }
            }
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            var button = (ActiveLabel)sender;
            if (button is null) return;
            button.ForeColor = _menuItemNormalColor;

            if (button.Role > LabelRole.Label && button.Tag is not null)
            {
                var hintLabel = button.Parent.Controls.Find(button.Tag.ToString(), true).FirstOrDefault() as ActiveLabel;
                if (hintLabel is not null)
                {
                    hintLabel.Text = string.Empty;
                    hintLabel.Visible = false;
                }
            }
        }

        private void ButtonMouseDown(object sender, MouseEventArgs e)
        {
            var button = (ActiveLabel)sender;
            if (button is null) return;
            button.Location = new Point(button.Left + 1, button.Top + 1);
        }

        private void ButtonMouseUp(object sender, MouseEventArgs e)
        {
            var button = (ActiveLabel)sender;
            if (button is null) return;
            button.Location = new Point(button.Left - 1, button.Top - 1);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var button = (ActiveLabel)sender;
            if (button is null) return;

            if (button.Role.Equals(LabelRole.Button))
            {
                switch (button.Name)
                {
                    case nameof(btnPlay): ShowPage(GameMode.Play); break;
                    case nameof(btnRules): ShowPage(GameMode.Rules); break;
                    case nameof(btnSettings): ShowPage(GameMode.Settings); break;
                    case nameof(btnRecords): ShowPage(GameMode.Records); break;
                    case nameof(btnQuit): Application.Exit(); break;
                    case nameof(btnGameStop):
                    case nameof(btnRulesBack):
                    case nameof(btnSettingsBack):
                    case nameof(btnRecordsBack): ShowPage(GameMode.Menu); break;

                    default:
                        break;
                };
            }

            if (button.Role.Equals(LabelRole.Option) && button.Value is not null && button.Values is not null && button.Captions is not null)
            {
                var currentValue = (int)button.Value;
                var currentValueIndex = button.Values.IndexOf(currentValue);
                var nextIndex = currentValueIndex + 1;
                if (nextIndex > button.Values.Count - 1) nextIndex = 0;
                button.Text = button.Captions[nextIndex];
                button.Value = button.Values[nextIndex];
            }
        }

        #endregion Menu

        #region Intro

        private async void ShowIntro()
        {
            _gameMode = GameMode.Intro;

            SetLabelCentered(labelLogo, "WEBCHEST", labelLogo.Font.Name, 72, 20, BackColor);
            labelLogo.Padding = new Padding(8, 0, 0, 0);
            labelLogo.Top = (Height - labelLogo.Height - 20) / 2;

            for (byte r = 0, g = 0, b = 0; r <= 22 & g <= 160 & b <= 133; r += 1, g += 8, b += 7, await Task.Delay(50))
            {
                labelLogo.ForeColor = Color.FromArgb(r, g, b);
            }
            labelLogo.ForeColor = Color.FromArgb(22, 160, 133);

            await Task.Delay(3000);

            for (byte r = 22, g = 160, b = 133; r >= 1 & g >= 1 & b >= 1; r -= 1, g -= 8, b -= 7, await Task.Delay(50))
            {
                labelLogo.ForeColor = Color.FromArgb(r, g, b);
            }
            labelLogo.ForeColor = Color.FromArgb(0, 0, 0);

            SetLabelCentered(labelLogo, "MAX IT", labelLogo.Font.Name, 72, 20, BackColor);
            labelLogo.Padding = new Padding(2, 0, 0, 0);
            labelLogo.Top = (Height - labelLogo.Height - 20) / 2;

            for (byte r = 0, g = 0, b = 0; r <= 22 & g <= 160 & b <= 133; r += 1, g += 8, b += 7, await Task.Delay(50))
            {
                labelLogo.ForeColor = Color.FromArgb(r, g, b);
            }
            labelLogo.ForeColor = Color.FromArgb(22, 160, 133);

            var startPos = labelLogo.Top;
            var endPos = 20;
            var step = (startPos - endPos) / 36;

            for (int i = startPos; i >= endPos; i -= step, await Task.Delay(2))
            {
                labelLogo.Top = i;
                labelLogo.Font = new Font(labelLogo.Font.Name, labelLogo.Font.Size - 1);
                labelLogo.Left = (Width - labelLogo.Width) / 2;
            }

            labelLogo.ForeColor = Color.White;

        }
        #endregion Intro

    }
}