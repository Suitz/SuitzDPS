using System;
using System.Runtime.InteropServices;

namespace SuitzDPS.Helpers
{
    internal class DetectKeyPress
    {
        internal static int Shift;

        internal static int Ctrl;

        internal static int Alt;

        internal static int Z;

        internal static int X;

        internal static int C;

        internal static int LButton;

        internal static int RButton;

        internal static int VK_XBUTTON1;

        internal static int VK_XBUTTON2;

        static DetectKeyPress()
        {
            DetectKeyPress.Shift = 16;
            DetectKeyPress.Ctrl = 17;
            DetectKeyPress.Alt = 18;
            DetectKeyPress.Z = 90;
            DetectKeyPress.X = 88;
            DetectKeyPress.C = 67;
            DetectKeyPress.LButton = 1;
            DetectKeyPress.RButton = 2;
            DetectKeyPress.VK_XBUTTON1 = 5;
            DetectKeyPress.VK_XBUTTON2 = 6;
        }

        public DetectKeyPress()
        {
        }

        [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
        internal static extern short GetAsyncKeyState(int virtualKeyCode);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern short GetKeyState(int virtualKeyCode);
    }
}