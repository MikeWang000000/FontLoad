using System.Runtime.InteropServices;

namespace FontLoad
{
    class FontUnloadProgram
    {
        const int HWND_BROADCAST = 0xFFFF;
        const int WM_FONTCHANGE = 0x001D;

        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResource")]
        public static extern int RemoveFontResource(string lpFileName);
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        static void Main(string[] args)
        {
            int unloaded = 0;
            foreach (string fileName in args)
            {
                unloaded += RemoveFontResource(fileName);
            }
            SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0);
            System.Console.WriteLine("Fonts unloaded: " + unloaded);
        }
    }
}
