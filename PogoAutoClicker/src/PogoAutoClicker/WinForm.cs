using System;
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

        private void StartClickbtn_Click(object sender, EventArgs e)
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

        private void StopClickbtn_Click(object sender, EventArgs e)
        {
            clickstop_func();
        }
    }
}
