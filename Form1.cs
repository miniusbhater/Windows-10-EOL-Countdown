namespace TimeToWin10EOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime bye10 = new DateTime(2025, 10, 14);
            DateTime today = DateTime.Today;
            TimeSpan difference = bye10 - today;
            string title = $"{difference.Days} more days until EOL";
            string contents = $"Goodbye windows 10 2015 - 2025";
            NotifyIcon notification = new NotifyIcon();
            notification.Icon = SystemIcons.Information;
            notification.Visible = true;
            notification.BalloonTipTitle = title;
            notification.BalloonTipText = contents;
            notification.BalloonTipIcon = ToolTipIcon.Info;
            notification.ShowBalloonTip(3000);
            this.Close();

        }
    }
}
