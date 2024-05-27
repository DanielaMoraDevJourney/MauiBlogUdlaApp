using MauiBlogUdlaApp.Views;

namespace MauiBlogUdlaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaRegistro();
        }
    }
}
