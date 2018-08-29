using System;
using Gtk;
using xCleanWay.Di;
using xCleanWay.Di.Factory;
using xCleanWay.GtkForms;

namespace xCleanWay.GtkMain
{
    public class GtkApp
    {
        private static GtkApp gtkApp;

        private Injector injector;
        private readonly AppMainWindow appMainWindow;

        [STAThread]
        public static void Main(string[] args)
        {
            gtkApp = new GtkApp(args);
            gtkApp.Start();
        }

        private GtkApp(string[] args)
        {
            injector = BuildInjector();
            injector.Inject(out appMainWindow);
        }

        private Injector BuildInjector()
        {
            return InjectorFactory
                .Create(InjectorFactory.InjectorConfiguration.GTK_INJECTOR_CONFIG).Build();
        }

        private void Start()
        {
            Application.Init();
            ShowMainWindow();
            Application.Run();
        }
        
        private void ShowMainWindow()
        {
            appMainWindow.Show();
        }
    }
}
