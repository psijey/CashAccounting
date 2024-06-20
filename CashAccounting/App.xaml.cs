namespace CashAccounting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("NewPage1", typeof(NewPage1));
            MainPage = new AppShell();
        }
    }
}