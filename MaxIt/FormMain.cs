using MaxIt.Properties;
using static MaxIt.Tools;
using System.Drawing.Imaging;

namespace MaxIt
{
    public partial class FormMain : Form
    {
        private bool _loading;
        private bool _showIntro;

        #region FormMain
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            _loading = true;
            _showIntro = true;
            InitialSetup();
        }

        private void FormMainShown(object sender, EventArgs e)
        {
            if (_showIntro) ShowIntro();
            else
            {
                SetLabelCentered(labelLogo, "MAX IT", labelLogo.Font.Name, 36, 20, Color.White);
            }
            _loading = false;
        }

        #endregion FormMain

        private void InitialSetup()
        {

        }

        private void SetTitlePosition()
        {

        }

        private void FormMainResize(object sender, EventArgs e)
        {
            SetTitlePosition();
        }





        private void PanelLogoResize(object sender, EventArgs e)
        {

        }

        #region Intro

        private async void ShowIntro()
        {
            labelLogo.Font = new Font(labelLogo.Font.Name, 72);
            labelLogo.Text = "WEBCHEST";
            labelLogo.ForeColor = BackColor;
            labelLogo.Padding = new Padding(8, 0, 0, 0);
            labelLogo.Left = (Width - labelLogo.Width) / 2;
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

            labelLogo.Text = "MAX IT";
            labelLogo.ForeColor = BackColor;
            labelLogo.Padding = new Padding(2, 0, 0, 0);
            labelLogo.Left = (Width - labelLogo.Width) / 2;
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