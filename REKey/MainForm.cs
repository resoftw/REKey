using System.Runtime.InteropServices;
using System.Text;

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
        private const uint MAPVK_VK_TO_VSC = 0x00;

        [DllImport("user32.dll")]
        private static extern int MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll", EntryPoint = "GetKeyNameTextW", CharSet = CharSet.Unicode)]
        private static extern int GetKeyNameText(int lParam, [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder str, int size);

        private GlobalKeyboardHook KeyboardHook;
        private List<String> Keys=new List<String>();
        private static string GetLocalizedKeyStringUnsafe(int key)
        {
            //https://stackoverflow.com/questions/38584015/using-getkeynametext-with-special-keys
            // strip any modifier keys
            long keyCode = key & 0xffff;

            var sb = new StringBuilder(256);

            long scanCode = MapVirtualKey((uint)keyCode, MAPVK_VK_TO_VSC);

            // shift the scancode to the high word
            scanCode = (scanCode << 16); // | (1 << 24);
            if (keyCode == 45 ||
                keyCode == 46 ||
                keyCode == 144 ||
                (33 <= keyCode && keyCode <= 40))
            {
                // add the extended key flag
                scanCode |= 0x1000000;
            }

            GetKeyNameText((int)scanCode, sb, 256);
            return sb.ToString();
        }
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
/*            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 80, 80));
            // SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //AllowTransparency = true;
            BackColor = Color.FromArgb(255, 10, 10, 20);
*/            KeyboardHook = new GlobalKeyboardHook();
            KeyboardHook.KeyboardPressed += KeyboardHook_KeyboardPressed;
        }

        private void KeyboardHook_KeyboardPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyUp)
            {
                string s = GetLocalizedKeyStringUnsafe(e.KeyboardData.VirtualCode);
                Keys.Add(s);
                tb.AppendText(s+Environment.NewLine);
                if (Keys.Count > 10) { Keys.RemoveRange(0, 1); }
                s = "";
                foreach (var k in Keys)
                {
                    s += k;
                }
                lbl.Text = s;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHook?.Dispose();
        }
    }
}