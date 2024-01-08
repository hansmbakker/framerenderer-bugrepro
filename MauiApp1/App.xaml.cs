using System.Diagnostics;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            MainPage = new AppShell();
        }

        private void CurrentDomain_FirstChanceException(object? sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            Debug.WriteLine($"*** UNHANDLED EXCEPTION: {e.Exception}");
            Debugger.Break();
        }
    }
}
