using System;
using Gtk;
using xCleanWay.Gtk.Di;
using xCleanWay.Remote.Providers.Rest.Country;

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
