namespace Hackathon
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 1290/3;
			const int newHeight = 2796/4;

            window.Width = newWidth;
            window.Height = newHeight;
            window.MaximumHeight = newHeight;
            window.MaximumWidth = newWidth;
            window.MinimumHeight = newHeight;
            window.MinimumWidth = newWidth;

            return window;
        }
    }
}
