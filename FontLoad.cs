using System.Runtime.InteropServices;

namespace FontLoad
{
    class FontLoadProgram
    {
        const int HWND_BROADCAST = 0xFFFF;
        const int WM_FONTCHANGE = 0x001D;

        [DllImport("gdi32.dll", EntryPoint = "AddFontResource")]
        public static extern int AddFontResource(string lpFileName);
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        static void Main(string[] args)
        {
            int loaded = 0;
            foreach (string fileName in args)
            {
                loaded += AddFontResource(fileName);
            }
            SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0);
            System.Console.WriteLine("Fonts loaded: " + loaded);
        }
    }
}
