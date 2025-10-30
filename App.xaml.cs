namespace oherreraEXAMEN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());
            /*navigationPage PARA NAVEGAR ENTRE PAGINAS*/
            return new Window(new NavigationPage(new Views.vLogin()));
        }
    }
}