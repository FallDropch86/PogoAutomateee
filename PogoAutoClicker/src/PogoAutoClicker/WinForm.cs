using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PogoAutoClicker
{
    public partial class WinForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_F6 = 0x75;

        private LowLevelKeyboardProc keyboardHookProc;
        private IntPtr keyboardHookId = IntPtr.Zero;

        bool IsClicking = false;
        bool leftranoncealrdy = false;
        bool rightranoncealrdy = false;

        static int delaytoclick;

        Thread leftClickThread = new Thread(() =>
        {
            while (true)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(delaytoclick);
            }
        });

        Thread rightClickThread = new Thread(() =>
        {
            while (true)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(delaytoclick);
            }
        });

        public void clickstartleft_func()
        {
            if (!IsClicking)
            {
                IsClicking = true;

                Console.WriteLine("Successfully started left clicking.");

                if (leftranoncealrdy)
                {
                    leftClickThread.Resume();
                }
                else
                {
                    leftClickThread.Start();
                }
            }
        }

        public void clickstartright_func()
        {
            if (!IsClicking)
            {
                IsClicking = true;

                Console.WriteLine("Successfully started right clicking.");

                if(rightranoncealrdy)
                {
                    rightClickThread.Resume();
                }
                else
                {
                    rightClickThread.Start();
                }
            }
        }

        public void clickstop_func()
        {
            if (leftClickThread.IsAlive)
            {
                IsClicking = false;
                leftranoncealrdy = true;

                leftClickThread.Suspend();
                Console.WriteLine("Successfully stopped left clicking.");
            }
            if (rightClickThread.IsAlive)
            {
                IsClicking = false;
                rightranoncealrdy = true;

                rightClickThread.Suspend();
                Console.WriteLine("Successfully stopped right clicking.");
            }
        }

        //=============================================================================================================================

        private Point offset;
        bool MoveWinMouse;

        public WinForm()
        {
            InitializeComponent();
            keyboardHookProc = KeyboardHookCallback;
        }

        private void WinForm_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MoveWinMouse = true;
        }

        private void WinForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveWinMouse == true)
            {
                Point currentwndpos = PointToScreen(e.Location);
                Location = new Point(currentwndpos.X - offset.X, currentwndpos.Y - offset.Y);
            }
        }

        private void WinForm_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWinMouse = false;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {
            this.rightorleftclickdropdown.SelectedIndex = 0;
            keyboardHookId = SetKeyboardHook();
        }

        private void rgbpanel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MoveWinMouse = true;
        }

        private void rgbpanel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveWinMouse == true)
            {
                Point currentwndpos = PointToScreen(e.Location);
                Location = new Point(currentwndpos.X - offset.X, currentwndpos.Y - offset.Y);
            }
        }

        private void rgbpanel2_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWinMouse = false;
        }

        private void rgbpanel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MoveWinMouse = true;
        }

        private void rgbpanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveWinMouse == true)
            {
                Point currentwndpos = PointToScreen(e.Location);
                Location = new Point(currentwndpos.X - offset.X, currentwndpos.Y - offset.Y);
            }
        }

        private void rgbpanel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWinMouse = false;
        }

        private void rgbpanel3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MoveWinMouse = true;
        }

        private void rgbpanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveWinMouse == true)
            {
                Point currentwndpos = PointToScreen(e.Location);
                Location = new Point(currentwndpos.X - offset.X, currentwndpos.Y - offset.Y);
            }
        }

        private void rgbpanel3_MouseUp(object sender, MouseEventArgs e)
        {
            MoveWinMouse = false;
        }

        private void DelayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void startcall()
        {
            if (rightorleftclickdropdown.Text == "Left Click")
            {
                string userdelay = DelayTextBox.Text;
                delaytoclick = Convert.ToInt32(userdelay);

                clickstartleft_func();
            }
            else
            {
                string userdelay = DelayTextBox.Text;
                delaytoclick = Convert.ToInt32(userdelay);

                clickstartright_func();
            }
        }

        private void StartClickbtn_Click(object sender, EventArgs e)
        {
            startcall();
        }

        private void StopClickbtn_Click(object sender, EventArgs e)
        {
            clickstop_func();
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == VK_F6)
                {
                    if (!IsClicking)
                    {
                        startcall();
                    } else
                    {
                        clickstop_func();
                    }
                }
            }

            return CallNextHookEx(keyboardHookId, nCode, wParam, lParam);
        }

        private IntPtr SetKeyboardHook()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, keyboardHookProc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private void WinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(keyboardHookId);
        }
    }
}
