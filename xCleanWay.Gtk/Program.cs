using System;
using Gtk;
using xCleanWay.Gtk.Di;

namespace xCleanWay.Gtk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
