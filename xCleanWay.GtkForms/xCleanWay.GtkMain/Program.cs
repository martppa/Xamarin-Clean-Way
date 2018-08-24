using System;
using Gtk;
using xCleanWay.Di;
using xCleanWay.Di.Factory;
using xCleanWay.GtkForms;

namespace xCleanWay.GtkMain
{
    class GtkApp
    {
        private static GtkApp gtkApp;

        private Injector injector;
        private AppMainWindow appMainWindow;
        
        public static void Main(string[] args)
        {
            gtkApp = new GtkApp();
            gtkApp.Start();
        }

        private GtkApp()
        {
            injector = buildInjector();
            injector.Inject(out appMainWindow);
        }

        private Injector buildInjector()
        {
            return InjectorFactory
                .Create(InjectorFactory.InjectorConfiguration.GTK_INJECTOR_CONFIG).Build();
        }

        private void ShowMainWindow()
        {
            appMainWindow.Show();
        }

        public void Start()
        {
            Application.Init();
            ShowMainWindow();
            Application.Run();
        }
    }
}
