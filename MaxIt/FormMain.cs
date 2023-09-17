namespace MaxIt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            SetTitlePosition();
        }

        private void SetTitlePosition()
        {
            labelTitle.Location = new Point((Width - labelTitle.Width) / 2, 50);
        }

        private void FormMainResize(object sender, EventArgs e)
        {
            SetTitlePosition();
        }
    }
}