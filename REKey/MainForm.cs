using System.Runtime.InteropServices;

namespace REKey
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        private GlobalKeyboardHook KeyboardHook;
        private List<String> Keys=new List<String>();
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));
            // SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //AllowTransparency = true;
            BackColor = Color.FromArgb(255, 10, 10, 20);
            KeyboardHook = new GlobalKeyboardHook();
            KeyboardHook.KeyboardPressed += KeyboardHook_KeyboardPressed;
        }

        private void KeyboardHook_KeyboardPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            lbl.Text=e.KeyboardData.VirtualCode.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHook?.Dispose();
        }
    }
}